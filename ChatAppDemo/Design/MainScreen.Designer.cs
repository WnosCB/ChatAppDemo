
namespace Client
{
    partial class MainScreen
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
            this.lbOnlineUser = new System.Windows.Forms.ListBox();
            this.DisplayChatBox = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.bttDisconnect = new System.Windows.Forms.Button();
            this.bttSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHAT BOX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MESSAGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Online List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "-------- Your Status --------";
            // 
            // lbOnlineUser
            // 
            this.lbOnlineUser.FormattingEnabled = true;
            this.lbOnlineUser.ItemHeight = 20;
            this.lbOnlineUser.Location = new System.Drawing.Point(576, 37);
            this.lbOnlineUser.Name = "lbOnlineUser";
            this.lbOnlineUser.Size = new System.Drawing.Size(212, 124);
            this.lbOnlineUser.TabIndex = 5;
            // 
            // DisplayChatBox
            // 
            this.DisplayChatBox.Location = new System.Drawing.Point(23, 37);
            this.DisplayChatBox.Multiline = true;
            this.DisplayChatBox.Name = "DisplayChatBox";
            this.DisplayChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayChatBox.Size = new System.Drawing.Size(528, 245);
            this.DisplayChatBox.TabIndex = 6;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(23, 308);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(528, 47);
            this.txtMessage.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(633, 195);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(155, 27);
            this.txtUsername.TabIndex = 8;
            // 
            // bttDisconnect
            // 
            this.bttDisconnect.Location = new System.Drawing.Point(633, 238);
            this.bttDisconnect.Name = "bttDisconnect";
            this.bttDisconnect.Size = new System.Drawing.Size(155, 29);
            this.bttDisconnect.TabIndex = 9;
            this.bttDisconnect.Text = "Disconnect";
            this.bttDisconnect.UseVisualStyleBackColor = true;
            // 
            // bttSend
            // 
            this.bttSend.Location = new System.Drawing.Point(576, 308);
            this.bttSend.Name = "bttSend";
            this.bttSend.Size = new System.Drawing.Size(212, 47);
            this.bttSend.TabIndex = 10;
            this.bttSend.Text = "SEND";
            this.bttSend.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AcceptButton = this.bttSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 372);
            this.Controls.Add(this.bttSend);
            this.Controls.Add(this.bttDisconnect);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.DisplayChatBox);
            this.Controls.Add(this.lbOnlineUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.Text = "Chat Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbOnlineUser;
        private System.Windows.Forms.TextBox DisplayChatBox;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button bttDisconnect;
        private System.Windows.Forms.Button bttSend;
    }
}