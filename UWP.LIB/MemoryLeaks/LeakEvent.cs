using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.LIB.MemoryLeaks
{
    public class LeakEvent
    {
        string value = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

        public LeakEvent()
        {
        }

        public void DoLeak(object sender, EventArgs e)
        {
            
        }
    }

    public class NoLeakEvent
    {
        string value = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

        public event EventHandler DontDoLeak;
        public NoLeakEvent(EventHandler handler)
        {
            DontDoLeak += handler;
        }

    }
}
