//SimpleLoader by Wilson, https://github.com/WilsonPublic/SimpleLoader [Open Source Cheat Loader]
//This is very noob friendly and can easily be adapted, this has no form of protection against cracking so please come up with your own ideas on how to prevent cracking
//I recommend using Dot Net Reactor to protect your programs

using System;
using System.Linq;
using System.Windows.Forms;
using ManualMapInjection.Injection;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;
using SimpleLoader.Extensions;
using static SimpleLoader.Extensions.Externsions;
using DarkUI.Controls;
using DarkUI.Forms;
using Microsoft.CSharp;
using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using SimpleLoader;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(44, 44, 44);
            panel5.Hide();
        }


     

        private void Form1_Load(object sender, EventArgs e) 
        {
            

        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            await LoadDesign();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string vacpath = "C:\\VAC-Bypass.exe"; //You can change the path to wherever you want but just remember to use "\\" instead of just one "\"
           wb.DownloadFile("https://github.com/doonayy/fortheboys/raw/main/miscs/VAC-Bypass-Loader.exe", vacpath);
            ProcessStartInfo start = new ProcessStartInfo(); //execute it
            start.FileName = "C:\\VAC-Bypass.exe";
            start.WindowStyle = ProcessWindowStyle.Hidden; // Do you want to show a console window?
            start.CreateNoWindow = false;
            int exitCode;
            using (Process proc = Process.Start(start)) // Run the external process & wait for it to finish
            {
                proc.WaitForExit();
                exitCode = proc.ExitCode; // Retrieve the app's exit code
                System.IO.File.Delete(vacpath); //Deleting the the vacbypass
                {
                    start.FileName = "steam.exe";
                    Process.Start("steam://rungameid/730"); //<-- this should launch it, aight let me try
                    start.WindowStyle = ProcessWindowStyle.Hidden; // Do you want to show a console window? 
                    start.CreateNoWindow = false; //
                    Thread.Sleep(20000); //Sleepy MS
                    {
                        WebClient dl = new WebClient();
                        string mainpath = "C:\\cheat.dll"; //You can change the path to wherever you want but just remember to use "\\" instead of just one "\"
//                        dl.DownloadFile("https://github.com/doonayy/fortheboys/raw/main/miscs/otv3.dll", mainpath); //Replace "DLL URL" with the URL to directly download your DLL [Example: http://myurl.com/MYDLL.dll]
                        var name = "csgo"; //Replace "csgo" with any exe you want [Example: For Team Fortress 2 you would replace it with "hl2"]
                        var target = Process.GetProcessesByName(name).FirstOrDefault();
                        var path = mainpath;
                        var file = File.ReadAllBytes(path);

                        //Checking if the DLL isn't found
                        if (!File.Exists(path))
                        {
                            MessageBox.Show("Error: DLL not found");
                            return;
                        }

                        //Injection, just leave this alone if you are a beginner
                        var injector = new ManualMapInjector(target) { AsyncInjection = true };
                        label2.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";

                        if (System.IO.File.Exists(mainpath)) //Checking if the DLL exists
                        {
                            System.IO.File.Delete(mainpath); //Deleting the DLL 
                        } //want me 2 make sex gui? im professional sexer, 
                    }
                }
            }
        }

        //!advertencia!                                                                                                    !advertencia!
        //!advertencia! el código a continuación es muy complicado, ya que enit (yo) lo hizo, lo mismo con extenstions.cs  !advertencia!
        //!advertencia!                                                                                                    !advertencia!

        private void rgbTimer_Tick(object sender, EventArgs e)
        {
            Rainbow.change_color(panel1); //its cum fuck renbow no gay
        }

        private void darkCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            rgbTimer.Enabled = darkCheckBox1.Checked; //check if checked
            if (!darkCheckBox1.Checked)
            {
                panel1.BackColor = Color.FromArgb(44, 44, 44); //color reinbow
            }
        }
        private async Task LoadDesign()
        {
            await Task.Run(() => //im runner jusein baldt
            {
                LoadSettings();
            });
        }
        private void exitB_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //lol rip program go dyieng
        }

        private void minimizeB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //mini, like ur pp
        }

        private void darkGroupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
            DarkMessageBox.ShowInformation("Configuration saved under config.simple.", "Configuration", DarkDialogButton.Ok); //whre konfig?
        }

        private void SaveConfiguration()
        {
            Configuration config = new Configuration(); //Configuration
            config.UseRGB = darkCheckBox1.Checked;
            config.otcv3 = darkComboBox1.SelectedItem.ToString() == "OTCv3";
            config.fluidaim = darkComboBox1.SelectedItem.ToString() == "Fluidaim";
            config.seaside = darkComboBox1.SelectedItem.ToString() == "Seaside";
            this.Refresh();
            string cfg = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(@"config.simple", cfg);
        }

        private void LoadSettings()
        {

            if (File.Exists("config.simple"))
            {
                string json = File.ReadAllText("config.simple");
                try
                {
                    Configuration config = JsonConvert.DeserializeObject<Configuration>(json);
                    darkCheckBox1.Checked = config.UseRGB;
                    if (config.otcv3 == true)
                    {
                        darkComboBox1.SelectedIndex = darkComboBox1.FindStringExact("OTCv3");
                    }

                    else if (config.fluidaim == true)
                    {
                        darkComboBox1.SelectedIndex = darkComboBox1.FindStringExact("Fluidaim");
                    }

                    else if (config.seaside == true)
                    {
                        darkComboBox1.SelectedIndex = darkComboBox1.FindStringExact("Seaside");
                    }
                    this.Refresh();


                }
                catch { }
            }
        }



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void darkComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebClient dl = new WebClient();
            string mainpath = "C:\\cheat.dll";

            if (darkComboBox1.SelectedItem.ToString() == "Fluidaim") //download dll if X selected
            {
                File.Delete(@"C:\cheat.dll");
                dl.DownloadFile("https://github.com/doonayy/fortheboys/raw/main/miscs/Fluidaim.dll", mainpath);
            }

            else if (darkComboBox1.SelectedItem.ToString() == "Seaside")//download dll if X selected
            {
                File.Delete(@"C:\cheat.dll");
                dl.DownloadFile("https://github.com/doonayy/fortheboys/raw/main/miscs/Seaside.dll", mainpath);
            }

            else if (darkComboBox1.SelectedItem.ToString() == "OTCv3")//download dll if X selected
            {
                File.Delete(@"C:\cheat.dll");
                dl.DownloadFile("https://github.com/doonayy/fortheboys/raw/main/miscs/otv3.dll", mainpath);
            }
        }

        private void darkButton3_Click(object sender, EventArgs e) //tried making some toggle thing for the credits tab, didnt rly work since darkui has some weird ass panels.
        {
            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    panel5.Show();
                    darkGroupBox2.Show();
                    break;
                case 2:
                    panel5.Hide();
                    darkGroupBox2.Hide();
                    break;
                default:
                    panel5.Hide();
                    darkGroupBox2.Hide();
                    break;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}