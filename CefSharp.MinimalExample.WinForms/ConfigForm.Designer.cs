namespace CefSharp.MinimalExample.WinForms
{
    partial class ConfigForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.textBoxTimeoutSecs = new System.Windows.Forms.TextBox();
            this.textBoxTimeouUrl = new System.Windows.Forms.TextBox();
            this.textBoxAppUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "App URL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Timeout URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Timeout Secs";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 149);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(537, 149);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 8;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // textBoxTimeoutSecs
            // 
            this.textBoxTimeoutSecs.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CefSharp.MinimalExample.WinForms.Properties.Settings.Default, "TimeoutSecs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxTimeoutSecs.Location = new System.Drawing.Point(97, 98);
            this.textBoxTimeoutSecs.Name = "textBoxTimeoutSecs";
            this.textBoxTimeoutSecs.Size = new System.Drawing.Size(515, 20);
            this.textBoxTimeoutSecs.TabIndex = 6;
            this.textBoxTimeoutSecs.Text = global::CefSharp.MinimalExample.WinForms.Properties.Settings.Default.TimeoutSecs;
            // 
            // textBoxTimeouUrl
            // 
            this.textBoxTimeouUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CefSharp.MinimalExample.WinForms.Properties.Settings.Default, "TimeoutURL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxTimeouUrl.Location = new System.Drawing.Point(97, 58);
            this.textBoxTimeouUrl.Name = "textBoxTimeouUrl";
            this.textBoxTimeouUrl.Size = new System.Drawing.Size(515, 20);
            this.textBoxTimeouUrl.TabIndex = 5;
            this.textBoxTimeouUrl.Text = global::CefSharp.MinimalExample.WinForms.Properties.Settings.Default.TimeoutURL;
            // 
            // textBoxAppUrl
            // 
            this.textBoxAppUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CefSharp.MinimalExample.WinForms.Properties.Settings.Default, "AppUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxAppUrl.Location = new System.Drawing.Point(97, 23);
            this.textBoxAppUrl.Name = "textBoxAppUrl";
            this.textBoxAppUrl.Size = new System.Drawing.Size(515, 20);
            this.textBoxAppUrl.TabIndex = 4;
            this.textBoxAppUrl.Text = global::CefSharp.MinimalExample.WinForms.Properties.Settings.Default.AppUrl;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 196);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxTimeoutSecs);
            this.Controls.Add(this.textBoxTimeouUrl);
            this.Controls.Add(this.textBoxAppUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ConfigForm";
            this.Text = "Kiosk Browser Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxAppUrl;
        public System.Windows.Forms.TextBox textBoxTimeouUrl;
        public System.Windows.Forms.TextBox textBoxTimeoutSecs;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonQuit;
    }
}