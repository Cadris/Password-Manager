namespace Password_Manager.Forms
{
    partial class genPasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordLengthTBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fixedTextBox = new System.Windows.Forms.TextBox();
            this.fixedTextBoxEnable = new System.Windows.Forms.CheckBox();
            this.checkSpecial = new System.Windows.Forms.CheckBox();
            this.checkSmall = new System.Windows.Forms.CheckBox();
            this.checkBlock = new System.Windows.Forms.CheckBox();
            this.checkNum = new System.Windows.Forms.CheckBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.statusBar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenaratePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnCopy = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip10 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genarate Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Password Length : ";
            // 
            // passwordLengthTBox
            // 
            this.passwordLengthTBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLengthTBox.Location = new System.Drawing.Point(185, 66);
            this.passwordLengthTBox.Name = "passwordLengthTBox";
            this.passwordLengthTBox.Size = new System.Drawing.Size(270, 20);
            this.passwordLengthTBox.TabIndex = 2;
            this.passwordLengthTBox.Text = "8";
            this.toolTip1.SetToolTip(this.passwordLengthTBox, "Enter Only Numeric Value below 100 Charecter");
            this.passwordLengthTBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.fixedTextBox);
            this.groupBox1.Controls.Add(this.fixedTextBoxEnable);
            this.groupBox1.Controls.Add(this.checkSpecial);
            this.groupBox1.Controls.Add(this.checkSmall);
            this.groupBox1.Controls.Add(this.checkBlock);
            this.groupBox1.Controls.Add(this.checkNum);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(28, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Panel";
            this.toolTip7.SetToolTip(this.groupBox1, "Enter Text here ");
            // 
            // fixedTextBox
            // 
            this.fixedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fixedTextBox.Enabled = false;
            this.fixedTextBox.Location = new System.Drawing.Point(143, 72);
            this.fixedTextBox.Name = "fixedTextBox";
            this.fixedTextBox.Size = new System.Drawing.Size(270, 20);
            this.fixedTextBox.TabIndex = 2;
            this.toolTip7.SetToolTip(this.fixedTextBox, "Enter Fixed Text Here");
            // 
            // fixedTextBoxEnable
            // 
            this.fixedTextBoxEnable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fixedTextBoxEnable.AutoSize = true;
            this.fixedTextBoxEnable.Location = new System.Drawing.Point(9, 74);
            this.fixedTextBoxEnable.Name = "fixedTextBoxEnable";
            this.fixedTextBoxEnable.Size = new System.Drawing.Size(128, 17);
            this.fixedTextBoxEnable.TabIndex = 1;
            this.fixedTextBoxEnable.Text = "Include a Fixed Text :";
            this.toolTip6.SetToolTip(this.fixedTextBoxEnable, "Select this to Enable a fixed text in the password.\r\n\r\nFixed Text in the password" +
        " means that a fixed text\r\nincluded in the textbox will be always be present in t" +
        "he \r\ngenarated password.");
            this.fixedTextBoxEnable.UseVisualStyleBackColor = true;
            this.fixedTextBoxEnable.CheckedChanged += new System.EventHandler(this.fixedTextBoxEnable_CheckedChanged);
            // 
            // checkSpecial
            // 
            this.checkSpecial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkSpecial.AutoSize = true;
            this.checkSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSpecial.Location = new System.Drawing.Point(208, 23);
            this.checkSpecial.Name = "checkSpecial";
            this.checkSpecial.Size = new System.Drawing.Size(205, 19);
            this.checkSpecial.TabIndex = 0;
            this.checkSpecial.Text = "Includes Special Charecters";
            this.toolTip3.SetToolTip(this.checkSpecial, "Includes Special Charecters in the Password Like \r\nEx:- !@#$%^&*/?");
            this.checkSpecial.UseVisualStyleBackColor = true;
            this.checkSpecial.CheckedChanged += new System.EventHandler(this.checkSpecial_CheckedChanged);
            // 
            // checkSmall
            // 
            this.checkSmall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkSmall.AutoSize = true;
            this.checkSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSmall.Location = new System.Drawing.Point(208, 48);
            this.checkSmall.Name = "checkSmall";
            this.checkSmall.Size = new System.Drawing.Size(179, 20);
            this.checkSmall.TabIndex = 0;
            this.checkSmall.Text = "Includes Small Letters";
            this.toolTip5.SetToolTip(this.checkSmall, "Includes alphabets in Capital Letters in the Password Like \r\nEx:- abcdefgh......." +
        "\r\n");
            this.checkSmall.UseVisualStyleBackColor = true;
            this.checkSmall.CheckedChanged += new System.EventHandler(this.checkSmall_CheckedChanged);
            // 
            // checkBlock
            // 
            this.checkBlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBlock.AutoSize = true;
            this.checkBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBlock.Location = new System.Drawing.Point(9, 48);
            this.checkBlock.Name = "checkBlock";
            this.checkBlock.Size = new System.Drawing.Size(179, 20);
            this.checkBlock.TabIndex = 0;
            this.checkBlock.Text = "Includes Block Letters";
            this.toolTip4.SetToolTip(this.checkBlock, "Includes alphabets in Capital Letters in the Password Like \r\nEx:- ABCDEFGH.....");
            this.checkBlock.UseVisualStyleBackColor = true;
            this.checkBlock.CheckedChanged += new System.EventHandler(this.checkBlock_CheckedChanged);
            // 
            // checkNum
            // 
            this.checkNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkNum.AutoSize = true;
            this.checkNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNum.Location = new System.Drawing.Point(9, 22);
            this.checkNum.Name = "checkNum";
            this.checkNum.Size = new System.Drawing.Size(151, 20);
            this.checkNum.TabIndex = 0;
            this.checkNum.Text = "Includes Numbers";
            this.toolTip2.SetToolTip(this.checkNum, "Includes Numbers in the Password Like Ex:- 1,2,3,4,5.....");
            this.checkNum.UseVisualStyleBackColor = true;
            this.checkNum.CheckedChanged += new System.EventHandler(this.checkNum_CheckedChanged);
            // 
            // resultBox
            // 
            this.resultBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultBox.Location = new System.Drawing.Point(28, 256);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(332, 20);
            this.resultBox.TabIndex = 4;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip8.SetToolTip(this.resultBox, "Shows The Genatared Password.\r\n\r\nIf nothing is shown, then it means no \r\npassword" +
        " has been genarated tilll now.");
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = true;
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusBar.Location = new System.Drawing.Point(49, 0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(126, 13);
            this.statusBar.TabIndex = 7;
            this.statusBar.Text = "No Operations Performed";
            this.statusBar.Click += new System.EventHandler(this.statusBar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusBar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 18);
            this.panel1.TabIndex = 8;
            // 
            // btnGenaratePassword
            // 
            this.btnGenaratePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenaratePassword.AutoRoundedCorners = true;
            this.btnGenaratePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnGenaratePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGenaratePassword.BorderRadius = 14;
            this.btnGenaratePassword.BorderThickness = 2;
            this.btnGenaratePassword.CheckedState.Parent = this.btnGenaratePassword;
            this.btnGenaratePassword.CustomImages.Parent = this.btnGenaratePassword;
            this.btnGenaratePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.btnGenaratePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenaratePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGenaratePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(125)))), ((int)(((byte)(217)))));
            this.btnGenaratePassword.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGenaratePassword.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnGenaratePassword.HoverState.Image = global::Password_Manager.Properties.Resources.gears_White;
            this.btnGenaratePassword.HoverState.Parent = this.btnGenaratePassword;
            this.btnGenaratePassword.Image = global::Password_Manager.Properties.Resources.gears_Blue;
            this.btnGenaratePassword.Location = new System.Drawing.Point(28, 292);
            this.btnGenaratePassword.Name = "btnGenaratePassword";
            this.btnGenaratePassword.ShadowDecoration.BorderRadius = 19;
            this.btnGenaratePassword.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGenaratePassword.ShadowDecoration.Enabled = true;
            this.btnGenaratePassword.ShadowDecoration.Parent = this.btnGenaratePassword;
            this.btnGenaratePassword.Size = new System.Drawing.Size(427, 31);
            this.btnGenaratePassword.TabIndex = 9;
            this.btnGenaratePassword.Text = "Genarate Password";
            this.toolTip10.SetToolTip(this.btnGenaratePassword, "Click to Genarate A new Password Based on the selected settings above ");
            this.btnGenaratePassword.Click += new System.EventHandler(this.btnGenaratePassword_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnCopy.IconColor = System.Drawing.Color.Black;
            this.btnCopy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopy.IconSize = 20;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.Location = new System.Drawing.Point(366, 254);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(89, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.toolTip9.SetToolTip(this.btnCopy, "Copy the Genarated Password to Clipboard");
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status :: ";
            // 
            // genPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(481, 372);
            this.Controls.Add(this.btnGenaratePassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.passwordLengthTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "genPasswordForm";
            this.Text = "genPasswordForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordLengthTBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fixedTextBox;
        private System.Windows.Forms.CheckBox fixedTextBoxEnable;
        private System.Windows.Forms.CheckBox checkSpecial;
        private System.Windows.Forms.CheckBox checkSmall;
        private System.Windows.Forms.CheckBox checkBlock;
        private System.Windows.Forms.CheckBox checkNum;
        private System.Windows.Forms.TextBox resultBox;
        private FontAwesome.Sharp.IconButton btnCopy;
        private System.Windows.Forms.Label statusBar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnGenaratePassword;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip9;
        private System.Windows.Forms.ToolTip toolTip10;
        private System.Windows.Forms.Label label3;
    }
}