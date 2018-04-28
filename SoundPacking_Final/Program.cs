using SoundPacking_Final;
using System;
using System.IO;
using System.Windows.Forms;

namespace Sounds_Packing
{
    class Program
    {
        static Random r = new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}