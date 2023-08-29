using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InjectorLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bit32Button_Click(object sender, EventArgs e)
        {
            Process.Start($"{Environment.CurrentDirectory}/32Bit/HeartlessDllInjector.exe");
            Environment.Exit(0);
        }

        private void bit64Button_Click(object sender, EventArgs e)
        {
            Process.Start($"{Environment.CurrentDirectory}/64Bit/HeartlessDllInjector.exe");
            Environment.Exit(0);
        }
    }
}
