using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204126
{
    class PosisiKarakterGame
    {
        public enum State
        {
            Jongkok, Berdiri, Tengkurap, Terbang
        }

        public enum Trigger
        {
            TombolW, TombolS, TombolX
        }

        

        public State prevState;
        public State nextState;
        public State currentState;
        public Trigger trigger;

        public void transition(State prevState, State nextState, Trigger trigger)
        {
            this.prevState = prevState;
            this.nextState = nextState;
            this.trigger = trigger;

            
        }

        public State getNextState(State prevState, Trigger trigger)
        {
            State nextState = prevState;

            return nextState;
        }

        

        public void activateTrigger(Trigger trigger)
        {
            State nextStage = getNextState(currentState, trigger);
            currentState = nextStage;

            transition(nextStage, nextState, trigger);
        }



    }

}
