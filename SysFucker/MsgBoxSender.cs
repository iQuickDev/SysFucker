using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace SysFucker
{
    public static class MsgBoxSender
    {
        public static void SpawnMsg(int seed)
        {
            new Thread(() =>
            {
                String msgString = "";
                Random r = new Random(seed);

                for (int i = 0; i < 5000; i++)
                {
                    int rInt = r.Next(33, 1000);
                    msgString += (char)rInt;
                }
                System.Windows.Forms.MessageBox.Show(msgString);
            }).Start();
        }
    }
}
