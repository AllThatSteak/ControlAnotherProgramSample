using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern void SetParent(IntPtr hwndChild, IntPtr hwndNewParent);

        [DllImport("User32.dll")]

        static extern int SetForegroundWindow(IntPtr point);


        public Process? Process = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Process == null)
            {
                Process = new Process();
                Process.StartInfo.FileName = "notepad.exe";
                Process.Start();
            }
        }

        private void btnDoStuff_Click(object sender, EventArgs e)
        {
            if (Process != null)
            {
                SetForegroundWindow(Process.MainWindowHandle);
                SendKeys.Send("💩 💩 💩 💩 💩 💩 💩 💩 💩 💩 💩 💩 💩 💩 💩 💩");
                SendKeys.Send("{ENTER}");
            }
        }
    }
}