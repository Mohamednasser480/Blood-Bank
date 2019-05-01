namespace project
{
    partial class Form1
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
            this.login = new System.Windows.Forms.Button();
            this.reg_donor = new System.Windows.Forms.Button();
            this.regi_reci = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.DimGray;
            this.login.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(214, 22);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(173, 53);
            this.login.TabIndex = 0;
            this.login.Text = "LOG IN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // reg_donor
            // 
            this.reg_donor.BackColor = System.Drawing.Color.DimGray;
            this.reg_donor.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_donor.Location = new System.Drawing.Point(214, 14);
            this.reg_donor.Name = "reg_donor";
            this.reg_donor.Size = new System.Drawing.Size(173, 59);
            this.reg_donor.TabIndex = 1;
            this.reg_donor.Text = "REGISTER AS DONOR";
            this.reg_donor.UseVisualStyleBackColor = false;
            this.reg_donor.Click += new System.EventHandler(this.reg_donor_Click);
            // 
            // regi_reci
            // 
            this.regi_reci.BackColor = System.Drawing.Color.DimGray;
            this.regi_reci.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regi_reci.Location = new System.Drawing.Point(214, 14);
            this.regi_reci.Name = "regi_reci";
            this.regi_reci.Size = new System.Drawing.Size(173, 51);
            this.regi_reci.TabIndex = 2;
            this.regi_reci.Text = "REGISTER AS RECIPIENT";
            this.regi_reci.UseVisualStyleBackColor = false;
            this.regi_reci.Click += new System.EventHandler(this.regi_reci_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DimGray;
            this.exit.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(211, 15);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(173, 54);
            this.exit.TabIndex = 3;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.login);
            this.panel1.Location = new System.Drawing.Point(-3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 88);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.reg_donor);
            this.panel2.Location = new System.Drawing.Point(-3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 85);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.regi_reci);
            this.panel3.Location = new System.Drawing.Point(-3, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 84);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Controls.Add(this.exit);
            this.panel4.Location = new System.Drawing.Point(0, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 84);
            this.panel4.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 382);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BLOOD BANK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button reg_donor;
        private System.Windows.Forms.Button regi_reci;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

