namespace Flight.UI
{
    partial class DashboardPanelControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnAddFlights = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbOrigin = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelFlights = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(178, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 69);
            this.label1.TabIndex = 13;
            this.label1.Text = "WizzAir-inspired app for hassle-free flight ticket bookings.";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelHeader.Controls.Add(this.btnAddFlights);
            this.panelHeader.Controls.Add(this.btnHelp);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 100);
            this.panelHeader.TabIndex = 14;
            // 
            // btnAddFlights
            // 
            this.btnAddFlights.AutoSize = true;
            this.btnAddFlights.FlatAppearance.BorderSize = 0;
            this.btnAddFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlights.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddFlights.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddFlights.Location = new System.Drawing.Point(615, 28);
            this.btnAddFlights.Name = "btnAddFlights";
            this.btnAddFlights.Size = new System.Drawing.Size(131, 38);
            this.btnAddFlights.TabIndex = 18;
            this.btnAddFlights.Text = "ADD FLIGHTS";
            this.btnAddFlights.UseVisualStyleBackColor = true;
            this.btnAddFlights.Click += new System.EventHandler(this.btnAddFlights_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.AutoSize = true;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHelp.Location = new System.Drawing.Point(752, 28);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(105, 38);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flight.UI.Properties.Resources.Wizz_Air_logo_2015_svg;
            this.pictureBox1.Location = new System.Drawing.Point(23, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(863, 28);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 38);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDestination);
            this.panel2.Controls.Add(this.lblOrigin);
            this.panel2.Controls.Add(this.tbDestination);
            this.panel2.Controls.Add(this.tbOrigin);
            this.panel2.Location = new System.Drawing.Point(30, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 82);
            this.panel2.TabIndex = 16;
            // 
            // tbDestination
            // 
            this.tbDestination.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDestination.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbDestination.Location = new System.Drawing.Point(464, 27);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(448, 38);
            this.tbDestination.TabIndex = 1;
            this.tbDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDestination.Click += new System.EventHandler(this.tbDestination_Click);
            this.tbDestination.TextChanged += new System.EventHandler(this.tbDestination_TextChanged);
            this.tbDestination.Leave += new System.EventHandler(this.tbDestination_Leave);
            // 
            // tbOrigin
            // 
            this.tbOrigin.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOrigin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbOrigin.Location = new System.Drawing.Point(29, 27);
            this.tbOrigin.Name = "tbOrigin";
            this.tbOrigin.Size = new System.Drawing.Size(429, 38);
            this.tbOrigin.TabIndex = 0;
            this.tbOrigin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOrigin.Click += new System.EventHandler(this.tbOrigin_Click);
            this.tbOrigin.TextChanged += new System.EventHandler(this.tbOrigin_TextChanged);
            this.tbOrigin.Leave += new System.EventHandler(this.tbOrigin_Leave);
            // 
            // flowLayoutPanelFlights
            // 
            this.flowLayoutPanelFlights.AutoScroll = true;
            this.flowLayoutPanelFlights.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelFlights.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelFlights.Location = new System.Drawing.Point(30, 226);
            this.flowLayoutPanelFlights.Name = "flowLayoutPanelFlights";
            this.flowLayoutPanelFlights.Size = new System.Drawing.Size(940, 450);
            this.flowLayoutPanelFlights.TabIndex = 17;
            this.flowLayoutPanelFlights.WrapContents = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Flight.UI.Properties.Resources.catania_right_tmb_width1920;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1000, 700);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.BackColor = System.Drawing.SystemColors.Window;
            this.lblOrigin.Enabled = false;
            this.lblOrigin.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOrigin.ForeColor = System.Drawing.Color.LightGray;
            this.lblOrigin.Location = new System.Drawing.Point(194, 30);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(79, 31);
            this.lblOrigin.TabIndex = 3;
            this.lblOrigin.Text = "Origin";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.BackColor = System.Drawing.SystemColors.Window;
            this.lblDestination.Enabled = false;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDestination.ForeColor = System.Drawing.Color.LightGray;
            this.lblDestination.Location = new System.Drawing.Point(642, 30);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(133, 31);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination";
            // 
            // DashboardPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.flowLayoutPanelFlights);
            this.Controls.Add(this.pictureBox2);
            this.Name = "DashboardPanelControl";
            this.Size = new System.Drawing.Size(1000, 700);
            this.Load += new System.EventHandler(this.DashboardPanelControl_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbOrigin;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFlights;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAddFlights;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblOrigin;
    }
}
