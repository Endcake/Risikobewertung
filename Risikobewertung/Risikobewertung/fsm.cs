using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;

namespace Risikobewertung
{
    public class fsm
    {
        private enum State { Open, SpecLoaded ,Closed }

        private enum Trigger { Close, loadSpec }

        private readonly StateMachine<State, Trigger> _machine;

        public fsm()
        {
            // Instantiate a new state machine in the Open state
            _machine = new StateMachine<State, Trigger>(State.Open);


            // Configure the Open state
            _machine.Configure(State.Open)
                .Permit(Trigger.Close, State.Closed)
                .Permit(Trigger.loadSpec, State.SpecLoaded);

            // configure SpecLoaded state
            _machine.Configure(State.SpecLoaded)
                .Permit(Trigger.Close, State.Closed);


        }

        public void Open()
        {

        }
        public int Close()
        {
            
            _machine.Fire(Trigger.Close);
            return 99;
        }

        public void loadSpectrum()
        {
            _machine.Fire(Trigger.loadSpec);
        }
    }
}
