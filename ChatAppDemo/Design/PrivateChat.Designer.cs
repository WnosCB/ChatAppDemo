
namespace Client
{
    partial class PrivateChat
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DisplayChatBox = new System.Windows.Forms.TextBox();
            this.textStat = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.bttSend = new System.Windows.Forms.Button();
            this.bttFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHAT BOX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MESSAGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "File name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Path: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "FIle Status: ";
            // 
            // DisplayChatBox
            // 
            this.DisplayChatBox.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayChatBox.Location = new System.Drawing.Point(13, 37);
            this.DisplayChatBox.Multiline = true;
            this.DisplayChatBox.Name = "DisplayChatBox";
            this.DisplayChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayChatBox.Size = new System.Drawing.Size(775, 168);
            this.DisplayChatBox.TabIndex = 5;
            // 
            // textStat
            // 
            this.textStat.BackColor = System.Drawing.SystemColors.Control;
            this.textStat.Location = new System.Drawing.Point(562, 212);
            this.textStat.Name = "textStat";
            this.textStat.Size = new System.Drawing.Size(226, 27);
            this.textStat.TabIndex = 6;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 254);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(411, 60);
            this.txtMessage.TabIndex = 7;
            // 
            // txtfName
            // 
            this.txtfName.BackColor = System.Drawing.SystemColors.Control;
            this.txtfName.Location = new System.Drawing.Point(99, 323);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(257, 27);
            this.txtfName.TabIndex = 8;
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.Control;
            this.txtPath.Location = new System.Drawing.Point(429, 323);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(359, 27);
            this.txtPath.TabIndex = 9;
            // 
            // bttSend
            // 
            this.bttSend.Location = new System.Drawing.Point(430, 254);
            this.bttSend.Name = "bttSend";
            this.bttSend.Size = new System.Drawing.Size(146, 60);
            this.bttSend.TabIndex = 10;
            this.bttSend.Text = "SEND";
            this.bttSend.UseVisualStyleBackColor = true;
            // 
            // bttFile
            // 
            this.bttFile.Location = new System.Drawing.Point(582, 254);
            this.bttFile.Name = "bttFile";
            this.bttFile.Size = new System.Drawing.Size(206, 60);
            this.bttFile.TabIndex = 11;
            this.bttFile.Text = "Choose File";
            this.bttFile.UseVisualStyleBackColor = true;
            // 
            // PrivateChat
            // 
            this.AcceptButton = this.bttSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttFile);
            this.Controls.Add(this.bttSend);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtfName);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.textStat);
            this.Controls.Add(this.DisplayChatBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrivateChat";
            this.Text = "Private Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DisplayChatBox;
        private System.Windows.Forms.TextBox textStat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button bttSend;
        private System.Windows.Forms.Button bttFile;
    }
}