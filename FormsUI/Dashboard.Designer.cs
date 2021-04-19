
namespace FormsUI
{
    partial class Dashboard
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
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.firstInsertNameText = new System.Windows.Forms.TextBox();
            this.firstNameInsertLabel = new System.Windows.Forms.Label();
            this.lastNameInsertText = new System.Windows.Forms.TextBox();
            this.lastNameInsertLabel = new System.Windows.Forms.Label();
            this.emailInsertText = new System.Windows.Forms.TextBox();
            this.emailInsertLabel = new System.Windows.Forms.Label();
            this.mobileInsertText = new System.Windows.Forms.TextBox();
            this.mobileInsertLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 23;
            this.peopleFoundListBox.Location = new System.Drawing.Point(54, 210);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(485, 140);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(418, 160);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 31);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNameLabel.Location = new System.Drawing.Point(50, 125);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 23);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "LAST NAME";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(170, 122);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(369, 30);
            this.lastNameText.TabIndex = 3;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(198, 25);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(209, 38);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "NAME FINDER";
            // 
            // firstInsertNameText
            // 
            this.firstInsertNameText.Location = new System.Drawing.Point(170, 367);
            this.firstInsertNameText.Name = "firstInsertNameText";
            this.firstInsertNameText.Size = new System.Drawing.Size(369, 30);
            this.firstInsertNameText.TabIndex = 6;
            // 
            // firstNameInsertLabel
            // 
            this.firstNameInsertLabel.AutoSize = true;
            this.firstNameInsertLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameInsertLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNameInsertLabel.Location = new System.Drawing.Point(50, 370);
            this.firstNameInsertLabel.Name = "firstNameInsertLabel";
            this.firstNameInsertLabel.Size = new System.Drawing.Size(110, 23);
            this.firstNameInsertLabel.TabIndex = 5;
            this.firstNameInsertLabel.Text = "FIRST NAME";
            // 
            // lastNameInsertText
            // 
            this.lastNameInsertText.Location = new System.Drawing.Point(170, 417);
            this.lastNameInsertText.Name = "lastNameInsertText";
            this.lastNameInsertText.Size = new System.Drawing.Size(369, 30);
            this.lastNameInsertText.TabIndex = 8;
            // 
            // lastNameInsertLabel
            // 
            this.lastNameInsertLabel.AutoSize = true;
            this.lastNameInsertLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInsertLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNameInsertLabel.Location = new System.Drawing.Point(50, 420);
            this.lastNameInsertLabel.Name = "lastNameInsertLabel";
            this.lastNameInsertLabel.Size = new System.Drawing.Size(106, 23);
            this.lastNameInsertLabel.TabIndex = 7;
            this.lastNameInsertLabel.Text = "LAST NAME";
            // 
            // emailInsertText
            // 
            this.emailInsertText.Location = new System.Drawing.Point(170, 476);
            this.emailInsertText.Name = "emailInsertText";
            this.emailInsertText.Size = new System.Drawing.Size(369, 30);
            this.emailInsertText.TabIndex = 10;
            // 
            // emailInsertLabel
            // 
            this.emailInsertLabel.AutoSize = true;
            this.emailInsertLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInsertLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emailInsertLabel.Location = new System.Drawing.Point(50, 479);
            this.emailInsertLabel.Name = "emailInsertLabel";
            this.emailInsertLabel.Size = new System.Drawing.Size(61, 23);
            this.emailInsertLabel.TabIndex = 9;
            this.emailInsertLabel.Text = "EMAIL";
            // 
            // mobileInsertText
            // 
            this.mobileInsertText.Location = new System.Drawing.Point(170, 537);
            this.mobileInsertText.Name = "mobileInsertText";
            this.mobileInsertText.Size = new System.Drawing.Size(369, 30);
            this.mobileInsertText.TabIndex = 12;
            // 
            // mobileInsertLabel
            // 
            this.mobileInsertLabel.AutoSize = true;
            this.mobileInsertLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileInsertLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mobileInsertLabel.Location = new System.Drawing.Point(50, 540);
            this.mobileInsertLabel.Name = "mobileInsertLabel";
            this.mobileInsertLabel.Size = new System.Drawing.Size(73, 23);
            this.mobileInsertLabel.TabIndex = 11;
            this.mobileInsertLabel.Text = "MOBILE";
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.ForeColor = System.Drawing.Color.White;
            this.insertButton.Location = new System.Drawing.Point(418, 582);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(121, 31);
            this.insertButton.TabIndex = 13;
            this.insertButton.Text = "INSERT";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(589, 647);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.mobileInsertText);
            this.Controls.Add(this.mobileInsertLabel);
            this.Controls.Add(this.emailInsertText);
            this.Controls.Add(this.emailInsertLabel);
            this.Controls.Add(this.lastNameInsertText);
            this.Controls.Add(this.lastNameInsertLabel);
            this.Controls.Add(this.firstInsertNameText);
            this.Controls.Add(this.firstNameInsertLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.peopleFoundListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox firstInsertNameText;
        private System.Windows.Forms.Label firstNameInsertLabel;
        private System.Windows.Forms.TextBox lastNameInsertText;
        private System.Windows.Forms.Label lastNameInsertLabel;
        private System.Windows.Forms.TextBox emailInsertText;
        private System.Windows.Forms.Label emailInsertLabel;
        private System.Windows.Forms.TextBox mobileInsertText;
        private System.Windows.Forms.Label mobileInsertLabel;
        private System.Windows.Forms.Button insertButton;
    }
}

