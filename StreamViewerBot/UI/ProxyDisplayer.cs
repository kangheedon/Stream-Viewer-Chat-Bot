﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace StreamViewerBot.UI
{
    public partial class ProxyDisplayer : Form
    {
        public ProxyDisplayer(List<string> proxyList)
        {
            InitializeComponent();

            txtProxyList.Text = string.Empty;

            foreach (var proxy in proxyList) txtProxyList.AppendText(proxy + Environment.NewLine);
        }

        private void lblBuyProxy_Click(object sender, EventArgs e)
        {
            try
            {
                var strCmdLine = "/C explorer \"https://www.webshare.io/?referral_code=ceuygyx4sir2";
                var browserProcess = Process.Start("CMD.exe", strCmdLine);
                browserProcess?.Close();
            }
            catch (Exception)
            {
                //ignored
            }
        }

        private void lblBuyProxy_MouseEnter(object sender, EventArgs e)
        {
            lblBuyProxy.ForeColor = Color.ForestGreen;
        }

        private void lblBuyProxy_MouseLeave(object sender, EventArgs e)
        {
            lblBuyProxy.ForeColor = Color.LimeGreen;
        }
    }
}