
namespace Splash
{
    partial class UserRecordForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRecordForm));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nametxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.agetxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pntxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addresstxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.savebtn = new Guna.UI2.WinForms.Guna2Button();
            this.updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.button2 = new System.Windows.Forms.Button();
            this.passtxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(176)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(812, 12);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Card";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name :";
            // 
            // nametxtbox
            // 
            this.nametxtbox.BorderRadius = 10;
            this.nametxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxtbox.DefaultText = "";
            this.nametxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nametxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nametxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametxtbox.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.nametxtbox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nametxtbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametxtbox.Location = new System.Drawing.Point(248, 105);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.PasswordChar = '\0';
            this.nametxtbox.PlaceholderText = "Name..";
            this.nametxtbox.SelectedText = "";
            this.nametxtbox.Size = new System.Drawing.Size(429, 41);
            this.nametxtbox.TabIndex = 4;
            // 
            // agetxtbox
            // 
            this.agetxtbox.BorderRadius = 10;
            this.agetxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.agetxtbox.DefaultText = "";
            this.agetxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.agetxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.agetxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.agetxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.agetxtbox.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.agetxtbox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.agetxtbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.agetxtbox.Location = new System.Drawing.Point(248, 163);
            this.agetxtbox.Name = "agetxtbox";
            this.agetxtbox.PasswordChar = '\0';
            this.agetxtbox.PlaceholderText = "Age..";
            this.agetxtbox.SelectedText = "";
            this.agetxtbox.Size = new System.Drawing.Size(429, 41);
            this.agetxtbox.TabIndex = 6;
            this.agetxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.agetxtbox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age :";
            // 
            // Pntxtbox
            // 
            this.Pntxtbox.BorderRadius = 10;
            this.Pntxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pntxtbox.DefaultText = "";
            this.Pntxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pntxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pntxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pntxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pntxtbox.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.Pntxtbox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Pntxtbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pntxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pntxtbox.Location = new System.Drawing.Point(248, 221);
            this.Pntxtbox.Name = "Pntxtbox";
            this.Pntxtbox.PasswordChar = '\0';
            this.Pntxtbox.PlaceholderText = "PhoneNumber..";
            this.Pntxtbox.SelectedText = "";
            this.Pntxtbox.Size = new System.Drawing.Size(429, 41);
            this.Pntxtbox.TabIndex = 8;
            this.Pntxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pntxtbox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone Number :";
            // 
            // addresstxtbox
            // 
            this.addresstxtbox.BorderRadius = 10;
            this.addresstxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addresstxtbox.DefaultText = "";
            this.addresstxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addresstxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addresstxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addresstxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addresstxtbox.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.addresstxtbox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addresstxtbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addresstxtbox.Location = new System.Drawing.Point(248, 279);
            this.addresstxtbox.Name = "addresstxtbox";
            this.addresstxtbox.PasswordChar = '\0';
            this.addresstxtbox.PlaceholderText = "Address..";
            this.addresstxtbox.SelectedText = "";
            this.addresstxtbox.Size = new System.Drawing.Size(429, 41);
            this.addresstxtbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(15, 539);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(71, 22);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "User ID";
            this.labelID.Visible = false;
            // 
            // savebtn
            // 
            this.savebtn.BorderRadius = 20;
            this.savebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.savebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.savebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.savebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.savebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(176)))));
            this.savebtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(227, 520);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(154, 61);
            this.savebtn.TabIndex = 17;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BorderRadius = 20;
            this.updatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(420, 520);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(154, 61);
            this.updatebtn.TabIndex = 18;
            this.updatebtn.Text = "Update";
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BorderRadius = 20;
            this.cancelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cancelbtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(613, 520);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(154, 61);
            this.cancelbtn.TabIndex = 19;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(765, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 32);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // passtxtbox
            // 
            this.passtxtbox.BorderRadius = 10;
            this.passtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxtbox.DefaultText = "";
            this.passtxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passtxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passtxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passtxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passtxtbox.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.passtxtbox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passtxtbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passtxtbox.Location = new System.Drawing.Point(248, 459);
            this.passtxtbox.Name = "passtxtbox";
            this.passtxtbox.PasswordChar = '\0';
            this.passtxtbox.PlaceholderText = "Password..";
            this.passtxtbox.SelectedText = "";
            this.passtxtbox.Size = new System.Drawing.Size(429, 41);
            this.passtxtbox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Password :";
            // 
            // Role
            // 
            this.Role.AutoRoundedCorners = true;
            this.Role.BackColor = System.Drawing.Color.Transparent;
            this.Role.BorderRadius = 17;
            this.Role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Role.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Role.ItemHeight = 30;
            this.Role.Items.AddRange(new object[] {
            "Owner",
            "Admin",
            "Cashier",
            "Seller",
            "Employee"});
            this.Role.Location = new System.Drawing.Point(248, 337);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(429, 36);
            this.Role.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Role :";
            // 
            // guna2CustomCheckBox1
            // 
            this.guna2CustomCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox1.Checked = true;
            this.guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2CustomCheckBox1.CheckedState.BorderRadius = 15;
            this.guna2CustomCheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(176)))));
            this.guna2CustomCheckBox1.CheckMarkColor = System.Drawing.SystemColors.MenuText;
            this.guna2CustomCheckBox1.Location = new System.Drawing.Point(439, 390);
            this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.Size = new System.Drawing.Size(46, 52);
            this.guna2CustomCheckBox1.TabIndex = 26;
            this.guna2CustomCheckBox1.Text = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 15;
            this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Available :";
            // 
            // UserRecordForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(812, 590);
            this.Controls.Add(this.guna2CustomCheckBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passtxtbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.addresstxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pntxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agetxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRecordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button cancelbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2TextBox nametxtbox;
        public Guna.UI2.WinForms.Guna2TextBox addresstxtbox;
        public Guna.UI2.WinForms.Guna2TextBox Pntxtbox;
        public Guna.UI2.WinForms.Guna2TextBox agetxtbox;
        public System.Windows.Forms.Label labelID;
        public Guna.UI2.WinForms.Guna2Button updatebtn;
        public Guna.UI2.WinForms.Guna2Button savebtn;
        public Guna.UI2.WinForms.Guna2TextBox passtxtbox;
        public Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;
        public Guna.UI2.WinForms.Guna2ComboBox Role;
    }
}