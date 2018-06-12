using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MessageForm : Form
    {
     
        String productname;
        String buyeremail;
        int count;
        
        public MessageForm(String email,String pname)
        {
            InitializeComponent();
            this.productname = pname;
            this.buyeremail = email;
            pnamelabel.Text = productname;
            set_msg(0);
        }

        private async void set_msg(int number)
        { 
            
            flowLayoutPanel1.VerticalScroll.Visible = true;
            flowLayoutPanel1.AutoScroll = true;
            WindowsFormsApplication1.Resources.MessageDB msg = new WindowsFormsApplication1.Resources.MessageDB();
            count = msg.find_msg_is_exist(productname);
            List<Resources.Message> send_msg;
            if (count<0)
            {
            }
            else
            {
                send_msg =await msg.get_msg(productname);
                for(int i=number;i<count;i++)
                {
                    FlowLayoutPanel fl = new FlowLayoutPanel();
                    fl.Width = 487;
                    fl.Height = 30;

                    PictureBox picbox = new PictureBox();
                    picbox.Width = 30;
                    picbox.Height = 30;
                    
                    set_msg_pic(picbox, send_msg[i].User_image);
                    picbox.Size = new System.Drawing.Size(30, 30);
                    picbox.SizeMode = PictureBoxSizeMode.Zoom;
                    
                    Label sendemail = new Label();
                    sendemail.Width = 50;
                    sendemail.Height = 30;
                    sendemail.Text = send_msg[i].BuyerEmail;
                    sendemail.Font = new Font("微軟正黑體", 12, FontStyle.Regular);

                    Label sendmsg = new Label();
                    sendmsg.Width = 350;
                    sendmsg.Height = 30;
                    sendmsg.Text = send_msg[i].SendMessage;
                    sendmsg.Location = new Point(100,92);
                    sendmsg.Font = new Font("微軟正黑體", 12, FontStyle.Regular);

                    fl.Controls.Add(picbox);
                    fl.Controls.Add(sendemail);
                    fl.Controls.Add(sendmsg);

                    flowLayoutPanel1.Controls.Add(fl);
                }
            }
        }

        private async void set_onemsg(int number)
        {

           
            WindowsFormsApplication1.Resources.MessageDB msg = new WindowsFormsApplication1.Resources.MessageDB();
            count = msg.find_msg_is_exist(productname);
            List<Resources.Message> send_msg;

            send_msg = await msg.get_msg(productname);
           
                    FlowLayoutPanel fl = new FlowLayoutPanel();
                     fl.Width = 487;
                    fl.Height = 30;

                    PictureBox picbox = new PictureBox();
                    picbox.Width = 30;
                    picbox.Height = 30;

                    set_msg_pic(picbox, send_msg[count-1].User_image);
                    picbox.Size = new System.Drawing.Size(30, 30);
                    picbox.SizeMode = PictureBoxSizeMode.Zoom;

                    Label sendemail = new Label();
                    sendemail.Width = 50;
                    sendemail.Height = 30;
                    sendemail.Text = send_msg[count-1].BuyerEmail;
                    sendemail.Font = new Font("微軟正黑體", 12, FontStyle.Regular);

                    Label sendmsg = new Label();
                    sendmsg.Width = 350;
                    sendmsg.Height = 30;
                    sendmsg.Text = send_msg[count-1].SendMessage;
                    sendmsg.Location = new Point(100, 92);
                    sendmsg.Font = new Font("微軟正黑體", 12, FontStyle.Regular);

                    fl.Controls.Add(picbox);
                    fl.Controls.Add(sendemail);
                    fl.Controls.Add(sendmsg);

                    flowLayoutPanel1.Controls.Add(fl);
              
           
        }


        private PictureBox set_msg_pic(PictureBox p1, string inputString)
        {
            byte[] imageBytes = Convert.FromBase64String(inputString);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);
            Bitmap img2 = new Bitmap(image, 30, 30);

            p1.Image = img2;
            return p1;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length <= 0)
            {
            }
            else
            {
                WindowsFormsApplication1.Resources.MessageDB msg = new WindowsFormsApplication1.Resources.MessageDB();
                WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
                String inputString = await user.get_picture(buyeremail);
                count = msg.find_msg_is_exist(buyeremail);
                msg.add_msg(productname, buyeremail, textBox1.Text.ToString(), inputString);
               
                set_onemsg(count);
                textBox1.Text = "";
            }
        }

       
    }
}
