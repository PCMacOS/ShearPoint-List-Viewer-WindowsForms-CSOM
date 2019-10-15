namespace WindowsFormsAppShearPoint
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.conectButton = new System.Windows.Forms.Button();
            this.logsTextBox = new System.Windows.Forms.TextBox();
            this.dataGridGetList = new System.Windows.Forms.DataGridView();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.buttonLoadRecords = new System.Windows.Forms.Button();
            this.buttonLoadPermisions = new System.Windows.Forms.Button();
            this.conectSiteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGetList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(59, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(167, 20);
            this.txtUrl.TabIndex = 0;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(12, 17);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(41, 13);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "Site Url";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(232, 15);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(60, 13);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "User Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(298, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(404, 15);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(53, 13);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(463, 12);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 4;
            // 
            // conectButton
            // 
            this.conectButton.Location = new System.Drawing.Point(569, 45);
            this.conectButton.Name = "conectButton";
            this.conectButton.Size = new System.Drawing.Size(117, 23);
            this.conectButton.TabIndex = 6;
            this.conectButton.Text = "Load List";
            this.conectButton.UseVisualStyleBackColor = true;
            this.conectButton.Click += new System.EventHandler(this.LoadLists);
            // 
            // logsTextBox
            // 
            this.logsTextBox.Location = new System.Drawing.Point(692, 12);
            this.logsTextBox.Multiline = true;
            this.logsTextBox.Name = "logsTextBox";
            this.logsTextBox.Size = new System.Drawing.Size(375, 429);
            this.logsTextBox.TabIndex = 7;
            // 
            // dataGridGetList
            // 
            this.dataGridGetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGetList.Location = new System.Drawing.Point(15, 74);
            this.dataGridGetList.Name = "dataGridGetList";
            this.dataGridGetList.Size = new System.Drawing.Size(671, 166);
            this.dataGridGetList.TabIndex = 8;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(15, 275);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(671, 166);
            this.dataGridViewList.TabIndex = 9;
            // 
            // buttonLoadRecords
            // 
            this.buttonLoadRecords.Location = new System.Drawing.Point(15, 246);
            this.buttonLoadRecords.Name = "buttonLoadRecords";
            this.buttonLoadRecords.Size = new System.Drawing.Size(99, 23);
            this.buttonLoadRecords.TabIndex = 10;
            this.buttonLoadRecords.Text = "Load Records";
            this.buttonLoadRecords.UseVisualStyleBackColor = true;
            this.buttonLoadRecords.Click += new System.EventHandler(this.ButtonLoadRecords_Click);
            // 
            // buttonLoadPermisions
            // 
            this.buttonLoadPermisions.Location = new System.Drawing.Point(129, 246);
            this.buttonLoadPermisions.Name = "buttonLoadPermisions";
            this.buttonLoadPermisions.Size = new System.Drawing.Size(97, 23);
            this.buttonLoadPermisions.TabIndex = 11;
            this.buttonLoadPermisions.Text = "Load Permitions";
            this.buttonLoadPermisions.UseVisualStyleBackColor = true;
            this.buttonLoadPermisions.Click += new System.EventHandler(this.ButtonLoadPermisions_Click);
            // 
            // conectSiteButton
            // 
            this.conectSiteButton.Location = new System.Drawing.Point(570, 12);
            this.conectSiteButton.Name = "conectSiteButton";
            this.conectSiteButton.Size = new System.Drawing.Size(116, 23);
            this.conectSiteButton.TabIndex = 12;
            this.conectSiteButton.Text = "Conect to ShearPoint Site";
            this.conectSiteButton.UseVisualStyleBackColor = true;
            this.conectSiteButton.Click += new System.EventHandler(this.ConectSiteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 453);
            this.Controls.Add(this.conectSiteButton);
            this.Controls.Add(this.buttonLoadPermisions);
            this.Controls.Add(this.buttonLoadRecords);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.dataGridGetList);
            this.Controls.Add(this.logsTextBox);
            this.Controls.Add(this.conectButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGetList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button conectButton;
        private System.Windows.Forms.TextBox logsTextBox;
        private System.Windows.Forms.DataGridView dataGridGetList;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonLoadRecords;
        private System.Windows.Forms.Button buttonLoadPermisions;
        private System.Windows.Forms.Button conectSiteButton;
    }
}

