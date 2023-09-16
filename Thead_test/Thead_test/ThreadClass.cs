using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thead_task_test
{
    public class MXThread 
    { 
        public void mythr()
        {
            for (int j = 0; j < 2; j++) 
            {
                Console.WriteLine("My Thread is" + " in progress...!!");
            }
        }
    }

    // Driver Class
    public class GFG 
    {
        // Main method
        public static void Main() 
        {
            MXThread obj = new MXThread();

            Thread t = new Thread(new ThreadStart(obj.mythr));
            t.Start();
        }
    }
}
