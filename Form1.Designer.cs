namespace tamogochiApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tamogochiImage = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.FeedButton = new System.Windows.Forms.Button();
            this.healButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.changeNameL = new System.Windows.Forms.Label();
            this.tamogochiName = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.talkButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.RandomIll = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tamogochiImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tamogochiImage
            // 
            this.tamogochiImage.Image = ((System.Drawing.Image)(resources.GetObject("tamogochiImage.Image")));
            this.tamogochiImage.Location = new System.Drawing.Point(153, 84);
            this.tamogochiImage.Name = "tamogochiImage";
            this.tamogochiImage.Size = new System.Drawing.Size(200, 150);
            this.tamogochiImage.TabIndex = 0;
            this.tamogochiImage.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(12, 79);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(124, 39);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // FeedButton
            // 
            this.FeedButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.FeedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FeedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FeedButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedButton.Location = new System.Drawing.Point(12, 124);
            this.FeedButton.Name = "FeedButton";
            this.FeedButton.Size = new System.Drawing.Size(124, 39);
            this.FeedButton.TabIndex = 2;
            this.FeedButton.Text = "Feed";
            this.FeedButton.UseVisualStyleBackColor = false;
            this.FeedButton.Click += new System.EventHandler(this.FeedButton_Click);
            // 
            // healButton
            // 
            this.healButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.healButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.healButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.healButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healButton.Location = new System.Drawing.Point(12, 169);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(124, 39);
            this.healButton.TabIndex = 3;
            this.healButton.Text = "Heal";
            this.healButton.UseVisualStyleBackColor = false;
            this.healButton.Click += new System.EventHandler(this.healButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(153, 265);
            this.nameTextBox.MaxLength = 15;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.White;
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(280, 265);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(73, 20);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // changeNameL
            // 
            this.changeNameL.BackColor = System.Drawing.Color.Transparent;
            this.changeNameL.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeNameL.ForeColor = System.Drawing.Color.White;
            this.changeNameL.Location = new System.Drawing.Point(151, 251);
            this.changeNameL.Name = "changeNameL";
            this.changeNameL.Size = new System.Drawing.Size(101, 11);
            this.changeNameL.TabIndex = 6;
            this.changeNameL.Text = "Change Name:";
            // 
            // tamogochiName
            // 
            this.tamogochiName.AutoSize = true;
            this.tamogochiName.BackColor = System.Drawing.Color.Transparent;
            this.tamogochiName.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamogochiName.ForeColor = System.Drawing.Color.White;
            this.tamogochiName.Location = new System.Drawing.Point(150, 68);
            this.tamogochiName.Name = "tamogochiName";
            this.tamogochiName.Size = new System.Drawing.Size(133, 13);
            this.tamogochiName.TabIndex = 7;
            this.tamogochiName.Text = "Tamogochi Name";
            this.tamogochiName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(12, 22);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(61, 11);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "Score: ";
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.White;
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(280, 321);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 20);
            this.helpButton.TabIndex = 9;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // talkButton
            // 
            this.talkButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.talkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.talkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.talkButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talkButton.Location = new System.Drawing.Point(12, 214);
            this.talkButton.Name = "talkButton";
            this.talkButton.Size = new System.Drawing.Size(124, 39);
            this.talkButton.TabIndex = 10;
            this.talkButton.Text = "Talk";
            this.talkButton.UseVisualStyleBackColor = false;
            this.talkButton.Click += new System.EventHandler(this.talkButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(12, 321);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 20);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RandomIll
            // 
            this.RandomIll.Enabled = true;
            this.RandomIll.Interval = 10000;
            this.RandomIll.Tick += new System.EventHandler(this.RandomIll_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(372, 353);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.talkButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.tamogochiName);
            this.Controls.Add(this.changeNameL);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.healButton);
            this.Controls.Add(this.FeedButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.tamogochiImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tamogochi";
            ((System.ComponentModel.ISupportInitialize)(this.tamogochiImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tamogochiImage;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button FeedButton;
        private System.Windows.Forms.Button healButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label changeNameL;
        private System.Windows.Forms.Label tamogochiName;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button talkButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Timer RandomIll;

    }
}

