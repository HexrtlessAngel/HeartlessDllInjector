using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartlessDllInjector
{
    public partial class InjectorFormWindow : Form
    {
        private int refreshButtonClicks, attempts, annoyedLevel;
        public List<string> dlls;
        public Injector injector;

        public InjectorFormWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            dlls = new List<string>();
            injector = new Injector();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            RefreshProcList();
        }

        private void RefreshProcList()
        {
            procListBox.Items.Clear();

            foreach (Process proc in Process.GetProcesses())
            {
                // Blacklisting certian processes for clean and safty reasons. (this looks jank ik lol)                
                switch (proc.ProcessName)
                {
                    default:
                        procListBox.Items.Add(proc.ProcessName);
                        break;

                    case "svchost":
                        continue;

                    case "winlogon":
                        continue;

                    case "RuntimeBroker":
                        continue;

                    case "chrome":
                        continue;

                    case "explorer":
                        continue;

                    case "OneDrive":
                        continue;

                    case "msedgewebview2":
                        continue;

                    case "conhost":
                        continue;

                    case "dllhost":
                        continue;

                    case "Discord":
                        continue;

                    case "Code":
                        continue;

                    case "Spotify":
                        continue;

                    case "csrss":
                        continue;

                    case "cmd":
                        continue;

                    case "SystemSettings":
                        continue;

                    case "qemu-ga":
                        continue;

                    case "Taskmgr":
                        continue;

                    case "wininit":
                        continue;

                    case "Guilded":
                        continue;
                }
            }
        }

        private void ExpressAnnoyance()
        {
            switch(annoyedLevel)
            {
                case 0:
                    SlightlyAnnoyed();
                    break;

                case 1:
                    MidAnnoyed();
                    break;

                case 2:
                    ExtremelyAnnoyed();
                    break;

                case 3:
                    MessageBox.Show("Fuck this shit I'm out of here...", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                    break;
            }
            annoyedLevel++;
        }

        private void SlightlyAnnoyed()
        {
            switch (MessageBox.Show("You good?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                case DialogResult.Yes:
                    MessageBox.Show("Ok... well just maybe don't play with a dll injector if you are bored? lol...", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case DialogResult.No:
                    MessageBox.Show("Sorry to hear that...", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void MidAnnoyed()
        {
            switch (MessageBox.Show("Ok are you doing this to make me angry?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                case DialogResult.Yes:
                    MessageBox.Show("Bruh...", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case DialogResult.No:
                    MessageBox.Show("Then would you please stop? :)", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void ExtremelyAnnoyed()
        {
            MessageBox.Show("FUCKING STOP", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void refreshProcListButton_Click(object sender, EventArgs e)
        {
            refreshButtonClicks++;

            if (refreshButtonClicks == 15)
            {
                ExpressAnnoyance();
                refreshButtonClicks = 0;
            }    

            RefreshProcList();
        }

        private void addDllButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            switch(openFileDialog.ShowDialog(this))
            {
                case DialogResult.OK:
                    AddDllToList(openFileDialog.FileName);
                    break;

                case DialogResult.Cancel:
                    MessageBox.Show("No dll file was selected...", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void AddDllToList(string dllItem)
        {
            dllsListBox.Items.Add(dllItem);
            dlls.Add(dllItem);
        }

        private void removeDllButton_Click(object sender, EventArgs e)
        {
            dllsListBox.Items.RemoveAt(dllsListBox.SelectedIndex);
            dlls.RemoveAt(dllsListBox.SelectedIndex + 1);
        }

        private bool CheckIfReady()
        {
            attempts++;

            if (procListBox.SelectedItems.Count == 0 && dllsListBox.Items.Count == 0)
            {
                if (attempts == 5)
                    MessageBox.Show("Dude... stop fucking around -_-", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (attempts == 6)
                    MessageBox.Show("Really?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                else if (attempts == 7)
                {
                    MessageBox.Show("Fuck this shit I'm out of here...", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                    MessageBox.Show("Please make sure you have a process highlight in the process list, also you have no dlls added...", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (procListBox.SelectedItems.Count == 0 && dllsListBox.Items.Count != 0)
            {
                if (attempts == 5)
                    MessageBox.Show("Dude... stop fucking around -_-", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (attempts == 6)
                    MessageBox.Show("Really?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                else if (attempts == 7)
                {
                    MessageBox.Show("Fuck this shit I'm out of here...", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    string word = "dll";

                    if (dlls.Count > 1)
                        word = "dlls";

                    MessageBox.Show($"Make sure you have the process you want to inject the {word} into", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }
            else if (procListBox.SelectedItems.Count != 0 && dllsListBox.Items.Count == 0)
            {
                if (attempts == 5)
                    MessageBox.Show("Dude... stop fucking around -_-", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (attempts == 6)
                    MessageBox.Show("Really?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                else if (attempts == 7)
                {
                    MessageBox.Show("Fuck this shit I'm out of here...", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                    MessageBox.Show("You didn't add any dlls to inject... are you trying to inject hopes and dreams? lol.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void injectDllsButton_Click(object sender, EventArgs e)
        {
            if (!CheckIfReady())
                return;

            attempts = 0;

            foreach(string dll in dlls)
            {
                if (injector.InjectByProcName(procListBox.Items[procListBox.SelectedIndex].ToString(), dll) != InjectorResult.InjectionComplete)
                {
                    MessageBox.Show($"{Path.GetFileName(dll)} failed to inject.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (MessageBox.Show("All dlls were injected! Would you like to exit now?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
