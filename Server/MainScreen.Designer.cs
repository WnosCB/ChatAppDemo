
namespace ChatAppDemo
{
    partial class txtClientChatBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.txtClientList = new System.Windows.Forms.TextBox();
            this.bttConnected = new System.Windows.Forms.TextBox();
            this.txtClientCB = new System.Windows.Forms.TextBox();
            this.bttListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SERVER INFOMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "MANAGED CLIENT LIST";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "CONNECTING CLIENTS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "CHAT CONFERENCE";
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(232, 6);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(167, 27);
            this.txtIPServer.TabIndex = 7;
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(469, 6);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(137, 27);
            this.txtPortServer.TabIndex = 8;
            // 
            // txtClientList
            // 
            this.txtClientList.BackColor = System.Drawing.SystemColors.Control;
            this.txtClientList.Location = new System.Drawing.Point(11, 77);
            this.txtClientList.Multiline = true;
            this.txtClientList.Name = "txtClientList";
            this.txtClientList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtClientList.Size = new System.Drawing.Size(215, 135);
            this.txtClientList.TabIndex = 9;
            // 
            // bttConnected
            // 
            this.bttConnected.BackColor = System.Drawing.SystemColors.Control;
            this.bttConnected.Location = new System.Drawing.Point(12, 238);
            this.bttConnected.Multiline = true;
            this.bttConnected.Name = "bttConnected";
            this.bttConnected.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bttConnected.Size = new System.Drawing.Size(214, 122);
            this.bttConnected.TabIndex = 10;
            // 
            // txtClientCB
            // 
            this.txtClientCB.BackColor = System.Drawing.SystemColors.Control;
            this.txtClientCB.Location = new System.Drawing.Point(275, 77);
            this.txtClientCB.Multiline = true;
            this.txtClientCB.Name = "txtClientCB";
            this.txtClientCB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtClientCB.Size = new System.Drawing.Size(513, 283);
            this.txtClientCB.TabIndex = 11;
            // 
            // bttListen
            // 
            this.bttListen.Location = new System.Drawing.Point(660, 6);
            this.bttListen.Name = "bttListen";
            this.bttListen.Size = new System.Drawing.Size(128, 29);
            this.bttListen.TabIndex = 12;
            this.bttListen.Text = "Listen";
            this.bttListen.UseVisualStyleBackColor = true;
            // 
            // txtClientChatBox
            // 
            this.AcceptButton = this.bttListen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.bttListen);
            this.Controls.Add(this.txtClientCB);
            this.Controls.Add(this.bttConnected);
            this.Controls.Add(this.txtClientList);
            this.Controls.Add(this.txtPortServer);
            this.Controls.Add(this.txtIPServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "txtClientChatBox";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.TextBox txtClientList;
        private System.Windows.Forms.TextBox bttConnected;
        private System.Windows.Forms.TextBox txtClientCB;
        private System.Windows.Forms.Button bttListen;
    }
}

