using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LzuProxyChanger
{
    public partial class Form1 : Form
    {
        private Thread thrTest;
        private bool enable;
        private string proxyAddress;
        private  readonly string[] proxys = { "proxy.lzu.edu.cn:8080", "proxy1.lzu.edu.cn:8080", "proxy2.lzu.edu.cn:8080", "127.0.0.1:8087", "" };
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            GetProxy();
            if (!enable)
            {
                rb_none.Checked = true;
            }
            else
            {
                if (proxyAddress == proxys[0])
                    rb_proxy1.Checked = true;
                if (proxyAddress == proxys[1])
                    rb_proxy2.Checked = true;
                if (proxyAddress == proxys[0])
                    rb_proxy3.Checked = true;
            }
            //设置代理可用 
            //rk.SetValue("ProxyEnable", 1);
            //设置代理IP和端口 
            //rk.SetValue("ProxyServer", proxys[0]);
            
            //rk.Close();
            //Proxies.SetProxy("proxy2.lzu.edu.cn:8080");

            //var p = new System.Net.NetworkInformation.Ping();
            //p.PingCompleted += p_PingCompleted;
            //System.Net.NetworkInformation.PingReply reply = p.Send("v.youku.com");

            //for (int i = 0; i < 5; i++)
            //{
            //    long total = 0;
            //    float total2 = 0; ;

            //    for (int j = 0; j < 10; j++)
            //    {
                    
            //        ////设置代理可用 
            //        //rk.SetValue("ProxyEnable", 1);
            //        ////设置代理IP和端口 
            //        //rk.SetValue("ProxyServer", proxys[i]);
                    
            //        //rk.Close();
            //        //total2+=Pings.Test("v.youku.com");
            //        var p = new System.Net.NetworkInformation.Ping();
            //        System.Net.NetworkInformation.PingReply reply = p.Send("v.youku.com");
            //        total += reply.RoundtripTime;
            //    }

            //    tb_ip.Text += proxys[i] + "  " + total / 10 + "   " + total2 / 3 + "\r\n";
            //}

        }
        private void SetProxy(string proxy)
        {
            Proxies.SetProxy(proxy);
            GetProxy();
            if (!rb_none.Checked)
            {
                if(thrTest!=null)
                    thrTest.Abort();
                thrTest = new Thread(CheckProxy);
                thrTest.IsBackground = true;
                thrTest.Start();
            }      
        }
        private void CheckProxy()
        {
            tool_s.ForeColor = Color.Blue;
            tool_s.Text = "正在测试...";
            BaseHttpRequest request = new BaseHttpRequest();
            try
            {
                request.CreateGetHttpResponse(new Uri("http://www.baidu.com/"), null, null, new WebProxy(proxyAddress), null, "GET");
            }
            catch (Exception)
            {
                tool_s.ForeColor = Color.Red;
                tool_s.Text = "代理无效";
                return;
            }
            if (!rb_none.Checked)
            {
                tool_s.ForeColor = Color.Green;
                tool_s.Text = "代理有效";
            }
        }

        private void GetProxy()
        {
            Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", true);
            ////设置代理可用 
            //rk.SetValue("ProxyEnable", 1);
            int temp=(int)rk.GetValue("ProxyEnable");
            enable = temp == 1;
            proxyAddress =(string) rk.GetValue("ProxyServer");
            ////设置代理IP和端口 
            //rk.SetValue("ProxyServer", proxys[i]);
            rk.Close();
            if (enable)
            {
                lb_proxy.Text = proxyAddress;
            }
            else
            {
                lb_proxy.Text = "无代理.";
            }
           

        }

        private void rb_none_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_none.Checked)
            {
                SetProxy(proxys[4]);
                tool_s.ForeColor = Color.Blue;
                tool_s.Text = "@jasine";
            }

        }

        private void rb_proxy1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_proxy1.Checked)
                SetProxy(proxys[0]);
        }

        private void rb_proxy2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_proxy2.Checked)
                SetProxy(proxys[1]);
        }

        private void rb_proxy3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_proxy3.Checked)
                SetProxy(proxys[2]);
        }

        private void rb_self_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_self.Checked)
                SetProxy(tb_ip.Text.Trim()+":"+tb_port.Text.Trim());
        }

       

       

        
    }
}
