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
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();



        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            ModalForm.Reselectrd_Player++;
            ModalForm.Position_num = 0;
            Close();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {

            
            Close();

        }


    }
}
