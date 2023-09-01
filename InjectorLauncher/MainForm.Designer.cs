namespace InjectorLauncher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bit32Button = new System.Windows.Forms.Button();
            this.bit64Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bit32Button
            // 
            this.bit32Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bit32Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bit32Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bit32Button.Location = new System.Drawing.Point(12, 36);
            this.bit32Button.Name = "bit32Button";
            this.bit32Button.Size = new System.Drawing.Size(289, 45);
            this.bit32Button.TabIndex = 0;
            this.bit32Button.Text = "32 Bit";
            this.bit32Button.UseVisualStyleBackColor = true;
            this.bit32Button.Click += new System.EventHandler(this.bit32Button_Click);
            // 
            // bit64Button
            // 
            this.bit64Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bit64Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bit64Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bit64Button.Location = new System.Drawing.Point(12, 87);
            this.bit64Button.Name = "bit64Button";
            this.bit64Button.Size = new System.Drawing.Size(289, 45);
            this.bit64Button.TabIndex = 1;
            this.bit64Button.Text = "64 Bit";
            this.bit64Button.UseVisualStyleBackColor = true;
            this.bit64Button.Click += new System.EventHandler(this.bit64Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Is the program/game 32 or 64 bit?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(310, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bit64Button);
            this.Controls.Add(this.bit32Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeartlessAngel\'s DLL Injector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bit32Button;
        private System.Windows.Forms.Button bit64Button;
        private System.Windows.Forms.Label label1;
    }
}

