namespace SMSender
{
    partial class SMSender
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
            this.senderLabel = new System.Windows.Forms.Label();
            this.senderBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.contentLabel = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.charNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // senderLabel
            // 
            this.senderLabel.AutoSize = true;
            this.senderLabel.Location = new System.Drawing.Point(12, 16);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(53, 13);
            this.senderLabel.TabIndex = 0;
            this.senderLabel.Text = "Nadawca";
            // 
            // senderBox
            // 
            this.senderBox.Location = new System.Drawing.Point(71, 13);
            this.senderBox.Name = "senderBox";
            this.senderBox.Size = new System.Drawing.Size(200, 20);
            this.senderBox.TabIndex = 5;
            this.senderBox.Text = "ECO";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(12, 42);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(38, 13);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Numer";
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(12, 77);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(34, 13);
            this.contentLabel.TabIndex = 2;
            this.contentLabel.Text = "Treść";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(71, 39);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(200, 20);
            this.numberBox.TabIndex = 3;
            this.numberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberBox_KeyPress);
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(71, 74);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(200, 150);
            this.contentBox.TabIndex = 4;
            this.contentBox.Text = "";
            this.contentBox.TextChanged += new System.EventHandler(this.contentBox_TextChanged);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(125, 257);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Wyślij";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // charNumber
            // 
            this.charNumber.AutoSize = true;
            this.charNumber.Location = new System.Drawing.Point(225, 227);
            this.charNumber.Name = "charNumber";
            this.charNumber.Size = new System.Drawing.Size(13, 13);
            this.charNumber.TabIndex = 6;
            this.charNumber.Text = "0";
            // 
            // SMSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 307);
            this.Controls.Add(this.charNumber);
            this.Controls.Add(this.senderBox);
            this.Controls.Add(this.senderLabel);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.sendButton);
            this.Name = "SMSender";
            this.Text = "SMSender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label senderLabel;
        private System.Windows.Forms.TextBox senderBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.RichTextBox contentBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label charNumber;

    }
}

