using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ModalForm : Form
    {
        public static int Player_Price;
        public static int Position_num;
        public static int Reselectrd_Player = 0;
        CheckForm checkForm = new CheckForm();
        public static string str1 = "";


        int pg = 0;
        int sg = 0;
        int sf = 0;
        int pf = 0;
        int ct = 0;

        public ModalForm()
        {
            InitializeComponent();
            lb_Completion.Location = new System.Drawing.Point(275, 300);

        }

        public static int Final_Price = 0;
        private void Result(int price)
        {


            if (Final_Price <= 15 && Final_Price + price <= 15)
            {

                Final_Price += price;

                if (Final_Price > 15) { MessageBox.Show("15달러가 넘어갔습니다."); }
            }
            else { MessageBox.Show("15달러가 넘어갔습니다."); }


        }


        private void ModalForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Player_Price <= 15)
            {

                MF_label.Text = Final_Price.ToString();


            }

        }

        private void button1_Click(object sender, EventArgs e)      // CT포지션 선택 버튼
        {

            if (Player_Price <= 5 && Player_Price > 0)
            {
                pb_ct.Load(str1);

                if (Final_Price < 15)
                    Result(Player_Price);

                ct = Player_Price;
                Player_Price = 0;


                if (Position_num == 5)
                {
                    MessageBox.Show("훌륭한 선택입니다!!");

                    Position_num = 0;
                }
                else
                {

                    checkForm.ShowDialog();
                    if (Reselectrd_Player == 0)
                    {
                        pb_ct.Image = null;
                        Final_Price -= ct;
                        ct = 0;
                    }

                }

                str1 = "";
            }
            else
            {
                Player_Price = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)  // SG포지션 선택 버튼
        {
            if (Player_Price <= 5 && Player_Price > 0)
            {
                pb_sg.Load(str1);


                if (Final_Price < 15)
                    Result(Player_Price);

                sg = Player_Price;

                if (Position_num == 1 || Position_num == 3)
                {
                    MessageBox.Show("훌륭한 선택입니다!!");
                    Position_num = 0;

                }
                else
                {

                    checkForm.ShowDialog();
                    if (Reselectrd_Player == 0)
                    {
                        pb_sg.Image = null;
                        Final_Price -= sg;
                        sg = 0;
                    }

                }


                Player_Price = 0;
                str1 = "";
            }
            else
            {
                Player_Price = 0;
            }

        }

        private void button3_Click(object sender, EventArgs e)      // PG포지션 선택 버튼
        {
            if (Player_Price <= 5 && Player_Price > 0)
            {
                pb_pg.Load(str1);

                if (Final_Price < 15)
                    Result(Player_Price);

                pg = Player_Price;


                if (Position_num == 1)
                {
                    MessageBox.Show("훌륭한 선택입니다!!");
                    Position_num = 0;
                }
                else
                {

                    checkForm.StartPosition = FormStartPosition.Manual;
                    checkForm.Location = new Point(750, 400);
                    checkForm.ShowDialog();
                    if (Reselectrd_Player == 0)
                    {
                        pb_pg.Image = null;
                        Final_Price -= pg;
                        pg = 0;
                    }

                }

                Player_Price = 0;
                str1 = "";
            }
            else
            {
                Player_Price = 0;
            }

        }

        private void button4_Click(object sender, EventArgs e)      // PF포지션 선택 버튼
        {

            if (Player_Price <= 5 && Player_Price > 0)
            {
                pb_pf.Load(str1);

                if (Final_Price < 15)
                    Result(Player_Price);

                pf = Player_Price;
                if (Position_num == 5 || Position_num == 3)
                {
                    MessageBox.Show("훌륭한 선택입니다!!");

                    Position_num = 0;
                }
                else
                {

                    checkForm.ShowDialog();
                    if (Reselectrd_Player == 0)
                    {
                        pb_pf.Image = null;
                        Final_Price -= pf;
                        pf = 0;
                    }

                }

                Player_Price = 0;

                str1 = "";
            }
            else
            {
                Player_Price = 0;
            }



        }

        private void button5_Click(object sender, EventArgs e)      // SF포지션 선택 버튼
        {
            if (Player_Price <= 5 && Player_Price > 0)
            {
                pb_sf.Load(str1);

                if (Final_Price < 15)
                    Result(Player_Price);

                sf = Player_Price;


                if (Position_num == 3)
                {
                    MessageBox.Show("훌륭한 선택입니다!!");

                    Position_num = 0;
                }
                else
                {

                    checkForm.ShowDialog();
                    if (Reselectrd_Player == 0)
                    {
                        pb_sf.Image = null;
                        Final_Price -= sf;
                        sf = 0;
                    }

                }

                Player_Price = 0;
                str1 = "";
            }
            else
            {
                Player_Price = 0;
            }
        }

        private void Remove_Player_PG_Click(object sender, EventArgs e)
        {

            pb_pg.Image = null;
            Final_Price -= pg;
            pg = 0;


        }

        private void Remove_Player_SG_Click(object sender, EventArgs e)
        {

            pb_sg.Image = null;

            Final_Price -= sg;
            sg = 0;

        }

        private void Remove_Player_SF_Click(object sender, EventArgs e)
        {
            pb_sf.Image = null;

            Final_Price -= sf;
            sf = 0;
        }

        private void Remove_Player_CT_Click(object sender, EventArgs e)
        {
            Final_Price -= ct;
            ct = 0;
            pb_ct.Image = null;
        }

        private void Remove_Player_PW_Click(object sender, EventArgs e)
        {
            pb_pf.Image = null;

            Final_Price -= pf;
            pf = 0;
        }

        private void btn_null_Click(object sender, EventArgs e)
        {
            pb_pg.Image = null;
            pb_sg.Image = null;
            pb_sf.Image = null;
            pb_ct.Image = null;
            pb_pf.Image = null;
            lb_Completion.Text = null;
            Final_Price = 0;

        }

        private void btn_end_Click(object sender, EventArgs e)
        {

            if (((Final_Price <= 15) && (pb_pg.Image != null) && (pb_sg.Image != null) && (pb_sf.Image != null) && (pb_pf.Image != null) && (pb_ct.Image != null)))
            {

                lb_Completion.Text = "Completed!!!";
            }
            else if ((pb_pg.Image == null) || (pb_sg.Image == null) || (pb_sf.Image == null) || (pb_pf.Image == null) || (pb_ct.Image == null))
            {
                lb_Completion.Text = "Try Again!!!";
            }

        }
    }
}
