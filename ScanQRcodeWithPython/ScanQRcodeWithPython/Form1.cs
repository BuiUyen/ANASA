using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanQRcodeWithPython
{
    public partial class Form1 : Form
    {

        private object syncGate = new object();
        private Process process;
        private StringBuilder output = new StringBuilder();
        private bool outputChanged;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lock (syncGate)
            {
                if (process != null) return;
            }

            output.Clear();
            outputChanged = false;
            richTextBox1.Text = "";
            process = new Process();
            process.StartInfo.FileName = @"C:\Program Files\Python310\python.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = Application.StartupPath + @"\scanqrcode.py";
            process.StartInfo.RedirectStandardOutput = true;
            process.OutputDataReceived += OnOutputDataReceived;
            process.Exited += OnProcessExited;
            process.Start();
            process.BeginOutputReadLine();
        }

        private void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            lock (syncGate)
            {
                if (sender != process) return;
                output.AppendLine(e.Data);                
                if (outputChanged) return;
                outputChanged = true;
                BeginInvoke(new Action(OnOutputChanged));
            }
        }

        private void OnOutputChanged()
        {
            lock (syncGate)
            {               
                richTextBox1.Text = output.ToString();              
                outputChanged = false;
            }
        }

        private void OnProcessExited(object sender, EventArgs e)
        {
            lock (syncGate)
            {
                if (sender != process) return;
                process.Dispose();
                process = null;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;           
            richTextBox1.ScrollToCaret();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://laptrinhvb.net");
        }
    }
}
