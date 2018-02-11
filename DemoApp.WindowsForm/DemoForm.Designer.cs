namespace DemoApp.WindowsForm
{
    partial class DemoForm
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
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxBody = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(47, 12);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(100, 22);
            this.TextBoxUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "帳號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密碼";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(186, 12);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.TextBoxPassword.TabIndex = 2;
            // 
            // TextBoxBody
            // 
            this.TextBoxBody.Location = new System.Drawing.Point(14, 68);
            this.TextBoxBody.Multiline = true;
            this.TextBoxBody.Name = "TextBoxBody";
            this.TextBoxBody.Size = new System.Drawing.Size(353, 181);
            this.TextBoxBody.TabIndex = 4;
            this.TextBoxBody.Text = "我是誰";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(292, 10);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "發送";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "發送給";
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(59, 40);
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.TextBoxPhoneNumber.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.TextBoxBody);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxBody;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
    }
}

