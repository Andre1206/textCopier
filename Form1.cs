using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCopier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const string repo_loc = @"C:\Users\h0a4r\OneDrive\桌面\code_projects\TextCopier\";

        private void fileToClipboard(string filePath)
        {
            // 檢查檔案是否存在
            if (File.Exists(filePath))
            {
                try
                {
                    // 讀取檔案所有文字
                    string text = File.ReadAllText(filePath);
                    // 將文字複製到剪貼簿
                    Clipboard.SetText(text);
                    string fileName = Path.GetFileName(filePath);
                    // ✅ 成功複製後顯示訊息到 msgTextBox
                    msgTextBox.Text = $"已成功複製：{fileName}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取檔案或設定剪貼簿時發生錯誤：" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("找不到檔案！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\graph\tree.txt";
            fileToClipboard(filePath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\functions\print.txt";
            fileToClipboard(filePath);
        }

        private void msgTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\functions\multiTestcases.txt";
            fileToClipboard(filePath);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\range_query\range_query_ST.txt";
            fileToClipboard(filePath);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\range_query\range_query_LPST.txt";
            fileToClipboard(filePath);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\range_query\range_query_BIT.txt";
            fileToClipboard(filePath);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\range_query\range_query_DBIT.txt";
            fileToClipboard(filePath);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\disjoint_set\DS.txt";
            fileToClipboard(filePath);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\disjoint_set\DS_map.txt";
            fileToClipboard(filePath);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\disjoint_set\DS_vector.txt";
            fileToClipboard(filePath);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\my_multiset\my_multiset.txt";
            fileToClipboard(filePath);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\number_theory\mint.txt";
            fileToClipboard(filePath);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\functions\board.txt";
            fileToClipboard(filePath);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\range_query\range_query_DST.txt";
            fileToClipboard(filePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\functions\YesNo.txt";
            fileToClipboard(filePath);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string filePath = repo_loc + @"codeSegments\functions\multiYesNo.txt";
            fileToClipboard(filePath);
        }
    }
}
