using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Oldurucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

public bool FindAndKillProcess(string name)
{	
	foreach (var clsProcess in Process.GetProcesses()) { 
	
		//. Be sure to not
		//add the .exe to the name you provide, i.e: NOTEPAD,
		if (clsProcess.ProcessName.StartsWith(name))
		{
			clsProcess.Kill();
			//first process killed, return true
			return true;
		}
	}
	//process not found, return false
	return false;
}
        private void button1_Click(object sender, EventArgs e)
        {
            FindAndKillProcess("notepad");
            textBox1.Text = FindAndKillProcess("notepad") ? "Killed" : "Not Killed";
        }
    }
}
