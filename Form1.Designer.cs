
namespace Quiz_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.questionLabel = new System.Windows.Forms.Label();
            this.choicesGroupBox = new System.Windows.Forms.GroupBox();
            this.choiceRadioButton4 = new System.Windows.Forms.RadioButton();
            this.choiceRadioButton3 = new System.Windows.Forms.RadioButton();
            this.choiceRadioButton2 = new System.Windows.Forms.RadioButton();
            this.choiceRadioButton1 = new System.Windows.Forms.RadioButton();
            this.nextButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.choicesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.questionLabel.Location = new System.Drawing.Point(17, 21);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(57, 28);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "سوال";
            // 
            // choicesGroupBox
            // 
            this.choicesGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.choicesGroupBox.Controls.Add(this.choiceRadioButton4);
            this.choicesGroupBox.Controls.Add(this.choiceRadioButton3);
            this.choicesGroupBox.Controls.Add(this.choiceRadioButton2);
            this.choicesGroupBox.Controls.Add(this.choiceRadioButton1);
            this.choicesGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.choicesGroupBox.Location = new System.Drawing.Point(17, 64);
            this.choicesGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.choicesGroupBox.Name = "choicesGroupBox";
            this.choicesGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.choicesGroupBox.Size = new System.Drawing.Size(776, 161);
            this.choicesGroupBox.TabIndex = 1;
            this.choicesGroupBox.TabStop = false;
            this.choicesGroupBox.Text = "سوال";
            // 
            // choiceRadioButton4
            // 
            this.choiceRadioButton4.AutoSize = true;
            this.choiceRadioButton4.Location = new System.Drawing.Point(23, 128);
            this.choiceRadioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.choiceRadioButton4.Name = "choiceRadioButton4";
            this.choiceRadioButton4.Size = new System.Drawing.Size(83, 27);
            this.choiceRadioButton4.TabIndex = 3;
            this.choiceRadioButton4.TabStop = true;
            this.choiceRadioButton4.Text = "Choice";
            this.choiceRadioButton4.UseVisualStyleBackColor = true;
            // 
            // choiceRadioButton3
            // 
            this.choiceRadioButton3.AutoSize = true;
            this.choiceRadioButton3.Location = new System.Drawing.Point(23, 96);
            this.choiceRadioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.choiceRadioButton3.Name = "choiceRadioButton3";
            this.choiceRadioButton3.Size = new System.Drawing.Size(83, 27);
            this.choiceRadioButton3.TabIndex = 2;
            this.choiceRadioButton3.TabStop = true;
            this.choiceRadioButton3.Text = "Choice";
            this.choiceRadioButton3.UseVisualStyleBackColor = true;
            // 
            // choiceRadioButton2
            // 
            this.choiceRadioButton2.AutoSize = true;
            this.choiceRadioButton2.Location = new System.Drawing.Point(23, 64);
            this.choiceRadioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.choiceRadioButton2.Name = "choiceRadioButton2";
            this.choiceRadioButton2.Size = new System.Drawing.Size(83, 27);
            this.choiceRadioButton2.TabIndex = 1;
            this.choiceRadioButton2.TabStop = true;
            this.choiceRadioButton2.Text = "Choice";
            this.choiceRadioButton2.UseVisualStyleBackColor = true;
            // 
            // choiceRadioButton1
            // 
            this.choiceRadioButton1.AutoSize = true;
            this.choiceRadioButton1.Location = new System.Drawing.Point(23, 32);
            this.choiceRadioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.choiceRadioButton1.Name = "choiceRadioButton1";
            this.choiceRadioButton1.Size = new System.Drawing.Size(83, 27);
            this.choiceRadioButton1.TabIndex = 0;
            this.choiceRadioButton1.TabStop = true;
            this.choiceRadioButton1.Text = "Choice";
            this.choiceRadioButton1.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nextButton.Location = new System.Drawing.Point(639, 261);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(85, 32);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "بعدی";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.scoreLabel.Location = new System.Drawing.Point(35, 301);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(56, 28);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "نمره :";
            this.scoreLabel.Visible = false;
            // 
            // retryButton
            // 
            this.retryButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.retryButton.Location = new System.Drawing.Point(506, 301);
            this.retryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(218, 32);
            this.retryButton.TabIndex = 4;
            this.retryButton.Text = "دوباره امتحان کنید";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Visible = false;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 368);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.choicesGroupBox);
            this.Controls.Add(this.questionLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Application";
            this.choicesGroupBox.ResumeLayout(false);
            this.choicesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.RadioButton choiceRadioButton1;
        private System.Windows.Forms.RadioButton choiceRadioButton2;
        private System.Windows.Forms.RadioButton choiceRadioButton3;
        private System.Windows.Forms.RadioButton choiceRadioButton4;
        private System.Windows.Forms.GroupBox choicesGroupBox;
        private System.Windows.Forms.Button retryButton;
    }
}

