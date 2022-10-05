namespace Network_Tool
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
            this.textServerPort = new System.Windows.Forms.TextBox();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelServerStatus = new System.Windows.Forms.Label();
            this.btnServerSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textServerSend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textServerReceived = new System.Windows.Forms.TextBox();
            this.btnServerStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelClientStatus = new System.Windows.Forms.Label();
            this.textClientIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClientDisconnect = new System.Windows.Forms.Button();
            this.btnClientSend = new System.Windows.Forms.Button();
            this.textClientPort = new System.Windows.Forms.TextBox();
            this.btnClientConnect = new System.Windows.Forms.Button();
            this.textClientReceived = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textClientSend = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textServerPort
            // 
            this.textServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textServerPort.Location = new System.Drawing.Point(128, 18);
            this.textServerPort.Name = "textServerPort";
            this.textServerPort.Size = new System.Drawing.Size(70, 26);
            this.textServerPort.TabIndex = 0;
            // 
            // btnServerStart
            // 
            this.btnServerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerStart.Location = new System.Drawing.Point(47, 58);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(75, 26);
            this.btnServerStart.TabIndex = 1;
            this.btnServerStart.Text = "Start";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelServerStatus);
            this.groupBox1.Controls.Add(this.btnServerSend);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textServerSend);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textServerReceived);
            this.groupBox1.Controls.Add(this.btnServerStop);
            this.groupBox1.Controls.Add(this.textServerPort);
            this.groupBox1.Controls.Add(this.btnServerStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(283, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 375);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Controls";
            // 
            // labelServerStatus
            // 
            this.labelServerStatus.AutoSize = true;
            this.labelServerStatus.Location = new System.Drawing.Point(100, 359);
            this.labelServerStatus.Name = "labelServerStatus";
            this.labelServerStatus.Size = new System.Drawing.Size(37, 13);
            this.labelServerStatus.TabIndex = 17;
            this.labelServerStatus.Text = "Status";
            // 
            // btnServerSend
            // 
            this.btnServerSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerSend.Location = new System.Drawing.Point(89, 313);
            this.btnServerSend.Name = "btnServerSend";
            this.btnServerSend.Size = new System.Drawing.Size(75, 34);
            this.btnServerSend.TabIndex = 8;
            this.btnServerSend.Text = "Send";
            this.btnServerSend.UseVisualStyleBackColor = true;
            this.btnServerSend.Click += new System.EventHandler(this.btnServerSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Command";
            // 
            // textServerSend
            // 
            this.textServerSend.Location = new System.Drawing.Point(27, 287);
            this.textServerSend.Name = "textServerSend";
            this.textServerSend.Size = new System.Drawing.Size(206, 20);
            this.textServerSend.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Received";
            // 
            // textServerReceived
            // 
            this.textServerReceived.AcceptsReturn = true;
            this.textServerReceived.AcceptsTab = true;
            this.textServerReceived.Location = new System.Drawing.Point(27, 114);
            this.textServerReceived.Multiline = true;
            this.textServerReceived.Name = "textServerReceived";
            this.textServerReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textServerReceived.Size = new System.Drawing.Size(206, 147);
            this.textServerReceived.TabIndex = 4;
            // 
            // btnServerStop
            // 
            this.btnServerStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerStop.Location = new System.Drawing.Point(128, 58);
            this.btnServerStop.Name = "btnServerStop";
            this.btnServerStop.Size = new System.Drawing.Size(75, 26);
            this.btnServerStop.TabIndex = 3;
            this.btnServerStop.Text = "Stop";
            this.btnServerStop.UseVisualStyleBackColor = true;
            this.btnServerStop.Click += new System.EventHandler(this.btnServerStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelClientStatus);
            this.groupBox2.Controls.Add(this.textClientIP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnClientDisconnect);
            this.groupBox2.Controls.Add(this.btnClientSend);
            this.groupBox2.Controls.Add(this.textClientPort);
            this.groupBox2.Controls.Add(this.btnClientConnect);
            this.groupBox2.Controls.Add(this.textClientReceived);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textClientSend);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 375);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Controls";
            // 
            // labelClientStatus
            // 
            this.labelClientStatus.AutoSize = true;
            this.labelClientStatus.Location = new System.Drawing.Point(102, 359);
            this.labelClientStatus.Name = "labelClientStatus";
            this.labelClientStatus.Size = new System.Drawing.Size(37, 13);
            this.labelClientStatus.TabIndex = 16;
            this.labelClientStatus.Text = "Status";
            // 
            // textClientIP
            // 
            this.textClientIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClientIP.Location = new System.Drawing.Point(73, 18);
            this.textClientIP.Name = "textClientIP";
            this.textClientIP.Size = new System.Drawing.Size(162, 26);
            this.textClientIP.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "IP Address:";
            // 
            // btnClientDisconnect
            // 
            this.btnClientDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientDisconnect.Location = new System.Drawing.Point(132, 90);
            this.btnClientDisconnect.Name = "btnClientDisconnect";
            this.btnClientDisconnect.Size = new System.Drawing.Size(111, 26);
            this.btnClientDisconnect.TabIndex = 12;
            this.btnClientDisconnect.Text = "Disconnect";
            this.btnClientDisconnect.UseVisualStyleBackColor = true;
            this.btnClientDisconnect.Click += new System.EventHandler(this.btnClientDisconnect_Click);
            // 
            // btnClientSend
            // 
            this.btnClientSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSend.Location = new System.Drawing.Point(91, 313);
            this.btnClientSend.Name = "btnClientSend";
            this.btnClientSend.Size = new System.Drawing.Size(75, 34);
            this.btnClientSend.TabIndex = 13;
            this.btnClientSend.Text = "Send";
            this.btnClientSend.UseVisualStyleBackColor = true;
            this.btnClientSend.Click += new System.EventHandler(this.btnClientSend_Click);
            // 
            // textClientPort
            // 
            this.textClientPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClientPort.Location = new System.Drawing.Point(132, 50);
            this.textClientPort.Name = "textClientPort";
            this.textClientPort.Size = new System.Drawing.Size(70, 26);
            this.textClientPort.TabIndex = 9;
            // 
            // btnClientConnect
            // 
            this.btnClientConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientConnect.Location = new System.Drawing.Point(22, 90);
            this.btnClientConnect.Name = "btnClientConnect";
            this.btnClientConnect.Size = new System.Drawing.Size(104, 26);
            this.btnClientConnect.TabIndex = 10;
            this.btnClientConnect.Text = "Connect";
            this.btnClientConnect.UseVisualStyleBackColor = true;
            this.btnClientConnect.Click += new System.EventHandler(this.btnClientConnect_Click);
            // 
            // textClientReceived
            // 
            this.textClientReceived.AllowDrop = true;
            this.textClientReceived.Location = new System.Drawing.Point(29, 149);
            this.textClientReceived.Multiline = true;
            this.textClientReceived.Name = "textClientReceived";
            this.textClientReceived.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textClientReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textClientReceived.Size = new System.Drawing.Size(206, 112);
            this.textClientReceived.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Port Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Command";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Received";
            // 
            // textClientSend
            // 
            this.textClientSend.Location = new System.Drawing.Point(29, 287);
            this.textClientSend.Name = "textClientSend";
            this.textClientSend.Size = new System.Drawing.Size(206, 20);
            this.textClientSend.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textServerPort;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnServerSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textServerSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textServerReceived;
        private System.Windows.Forms.Button btnServerStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textClientIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClientDisconnect;
        private System.Windows.Forms.Button btnClientSend;
        private System.Windows.Forms.TextBox textClientPort;
        private System.Windows.Forms.Button btnClientConnect;
        private System.Windows.Forms.TextBox textClientReceived;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textClientSend;
        private System.Windows.Forms.Label labelServerStatus;
        private System.Windows.Forms.Label labelClientStatus;
    }
}

