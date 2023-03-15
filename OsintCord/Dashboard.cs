using Bunifu.UI.WinForms;
using DiscordRPC;
using HtmlAgilityPack;
using Leaf.xNet;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OsintCord.APIs;
using OsintCord.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OsintCord
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/2v7DnTYgGQ");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://patched.to/User/pointx");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/XiterShop");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://patched.to/Thread-http-%E2%9C%85-2-proxies-datacenters-uhq-http%F0%9F%94%B9cloud-%F0%9F%8D%80-guaranteed-high-cpm-%E2%9C%94%EF%B8%8F");
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://patched.to/Thread-diamond-%E2%9C%85-combo-cloud-suhq-gaypal-%F0%9F%8D%80-guaranteed-hits-%E2%9C%94%EF%B8%8F");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://patched.to/Thread-diamond-%E2%9C%85-venmo-capture-phone-%F0%9F%8D%80-new-config-cheap-%E2%9C%94%EF%B8%8F");
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            panel1_Home.Visible = true;
            panel1_Lookup.Visible = false;
            panel1_tokenLog.Visible = false;
            panel2_setting.Visible = false;
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            

            DiscordRichPresence.rpctimestamp = Timestamps.Now;
            DiscordRichPresence.InitializeRPC();

            Process.Start("https://t.me/XiterShop");

            panel1_Home.Visible = true;
            panel1_Lookup.Visible = false;
            panel1_tokenLog.Visible = false;
            panel2_setting.Visible = false;
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            panel1_Home.Visible = false;
            panel1_Lookup.Visible = true;
            panel1_tokenLog.Visible = false;
            panel2_setting.Visible = false;
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            panel1_Home.Visible = false;
            panel1_Lookup.Visible = false;
            panel1_tokenLog.Visible = true;
            panel2_setting.Visible = false;
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            panel1_Home.Visible = false;
            panel1_Lookup.Visible = false;
            panel1_tokenLog.Visible = false;
            panel2_setting.Visible = true;
        }
       
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                HttpRequest HttpRequest = new HttpRequest();
                var source = HttpRequest.Get($"https://lookup.guru/{txtID.Text}").ToString();

                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = web.Load($"https://lookup.guru/{txtID.Text}");
                lbUserId.Text = document.DocumentNode.SelectNodes("/html/body/div/div/div/div[1]/div[2]/div[2]/div[1]/p[2]").First().InnerText;
                lbCreation.Text = document.DocumentNode.SelectNodes("/html/body/div/div/div/div[1]/div[2]/div[2]/div[3]/p[2]").First().InnerText;
                lbType.Text = document.DocumentNode.SelectNodes("/html/body/div/div/div/div[1]/div[2]/div[2]/div[2]/p[2]").First().InnerText;
                lbAge.Text = document.DocumentNode.SelectNodes("/html/body/div/div/div/div[1]/div[2]/div[2]/div[4]/p[2]").First().InnerText;
                lbName.Text = document.DocumentNode.SelectNodes("/html/body/div/div/div/div[1]/div[2]/div[1]/div[1]/div[1]/span").First().InnerText + document.DocumentNode.SelectNodes("/html/body/div/div/div/div[1]/div[2]/div[1]/div[1]/div[1]/small").First().InnerText;

                if (Global.webhookEnable == true)
                {
                    Webhook.SendMessage($"ID Information [{txtID.Text}]", "<:black:1013500552967094303> **Creation Data**: ```" + lbCreation.Text + "```\n<:black_din_imp:1013500483652038696> **Type:**```" + lbType.Text + "```\n<:7k:1002780632532918393> **Age:** ```" + lbAge.Text + "```" + "\n<:black:1013500552967094303> **Username**: ```" + lbName.Text.ToString() + "```");
                }
                else { }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Format Incorrect or other problem");
            }         
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("start-maximized");

                IWebDriver driver = new ChromeDriver(options);
                driver.Navigate().GoToUrl("https://discord.com/login");

                string jsCode = @"function login(token) {
                    setInterval(() => {
                        document.body.appendChild(document.createElement `iframe`).contentWindow.localStorage.token = `""${token}""`
                    }, 50);
                    setTimeout(() => {
                        location.reload();
                    }, 2500);
                }
                login('" + txtToken.Text + "')";
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript(jsCode);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error put correct token");
            }
           
        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
            try
            {
                Global.webhook = lbWebHook.Text;
                Global.webhookEnable = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Format or other error");
            }
        }

        private void panel2_setting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("3LnXxbSPYk3DLqtXvtz84vWmd1w7ECyNNk");
            MessageBox.Show("Adress BTC Copied to clipboard");
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("0xC3370d68aF037285a2afaAE42472d90BDE5BbEE1");
            MessageBox.Show("Adress ETH Copied to clipboard");
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("MLBwb9hYf9GWcj6KkZGqEZWUiY8a7cQfvt");
            MessageBox.Show("Adress LTC Copied to clipboard");
        }
    }
}
