namespace Void_Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            launchButton = new Button();
            fflagsButton = new Button();
            flagsTextBox = new RichTextBox();
            saveFlagsButton = new Button();
            homeButton = new Button();
            importFlagsButton = new Button();
            clearFlagsButton = new Button();
            welcome = new Label();
            bindingSource1 = new BindingSource(components);
            filelocationButton = new Button();
            modsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // launchButton
            // 
            launchButton.AccessibleName = "";
            launchButton.BackColor = Color.FromArgb(45, 45, 45);
            launchButton.FlatAppearance.BorderSize = 0;
            launchButton.FlatStyle = FlatStyle.Flat;
            launchButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            launchButton.ForeColor = Color.White;
            launchButton.Location = new Point(664, 415);
            launchButton.Name = "launchButton";
            launchButton.Size = new Size(109, 23);
            launchButton.TabIndex = 0;
            launchButton.Text = "Launch Roblox";
            launchButton.UseVisualStyleBackColor = false;
            launchButton.Click += launchButton_Click;
            // 
            // fflagsButton
            // 
            fflagsButton.BackColor = Color.FromArgb(45, 45, 45);
            fflagsButton.FlatAppearance.BorderSize = 0;
            fflagsButton.FlatStyle = FlatStyle.Flat;
            fflagsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            fflagsButton.ForeColor = Color.White;
            fflagsButton.Location = new Point(12, 112);
            fflagsButton.Name = "fflagsButton";
            fflagsButton.Size = new Size(102, 27);
            fflagsButton.TabIndex = 1;
            fflagsButton.Text = "FFlags";
            fflagsButton.UseVisualStyleBackColor = false;
            fflagsButton.Click += fflagsButton_Click;
            // 
            // flagsTextBox
            // 
            flagsTextBox.BackColor = Color.FromArgb(48, 48, 48);
            flagsTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            flagsTextBox.ForeColor = Color.White;
            flagsTextBox.Location = new Point(134, 71);
            flagsTextBox.Name = "flagsTextBox";
            flagsTextBox.Size = new Size(627, 338);
            flagsTextBox.TabIndex = 2;
            flagsTextBox.Text = "";
            flagsTextBox.Visible = false;
            // 
            // saveFlagsButton
            // 
            saveFlagsButton.AccessibleName = "";
            saveFlagsButton.BackColor = Color.FromArgb(45, 45, 45);
            saveFlagsButton.FlatAppearance.BorderSize = 0;
            saveFlagsButton.FlatStyle = FlatStyle.Flat;
            saveFlagsButton.ForeColor = Color.White;
            saveFlagsButton.Location = new Point(167, 42);
            saveFlagsButton.Name = "saveFlagsButton";
            saveFlagsButton.Size = new Size(109, 23);
            saveFlagsButton.TabIndex = 4;
            saveFlagsButton.Text = "Apply FFlags";
            saveFlagsButton.UseVisualStyleBackColor = false;
            saveFlagsButton.Visible = false;
            saveFlagsButton.Click += saveFlagsButton_Click;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.FromArgb(45, 45, 45);
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeButton.ForeColor = Color.White;
            homeButton.Location = new Point(12, 68);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(102, 27);
            homeButton.TabIndex = 5;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // importFlagsButton
            // 
            importFlagsButton.AccessibleName = "";
            importFlagsButton.BackColor = Color.FromArgb(45, 45, 45);
            importFlagsButton.FlatAppearance.BorderSize = 0;
            importFlagsButton.FlatStyle = FlatStyle.Flat;
            importFlagsButton.ForeColor = Color.White;
            importFlagsButton.Location = new Point(296, 42);
            importFlagsButton.Name = "importFlagsButton";
            importFlagsButton.Size = new Size(109, 23);
            importFlagsButton.TabIndex = 6;
            importFlagsButton.Text = "Import JSON";
            importFlagsButton.UseVisualStyleBackColor = false;
            importFlagsButton.Visible = false;
            importFlagsButton.Click += importFlagsButton_Click;
            // 
            // clearFlagsButton
            // 
            clearFlagsButton.AccessibleName = "";
            clearFlagsButton.BackColor = Color.FromArgb(45, 45, 45);
            clearFlagsButton.FlatAppearance.BorderSize = 0;
            clearFlagsButton.FlatStyle = FlatStyle.Flat;
            clearFlagsButton.ForeColor = Color.White;
            clearFlagsButton.Location = new Point(421, 42);
            clearFlagsButton.Name = "clearFlagsButton";
            clearFlagsButton.Size = new Size(109, 23);
            clearFlagsButton.TabIndex = 7;
            clearFlagsButton.Text = "Clear FFlags";
            clearFlagsButton.UseVisualStyleBackColor = false;
            clearFlagsButton.Visible = false;
            clearFlagsButton.Click += clearFlagsButton_Click;
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.BackColor = Color.Transparent;
            welcome.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            welcome.Location = new Point(202, 42);
            welcome.Name = "welcome";
            welcome.Size = new Size(462, 42);
            welcome.TabIndex = 8;
            welcome.Text = "Hello, welcome to Void Client!";
            welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filelocationButton
            // 
            filelocationButton.AccessibleName = "";
            filelocationButton.BackColor = Color.FromArgb(45, 45, 45);
            filelocationButton.FlatAppearance.BorderSize = 0;
            filelocationButton.FlatStyle = FlatStyle.Flat;
            filelocationButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filelocationButton.ForeColor = Color.White;
            filelocationButton.Location = new Point(535, 415);
            filelocationButton.Name = "filelocationButton";
            filelocationButton.Size = new Size(114, 23);
            filelocationButton.TabIndex = 9;
            filelocationButton.Text = "Open File Location ";
            filelocationButton.UseVisualStyleBackColor = false;
            filelocationButton.Click += FilelocationButton_Click;
            // 
            // modsButton
            // 
            modsButton.BackColor = Color.FromArgb(45, 45, 45);
            modsButton.FlatAppearance.BorderSize = 0;
            modsButton.FlatStyle = FlatStyle.Flat;
            modsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            modsButton.ForeColor = Color.White;
            modsButton.Location = new Point(12, 155);
            modsButton.Name = "modsButton";
            modsButton.Size = new Size(102, 27);
            modsButton.TabIndex = 10;
            modsButton.Text = "Mods";
            modsButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(800, 450);
            Controls.Add(modsButton);
            Controls.Add(filelocationButton);
            Controls.Add(welcome);
            Controls.Add(clearFlagsButton);
            Controls.Add(importFlagsButton);
            Controls.Add(homeButton);
            Controls.Add(saveFlagsButton);
            Controls.Add(flagsTextBox);
            Controls.Add(fflagsButton);
            Controls.Add(launchButton);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Void Client";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button launchButton;
        private Button fflagsButton;
        private RichTextBox flagsTextBox;
        private Button saveFlagsButton;
        private Button homeButton;
        private Button importFlagsButton;
        private Button clearFlagsButton;
        private Label welcome;
        private BindingSource bindingSource1;
        private Button filelocationButton;
        private Button modsButton;
    }
}
