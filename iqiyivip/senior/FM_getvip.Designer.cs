﻿namespace VideoVIP
{
    partial class FM_getvip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM_getvip));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_get = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_getmore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(210, 135);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Visible = false;
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(12, 106);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(75, 23);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "爱奇艺VIP";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "本工具用于在线获取各种VIP\r\n\r\n会员是第三方所提供\r\n\r\n若提示输入密码，密码是\r\na86869390A";
            // 
            // btn_getmore
            // 
            this.btn_getmore.Location = new System.Drawing.Point(105, 106);
            this.btn_getmore.Name = "btn_getmore";
            this.btn_getmore.Size = new System.Drawing.Size(75, 23);
            this.btn_getmore.TabIndex = 3;
            this.btn_getmore.Text = "更多VIP";
            this.btn_getmore.UseVisualStyleBackColor = true;
            this.btn_getmore.Click += new System.EventHandler(this.btn_getmore_Click);
            // 
            // FM_getvip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 135);
            this.Controls.Add(this.btn_getmore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FM_getvip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "获取VIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_getmore;
    }
}