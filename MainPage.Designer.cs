namespace Minecraft_Launch_Script
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnNewMethodBypass = new System.Windows.Forms.Button();
            this.btnOldMethod = new System.Windows.Forms.Button();
            this.btnPerformanceTweak = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 750);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 30);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(236, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 30);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(236, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(851, 720);
            this.panel4.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnHome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPerformanceTweak, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNewMethodBypass, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOldMethod, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 184);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(230, 40);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnNewMethodBypass
            // 
            this.btnNewMethodBypass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMethodBypass.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnNewMethodBypass.Location = new System.Drawing.Point(3, 49);
            this.btnNewMethodBypass.Name = "btnNewMethodBypass";
            this.btnNewMethodBypass.Size = new System.Drawing.Size(230, 40);
            this.btnNewMethodBypass.TabIndex = 3;
            this.btnNewMethodBypass.Text = "New Method Bypass";
            this.btnNewMethodBypass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMethodBypass.UseVisualStyleBackColor = true;
            this.btnNewMethodBypass.Click += new System.EventHandler(this.btnNewMethodBypass_Click);
            // 
            // btnOldMethod
            // 
            this.btnOldMethod.Enabled = false;
            this.btnOldMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOldMethod.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnOldMethod.Location = new System.Drawing.Point(3, 95);
            this.btnOldMethod.Name = "btnOldMethod";
            this.btnOldMethod.Size = new System.Drawing.Size(230, 40);
            this.btnOldMethod.TabIndex = 4;
            this.btnOldMethod.Text = "Old Method";
            this.btnOldMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOldMethod.UseVisualStyleBackColor = true;
            this.btnOldMethod.Visible = false;
            this.btnOldMethod.Click += new System.EventHandler(this.btnOldMethod_Click);
            // 
            // btnPerformanceTweak
            // 
            this.btnPerformanceTweak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformanceTweak.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPerformanceTweak.Location = new System.Drawing.Point(3, 141);
            this.btnPerformanceTweak.Name = "btnPerformanceTweak";
            this.btnPerformanceTweak.Size = new System.Drawing.Size(230, 40);
            this.btnPerformanceTweak.TabIndex = 5;
            this.btnPerformanceTweak.Text = "Performance Tweak";
            this.btnPerformanceTweak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerformanceTweak.UseVisualStyleBackColor = true;
            this.btnPerformanceTweak.Click += new System.EventHandler(this.btnPerformanceTweak_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAbout.Location = new System.Drawing.Point(3, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(230, 40);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnAbout, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 704);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(236, 46);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1087, 750);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Minecraft Bedrock Edition Launcher";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPerformanceTweak;
        private System.Windows.Forms.Button btnNewMethodBypass;
        private System.Windows.Forms.Button btnOldMethod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

