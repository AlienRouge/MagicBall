
namespace MagicBall
{
    partial class Form1
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
            this.questionBox = new System.Windows.Forms.TextBox();
            this.yesLimit = new System.Windows.Forms.NumericUpDown();
            this.AnsBtn = new System.Windows.Forms.Button();
            this.SwitchBtn = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.Label();
            this.YesLimitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yesLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(43, 82);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(251, 20);
            this.questionBox.TabIndex = 0;
            // 
            // yesLimit
            // 
            this.yesLimit.DecimalPlaces = 1;
            this.yesLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yesLimit.Location = new System.Drawing.Point(94, 265);
            this.yesLimit.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yesLimit.Name = "yesLimit";
            this.yesLimit.Size = new System.Drawing.Size(52, 20);
            this.yesLimit.TabIndex = 1;
            this.yesLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yesLimit.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // AnsBtn
            // 
            this.AnsBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnsBtn.Location = new System.Drawing.Point(110, 120);
            this.AnsBtn.Name = "AnsBtn";
            this.AnsBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AnsBtn.Size = new System.Drawing.Size(111, 59);
            this.AnsBtn.TabIndex = 2;
            this.AnsBtn.Text = "I want to know";
            this.AnsBtn.UseVisualStyleBackColor = true;
            this.AnsBtn.Click += new System.EventHandler(this.AnsBtn_Click);
            // 
            // SwitchBtn
            // 
            this.SwitchBtn.Location = new System.Drawing.Point(261, 262);
            this.SwitchBtn.Name = "SwitchBtn";
            this.SwitchBtn.Size = new System.Drawing.Size(60, 23);
            this.SwitchBtn.TabIndex = 3;
            this.SwitchBtn.Text = "Yes/No";
            this.SwitchBtn.UseVisualStyleBackColor = true;
            this.SwitchBtn.Click += new System.EventHandler(this.SwitchBtn_Click);
            // 
            // answerBox
            // 
            this.answerBox.AutoSize = true;
            this.answerBox.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBox.Location = new System.Drawing.Point(14, 211);
            this.answerBox.MaximumSize = new System.Drawing.Size(500, 500);
            this.answerBox.Name = "answerBox";
            this.answerBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.answerBox.Size = new System.Drawing.Size(69, 20);
            this.answerBox.TabIndex = 4;
            this.answerBox.Text = "label1";
            this.answerBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YesLimitLabel
            // 
            this.YesLimitLabel.AutoSize = true;
            this.YesLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YesLimitLabel.Location = new System.Drawing.Point(6, 267);
            this.YesLimitLabel.Name = "YesLimitLabel";
            this.YesLimitLabel.Size = new System.Drawing.Size(88, 15);
            this.YesLimitLabel.TabIndex = 5;
            this.YesLimitLabel.Text = "Yes/No limit:";
            this.YesLimitLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Magic Ball";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YesLimitLabel);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.SwitchBtn);
            this.Controls.Add(this.AnsBtn);
            this.Controls.Add(this.yesLimit);
            this.Controls.Add(this.questionBox);
            this.Name = "Form1";
            this.Text = "MagicBall";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yesLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.NumericUpDown yesLimit;
        private System.Windows.Forms.Button AnsBtn;
        private System.Windows.Forms.Button SwitchBtn;
        private System.Windows.Forms.Label answerBox;
        private System.Windows.Forms.Label YesLimitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

