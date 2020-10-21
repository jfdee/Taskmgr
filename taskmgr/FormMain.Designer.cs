namespace taskmgr
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAddProcess = new System.Windows.Forms.Button();
            this.buttonRemoveProcess = new System.Windows.Forms.Button();
            this.listBoxPID = new System.Windows.Forms.ListBox();
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.listBoxPriority = new System.Windows.Forms.ListBox();
            this.listBoxMemory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAboutMemory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPauseRestore = new System.Windows.Forms.Button();
            this.buttonIncreaseSpeed = new System.Windows.Forms.Button();
            this.buttonReduceSpeed = new System.Windows.Forms.Button();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddProcess
            // 
            this.buttonAddProcess.Location = new System.Drawing.Point(28, 254);
            this.buttonAddProcess.Name = "buttonAddProcess";
            this.buttonAddProcess.Size = new System.Drawing.Size(57, 23);
            this.buttonAddProcess.TabIndex = 5;
            this.buttonAddProcess.Text = "Add";
            this.buttonAddProcess.UseVisualStyleBackColor = true;
            this.buttonAddProcess.Click += new System.EventHandler(this.buttonAddProcess_Click);
            // 
            // buttonRemoveProcess
            // 
            this.buttonRemoveProcess.Location = new System.Drawing.Point(91, 254);
            this.buttonRemoveProcess.Name = "buttonRemoveProcess";
            this.buttonRemoveProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveProcess.TabIndex = 7;
            this.buttonRemoveProcess.Text = "Remove";
            this.buttonRemoveProcess.UseVisualStyleBackColor = true;
            this.buttonRemoveProcess.Click += new System.EventHandler(this.buttonRemoveProcess_Click);
            // 
            // listBoxPID
            // 
            this.listBoxPID.FormattingEnabled = true;
            this.listBoxPID.Location = new System.Drawing.Point(28, 129);
            this.listBoxPID.Name = "listBoxPID";
            this.listBoxPID.Size = new System.Drawing.Size(120, 95);
            this.listBoxPID.TabIndex = 8;
            this.listBoxPID.SelectedIndexChanged += new System.EventHandler(this.listBoxPID_SelectedIndexChanged);
            // 
            // listBoxName
            // 
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.Location = new System.Drawing.Point(154, 129);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(120, 95);
            this.listBoxName.TabIndex = 9;
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.Location = new System.Drawing.Point(280, 129);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(120, 95);
            this.listBoxStatus.TabIndex = 10;
            // 
            // listBoxPriority
            // 
            this.listBoxPriority.FormattingEnabled = true;
            this.listBoxPriority.Location = new System.Drawing.Point(406, 129);
            this.listBoxPriority.Name = "listBoxPriority";
            this.listBoxPriority.Size = new System.Drawing.Size(120, 95);
            this.listBoxPriority.TabIndex = 11;
            // 
            // listBoxMemory
            // 
            this.listBoxMemory.FormattingEnabled = true;
            this.listBoxMemory.Location = new System.Drawing.Point(532, 129);
            this.listBoxMemory.Name = "listBoxMemory";
            this.listBoxMemory.Size = new System.Drawing.Size(120, 95);
            this.listBoxMemory.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "PID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Priority";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Memory";
            // 
            // textBoxAboutMemory
            // 
            this.textBoxAboutMemory.Location = new System.Drawing.Point(294, 12);
            this.textBoxAboutMemory.Name = "textBoxAboutMemory";
            this.textBoxAboutMemory.Size = new System.Drawing.Size(120, 20);
            this.textBoxAboutMemory.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Memory";
            // 
            // buttonPauseRestore
            // 
            this.buttonPauseRestore.Location = new System.Drawing.Point(172, 254);
            this.buttonPauseRestore.Name = "buttonPauseRestore";
            this.buttonPauseRestore.Size = new System.Drawing.Size(89, 23);
            this.buttonPauseRestore.TabIndex = 20;
            this.buttonPauseRestore.Text = "Pause/Restore";
            this.buttonPauseRestore.UseVisualStyleBackColor = true;
            this.buttonPauseRestore.Click += new System.EventHandler(this.buttonPauseRestore_Click);
            // 
            // buttonIncreaseSpeed
            // 
            this.buttonIncreaseSpeed.Location = new System.Drawing.Point(267, 254);
            this.buttonIncreaseSpeed.Name = "buttonIncreaseSpeed";
            this.buttonIncreaseSpeed.Size = new System.Drawing.Size(75, 23);
            this.buttonIncreaseSpeed.TabIndex = 21;
            this.buttonIncreaseSpeed.Text = "Increase";
            this.buttonIncreaseSpeed.UseVisualStyleBackColor = true;
            this.buttonIncreaseSpeed.Click += new System.EventHandler(this.buttonIncreaseSpeed_Click);
            // 
            // buttonReduceSpeed
            // 
            this.buttonReduceSpeed.Location = new System.Drawing.Point(348, 254);
            this.buttonReduceSpeed.Name = "buttonReduceSpeed";
            this.buttonReduceSpeed.Size = new System.Drawing.Size(75, 23);
            this.buttonReduceSpeed.TabIndex = 22;
            this.buttonReduceSpeed.Text = "Reduce";
            this.buttonReduceSpeed.UseVisualStyleBackColor = true;
            this.buttonReduceSpeed.Click += new System.EventHandler(this.buttonReduceSpeed_Click);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(116, 12);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Processor speed";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Location = new System.Drawing.Point(116, 38);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimer.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Time";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTimer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.buttonReduceSpeed);
            this.Controls.Add(this.buttonIncreaseSpeed);
            this.Controls.Add(this.buttonPauseRestore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAboutMemory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMemory);
            this.Controls.Add(this.listBoxPriority);
            this.Controls.Add(this.listBoxStatus);
            this.Controls.Add(this.listBoxName);
            this.Controls.Add(this.listBoxPID);
            this.Controls.Add(this.buttonRemoveProcess);
            this.Controls.Add(this.buttonAddProcess);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddProcess;
        private System.Windows.Forms.Button buttonRemoveProcess;
        private System.Windows.Forms.ListBox listBoxPID;
        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.ListBox listBoxPriority;
        private System.Windows.Forms.ListBox listBoxMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAboutMemory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonPauseRestore;
        private System.Windows.Forms.Button buttonIncreaseSpeed;
        private System.Windows.Forms.Button buttonReduceSpeed;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.Label label8;
    }
}

