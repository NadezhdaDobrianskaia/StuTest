using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenisLoadTextBox
{
    //Stu Edit and Nadia
    public partial class Form1 : Form
    {
        Form2 frm;
        public Form1()
        {
            InitializeComponent();
        }

        private void FormLoader_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarLoading.Increment(10);
            if (progressBarLoading.Value == progressBarLoading.Maximum)
            {
                this.Hide();
                frm = new Form2();
                frm.Show();
                timer1.Stop();
            }
            
        }

    }
}
