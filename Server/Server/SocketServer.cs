using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
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

    class SocketServer
    {
        Thread svThread;
        public void start()
        {
            svThread = new Thread(doStart);
            svThread.Start();
        }

        public void stop()
        {
            if(svThread != null && svThread.IsAlive)
            {
                svThread.Abort();
                svThread.Join();
                svThread = null;
            }
        }

        private void doStart()
        {
            Int32 port = 8888;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");

            TcpListener serverSocket = new TcpListener(localAddr, port);
            TcpClient clientSocket = default(TcpClient);

            Console.WriteLine(" >> " + "Server Started");
            serverSocket.Start();

            int counter = 0;
            while (true)
            {
                counter += 1;
                clientSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine(" >> " + "Client No:" + Convert.ToString(counter) + " started!");
                handleClinet client = new handleClinet();
                client.startClient(clientSocket, Convert.ToString(counter));
            }
        }
    }

    public class handleClinet
    {
        private const string splitter = "$";

        TcpClient clientSocket;
        string clNo;
        public void startClient(TcpClient inClientSocket, string clineNo)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            Thread ctThread = new Thread(doOperation);
            ctThread.Start();
        }
        private void doOperation()
        {
            byte[] bytesFrom = new byte[clientSocket.ReceiveBufferSize];
            string dataFromClient = null;
            Byte[] sendBytes = null;
            string serverResponse = null;
            string[] msg = null;
            while ((true))
            {
                try
                {
                    // 收訊息
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);

                    msg = dataFromClient.Split(splitter.ToCharArray());

                    int op = Int32.Parse(msg[0]);

                    // 處理工作 & 回傳
                    switch (op)
                    {
                        case (int)connOP.Login:
                            {
                                //登入
                                string email = msg[1];
                                string password = msg[2];
                                int returnCode = doLogin(email, password);

                                //回傳
                                serverResponse = ((int)responeCode.Success).ToString() + splitter + returnCode.ToString() + splitter;
                            }
                            break;

                        case (int)connOP.Regist:
                            {

                            }
                            break;

                        default:
                            serverResponse = ((int)responeCode.Error).ToString() + splitter + "Unknow op" + splitter;
                            break;
                    }

                    //傳訊息
                    sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    Console.WriteLine(" >> " + serverResponse);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error >> " + ex.ToString());
                }
            }
        }

        private int doLogin(string email, string password)
        {
            UserDB user = new UserDB();
            int returnCode = user.login_success(email.ToString(), password.ToString());

            return returnCode;
        }
    }
}
