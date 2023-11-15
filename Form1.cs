using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
            Form modalform = new ModalForm();
            this.ClientSize = new Size(1000, 800);


            this.AddOwnedForm(modalform);

            modalform.Show();
        }


        ModalForm MF = new ModalForm();
        public static int count = 0;


        //////////////////////////////////////////////////////////////////////////가드 시작
        private void btn_Curry_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\Stephen Curry.jpg";

                ModalForm.Position_num = 1;
                count = 0;
            
        }

        private void btn_Ball_Click(object sender, EventArgs e)
        {
            
            ModalForm.Player_Price += 5;
            ModalForm.str1 = "C:\\C#\\Project\\bin\\lamelo ball.jpg";
            
            ModalForm.Position_num = 1;
                count = 0;
            

        }

        private void btn_Morant_Click(object sender, EventArgs e)
        {
            

                ModalForm.Player_Price += 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\ja morant.jpg";
                ModalForm.Position_num = 1;
                count = 0;
            
        }

        private void btn_Harden_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\james harden.jpg";
                ModalForm.Position_num = 1;
                count = 0;
            

        }
        private void btn_Booker_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 4;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\devin booker.jpg";
                ModalForm.Position_num = 1;
                count = 0;
            

        }

        private void btn_Young_Click(object sender, EventArgs e)
        {
            

                ModalForm.Player_Price += 4;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\Trae Young.jpg";
                ModalForm.Position_num = 1;
                count = 0;

            
        }

        private void btn_Mitchell_Click(object sender, EventArgs e)
        {
            

                ModalForm.Player_Price += 4;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\donovan mitchell.jpg";
                ModalForm.Position_num = 1;
                count = 0;

            
        }

        private void btn_Irving_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\Kyrie Irving.jpg";
                ModalForm.Position_num = 1;
                count = 0;

            
        }

        private void btn_Murray_Click(object sender, EventArgs e)
        {
            

                ModalForm.Player_Price += 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\jamal murray.jpg";
                ModalForm.Position_num = 1;
                count = 0;

            
        }

        private void btn_Brown_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\Jaylen Brown.jpg";
                ModalForm.Position_num = 1;
                
        }

        private void btn_Mccollum_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 2;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\CJ Mccollum.jpg";
                ModalForm.Position_num = 1;
                
        }

        private void btn_Lowry_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 2;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\kyle lowry.jpg";
                ModalForm.Position_num = 1;
                

            
        }

        private void btn_Smart_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 2;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\marcus smart.jpg";
                ModalForm.Position_num = 1;
                
        }

        private void btn_Rose_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 1;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\derrick rose.jpg";
                ModalForm.Position_num = 1;
                count = 0;

            
        }

        private void btn_Poole_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 1;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\jordan poole.jpg";
                ModalForm.Position_num = 1;
                count = 0;
            
        }

        private void btn_Payton_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 1;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\gary payton ii.jpg";
                ModalForm.Position_num = 1;
                count = 0;

            
        }
        /////////////////////////////////////////////////////////////////////가드 끝
        private void btn_Lebron_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 5;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\LeBron James.jpg";
                count = 0;

            
        }

        private void btn_Doncic_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 5;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\Luka Docic.jpg";
                count = 0;

            
        }

        private void btn_Giannis_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 5;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\giannis antetokounmpo.jpg";
                count = 0;

            
        }

        private void btn_Tatun_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 5;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\jayson tatum.jpg";
                count = 0;

            
        }

        private void btn_DeRozan_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 4;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\Demar DeRozan.jpg";
                count = 0;

            
        }

        private void btn_Butler_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 4;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\jimmy butler.jpg";
                count = 0;

            
        }

        private void btn_Leonard_Click(object sender, EventArgs e)
        {
             ModalForm.Player_Price += 4;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\kawhi leonard.jpg";
                count = 0;

            
        }

        private void btn_George_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 3;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\paul george.jpg";
                count = 0;

            
        }

        private void btn_Gordon_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 3;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\Aaron Gordon.jpg";
                count = 0;

            
        }

        private void btn_Simmons_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 3;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\ben simmons.jpg";
                count = 0;

            
        }

        private void btn_Oubre_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 2;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\kelly oubre jr.jpg";
                count = 0;
            
        }

        private void btn_Batum_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 2;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\nicolas batum.jpg";
                count = 0;
            
        }

        private void btn_Griffin_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 2;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\Blake Griffin.jpg";
                
            
        }

        private void btn_Iguodala_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 1;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\andre iguodala.jpg";
                
        }

        private void btn_Brooks_Click(object sender, EventArgs e)
        {
            

                ModalForm.Player_Price += 1;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\dillon brooks.jpg";
                count = 0;

            
        }

        private void btn_Kuzma_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 1;
                ModalForm.Position_num = 3;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\kyle kuzma.jpg";
                
        }

        ///////////////////////////////////////////////////////////////////포워드 끝

        private void btn_Jokic_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 5;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\nikola jokic.jpg";
                
        }

        private void btn_Ayton_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 5;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\deandre ayton.jpg";
                
        }

        private void btn_Davis_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 5;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\anthony davis.jpg";
                
        }

        private void btn_Embiid_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 5;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\Joel Embiid.jpg";
                
        }

        private void btn_Allen_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 4;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\jarrett allen.jpg";
                
        }

        private void btn_Gobert_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 4;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\rudy gobert.jpg";
                
        }

        private void btn_Adebayo_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 4;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\Bam Adebayo.jpg";
                
        }

        private void btn_Adoms_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 3;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\steven adams.jpg";
                
        }

        private void btn_Green_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 3;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\Draymond Green.jpg";
                
        }

        private void btn_Lopez_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 3;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\Brook Lopez.jpg";
                
        }

        private void btn_Drummond_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 2;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\andre drummond.jpg";
                
        }

        private void btn_Vucevic_Click(object sender, EventArgs e)
        {
             
                ModalForm.Player_Price += 2;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\nikola vucevic.jpg";
                
            
        }

        private void btn_Vanlanciunas_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 2;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\jonas valanciunas.jpg";
                
        }

        private void btn_Love_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 1;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\kevin love.jpg";
                
        }

        private void btn_Mobley_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 1;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\evan mobley.jpg";
                
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
                ModalForm.Player_Price += 1;
                ModalForm.Position_num = 5;
                ModalForm.str1 = "C:\\C#\\Project\\bin\\montrezl harrell.jpg";
                
        }
        ////////////////////////////////////////////////////////////////////센터 끝



    }
}
