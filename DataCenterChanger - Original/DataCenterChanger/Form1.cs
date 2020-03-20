using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;
using IniParser;
using IniParser.Model;

namespace DataCenterChanger
{
    public partial class DCC : MetroForm
    {
        public static List<string> servers = new List<string>() { "eus", "cus", "scus", "wus", "sbr", "neu", "weu", "eas", "seas", "eau", "wja"};

        public DCC()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.GameSettingsPath;
        }

        private void OpenFD_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog()
            {
                FileName = "GameSettings.ini",
                Filter = "Configuration File (*.ini)|*.ini",
                Title = "Select the GameSettings.ini file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Properties.Settings.Default.GameSettingsPath = openFileDialog1.FileName;
                    Properties.Settings.Default.Save();
                    textBox1.Text = openFileDialog1.FileName;
                } catch
                {
                    MessageBox.Show("Please choose a valid file.");
                }
            }
        }

        private void SwitchServer_Click(object sender, EventArgs e)
        {
            if (servers.Contains(centreName.Text))
            {
                try
                {
                    var parser = new FileIniDataParser();
                    IniData data = parser.ReadFile(Properties.Settings.Default.GameSettingsPath);

                    data["ONLINE"]["DataCenterHint"] = centreName.Text;

                    parser.WriteFile(Properties.Settings.Default.GameSettingsPath, data);
                }
                catch
                {
                    MessageBox.Show("Please choose a valid file");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid server name");
            }
        }
    }
}