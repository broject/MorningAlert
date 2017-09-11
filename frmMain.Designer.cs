namespace MorningAlert
{
    partial class frmMain
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
            this.dayAlert = new System.Windows.Forms.CheckedListBox();
            this.txtMusic = new System.Windows.Forms.TextBox();
            this.btnMusic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tmeAlert = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dayAlert
            // 
            this.dayAlert.Dock = System.Windows.Forms.DockStyle.Left;
            this.dayAlert.FormattingEnabled = true;
            this.dayAlert.Items.AddRange(new object[] {
            "Даваа",
            "Мягмар",
            "Лхагва",
            "Пүрэв",
            "Баасан",
            "Бямба",
            "Ням"});
            this.dayAlert.Location = new System.Drawing.Point(0, 0);
            this.dayAlert.Name = "dayAlert";
            this.dayAlert.Size = new System.Drawing.Size(120, 189);
            this.dayAlert.TabIndex = 0;
            this.dayAlert.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.dayAlert_ItemCheck);
            // 
            // txtMusic
            // 
            this.txtMusic.Location = new System.Drawing.Point(129, 74);
            this.txtMusic.Name = "txtMusic";
            this.txtMusic.ReadOnly = true;
            this.txtMusic.Size = new System.Drawing.Size(195, 20);
            this.txtMusic.TabIndex = 1;
            this.txtMusic.TextChanged += new System.EventHandler(this.txtMusic_TextChanged);
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(129, 100);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(195, 23);
            this.btnMusic.TabIndex = 2;
            this.btnMusic.Text = "Дууны файл сонгох";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тоглуулах дууны замаа сонгоорой!";
            // 
            // tmeAlert
            // 
            this.tmeAlert.CustomFormat = "HH цаг mm минут";
            this.tmeAlert.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tmeAlert.Location = new System.Drawing.Point(129, 25);
            this.tmeAlert.Name = "tmeAlert";
            this.tmeAlert.Size = new System.Drawing.Size(195, 20);
            this.tmeAlert.TabIndex = 5;
            this.tmeAlert.ValueChanged += new System.EventHandler(this.tmeAlert_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сэрэх цагаа оруулаарай!";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(129, 152);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(195, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Эхлүүлэх";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(129, 129);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(152, 17);
            this.chkAutoStart.TabIndex = 6;
            this.chkAutoStart.Text = "Автоматаар ажиллах уу?";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            this.chkAutoStart.CheckedChanged += new System.EventHandler(this.chkAutoStart_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 189);
            this.Controls.Add(this.chkAutoStart);
            this.Controls.Add(this.tmeAlert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.txtMusic);
            this.Controls.Add(this.dayAlert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox dayAlert;
        private System.Windows.Forms.TextBox txtMusic;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tmeAlert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkAutoStart;
    }
}

