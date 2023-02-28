using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaDöngüler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.RebeccaPurple;

        }

        private void btnYillar_Click(object sender, EventArgs e)
        {
            for (int i = 1935; i <= 2019; i++)
            {
                comboYillar.Items.Add(i.ToString());
            }

        }

        private void btnTersyillar_Click(object sender, EventArgs e)
        {
            for (int i = 2019; i >=1945; i--)
            {
                comboYillar.Items.Add(i.ToString());

            }
        }
    }
}
