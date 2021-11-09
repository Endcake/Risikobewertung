using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stateless;
namespace Risikobewertung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //
        //          setup state machine
        //
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public enum state { Open, Close }

        private enum Trigger { btnExit}

        private readonly StateMachine<state, Trigger> _machine;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
