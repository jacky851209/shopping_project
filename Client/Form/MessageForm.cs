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
        WindowsFormsApplication1.Resources.MessageDB msg = new WindowsFormsApplication1.Resources.MessageDB();
        WindowsFormsApplication1.Resources.ProductDB pro = new WindowsFormsApplication1.Resources.ProductDB();
        WindowsFormsApplication1.Resources.UserDB user = new WindowsFormsApplication1.Resources.UserDB();
        WindowsFormsApplication1.Resources.ScoreDB sco = new WindowsFormsApplication1.Resources.ScoreDB();
        Bitmap star = new Bitmap(Properties.Resources.star, 25, 25);
        Bitmap ystar = new Bitmap(Properties.Resources.Ystar, 25, 25);
        String productname;
        String buyeremail;
        String Owneremail;
        int count;
 

        public MessageForm(String email, String pmail, String omail)
        {
            InitializeComponent();
            this.productname = pmail;
            this.buyeremail = email;
            this.Owneremail = omail;
            pnamelabel.Text = productname;
            set_score_star();
            set_msg();
            set_avgscore();
        }

        private async void set_msg()
        {
            flowLayoutPanel1.VerticalScroll.Visible = true;
            flowLayoutPanel1.AutoScroll = true;

            count = msg.find_msg_is_exist(productname);
            List<Resources.Message> send_msg;
            if (count == 0)
            {
            }
            else
            {
                send_msg = await msg.get_msg(productname);
                for (int i = 0; i < count; i++)
                {
                    FlowLayoutPanel fl = new FlowLayoutPanel();
                    fl.Width = 487;
                    fl.Height = 30;

                    PictureBox picbox = new PictureBox();
                    picbox.Width = 30;
                    picbox.Height = 30;
                    set_msg_pic(picbox, await user.get_picture(send_msg[i].BuyerEmail));
                    picbox.Size = new System.Drawing.Size(30, 30);
                    picbox.SizeMode = PictureBoxSizeMode.Zoom;


                    Label sendemail = new Label();
                    sendemail.Width = 50;
                    sendemail.Height = 30;
                    sendemail.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                    sendemail.ForeColor = Color.Navy;
                    sendemail.Location = new Point(50, 100);
                    if (send_msg[i].BuyerEmail == send_msg[i].OwnerEmail)
                    {
                        sendemail.Text = "賣家";
                    }
                    else
                    {
                        sendemail.Text = send_msg[i].BuyerEmail;
                    }

                    Label sendmsg = new Label();
                    sendmsg.Width = 350;
                    sendmsg.Height = 30;
                    sendmsg.Text = send_msg[i].SendMessage;
                    sendmsg.Location = new Point(100, 100);
                    sendmsg.Font = new Font("微軟正黑體", 12, FontStyle.Regular);

                    fl.Controls.Add(picbox);
                    fl.Controls.Add(sendemail);
                    fl.Controls.Add(sendmsg);

                    flowLayoutPanel1.Controls.Add(fl);
                }
            }
        }

        public async void set_avgscore()
        {
            List<Resources.Score> score;
            Double all_person_count = sco.get_person_count(productname, Owneremail);
            Double TotalScore = 0;
            manypeople.Text = all_person_count.ToString();
            if (all_person_count < 10) {
                manypeople.Location = new Point(316, 82);
            }
            else{
                manypeople.Location = new Point(308, 82);
            }
            if (all_person_count == 0)
            {
                Sourcelabel.Text = "---";
            }
            else
            {
                score = await sco.get_person_score(productname, Owneremail);
                for (int i = 0; i < all_person_count; i++)
                {
                    TotalScore += score[i].score;
                }
                TotalScore /= all_person_count;
                Sourcelabel.Text = Math.Round(TotalScore, 1).ToString();
                await pro.set_score(Owneremail, productname, TotalScore);
            }

        }


        private async void set_onemsg()
        {
            count = msg.find_msg_is_exist(productname);
            List<Resources.Message> send_msg;

            send_msg = await msg.get_msg(productname);

            FlowLayoutPanel fl = new FlowLayoutPanel();
            fl.Width = 487;
            fl.Height = 30;

            PictureBox picbox = new PictureBox();
            picbox.Width = 30;
            picbox.Height = 30;
            picbox.Size = new System.Drawing.Size(30, 30);
            picbox.SizeMode = PictureBoxSizeMode.Zoom;

            set_msg_pic(picbox, await user.get_picture(send_msg[count-1].BuyerEmail));

            Label sendemail = new Label();
            sendemail.Width = 50;
            sendemail.Height = 30;
            sendemail.ForeColor = Color.Navy;
            sendemail.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
            sendemail.Location = new Point(50, 100);
            if (send_msg[count-1].BuyerEmail == send_msg[count-1].OwnerEmail)
            {
                sendemail.Text = "賣家";
            }
            else
            {
                sendemail.Text = send_msg[count - 1].BuyerEmail;
            }

            Label sendmsg = new Label();
            sendmsg.Width = 200;
            sendmsg.Height = 20;
            sendmsg.Text = send_msg[count - 1].SendMessage;
            sendmsg.Location = new Point(100, 100);
            sendmsg.Font = new Font("微軟正黑體", 12, FontStyle.Regular);

            fl.Controls.Add(picbox);
            fl.Controls.Add(sendemail);
            fl.Controls.Add(sendmsg);

            flowLayoutPanel1.Controls.Add(fl);

        }


        private void set_msg_pic(PictureBox p1, string inputString)
        {
            byte[] imageBytes = Convert.FromBase64String(inputString.ToString());
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);
            Bitmap img2 = new Bitmap(image, 30, 30);

            p1.Image = img2;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0)
            {
            }
            else
            {
                msg.set_message(productname, Owneremail, buyeremail, textBox1.Text.ToString());
                set_onemsg();
                textBox1.Text = "";
                set_avgscore();
                set_score_star();
            }
        }

        private void star1_Click(object sender, EventArgs e)
        {
            set_one_star();
            // await pro.score(Owneremail, productname, buyeremail, 1);
            if (sco.find_buyer_is_scored(productname, Owneremail, buyeremail) == true)
            {
                sco.change_score(productname, Owneremail, buyeremail, 1);
            }
            else
            {
                sco.add_score(productname, Owneremail, buyeremail, 1);
            }
        }

        private void star2_Click(object sender, EventArgs e)
        {
            set_two_star();
            if (sco.find_buyer_is_scored(productname, Owneremail, buyeremail) == true)
            {
                sco.change_score(productname, Owneremail, buyeremail, 2);
            }
            else
            {
                sco.add_score(productname, Owneremail, buyeremail, 2);
            }
        }

        private void star3_Click(object sender, EventArgs e)
        {
            set_three_star();
            if (sco.find_buyer_is_scored(productname, Owneremail, buyeremail) == true)
            {
                sco.change_score(productname, Owneremail, buyeremail, 3);
            }
            else
            {
                sco.add_score(productname, Owneremail, buyeremail, 3);
            }
        }

        private void star4_Click(object sender, EventArgs e)
        {
            set_fore_star();
            if (sco.find_buyer_is_scored(productname, Owneremail, buyeremail) == true)
            {
                sco.change_score(productname, Owneremail, buyeremail, 4);
            }
            else
            {
                sco.add_score(productname, Owneremail, buyeremail, 4);
            }
        }

        private void star5_Click(object sender, EventArgs e)
        {
            set_five_star();
            if (sco.find_buyer_is_scored(productname, Owneremail, buyeremail) == true)
            {
                sco.change_score(productname, Owneremail, buyeremail, 5);
            }
            else
            {
                sco.add_score(productname, Owneremail, buyeremail, 5);
            }
        }
        private async void set_score_star()
        {
            if (Owneremail != buyeremail)
            {
                if (sco.find_buyer_is_scored(productname, Owneremail, buyeremail) == true)
                {
                    if (await sco.get_score(productname, Owneremail, buyeremail) == 1)
                    {
                        set_one_star();
                    }
                    else if (await sco.get_score(productname, Owneremail, buyeremail) == 2)
                    {
                        set_two_star();
                    }
                    else if (await sco.get_score(productname, Owneremail, buyeremail) == 3)
                    {
                        set_three_star();
                    }
                    else if (await sco.get_score(productname, Owneremail, buyeremail) == 4)
                    {
                        set_fore_star();
                    }
                    else if (await sco.get_score(productname, Owneremail, buyeremail) == 5)
                    {
                        set_five_star();
                    }
                }
                else
                {
                    set_no_star();
                }
            }
        }
        private void set_no_star()
        {
            this.star1.BackgroundImage = star;
            this.star2.BackgroundImage = star;
            this.star3.BackgroundImage = star;
            this.star4.BackgroundImage = star;
            this.star5.BackgroundImage = star;
        }
        private void set_one_star()
        {
            this.star1.BackgroundImage = ystar;
            this.star2.BackgroundImage = star;
            this.star3.BackgroundImage = star;
            this.star4.BackgroundImage = star;
            this.star5.BackgroundImage = star;
        }
        private void set_two_star()
        {
            this.star1.BackgroundImage = ystar;
            this.star2.BackgroundImage = ystar;
            this.star3.BackgroundImage = star;
            this.star4.BackgroundImage = star;
            this.star5.BackgroundImage = star;
        }
        private void set_three_star()
        {
            this.star1.BackgroundImage = ystar;
            this.star2.BackgroundImage = ystar;
            this.star3.BackgroundImage = ystar;
            this.star4.BackgroundImage = star;
            this.star5.BackgroundImage = star;
        }
        private void set_fore_star()
        {
            this.star1.BackgroundImage = ystar;
            this.star2.BackgroundImage = ystar;
            this.star3.BackgroundImage = ystar;
            this.star4.BackgroundImage = ystar;
            this.star5.BackgroundImage = star;
        }
        private void set_five_star()
        {
            this.star1.BackgroundImage = ystar;
            this.star2.BackgroundImage = ystar;
            this.star3.BackgroundImage = ystar;
            this.star4.BackgroundImage = ystar;
            this.star5.BackgroundImage = ystar;
        }
    }
}
