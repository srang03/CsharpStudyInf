using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAsyncAswaitFromIAmTimCorey
{
    // Task A, B, C, D가 존재할 경우 기존의 동기식 프로그램에서는 순차적으로만 작업을 수행하고 D가 완료될 때까지 다른 작업을 할 수 없었다.

    // 이익 1. 사용자 인터페이스
    // Task B가 많은 시간이 소요되는 작업일 경우 사용자 인터페이스가 잠겨 사용할 수 없을 수 있다.
    // 

    // 이익 2. 의존성
    // 병렬처리로 인하여 각각의 다른 작업을 기다리지 않고 동시에 실행할 수 있다. 

    // 문제점 1. UI 인터페이스 멈추는 현상, 2. 하나의 작업이 끝날 때까지 기다려야하는 현상
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sync_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();

            RunDownloadSync();
            sw.Stop();

            this.textBox1.Text += $"Total execution time: {sw.ElapsedMilliseconds} {Environment.NewLine}";
        }

        private async Task RunDownloadAsync()
        {
            List<string> websites = PreData();
            foreach (string site in websites)
            {
                WebsiteDataModel results = await Task.Run(()=> Downloadwebsite(site));
                // wait for result;
                ReportWebsiteInfo(results);
            }
        }

        private async Task RunDownloadParallelAsync()
        {
            List<string> websites = PreData();
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();

            foreach (string site in websites)
            {
                tasks.Add(DownloadwebsiteAsync(site));
                // wait for result;
              
            }
            var results = await Task.WhenAll(tasks);

            foreach (var result in results)
            {
                ReportWebsiteInfo(result);
            }
        }


        private List<string> PreData()
        {
            List<string> output = new List<string>();
            output.Add("https://www.naver.com");
            //output.Add("https://www.goolge.com");
            output.Add("https://www.daum.net");
            output.Add("https://www.youtube.com");

            return output;
        }

        private void RunDownloadSync()
        {
            List<string> websites = PreData();
            foreach(string site in websites)
            {
                WebsiteDataModel results = Downloadwebsite(site);
                ReportWebsiteInfo(results);
            }
        }

        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
            this.textBox1.Text += $"{data.WebsiteUrl} downloaded: {data.WebsiteData.Length} characters long. {Environment.NewLine}";
           
        }

        private WebsiteDataModel Downloadwebsite(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            output.WebsiteUrl = websiteURL;
            output.WebsiteData = client.DownloadString(websiteURL);

            return output;
        }

        private async Task<WebsiteDataModel> DownloadwebsiteAsync(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            output.WebsiteUrl = websiteURL;
            output.WebsiteData = await client.DownloadStringTaskAsync(websiteURL);

            return output;
        }

        private async void btn_async_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();

            await RunDownloadAsync();
            sw.Stop();

            this.textBox1.Text += $"Total execution time: {sw.ElapsedMilliseconds} {Environment.NewLine}";
       
        }

        private async void btn_paralleAsync_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();

            await RunDownloadParallelAsync();
            sw.Stop();

            this.textBox1.Text += $"Total execution time: {sw.ElapsedMilliseconds} {Environment.NewLine}";
        }
    }
}
