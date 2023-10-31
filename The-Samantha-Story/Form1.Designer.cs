namespace The_Samantha_Story
{
    partial class theSamanthaStory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(theSamanthaStory));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.defendButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.characterScreen = new System.Windows.Forms.Label();
            this.gameSaves = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.Label();
            this.inventoryScreen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(288, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(915, 534);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(288, 769);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(915, 36);
            this.progressBar1.TabIndex = 1;
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.yesButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Location = new System.Drawing.Point(288, 552);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(190, 82);
            this.yesButton.TabIndex = 2;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.noButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.noButton.Location = new System.Drawing.Point(484, 552);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(190, 82);
            this.noButton.TabIndex = 3;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.saveButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(1024, 568);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(179, 50);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // attackButton
            // 
            this.attackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.attackButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.Location = new System.Drawing.Point(680, 552);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(166, 82);
            this.attackButton.TabIndex = 5;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // defendButton
            // 
            this.defendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.defendButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defendButton.Location = new System.Drawing.Point(852, 552);
            this.defendButton.Name = "defendButton";
            this.defendButton.Size = new System.Drawing.Size(166, 82);
            this.defendButton.TabIndex = 6;
            this.defendButton.Text = "Defend";
            this.defendButton.UseVisualStyleBackColor = false;
            this.defendButton.Click += new System.EventHandler(this.defendButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(261, 253);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 626);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(223, 179);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // characterScreen
            // 
            this.characterScreen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.characterScreen.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.characterScreen.Location = new System.Drawing.Point(13, 304);
            this.characterScreen.Name = "characterScreen";
            this.characterScreen.Size = new System.Drawing.Size(260, 19);
            this.characterScreen.TabIndex = 10;
            this.characterScreen.Text = "Character";
            this.characterScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameSaves
            // 
            this.gameSaves.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gameSaves.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameSaves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gameSaves.Location = new System.Drawing.Point(13, 15);
            this.gameSaves.Name = "gameSaves";
            this.gameSaves.Size = new System.Drawing.Size(260, 26);
            this.gameSaves.TabIndex = 11;
            this.gameSaves.Text = "Game Saves";
            this.gameSaves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.progressBar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.progressBar.Location = new System.Drawing.Point(288, 711);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(915, 40);
            this.progressBar.TabIndex = 12;
            this.progressBar.Text = "Progress Bar";
            this.progressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inventoryScreen
            // 
            this.inventoryScreen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.inventoryScreen.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryScreen.Location = new System.Drawing.Point(13, 603);
            this.inventoryScreen.Name = "inventoryScreen";
            this.inventoryScreen.Size = new System.Drawing.Size(190, 20);
            this.inventoryScreen.TabIndex = 13;
            this.inventoryScreen.Text = "Inventory";
            this.inventoryScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // theSamanthaStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1228, 817);
            this.Controls.Add(this.inventoryScreen);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.gameSaves);
            this.Controls.Add(this.characterScreen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.defendButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "theSamanthaStory";
            this.Text = "The Samanatha Story";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button defendButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label characterScreen;
        private System.Windows.Forms.Label gameSaves;
        private System.Windows.Forms.Label progressBar;
        private System.Windows.Forms.Label inventoryScreen;
    }
}

