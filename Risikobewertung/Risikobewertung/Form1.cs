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

        fsm fsm = new fsm();


        public Form1()
        {
            InitializeComponent();

           
          
           


        }

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //
        //          setup state machine
        //
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        
        
          

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            if (fsm.Close() == 99)
            {
                Application.Exit();
            }
           
        }

        private void btnLoadSpectrum_Click(object sender, EventArgs e)
        {
            
        }
    }
}
