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

        // private readonly StateMachine<state, Trigger> _machine;
        StateMachine<> _machine = new StateMachine<state, Trigger>(state.Open);


                        // Instantiate a new state machine in the 'off' state
            var onOffSwitch = new StateMachine<string, char>(off);

        // Configure state machine with the Configure method, supplying the state to be configured as a parameter
        onOffSwitch.Configure(off).Permit(space, on);
        onOffSwitch.Configure(on).Permit(space, off);




        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
