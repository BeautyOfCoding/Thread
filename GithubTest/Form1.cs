using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithubTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => 
            {
                while (true)
                {
                    Console.WriteLine("测试分析");
                    Thread.Sleep(1000);

                    // https://blog.csdn.net/weixin_38211198/article/details/118345307
                    //第一步，创建一个新的项目

                    //第二步，右键解决方案，创建一个Git存储库，登录Github账号或者在现有远程里面填写仓储地址

                    //这时候，仓储已经建立，但是没有内容，点击一下提交，刷新一下Github发现已经有内容了

                    //修改代码后，解决方案资源管理器里面有红色红√，右键解决方案>git>提交或存储，填写说明，全部提交，随后点推送

                    Thread.Sleep(100);
                }
            });
        }
    }
}
