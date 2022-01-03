using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace key_spirit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJump_Click(object sender, EventArgs e)
        {
            PInvoke.POINT pOINT = PInvoke.User32.GetCursorPos();
            IntPtr intPtr = PInvoke.User32.WindowFromPoint(pOINT);
            PInvoke.User32.MessageBox(intPtr,"hello world!", "hello",PInvoke.User32.MessageBoxOptions.MB_APPLMODAL);
        }
    }
}
