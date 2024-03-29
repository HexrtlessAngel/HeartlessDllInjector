﻿// Hello world? What if the world is leaving??? Ever thought of that?!?!?!
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HeartlessDllInjector
{
    public partial class InjectorFormWindow : Form
    {
        private int refreshButtonClicks, attempts, annoyedLevel;
        private List<string> blackListedProcNames;

        public bool transparentWindow;
        public List<string> dlls;
        public Injector injector;

        public InjectorFormWindow()
        {
            InitializeComponent();

            InitBlackListedProcNames();
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            dlls = new List<string>();
            injector = new Injector();

            RefreshProcList();

            if (Environment.Is64BitProcess)
                Text += " (64 BIT)";
            else
                Text += " (32 BIT)";

            if (CheckIfRunningAsAdmin())
            {
                MessageBox.Show("Running as admin, DLL Injection as an admin can get real dangerous real fast, know what you are injecting, be safe and have fun. ;)", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Text += " (ADMIN)";
            }
        }

        private bool CheckIfRunningAsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal= new WindowsPrincipal(identity);

            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void RefreshProcList()
        {
            procListBox.Items.Clear();

            foreach (Process proc in Process.GetProcesses())
            {
                // Lol
                if (Process.GetCurrentProcess().Id == proc.Id)
                    continue;

                // Blacklisting certian processes for clean and safty reasons. (this looks jank ik lol)
                if (IsBlacklistedProess(proc.ProcessName))
                    continue;

                // If the process is not in the same bit as we are in
                if (IsProcess64Bit(proc) != Environment.Is64BitProcess)
                    continue;

                procListBox.Items.Add(proc.ProcessName);
            }
        }

        private bool IsProcess64Bit(Process proc)
        {
            try
            {
                if (!Environment.Is64BitOperatingSystem)
                    return false;

                bool isWow64;

                if (!Natives.IsWow64Process(proc.Handle, out isWow64))
                    return false;

                return !isWow64;
            }
            catch
            {
                return false;
            }
        }

        private void InitBlackListedProcNames()
        {
            blackListedProcNames = new List<string>
            {
                "HeartlessDllInjector", // This lmao
                "rundll32",
                "svchost",
                "winlogon",
                "RuntimeBroker",
                "chrome",
                "explorer",
                "OneDrive",
                "msedgewebview2",
                "conhost",
                "dllhost",
                "Discord",
                "Code",
                "Spotify",
                "csrss",
                "cmd",
                "SystemSettings",
                "qemu-ga",
                "Taskmgr",
                "wininit",
                "Guilded",
                "brave",
            };
        }

        private bool IsBlacklistedProess(string name)
        {
            return blackListedProcNames.Contains(name);
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

        private void AddDllFromOpenmFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            switch (openFileDialog.ShowDialog(this))
            {
                case DialogResult.OK:
                    AddDllToList(openFileDialog.FileName);
                    break;

                case DialogResult.Cancel:
                    MessageBox.Show("No dll file was selected...", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void addDllButton_Click(object sender, EventArgs e) => AddDllFromOpenmFileDialog();

        private void AddDllToList(string dllItem)
        {
            dllsListBox.Items.Add(dllItem);
            dlls.Add(dllItem);
        }

        private void removeDllButton_Click(object sender, EventArgs e)
        {
            if (dllsListBox.Items.Count == 0)
                return;

            dllsListBox.Items.RemoveAt(dllsListBox.SelectedIndex);
            dlls.RemoveAt(dllsListBox.SelectedIndex + 1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
        private void addDLLToolStripMenuItem_Click(object sender, EventArgs e) => AddDllFromOpenmFileDialog();

        private void refreshProcessListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshButtonClicks++;

            if (refreshButtonClicks == 15)
            {
                ExpressAnnoyance();
                refreshButtonClicks = 0;
            }

            RefreshProcList();
        }

        private void clickMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // :D
            MessageBox.Show("When life gives you lemons, don't make lemonade. Make life take the lemons back! Get mad! I don't want your damn lemons, what the hell am I supposed to do with these? Demand to see life's manager! Make life rue the day it thought it could give Cave Johnson lemons! Do you know who I am? I'm the man who's gonna burn your house down! With the lemons! I'm gonna get my engineers to invent a combustible lemon that burns your house down!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
