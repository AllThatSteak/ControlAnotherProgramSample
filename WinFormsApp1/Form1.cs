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
                for (int i = 0; i < 10; i++)
                {
                    SendKeys.Send("P");
                }
                SendKeys.Send("💩 💩 💩 💩 💩 💩 💩 💩 💩 💩 💩 💩 💩 💩 💩 💩");
                SendKeys.Send("{ENTER}");
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.DoDragDrop(panel1, DragDropEffects.Move);
        }

        private void btnStart_MouseDown(object sender, MouseEventArgs e)
        {
            btnStart.DoDragDrop("MOOP", DragDropEffects.Move);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }
    }
}