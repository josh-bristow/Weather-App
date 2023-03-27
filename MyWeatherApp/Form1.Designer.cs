namespace MyWeatherApp
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
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblWindSpeed2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTemperature2 = new System.Windows.Forms.Label();
            this.txtBoxCitySearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureForecastDay2 = new System.Windows.Forms.PictureBox();
            this.pictureMain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTemperature3 = new System.Windows.Forms.Label();
            this.lblWindSpeed3 = new System.Windows.Forms.Label();
            this.lblDescription3 = new System.Windows.Forms.Label();
            this.pictureForecastDay3 = new System.Windows.Forms.PictureBox();
            this.lblDay3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCityException = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureForecastDay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureForecastDay3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.BackColor = System.Drawing.Color.Transparent;
            this.lblCityName.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityName.ForeColor = System.Drawing.Color.White;
            this.lblCityName.Location = new System.Drawing.Point(535, 39);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(183, 61);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "Durban";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Lime;
            this.lblCountry.Location = new System.Drawing.Point(539, 100);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(55, 41);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "ZA";
            this.lblCountry.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperature.Font = new System.Drawing.Font("Calibri", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.Color.White;
            this.lblTemperature.Location = new System.Drawing.Point(230, 154);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(79, 91);
            this.lblTemperature.TabIndex = 2;
            this.lblTemperature.Text = "C";
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.BackColor = System.Drawing.Color.Transparent;
            this.lblDay2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay2.ForeColor = System.Drawing.Color.White;
            this.lblDay2.Location = new System.Drawing.Point(969, 100);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(71, 41);
            this.lblDay2.TabIndex = 5;
            this.lblDay2.Text = "Day";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.ForeColor = System.Drawing.Color.White;
            this.lblDescription2.Location = new System.Drawing.Point(934, 253);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(144, 33);
            this.lblDescription2.TabIndex = 7;
            this.lblDescription2.Text = "Description";
            this.lblDescription2.Click += new System.EventHandler(this.lblDescription2_Click);
            // 
            // lblWindSpeed2
            // 
            this.lblWindSpeed2.AutoSize = true;
            this.lblWindSpeed2.BackColor = System.Drawing.Color.Transparent;
            this.lblWindSpeed2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed2.ForeColor = System.Drawing.Color.White;
            this.lblWindSpeed2.Location = new System.Drawing.Point(1127, 212);
            this.lblWindSpeed2.Name = "lblWindSpeed2";
            this.lblWindSpeed2.Size = new System.Drawing.Size(76, 33);
            this.lblWindSpeed2.TabIndex = 8;
            this.lblWindSpeed2.Text = "km/h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(932, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 61);
            this.label5.TabIndex = 9;
            this.label5.Text = "Forecast";
            // 
            // lblTemperature2
            // 
            this.lblTemperature2.AutoSize = true;
            this.lblTemperature2.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperature2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature2.ForeColor = System.Drawing.Color.White;
            this.lblTemperature2.Location = new System.Drawing.Point(1011, 173);
            this.lblTemperature2.Name = "lblTemperature2";
            this.lblTemperature2.Size = new System.Drawing.Size(29, 33);
            this.lblTemperature2.TabIndex = 10;
            this.lblTemperature2.Text = "C";
            // 
            // txtBoxCitySearch
            // 
            this.txtBoxCitySearch.Location = new System.Drawing.Point(50, 43);
            this.txtBoxCitySearch.Name = "txtBoxCitySearch";
            this.txtBoxCitySearch.Size = new System.Drawing.Size(176, 22);
            this.txtBoxCitySearch.TabIndex = 11;
            this.txtBoxCitySearch.Text = "Search for a city...";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(246, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 34);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureForecastDay2
            // 
            this.pictureForecastDay2.BackColor = System.Drawing.Color.Transparent;
            this.pictureForecastDay2.Image = global::MyWeatherApp.Properties.Resources.storm;
            this.pictureForecastDay2.Location = new System.Drawing.Point(792, 173);
            this.pictureForecastDay2.Name = "pictureForecastDay2";
            this.pictureForecastDay2.Size = new System.Drawing.Size(136, 113);
            this.pictureForecastDay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureForecastDay2.TabIndex = 4;
            this.pictureForecastDay2.TabStop = false;
            // 
            // pictureMain
            // 
            this.pictureMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureMain.Image = global::MyWeatherApp.Properties.Resources.storm;
            this.pictureMain.Location = new System.Drawing.Point(49, 154);
            this.pictureMain.Name = "pictureMain";
            this.pictureMain.Size = new System.Drawing.Size(175, 128);
            this.pictureMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMain.TabIndex = 3;
            this.pictureMain.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(934, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wind Speed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(934, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Wind Speed:";
            // 
            // lblTemperature3
            // 
            this.lblTemperature3.AutoSize = true;
            this.lblTemperature3.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperature3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature3.ForeColor = System.Drawing.Color.White;
            this.lblTemperature3.Location = new System.Drawing.Point(1011, 375);
            this.lblTemperature3.Name = "lblTemperature3";
            this.lblTemperature3.Size = new System.Drawing.Size(29, 33);
            this.lblTemperature3.TabIndex = 17;
            this.lblTemperature3.Text = "C";
            // 
            // lblWindSpeed3
            // 
            this.lblWindSpeed3.AutoSize = true;
            this.lblWindSpeed3.BackColor = System.Drawing.Color.Transparent;
            this.lblWindSpeed3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed3.ForeColor = System.Drawing.Color.White;
            this.lblWindSpeed3.Location = new System.Drawing.Point(1127, 414);
            this.lblWindSpeed3.Name = "lblWindSpeed3";
            this.lblWindSpeed3.Size = new System.Drawing.Size(76, 33);
            this.lblWindSpeed3.TabIndex = 16;
            this.lblWindSpeed3.Text = "km/h";
            // 
            // lblDescription3
            // 
            this.lblDescription3.AutoSize = true;
            this.lblDescription3.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription3.ForeColor = System.Drawing.Color.White;
            this.lblDescription3.Location = new System.Drawing.Point(934, 455);
            this.lblDescription3.Name = "lblDescription3";
            this.lblDescription3.Size = new System.Drawing.Size(144, 33);
            this.lblDescription3.TabIndex = 15;
            this.lblDescription3.Text = "Description";
            // 
            // pictureForecastDay3
            // 
            this.pictureForecastDay3.BackColor = System.Drawing.Color.Transparent;
            this.pictureForecastDay3.Image = global::MyWeatherApp.Properties.Resources.storm;
            this.pictureForecastDay3.Location = new System.Drawing.Point(792, 375);
            this.pictureForecastDay3.Name = "pictureForecastDay3";
            this.pictureForecastDay3.Size = new System.Drawing.Size(136, 113);
            this.pictureForecastDay3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureForecastDay3.TabIndex = 14;
            this.pictureForecastDay3.TabStop = false;
            // 
            // lblDay3
            // 
            this.lblDay3.AutoSize = true;
            this.lblDay3.BackColor = System.Drawing.Color.Transparent;
            this.lblDay3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay3.ForeColor = System.Drawing.Color.White;
            this.lblDay3.Location = new System.Drawing.Point(969, 317);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(71, 41);
            this.lblDay3.TabIndex = 19;
            this.lblDay3.Text = "Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(43, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 33);
            this.label6.TabIndex = 22;
            this.label6.Text = "Wind Speed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 33);
            this.label7.TabIndex = 23;
            this.label7.Text = "Humidity:";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lblHumidity.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.Color.White;
            this.lblHumidity.Location = new System.Drawing.Point(226, 322);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(35, 33);
            this.lblHumidity.TabIndex = 24;
            this.lblHumidity.Text = "%";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblWindSpeed.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.ForeColor = System.Drawing.Color.White;
            this.lblWindSpeed.Location = new System.Drawing.Point(226, 375);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(76, 33);
            this.lblWindSpeed.TabIndex = 25;
            this.lblWindSpeed.Text = "km/h";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(240, 245);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(144, 33);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "Description";
            // 
            // lblCityException
            // 
            this.lblCityException.AutoSize = true;
            this.lblCityException.BackColor = System.Drawing.Color.Transparent;
            this.lblCityException.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityException.ForeColor = System.Drawing.Color.Red;
            this.lblCityException.Location = new System.Drawing.Point(63, 69);
            this.lblCityException.Name = "lblCityException";
            this.lblCityException.Size = new System.Drawing.Size(161, 31);
            this.lblCityException.TabIndex = 27;
            this.lblCityException.Text = "City not found";
            this.lblCityException.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWeatherApp.Properties.Resources.jonathan_bowers_BqKdvJ8a5TI_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 568);
            this.Controls.Add(this.lblCityException);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDay3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTemperature3);
            this.Controls.Add(this.lblWindSpeed3);
            this.Controls.Add(this.lblDescription3);
            this.Controls.Add(this.pictureForecastDay3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxCitySearch);
            this.Controls.Add(this.lblTemperature2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWindSpeed2);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.lblDay2);
            this.Controls.Add(this.pictureForecastDay2);
            this.Controls.Add(this.pictureMain);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCityName);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1350, 615);
            this.MinimumSize = new System.Drawing.Size(1350, 615);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weatherman";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureForecastDay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureForecastDay3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.PictureBox pictureMain;
        private System.Windows.Forms.PictureBox pictureForecastDay2;
        private System.Windows.Forms.Label lblDay2;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Label lblWindSpeed2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTemperature2;
        private System.Windows.Forms.TextBox txtBoxCitySearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTemperature3;
        private System.Windows.Forms.Label lblWindSpeed3;
        private System.Windows.Forms.Label lblDescription3;
        private System.Windows.Forms.PictureBox pictureForecastDay3;
        private System.Windows.Forms.Label lblDay3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCityException;
    }
}

