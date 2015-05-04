// Copyright © 2010-2014 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.Windows.Forms;
using CefSharp.MinimalExample.WinForms.Controls;
using CefSharp.WinForms;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class BrowserForm : Form
    {
        private readonly ChromiumWebBrowser browser;

        private bool timeoutInProgress;
        private DateTime timeoutStart;
        private int configTouchStep;

        public BrowserForm()
        {
            InitializeComponent();

            timeoutInProgress = false;
            configTouchStep = 0;

            Text = "CefSharp";
            WindowState = FormWindowState.Maximized;

            browser = new ChromiumWebBrowser(Program.config.textBoxAppUrl.Text)
            {
                Dock = DockStyle.Fill,
            };

            this.Controls.Add(browser);

            browser.NavStateChanged += OnBrowserNavStateChanged;
            browser.ConsoleMessage += OnBrowserConsoleMessage;
            browser.StatusMessage += OnBrowserStatusMessage;
            browser.TitleChanged += OnBrowserTitleChanged;
            browser.AddressChanged += OnBrowserAddressChanged;

            var bitness = Environment.Is64BitProcess ? "x64" : "x86";
            var version = String.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}, Environment: {3}", Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion, bitness);
            DisplayOutput(version);
        }

        private void OnBrowserConsoleMessage(object sender, ConsoleMessageEventArgs args)
        {
            DisplayOutput(string.Format("Line: {0}, Source: {1}, Message: {2}", args.Line, args.Source, args.Message));
        }

        private void OnBrowserStatusMessage(object sender, StatusMessageEventArgs args)
        {
            //this.InvokeOnUiThreadIfRequired(() => statusLabel.Text = args.Value);
        }

        private void OnBrowserNavStateChanged(object sender, NavStateChangedEventArgs args)
        {
            SetCanGoBack(args.CanGoBack);
            SetCanGoForward(args.CanGoForward);

            this.InvokeOnUiThreadIfRequired(() => SetIsLoading(!args.CanReload));
        }

        private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => Text = args.Title);
        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            Console.WriteLine(args.Address);

            if (args.Address == Program.config.textBoxTimeouUrl.Text)
            {
                timeoutInProgress = true;
                timeoutStart = DateTime.Now;
            }
            else if (args.Address == Program.config.textBoxAppUrl.Text)
            {
                timeoutInProgress = false;
            }

            //this.InvokeOnUiThreadIfRequired(() => urlTextBox.Text = args.Address);
        }

        private void SetCanGoBack(bool canGoBack)
        {
            //this.InvokeOnUiThreadIfRequired(() => backButton.Enabled = canGoBack);
        }

        private void SetCanGoForward(bool canGoForward)
        {
            //this.InvokeOnUiThreadIfRequired(() => forwardButton.Enabled = canGoForward);
        }

        private void SetIsLoading(bool isLoading)
        {
            /*
            goButton.Text = isLoading ?
                "Stop" :
                "Go";
            goButton.Image = isLoading ?
                Properties.Resources.nav_plain_red :
                Properties.Resources.nav_plain_green;

            HandleToolStripLayout();
            */
        }

        public void DisplayOutput(string output)
        {
            //this.InvokeOnUiThreadIfRequired(() => outputLabel.Text = output);
        }


        private void ExitMenuItemClick(object sender, EventArgs e)
        {
            browser.Dispose();
            Cef.Shutdown();
            Close();
        }

        private void GoButtonClick(object sender, EventArgs e)
        {
            //LoadUrl(urlTextBox.Text);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void ForwardButtonClick(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void UrlTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            //LoadUrl(urlTextBox.Text);
        }

        private void LoadUrl(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                browser.Load(url);
            }
        }

        public void mouseHook(int x, int y)
        {
            if ((x < 60) && (y < 60))
            {
                if (configTouchStep != 3)
                {
                    configTouchStep++;
                }
                else
                {
                    configTouchStep = 0;
                }
            }
            else
            {
                if (configTouchStep == 3)
                {
                    configTouchStep++;
                }
                else
                {
                    configTouchStep = 0;
                }
            }

            if (configTouchStep == 5) {
                // Goto Config
                this.Close();
            }
        }

        private void timerTimeou_Tick(object sender, EventArgs e)
        {
            if (!timeoutInProgress) return;

            if (Program.config.textBoxTimeoutSecs.Text.Length == 0) return;

            TimeSpan t = DateTime.Now - timeoutStart;

            if (t.TotalSeconds > Convert.ToInt32(Program.config.textBoxTimeoutSecs.Text)) {
                // Timeout
                timeoutInProgress = false;
                browser.Load(Program.config.textBoxAppUrl.Text);
            }
        }

    }
}
