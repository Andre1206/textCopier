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
        private static readonly string CodeSegmentsDirectory =
            Path.Combine(AppContext.BaseDirectory, "codeSegments");

        private void codeSegmentToClipboard(params string[] relativePathParts)
        {
            string filePath = relativePathParts.Aggregate(
                CodeSegmentsDirectory,
                (currentPath, pathPart) => Path.Combine(currentPath, pathPart));

            fileToClipboard(filePath);
        }

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
            codeSegmentToClipboard("graph", "tree.txt");
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
            codeSegmentToClipboard("functions", "print.txt");
        }

        private void msgTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("functions", "multiTestcases.txt");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("range_query", "range_query_ST.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("range_query", "range_query_LPST.txt");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("range_query", "range_query_BIT.txt");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("range_query", "range_query_DBIT.txt");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("disjoint_set", "DS.txt");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("disjoint_set", "DS_map.txt");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("disjoint_set", "DS_vector.txt");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("my_multiset", "my_multiset.txt");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("number_theory", "mint.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("functions", "board.txt");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("range_query", "range_query_DST.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("functions", "YesNo.txt");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            codeSegmentToClipboard("functions", "multiYesNo.txt");
        }
    }
}
