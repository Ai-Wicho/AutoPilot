
namespace AutoPilot
{
    partial class MAIN_FORM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BTN_GO = new System.Windows.Forms.Button();
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_TIME_REMAINING = new System.Windows.Forms.TextBox();
            this.MM_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HH_TB = new System.Windows.Forms.TextBox();
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_IDLE_TIME = new System.Windows.Forms.TextBox();
            this.MM_TOLERANCE_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GB1.SuspendLayout();
            this.GB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_GO
            // 
            this.BTN_GO.Location = new System.Drawing.Point(362, 287);
            this.BTN_GO.Name = "BTN_GO";
            this.BTN_GO.Size = new System.Drawing.Size(75, 23);
            this.BTN_GO.TabIndex = 0;
            this.BTN_GO.Text = "Go";
            this.BTN_GO.UseVisualStyleBackColor = true;
            this.BTN_GO.Click += new System.EventHandler(this.BTN_GO_Click);
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.label2);
            this.GB1.Controls.Add(this.TB_TIME_REMAINING);
            this.GB1.Controls.Add(this.MM_TB);
            this.GB1.Controls.Add(this.label1);
            this.GB1.Controls.Add(this.HH_TB);
            this.GB1.Location = new System.Drawing.Point(68, 55);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(200, 174);
            this.GB1.TabIndex = 1;
            this.GB1.TabStop = false;
            this.GB1.Text = "Time Set";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time Remaining";
            // 
            // TB_TIME_REMAINING
            // 
            this.TB_TIME_REMAINING.Enabled = false;
            this.TB_TIME_REMAINING.Location = new System.Drawing.Point(49, 128);
            this.TB_TIME_REMAINING.Name = "TB_TIME_REMAINING";
            this.TB_TIME_REMAINING.ReadOnly = true;
            this.TB_TIME_REMAINING.Size = new System.Drawing.Size(100, 23);
            this.TB_TIME_REMAINING.TabIndex = 5;
            // 
            // MM_TB
            // 
            this.MM_TB.Location = new System.Drawing.Point(97, 37);
            this.MM_TB.MaxLength = 2;
            this.MM_TB.Name = "MM_TB";
            this.MM_TB.Size = new System.Drawing.Size(23, 23);
            this.MM_TB.TabIndex = 4;
            this.MM_TB.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "HH : MM";
            // 
            // HH_TB
            // 
            this.HH_TB.Location = new System.Drawing.Point(64, 37);
            this.HH_TB.MaxLength = 2;
            this.HH_TB.Name = "HH_TB";
            this.HH_TB.Size = new System.Drawing.Size(23, 23);
            this.HH_TB.TabIndex = 3;
            this.HH_TB.Text = "5";
            // 
            // GB2
            // 
            this.GB2.Controls.Add(this.label4);
            this.GB2.Controls.Add(this.TB_IDLE_TIME);
            this.GB2.Controls.Add(this.MM_TOLERANCE_TB);
            this.GB2.Controls.Add(this.label3);
            this.GB2.Location = new System.Drawing.Point(509, 55);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(200, 174);
            this.GB2.TabIndex = 2;
            this.GB2.TabStop = false;
            this.GB2.Text = "Idle Condition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Idle Time";
            // 
            // TB_IDLE_TIME
            // 
            this.TB_IDLE_TIME.Enabled = false;
            this.TB_IDLE_TIME.Location = new System.Drawing.Point(47, 128);
            this.TB_IDLE_TIME.Name = "TB_IDLE_TIME";
            this.TB_IDLE_TIME.ReadOnly = true;
            this.TB_IDLE_TIME.Size = new System.Drawing.Size(100, 23);
            this.TB_IDLE_TIME.TabIndex = 9;
            // 
            // MM_TOLERANCE_TB
            // 
            this.MM_TOLERANCE_TB.Location = new System.Drawing.Point(82, 49);
            this.MM_TOLERANCE_TB.MaxLength = 2;
            this.MM_TOLERANCE_TB.Name = "MM_TOLERANCE_TB";
            this.MM_TOLERANCE_TB.Size = new System.Drawing.Size(23, 23);
            this.MM_TOLERANCE_TB.TabIndex = 8;
            this.MM_TOLERANCE_TB.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Idle Tolerance: MM";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MAIN_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 360);
            this.Controls.Add(this.GB2);
            this.Controls.Add(this.GB1);
            this.Controls.Add(this.BTN_GO);
            this.Name = "MAIN_FORM";
            this.Text = "Form1";
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            this.GB2.ResumeLayout(false);
            this.GB2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_GO;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_TIME_REMAINING;
        private System.Windows.Forms.TextBox MM_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HH_TB;
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.TextBox MM_TOLERANCE_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_IDLE_TIME;
        private System.Windows.Forms.Timer timer1;
    }
}

