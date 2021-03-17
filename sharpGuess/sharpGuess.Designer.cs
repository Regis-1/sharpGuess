
namespace sharpGuess
{
    partial class sharpGuess
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
            this.lGuessed = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserGuess = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lGuessed
            // 
            this.lGuessed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lGuessed.FormattingEnabled = true;
            this.lGuessed.ItemHeight = 19;
            this.lGuessed.Location = new System.Drawing.Point(12, 12);
            this.lGuessed.Name = "lGuessed";
            this.lGuessed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lGuessed.Size = new System.Drawing.Size(110, 232);
            this.lGuessed.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 12);
            this.label1.MaximumSize = new System.Drawing.Size(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Właśnie wylosowałem pewną liczbę z zakresu\r\ndo 1 do 1000. \r\n\r\nZgadnij jaka to lic" +
    "zba...";
            // 
            // tbUserGuess
            // 
            this.tbUserGuess.Location = new System.Drawing.Point(219, 188);
            this.tbUserGuess.Name = "tbUserGuess";
            this.tbUserGuess.Size = new System.Drawing.Size(67, 23);
            this.tbUserGuess.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 266);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Twój wybór:";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(144, 221);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(142, 23);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "Zgaduj";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(190, 112);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 56);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "<";
            this.lblResult.Visible = false;
            // 
            // sharpGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 266);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tbUserGuess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lGuessed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "sharpGuess";
            this.Text = "sharpGuess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lGuessed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserGuess;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblResult;
    }
}

