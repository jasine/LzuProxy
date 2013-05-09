namespace LzuProxyChanger
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.rb_proxy1 = new System.Windows.Forms.RadioButton();
            this.rb_proxy2 = new System.Windows.Forms.RadioButton();
            this.rb_proxy3 = new System.Windows.Forms.RadioButton();
            this.lb_proxy = new System.Windows.Forms.Label();
            this.rb_self = new System.Windows.Forms.RadioButton();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tool_s = new System.Windows.Forms.ToolStripStatusLabel();
            this.rb_none = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前代理：";
            // 
            // rb_proxy1
            // 
            this.rb_proxy1.AutoSize = true;
            this.rb_proxy1.Location = new System.Drawing.Point(52, 35);
            this.rb_proxy1.Name = "rb_proxy1";
            this.rb_proxy1.Size = new System.Drawing.Size(53, 16);
            this.rb_proxy1.TabIndex = 2;
            this.rb_proxy1.TabStop = true;
            this.rb_proxy1.Text = "代理1";
            this.rb_proxy1.UseVisualStyleBackColor = true;
            this.rb_proxy1.CheckedChanged += new System.EventHandler(this.rb_proxy1_CheckedChanged);
            // 
            // rb_proxy2
            // 
            this.rb_proxy2.AutoSize = true;
            this.rb_proxy2.Location = new System.Drawing.Point(111, 35);
            this.rb_proxy2.Name = "rb_proxy2";
            this.rb_proxy2.Size = new System.Drawing.Size(53, 16);
            this.rb_proxy2.TabIndex = 3;
            this.rb_proxy2.TabStop = true;
            this.rb_proxy2.Text = "代理2";
            this.rb_proxy2.UseVisualStyleBackColor = true;
            this.rb_proxy2.CheckedChanged += new System.EventHandler(this.rb_proxy2_CheckedChanged);
            // 
            // rb_proxy3
            // 
            this.rb_proxy3.AutoSize = true;
            this.rb_proxy3.Location = new System.Drawing.Point(170, 35);
            this.rb_proxy3.Name = "rb_proxy3";
            this.rb_proxy3.Size = new System.Drawing.Size(53, 16);
            this.rb_proxy3.TabIndex = 4;
            this.rb_proxy3.TabStop = true;
            this.rb_proxy3.Text = "代理3";
            this.rb_proxy3.UseVisualStyleBackColor = true;
            this.rb_proxy3.CheckedChanged += new System.EventHandler(this.rb_proxy3_CheckedChanged);
            // 
            // lb_proxy
            // 
            this.lb_proxy.AutoSize = true;
            this.lb_proxy.Location = new System.Drawing.Point(74, 9);
            this.lb_proxy.Name = "lb_proxy";
            this.lb_proxy.Size = new System.Drawing.Size(0, 12);
            this.lb_proxy.TabIndex = 5;
            // 
            // rb_self
            // 
            this.rb_self.AutoSize = true;
            this.rb_self.Location = new System.Drawing.Point(11, 69);
            this.rb_self.Name = "rb_self";
            this.rb_self.Size = new System.Drawing.Size(59, 16);
            this.rb_self.TabIndex = 6;
            this.rb_self.TabStop = true;
            this.rb_self.Text = "自定义";
            this.rb_self.UseVisualStyleBackColor = true;
            this.rb_self.CheckedChanged += new System.EventHandler(this.rb_self_CheckedChanged);
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(76, 68);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(88, 21);
            this.tb_ip.TabIndex = 7;
            this.tb_ip.Text = "127.0.0.1";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(170, 68);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(45, 21);
            this.tb_port.TabIndex = 8;
            this.tb_port.Text = "8087";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_s});
            this.statusStrip1.Location = new System.Drawing.Point(0, 101);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(228, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tool_s
            // 
            this.tool_s.Name = "tool_s";
            this.tool_s.Size = new System.Drawing.Size(53, 17);
            this.tool_s.Text = "@jasine";
            // 
            // rb_none
            // 
            this.rb_none.AutoSize = true;
            this.rb_none.Location = new System.Drawing.Point(11, 35);
            this.rb_none.Name = "rb_none";
            this.rb_none.Size = new System.Drawing.Size(35, 16);
            this.rb_none.TabIndex = 11;
            this.rb_none.TabStop = true;
            this.rb_none.Text = "无";
            this.rb_none.UseVisualStyleBackColor = true;
            this.rb_none.CheckedChanged += new System.EventHandler(this.rb_none_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 123);
            this.Controls.Add(this.rb_none);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.rb_self);
            this.Controls.Add(this.lb_proxy);
            this.Controls.Add(this.rb_proxy3);
            this.Controls.Add(this.rb_proxy2);
            this.Controls.Add(this.rb_proxy1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "兰大代理修改器";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_proxy1;
        private System.Windows.Forms.RadioButton rb_proxy2;
        private System.Windows.Forms.RadioButton rb_proxy3;
        private System.Windows.Forms.Label lb_proxy;
        private System.Windows.Forms.RadioButton rb_self;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tool_s;
        private System.Windows.Forms.RadioButton rb_none;

    }
}

