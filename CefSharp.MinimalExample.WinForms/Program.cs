// Copyright © 2010-2014 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public class Program
    {
        public static ConfigForm config;

        [STAThread]
        public static void Main()
        {
            Cef.Initialize(new CefSettings());

            config = new ConfigForm();
            Application.Run(config);
        }

    }
}
