namespace HttpRequestBuilder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.reqMethod = new System.Windows.Forms.ComboBox();
            this.txUri = new System.Windows.Forms.TextBox();
            this.txHeaders = new System.Windows.Forms.TextBox();
            this.txData = new System.Windows.Forms.TextBox();
            this.txRes = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.chRedir = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.proxyType = new System.Windows.Forms.ComboBox();
            this.txProxyAddr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reqMethod
            // 
            this.reqMethod.FormattingEnabled = true;
            this.reqMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "HEAD"});
            this.reqMethod.Location = new System.Drawing.Point(12, 12);
            this.reqMethod.Name = "reqMethod";
            this.reqMethod.Size = new System.Drawing.Size(76, 21);
            this.reqMethod.TabIndex = 0;
            this.reqMethod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txUri
            // 
            this.txUri.Location = new System.Drawing.Point(94, 12);
            this.txUri.Name = "txUri";
            this.txUri.Size = new System.Drawing.Size(549, 20);
            this.txUri.TabIndex = 1;
            // 
            // txHeaders
            // 
            this.txHeaders.Location = new System.Drawing.Point(12, 39);
            this.txHeaders.Multiline = true;
            this.txHeaders.Name = "txHeaders";
            this.txHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txHeaders.Size = new System.Drawing.Size(631, 211);
            this.txHeaders.TabIndex = 2;
            this.txHeaders.Text = "Host: yandex.ru\r\nConnection: Keep-Alive";
            // 
            // txData
            // 
            this.txData.Location = new System.Drawing.Point(12, 256);
            this.txData.Multiline = true;
            this.txData.Name = "txData";
            this.txData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txData.Size = new System.Drawing.Size(631, 137);
            this.txData.TabIndex = 3;
            this.txData.Text = "id=18&sekay=yakes";
            // 
            // txRes
            // 
            this.txRes.Location = new System.Drawing.Point(650, 12);
            this.txRes.Multiline = true;
            this.txRes.Name = "txRes";
            this.txRes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txRes.Size = new System.Drawing.Size(763, 352);
            this.txRes.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1193, 368);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(107, 25);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export response";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnNotepad
            // 
            this.btnNotepad.Location = new System.Drawing.Point(1306, 368);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(107, 25);
            this.btnNotepad.TabIndex = 6;
            this.btnNotepad.Text = "Notepad view";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(649, 368);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(107, 25);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // chRedir
            // 
            this.chRedir.AutoSize = true;
            this.chRedir.Checked = true;
            this.chRedir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chRedir.Location = new System.Drawing.Point(875, 373);
            this.chRedir.Name = "chRedir";
            this.chRedir.Size = new System.Drawing.Size(89, 17);
            this.chRedir.TabIndex = 8;
            this.chRedir.Text = "Allow redirect";
            this.chRedir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Urlencode req data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(967, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Proxy";
            // 
            // proxyType
            // 
            this.proxyType.FormattingEnabled = true;
            this.proxyType.Items.AddRange(new object[] {
            "HTTP",
            "Socks4",
            "Socks5"});
            this.proxyType.Location = new System.Drawing.Point(1006, 370);
            this.proxyType.Name = "proxyType";
            this.proxyType.Size = new System.Drawing.Size(76, 21);
            this.proxyType.TabIndex = 11;
            // 
            // txProxyAddr
            // 
            this.txProxyAddr.Location = new System.Drawing.Point(1088, 370);
            this.txProxyAddr.Name = "txProxyAddr";
            this.txProxyAddr.Size = new System.Drawing.Size(99, 20);
            this.txProxyAddr.TabIndex = 12;
            this.txProxyAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 405);
            this.Controls.Add(this.txProxyAddr);
            this.Controls.Add(this.proxyType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chRedir);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnNotepad);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txRes);
            this.Controls.Add(this.txData);
            this.Controls.Add(this.txHeaders);
            this.Controls.Add(this.txUri);
            this.Controls.Add(this.reqMethod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "HttpRequest Builder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reqMethod;
        private System.Windows.Forms.TextBox txUri;
        private System.Windows.Forms.TextBox txHeaders;
        private System.Windows.Forms.TextBox txData;
        private System.Windows.Forms.TextBox txRes;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox chRedir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox proxyType;
        private System.Windows.Forms.TextBox txProxyAddr;
    }
}

