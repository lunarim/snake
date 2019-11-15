using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Windows.Forms;

namespace snake_test_v1
{
    class userinput
    {
        //load list of available keyboard buttons
        private static Hashtable keyTable = new Hashtable();

        //perform a check to see if a particukar button is pressed
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool) keyTable[key];
        }

        //detect if a keyboard button is pressed 
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;

        }
    }
}
