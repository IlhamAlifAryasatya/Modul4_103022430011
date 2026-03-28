using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022430011
{
    public class MesinKopi
    {
        public enum State { OFF, STANDBY, BREWING, MAINTENANCE }
        public State currentState;

        public MesinKopi() 
        {
            currentState = State.OFF;
        }

        public void Transisi(string trigger)
        {
            State oldState = currentState;
            bool valid = true;

            switch (currentState)
            {
                case State.OFF:
                    if (trigger == "POWER_ON") currentState = State.STANDBY;
                    else valid = false;
                    break;
                case State.STANDBY:
                    if (trigger == "POWER_OFF") currentState = State.OFF;
                    else if (trigger == "START_BREW") currentState = State.BREWING;
                    else if (trigger == "START_MAINTENANCE") currentState = State.MAINTENANCE;
                    else valid = false;
                    break;
                case State.BREWING:
                    if (trigger == "FINISH_BREW") currentState = State.STANDBY;
                    else valid = false;
                    break;
                case State.MAINTENANCE:
                    if (trigger == "FINISH_MAINTENANCE") currentState = State.STANDBY;
                    else valid = false;
                    break;
            }
            if (valid)
            {
                Console.WriteLine($"MESIN {oldState} berubah menjadi {currentState}");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
    }
}
