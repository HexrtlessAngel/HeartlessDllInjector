// Ha! you though I wouldn't put a comment in here, you're wrong I do it EVERYWHERE! HAHAHAHA!!!!!
// I
// A M
// E V E R Y W H E R E
// B I T C H
namespace HeartlessDllInjector
{
    partial class InjectorFormWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InjectorFormWindow));
            this.injectDllsButton = new System.Windows.Forms.Button();
            this.addDllButton = new System.Windows.Forms.Button();
            this.procListBox = new System.Windows.Forms.ListBox();
            this.dllsListBox = new System.Windows.Forms.ListBox();
            this.refreshProcListButton = new System.Windows.Forms.Button();
            this.removeDllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshProcessListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // injectDllsButton
            // 
            this.injectDllsButton.BackColor = System.Drawing.SystemColors.Control;
            this.injectDllsButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.injectDllsButton.FlatAppearance.BorderSize = 0;
            this.injectDllsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.injectDllsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.injectDllsButton.ForeColor = System.Drawing.Color.Black;
            this.injectDllsButton.Location = new System.Drawing.Point(623, 398);
            this.injectDllsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.injectDllsButton.Name = "injectDllsButton";
            this.injectDllsButton.Size = new System.Drawing.Size(88, 38);
            this.injectDllsButton.TabIndex = 0;
            this.injectDllsButton.Text = "Inject DLLs";
            this.injectDllsButton.UseVisualStyleBackColor = false;
            this.injectDllsButton.Click += new System.EventHandler(this.injectDllsButton_Click);
            // 
            // addDllButton
            // 
            this.addDllButton.BackColor = System.Drawing.SystemColors.Control;
            this.addDllButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.addDllButton.FlatAppearance.BorderSize = 0;
            this.addDllButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addDllButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.addDllButton.ForeColor = System.Drawing.Color.Black;
            this.addDllButton.Location = new System.Drawing.Point(541, 397);
            this.addDllButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addDllButton.Name = "addDllButton";
            this.addDllButton.Size = new System.Drawing.Size(74, 38);
            this.addDllButton.TabIndex = 1;
            this.addDllButton.Text = "Add DLL";
            this.addDllButton.UseVisualStyleBackColor = false;
            this.addDllButton.Click += new System.EventHandler(this.addDllButton_Click);
            // 
            // procListBox
            // 
            this.procListBox.BackColor = System.Drawing.Color.White;
            this.procListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.procListBox.ForeColor = System.Drawing.Color.Black;
            this.procListBox.FormattingEnabled = true;
            this.procListBox.ItemHeight = 15;
            this.procListBox.Location = new System.Drawing.Point(13, 42);
            this.procListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.procListBox.Name = "procListBox";
            this.procListBox.Size = new System.Drawing.Size(281, 394);
            this.procListBox.TabIndex = 2;
            // 
            // dllsListBox
            // 
            this.dllsListBox.BackColor = System.Drawing.Color.White;
            this.dllsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dllsListBox.ForeColor = System.Drawing.Color.Black;
            this.dllsListBox.FormattingEnabled = true;
            this.dllsListBox.ItemHeight = 15;
            this.dllsListBox.Location = new System.Drawing.Point(302, 42);
            this.dllsListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dllsListBox.Name = "dllsListBox";
            this.dllsListBox.Size = new System.Drawing.Size(409, 349);
            this.dllsListBox.TabIndex = 3;
            // 
            // refreshProcListButton
            // 
            this.refreshProcListButton.BackColor = System.Drawing.SystemColors.Control;
            this.refreshProcListButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.refreshProcListButton.FlatAppearance.BorderSize = 0;
            this.refreshProcListButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshProcListButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.refreshProcListButton.ForeColor = System.Drawing.Color.Black;
            this.refreshProcListButton.Location = new System.Drawing.Point(301, 397);
            this.refreshProcListButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refreshProcListButton.Name = "refreshProcListButton";
            this.refreshProcListButton.Size = new System.Drawing.Size(130, 38);
            this.refreshProcListButton.TabIndex = 4;
            this.refreshProcListButton.Text = "Refersh process list";
            this.refreshProcListButton.UseVisualStyleBackColor = false;
            this.refreshProcListButton.Click += new System.EventHandler(this.refreshProcListButton_Click);
            // 
            // removeDllButton
            // 
            this.removeDllButton.BackColor = System.Drawing.SystemColors.Control;
            this.removeDllButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.removeDllButton.FlatAppearance.BorderSize = 0;
            this.removeDllButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removeDllButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.removeDllButton.ForeColor = System.Drawing.Color.Black;
            this.removeDllButton.Location = new System.Drawing.Point(439, 398);
            this.removeDllButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeDllButton.Name = "removeDllButton";
            this.removeDllButton.Size = new System.Drawing.Size(94, 38);
            this.removeDllButton.TabIndex = 5;
            this.removeDllButton.Text = "Remove DLL";
            this.removeDllButton.UseVisualStyleBackColor = false;
            this.removeDllButton.Click += new System.EventHandler(this.removeDllButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Processes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(298, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "DLLs";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDLLToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addDLLToolStripMenuItem
            // 
            this.addDLLToolStripMenuItem.Name = "addDLLToolStripMenuItem";
            this.addDLLToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.addDLLToolStripMenuItem.Text = "Add DLL";
            this.addDLLToolStripMenuItem.Click += new System.EventHandler(this.addDLLToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshProcessListToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // refreshProcessListToolStripMenuItem
            // 
            this.refreshProcessListToolStripMenuItem.Name = "refreshProcessListToolStripMenuItem";
            this.refreshProcessListToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.refreshProcessListToolStripMenuItem.Text = "Refresh process list";
            this.refreshProcessListToolStripMenuItem.Click += new System.EventHandler(this.refreshProcessListToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InjectorFormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(722, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeDllButton);
            this.Controls.Add(this.refreshProcListButton);
            this.Controls.Add(this.dllsListBox);
            this.Controls.Add(this.procListBox);
            this.Controls.Add(this.addDllButton);
            this.Controls.Add(this.injectDllsButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InjectorFormWindow";
            this.Text = "HeartlessAngel\'s DLL Injector";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button injectDllsButton;
        private System.Windows.Forms.Button addDllButton;
        private System.Windows.Forms.ListBox procListBox;
        private System.Windows.Forms.ListBox dllsListBox;
        private System.Windows.Forms.Button refreshProcListButton;
        private System.Windows.Forms.Button removeDllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDLLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshProcessListToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

