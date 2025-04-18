using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLoginPrj
{
    public partial class T1 : Form
    {
        public T1()
        {
            InitializeComponent();
        }

        private void BtnResPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            TRPassword tRPassword = new TRPassword();
            tRPassword.Show();
        }
    }
}
