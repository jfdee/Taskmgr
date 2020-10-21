namespace taskmgr
{
    partial class FormRemoveProcess
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRemoveOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // buttonRemoveOK
            // 
            this.buttonRemoveOK.Location = new System.Drawing.Point(85, 97);
            this.buttonRemoveOK.Name = "buttonRemoveOK";
            this.buttonRemoveOK.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveOK.TabIndex = 1;
            this.buttonRemoveOK.Text = "Remove";
            this.buttonRemoveOK.UseVisualStyleBackColor = true;
            this.buttonRemoveOK.Click += new System.EventHandler(this.buttonRemoveOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PID";
            // 
            // FormRemoveProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoveOK);
            this.Controls.Add(this.textBox1);
            this.Name = "FormRemoveProcess";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRemoveOK;
        private System.Windows.Forms.Label label1;
    }
}