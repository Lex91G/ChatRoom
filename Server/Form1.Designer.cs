namespace Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.CheckOnline = new System.Windows.Forms.CheckBox();
            this.PeopleOnline = new System.Windows.Forms.TextBox();
            this.ConvoBox = new System.Windows.Forms.RichTextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.PeopleOnChat = new System.Windows.Forms.ListView();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 62);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fancy Chat";
            // 
            // CheckOnline
            // 
            this.CheckOnline.AutoSize = true;
            this.CheckOnline.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOnline.Location = new System.Drawing.Point(27, 22);
            this.CheckOnline.Name = "CheckOnline";
            this.CheckOnline.Size = new System.Drawing.Size(98, 32);
            this.CheckOnline.TabIndex = 9;
            this.CheckOnline.Text = "Online";
            this.CheckOnline.UseVisualStyleBackColor = true;
            // 
            // PeopleOnline
            // 
            this.PeopleOnline.BackColor = System.Drawing.SystemColors.ControlText;
            this.PeopleOnline.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleOnline.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PeopleOnline.Location = new System.Drawing.Point(1045, 0);
            this.PeopleOnline.Name = "PeopleOnline";
            this.PeopleOnline.Size = new System.Drawing.Size(219, 48);
            this.PeopleOnline.TabIndex = 10;
            this.PeopleOnline.Text = "People Online";
            this.PeopleOnline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConvoBox
            // 
            this.ConvoBox.Location = new System.Drawing.Point(27, 96);
            this.ConvoBox.Name = "ConvoBox";
            this.ConvoBox.Size = new System.Drawing.Size(977, 326);
            this.ConvoBox.TabIndex = 11;
            this.ConvoBox.Text = "";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(933, 36);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(57, 48);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // PeopleOnChat
            // 
            this.PeopleOnChat.Location = new System.Drawing.Point(1020, 54);
            this.PeopleOnChat.Name = "PeopleOnChat";
            this.PeopleOnChat.Size = new System.Drawing.Size(244, 374);
            this.PeopleOnChat.TabIndex = 13;
            this.PeopleOnChat.UseCompatibleStateImageBehavior = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 432);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(977, 56);
            this.textBox.TabIndex = 14;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(1020, 432);
            this.Send.Margin = new System.Windows.Forms.Padding(4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(231, 57);
            this.Send.TabIndex = 15;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 502);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.PeopleOnChat);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ConvoBox);
            this.Controls.Add(this.PeopleOnline);
            this.Controls.Add(this.CheckOnline);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckOnline;
        private System.Windows.Forms.TextBox PeopleOnline;
        private System.Windows.Forms.RichTextBox ConvoBox;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListView PeopleOnChat;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Send;
    }
}