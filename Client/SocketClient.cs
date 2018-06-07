using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public enum connOP : int
    {
        Login = 100,
        Regist,
    }

    public enum responeCode : int
    {
        Success = 100,
        Error,
    }
    class SocketClient
    {
        private const string splitter = "$";

        // 多執行緒，lock 使用
        private static readonly object thisLock = new object();

        // 將唯一實例設為 private static
        private static SocketClient Instance;
        private SocketClient()
        {
            clientSocket.Connect("127.0.0.1", 8888);
        }

        // 外界只能使用靜態方法取得實例
        public static SocketClient GetInstance()
        {
            // 先判斷目前有沒有實例，沒有的話才開始 lock，
            // 此次的判斷，是避免在有實例的情況，也執行 lock ，影響效能
            if (null == Instance)
            {
                // 避免多執行緒可能會產生兩個以上的實例，所以 lock
                lock (thisLock)
                {
                    // lock 後，再判斷一次目前有無實例
                    // 此次的判斷，是避免多執行緒，同時通過前一次的 null == instance 判斷
                    if (null == Instance)
                    {
                        Instance = new SocketClient();
                    }
                }
            }

            return Instance;
        }


        // Socket part
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream;

        public int doLogin(string email, string password)
        {
            NetworkStream serverStream = clientSocket.GetStream();

            // 包裝訊息 
            string sendMsg = ((int)connOP.Login).ToString() + splitter + email + splitter + password + splitter;

            //傳送
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(sendMsg);
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            //讀取
            byte[] inStream = new byte[clientSocket.ReceiveBufferSize];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);

            // 拆訊息
            string[] msg = returndata.Split(splitter.ToCharArray());

            return Int32.Parse(msg[1]);
        }
    }
}
