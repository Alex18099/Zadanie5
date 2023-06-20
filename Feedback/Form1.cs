using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SendMail sendMail = new SendMail(textBoxBody.Text, textBoxName.Text, textBoxSubject.Text);
            sendMail.MySendMail();
        }
    }
}
