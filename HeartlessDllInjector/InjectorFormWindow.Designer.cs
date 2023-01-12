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
            this.SuspendLayout();
            // 
            // injectDllsButton
            // 
            this.injectDllsButton.Location = new System.Drawing.Point(415, 243);
            this.injectDllsButton.Name = "injectDllsButton";
            this.injectDllsButton.Size = new System.Drawing.Size(75, 33);
            this.injectDllsButton.TabIndex = 0;
            this.injectDllsButton.Text = "Inject DLLs";
            this.injectDllsButton.UseVisualStyleBackColor = true;
            this.injectDllsButton.Click += new System.EventHandler(this.injectDllsButton_Click);
            // 
            // addDllButton
            // 
            this.addDllButton.Location = new System.Drawing.Point(346, 243);
            this.addDllButton.Name = "addDllButton";
            this.addDllButton.Size = new System.Drawing.Size(63, 33);
            this.addDllButton.TabIndex = 1;
            this.addDllButton.Text = "Add DLL";
            this.addDllButton.UseVisualStyleBackColor = true;
            this.addDllButton.Click += new System.EventHandler(this.addDllButton_Click);
            // 
            // procListBox
            // 
            this.procListBox.FormattingEnabled = true;
            this.procListBox.Location = new System.Drawing.Point(12, 12);
            this.procListBox.Name = "procListBox";
            this.procListBox.Size = new System.Drawing.Size(123, 264);
            this.procListBox.TabIndex = 2;
            // 
            // dllsListBox
            // 
            this.dllsListBox.FormattingEnabled = true;
            this.dllsListBox.Location = new System.Drawing.Point(142, 12);
            this.dllsListBox.Name = "dllsListBox";
            this.dllsListBox.Size = new System.Drawing.Size(348, 225);
            this.dllsListBox.TabIndex = 3;
            // 
            // refreshProcListButton
            // 
            this.refreshProcListButton.Location = new System.Drawing.Point(142, 243);
            this.refreshProcListButton.Name = "refreshProcListButton";
            this.refreshProcListButton.Size = new System.Drawing.Size(111, 33);
            this.refreshProcListButton.TabIndex = 4;
            this.refreshProcListButton.Text = "Refersh process list";
            this.refreshProcListButton.UseVisualStyleBackColor = true;
            this.refreshProcListButton.Click += new System.EventHandler(this.refreshProcListButton_Click);
            // 
            // removeDllButton
            // 
            this.removeDllButton.Location = new System.Drawing.Point(259, 243);
            this.removeDllButton.Name = "removeDllButton";
            this.removeDllButton.Size = new System.Drawing.Size(81, 33);
            this.removeDllButton.TabIndex = 5;
            this.removeDllButton.Text = "Remove DLL";
            this.removeDllButton.UseVisualStyleBackColor = true;
            this.removeDllButton.Click += new System.EventHandler(this.removeDllButton_Click);
            // 
            // InjectorFormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 289);
            this.Controls.Add(this.removeDllButton);
            this.Controls.Add(this.refreshProcListButton);
            this.Controls.Add(this.dllsListBox);
            this.Controls.Add(this.procListBox);
            this.Controls.Add(this.addDllButton);
            this.Controls.Add(this.injectDllsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InjectorFormWindow";
            this.Text = "HeartlessAngel\'s DLL Injector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button injectDllsButton;
        private System.Windows.Forms.Button addDllButton;
        private System.Windows.Forms.ListBox procListBox;
        private System.Windows.Forms.ListBox dllsListBox;
        private System.Windows.Forms.Button refreshProcListButton;
        private System.Windows.Forms.Button removeDllButton;
    }
}

