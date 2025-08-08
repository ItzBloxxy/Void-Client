using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Void_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string versionsPath = Path.Combine(localAppData, "Roblox", "Versions");

                if (Directory.Exists(versionsPath))
                {
                    string? robloxVersionFolder = Directory.GetDirectories(versionsPath)
                        .FirstOrDefault(dir => File.Exists(Path.Combine(dir, "RobloxPlayerBeta.exe")));

                    if (robloxVersionFolder != null)
                    {
                        string settingsFile = Path.Combine(robloxVersionFolder, "ClientSettings", "ClientAppSettings.json");

                        if (File.Exists(settingsFile))
                        {
                            string fileContent = File.ReadAllText(settingsFile);
                            flagsTextBox.Text = fileContent;  // No JSON validation here
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading flags: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            flagsTextBox.Visible = false;
            saveFlagsButton.Visible = false;
            importFlagsButton.Visible = false;
            clearFlagsButton.Visible = false;
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string versionsPath = Path.Combine(localAppData, "Roblox", "Versions");

                if (!Directory.Exists(versionsPath))
                {
                    MessageBox.Show("Roblox is not installed on this system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string? robloxPlayerPath = Directory.GetDirectories(versionsPath)
                    .Select(dir => Path.Combine(dir, "RobloxPlayerBeta.exe"))
                    .FirstOrDefault(File.Exists);

                if (robloxPlayerPath == null)
                {
                    MessageBox.Show("RobloxPlayerBeta.exe not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = robloxPlayerPath,
                    Arguments = "", // You can add launch flags here if needed
                    UseShellExecute = false
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error launching Roblox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilelocationButton_Click(object sender, EventArgs e)
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string versionsPath = Path.Combine(localAppData, "Roblox", "Versions");

            if (!Directory.Exists(versionsPath))
            {
                MessageBox.Show("Roblox is not installed on this system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string? robloxPlayerPath = Directory.GetDirectories(versionsPath)
                .Select(dir => Path.Combine(dir, "RobloxPlayerBeta.exe"))
                .FirstOrDefault(File.Exists);

            if (robloxPlayerPath != null)
            {
                string robloxFolder = Path.GetDirectoryName(robloxPlayerPath)!;
                Process.Start("explorer.exe", $"\"{robloxFolder}\"");
            }
            else
            {
                MessageBox.Show("Roblox folder not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Rename method to start with an uppercase letter to fix IDE1006
        private void fflagsButton_Click(object sender, EventArgs e)
        {
            flagsTextBox.Visible = true;  // Show the textbox when clicked
            saveFlagsButton.Visible = true;
            importFlagsButton.Visible = true;
            clearFlagsButton.Visible = true;
            welcome.Visible = false; // Hide welcome label when flags are shown
        }
        private void saveFlagsButton_Click(object sender, EventArgs e)
        {
            string flags = flagsTextBox.Text;

            try
            {
                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string versionsPath = Path.Combine(localAppData, "Roblox", "Versions");

                if (!Directory.Exists(versionsPath))
                {
                    MessageBox.Show("Roblox is not installed or Versions folder missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string? robloxVersionFolder = Directory.GetDirectories(versionsPath)
                    .FirstOrDefault(dir => File.Exists(Path.Combine(dir, "RobloxPlayerBeta.exe")));

                if (robloxVersionFolder == null)
                {
                    MessageBox.Show("Roblox version folder not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string settingsFolder = Path.Combine(robloxVersionFolder, "ClientSettings");

                if (!Directory.Exists(settingsFolder))
                {
                    Directory.CreateDirectory(settingsFolder);
                }

                string settingsFile = Path.Combine(settingsFolder, "ClientAppSettings.json");

                File.WriteAllText(settingsFile, flags);

                // Only show popup if flags are NOT empty or whitespace
                if (!string.IsNullOrWhiteSpace(flags))
                {
                    MessageBox.Show("Flags saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // No popup if flags is empty or whitespace
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving flags: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearFlagsButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove all fflags?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                flagsTextBox.Text = ""; // Clear the textbox

                // Save empty flags to file
                saveFlagsButton_Click(sender, e);
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            flagsTextBox.Visible = false;  // Show the textbox when clicked
            saveFlagsButton.Visible = false;
            importFlagsButton.Visible = false;
            clearFlagsButton.Visible = false;
            welcome.Visible = true;
        }
        private void importFlagsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON and Text files (*.json;*.txt)|*.json;*.txt|JSON files (*.json)|*.json|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Import Flags from JSON or TXT";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileContent = File.ReadAllText(openFileDialog.FileName);
                    flagsTextBox.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error importing file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}