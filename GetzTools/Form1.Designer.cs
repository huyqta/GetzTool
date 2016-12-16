namespace GetzTools
{
    partial class frmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSMS = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSmsResult = new System.Windows.Forms.RichTextBox();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSmsMessage = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSmsRecipients = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdSmsLive = new System.Windows.Forms.RadioButton();
            this.rdSmsUAT = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPushBadge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdPushEnterprise = new System.Windows.Forms.RadioButton();
            this.btnPushNotification = new System.Windows.Forms.Button();
            this.txtPushMessages = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtListDevicePush = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdPushPublic = new System.Windows.Forms.RadioButton();
            this.rdPushInternal = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.tabSMS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSetting.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSMS);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(20, 60);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(742, 533);
            this.tabMain.TabIndex = 0;
            // 
            // tabSMS
            // 
            this.tabSMS.Controls.Add(this.groupBox1);
            this.tabSMS.Controls.Add(this.gbSetting);
            this.tabSMS.Location = new System.Drawing.Point(4, 22);
            this.tabSMS.Name = "tabSMS";
            this.tabSMS.Padding = new System.Windows.Forms.Padding(3);
            this.tabSMS.Size = new System.Drawing.Size(734, 507);
            this.tabSMS.TabIndex = 0;
            this.tabSMS.Text = "Sending SMS";
            this.tabSMS.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSmsResult);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 331);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // txtSmsResult
            // 
            this.txtSmsResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSmsResult.Location = new System.Drawing.Point(3, 16);
            this.txtSmsResult.Name = "txtSmsResult";
            this.txtSmsResult.Size = new System.Drawing.Size(722, 312);
            this.txtSmsResult.TabIndex = 6;
            this.txtSmsResult.Text = "";
            // 
            // gbSetting
            // 
            this.gbSetting.Controls.Add(this.btnSend);
            this.gbSetting.Controls.Add(this.txtSmsMessage);
            this.gbSetting.Controls.Add(this.label3);
            this.gbSetting.Controls.Add(this.txtSmsRecipients);
            this.gbSetting.Controls.Add(this.label2);
            this.gbSetting.Controls.Add(this.label1);
            this.gbSetting.Controls.Add(this.rdSmsLive);
            this.gbSetting.Controls.Add(this.rdSmsUAT);
            this.gbSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSetting.Location = new System.Drawing.Point(3, 3);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(728, 170);
            this.gbSetting.TabIndex = 1;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "Setting:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(90, 140);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSmsMessage
            // 
            this.txtSmsMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSmsMessage.Location = new System.Drawing.Point(90, 68);
            this.txtSmsMessage.Name = "txtSmsMessage";
            this.txtSmsMessage.Size = new System.Drawing.Size(629, 66);
            this.txtSmsMessage.TabIndex = 5;
            this.txtSmsMessage.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message:";
            // 
            // txtSmsRecipients
            // 
            this.txtSmsRecipients.Location = new System.Drawing.Point(90, 42);
            this.txtSmsRecipients.Name = "txtSmsRecipients";
            this.txtSmsRecipients.Size = new System.Drawing.Size(193, 20);
            this.txtSmsRecipients.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recipients:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose server:";
            // 
            // rdSmsLive
            // 
            this.rdSmsLive.AutoSize = true;
            this.rdSmsLive.Location = new System.Drawing.Point(143, 19);
            this.rdSmsLive.Name = "rdSmsLive";
            this.rdSmsLive.Size = new System.Drawing.Size(48, 17);
            this.rdSmsLive.TabIndex = 0;
            this.rdSmsLive.Text = "LIVE";
            this.rdSmsLive.UseVisualStyleBackColor = true;
            this.rdSmsLive.CheckedChanged += new System.EventHandler(this.rdSms_CheckedChanged);
            // 
            // rdSmsUAT
            // 
            this.rdSmsUAT.AutoSize = true;
            this.rdSmsUAT.Checked = true;
            this.rdSmsUAT.Location = new System.Drawing.Point(90, 19);
            this.rdSmsUAT.Name = "rdSmsUAT";
            this.rdSmsUAT.Size = new System.Drawing.Size(47, 17);
            this.rdSmsUAT.TabIndex = 0;
            this.rdSmsUAT.TabStop = true;
            this.rdSmsUAT.Text = "UAT";
            this.rdSmsUAT.UseVisualStyleBackColor = true;
            this.rdSmsUAT.CheckedChanged += new System.EventHandler(this.rdSms_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Push Notification";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPushBadge);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rdPushEnterprise);
            this.groupBox2.Controls.Add(this.btnPushNotification);
            this.groupBox2.Controls.Add(this.txtPushMessages);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtListDevicePush);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rdPushPublic);
            this.groupBox2.Controls.Add(this.rdPushInternal);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 268);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting:";
            // 
            // txtPushBadge
            // 
            this.txtPushBadge.Location = new System.Drawing.Point(90, 163);
            this.txtPushBadge.Name = "txtPushBadge";
            this.txtPushBadge.Size = new System.Drawing.Size(131, 20);
            this.txtPushBadge.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Badge:";
            // 
            // rdPushEnterprise
            // 
            this.rdPushEnterprise.AutoSize = true;
            this.rdPushEnterprise.Location = new System.Drawing.Point(244, 19);
            this.rdPushEnterprise.Name = "rdPushEnterprise";
            this.rdPushEnterprise.Size = new System.Drawing.Size(94, 17);
            this.rdPushEnterprise.TabIndex = 7;
            this.rdPushEnterprise.Text = "ENTERPRISE";
            this.rdPushEnterprise.UseVisualStyleBackColor = true;
            this.rdPushEnterprise.CheckedChanged += new System.EventHandler(this.rdPushNotification_CheckedChanged);
            // 
            // btnPushNotification
            // 
            this.btnPushNotification.Location = new System.Drawing.Point(90, 239);
            this.btnPushNotification.Name = "btnPushNotification";
            this.btnPushNotification.Size = new System.Drawing.Size(75, 23);
            this.btnPushNotification.TabIndex = 6;
            this.btnPushNotification.Text = "PUSH";
            this.btnPushNotification.UseVisualStyleBackColor = true;
            this.btnPushNotification.Click += new System.EventHandler(this.btnPushNotification_Click);
            // 
            // txtPushMessages
            // 
            this.txtPushMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPushMessages.Location = new System.Drawing.Point(90, 188);
            this.txtPushMessages.Name = "txtPushMessages";
            this.txtPushMessages.Size = new System.Drawing.Size(629, 45);
            this.txtPushMessages.TabIndex = 5;
            this.txtPushMessages.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Message:";
            // 
            // txtListDevicePush
            // 
            this.txtListDevicePush.Location = new System.Drawing.Point(90, 42);
            this.txtListDevicePush.Multiline = true;
            this.txtListDevicePush.Name = "txtListDevicePush";
            this.txtListDevicePush.Size = new System.Drawing.Size(629, 115);
            this.txtListDevicePush.TabIndex = 3;
            this.txtListDevicePush.Text = "d4ad5b4b4058db21923816499bfbd90ff09898e2d396e06dd82ca8befaa02b06";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "List devices:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Choose server:";
            // 
            // rdPushPublic
            // 
            this.rdPushPublic.AutoSize = true;
            this.rdPushPublic.Location = new System.Drawing.Point(175, 19);
            this.rdPushPublic.Name = "rdPushPublic";
            this.rdPushPublic.Size = new System.Drawing.Size(63, 17);
            this.rdPushPublic.TabIndex = 0;
            this.rdPushPublic.Text = "PUBLIC";
            this.rdPushPublic.UseVisualStyleBackColor = true;
            this.rdPushPublic.CheckedChanged += new System.EventHandler(this.rdPushNotification_CheckedChanged);
            // 
            // rdPushInternal
            // 
            this.rdPushInternal.AutoSize = true;
            this.rdPushInternal.Checked = true;
            this.rdPushInternal.Location = new System.Drawing.Point(90, 19);
            this.rdPushInternal.Name = "rdPushInternal";
            this.rdPushInternal.Size = new System.Drawing.Size(79, 17);
            this.rdPushInternal.TabIndex = 0;
            this.rdPushInternal.TabStop = true;
            this.rdPushInternal.Text = "INTERNAL";
            this.rdPushInternal.UseVisualStyleBackColor = true;
            this.rdPushInternal.CheckedChanged += new System.EventHandler(this.rdPushNotification_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(742, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 507);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Sending Email";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 635);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Getz Tools";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabSMS.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbSetting.ResumeLayout(false);
            this.gbSetting.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSMS;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.RadioButton rdSmsLive;
        private System.Windows.Forms.RadioButton rdSmsUAT;
        private System.Windows.Forms.TextBox txtSmsRecipients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox txtSmsMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtSmsResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPushNotification;
        private System.Windows.Forms.RichTextBox txtPushMessages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtListDevicePush;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdPushPublic;
        private System.Windows.Forms.RadioButton rdPushInternal;
        private System.Windows.Forms.RadioButton rdPushEnterprise;
        private System.Windows.Forms.TextBox txtPushBadge;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

