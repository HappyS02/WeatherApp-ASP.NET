namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_anlikgün = new System.Windows.Forms.Label();
            this.lbl_anlikayyil = new System.Windows.Forms.Label();
            this.lbl_anlikdes = new System.Windows.Forms.Label();
            this.lbl_anlikcond = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_cityName = new System.Windows.Forms.Label();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_day_2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cond_2 = new System.Windows.Forms.Label();
            this.lbl_temp_6 = new System.Windows.Forms.Label();
            this.lbl_des_2 = new System.Windows.Forms.Label();
            this.lbl_wind_6 = new System.Windows.Forms.Label();
            this.lbl_wind_2 = new System.Windows.Forms.Label();
            this.lbl_des_6 = new System.Windows.Forms.Label();
            this.lbl_temp_2 = new System.Windows.Forms.Label();
            this.lbl_cond_6 = new System.Windows.Forms.Label();
            this.lbl_day_3 = new System.Windows.Forms.Label();
            this.lbl_day_6 = new System.Windows.Forms.Label();
            this.lbl_cond_3 = new System.Windows.Forms.Label();
            this.lbl_temp_5 = new System.Windows.Forms.Label();
            this.lbl_des_3 = new System.Windows.Forms.Label();
            this.lbl_wind_5 = new System.Windows.Forms.Label();
            this.lbl_wind_3 = new System.Windows.Forms.Label();
            this.lbl_des_5 = new System.Windows.Forms.Label();
            this.lbl_temp_3 = new System.Windows.Forms.Label();
            this.lbl_cond_5 = new System.Windows.Forms.Label();
            this.lbl_day_4 = new System.Windows.Forms.Label();
            this.lbl_day_5 = new System.Windows.Forms.Label();
            this.lbl_cond_4 = new System.Windows.Forms.Label();
            this.lbl_temp_4 = new System.Windows.Forms.Label();
            this.lbl_des_4 = new System.Windows.Forms.Label();
            this.lbl_wind_4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_anlikgün
            // 
            this.lbl_anlikgün.AutoSize = true;
            this.lbl_anlikgün.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anlikgün.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_anlikgün.ForeColor = System.Drawing.Color.White;
            this.lbl_anlikgün.Location = new System.Drawing.Point(58, 32);
            this.lbl_anlikgün.Name = "lbl_anlikgün";
            this.lbl_anlikgün.Size = new System.Drawing.Size(44, 25);
            this.lbl_anlikgün.TabIndex = 41;
            this.lbl_anlikgün.Text = "day";
            // 
            // lbl_anlikayyil
            // 
            this.lbl_anlikayyil.AutoSize = true;
            this.lbl_anlikayyil.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anlikayyil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_anlikayyil.ForeColor = System.Drawing.Color.White;
            this.lbl_anlikayyil.Location = new System.Drawing.Point(58, 61);
            this.lbl_anlikayyil.Name = "lbl_anlikayyil";
            this.lbl_anlikayyil.Size = new System.Drawing.Size(50, 25);
            this.lbl_anlikayyil.TabIndex = 42;
            this.lbl_anlikayyil.Text = "date";
            // 
            // lbl_anlikdes
            // 
            this.lbl_anlikdes.AutoSize = true;
            this.lbl_anlikdes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anlikdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_anlikdes.ForeColor = System.Drawing.Color.White;
            this.lbl_anlikdes.Location = new System.Drawing.Point(56, 146);
            this.lbl_anlikdes.Name = "lbl_anlikdes";
            this.lbl_anlikdes.Size = new System.Drawing.Size(84, 37);
            this.lbl_anlikdes.TabIndex = 43;
            this.lbl_anlikdes.Text = "desc";
            // 
            // lbl_anlikcond
            // 
            this.lbl_anlikcond.AutoSize = true;
            this.lbl_anlikcond.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anlikcond.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_anlikcond.ForeColor = System.Drawing.Color.White;
            this.lbl_anlikcond.Location = new System.Drawing.Point(54, 97);
            this.lbl_anlikcond.Name = "lbl_anlikcond";
            this.lbl_anlikcond.Size = new System.Drawing.Size(108, 46);
            this.lbl_anlikcond.TabIndex = 44;
            this.lbl_anlikcond.Text = "cond";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.BackColor = System.Drawing.Color.Transparent;
            this.lbl_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_country.ForeColor = System.Drawing.Color.White;
            this.lbl_country.Location = new System.Drawing.Point(71, 611);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(90, 29);
            this.lbl_country.TabIndex = 1;
            this.lbl_country.Text = "country";
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cityName.ForeColor = System.Drawing.Color.White;
            this.lbl_cityName.Location = new System.Drawing.Point(71, 572);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(60, 36);
            this.lbl_cityName.TabIndex = 0;
            this.lbl_cityName.Text = "city";
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Temp.ForeColor = System.Drawing.Color.White;
            this.lbl_Temp.Location = new System.Drawing.Point(49, 487);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(80, 76);
            this.lbl_Temp.TabIndex = 2;
            this.lbl_Temp.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(662, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(358, 7);
            this.label7.TabIndex = 80;
            this.label7.Text = "_________________________________________________________________________________" +
    "_____________________________________\r\n";
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGetWeather.ForeColor = System.Drawing.Color.Black;
            this.btnGetWeather.Location = new System.Drawing.Point(910, 12);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(62, 23);
            this.btnGetWeather.TabIndex = 79;
            this.btnGetWeather.Text = "Accept";
            this.btnGetWeather.UseVisualStyleBackColor = false;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(713, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 78;
            this.label6.Text = "City :";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(776, 12);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(128, 23);
            this.txtCity.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(662, 646);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 7);
            this.label5.TabIndex = 76;
            this.label5.Text = "_________________________________________________________________________________" +
    "_____________________________________\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(662, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 7);
            this.label4.TabIndex = 75;
            this.label4.Text = "_________________________________________________________________________________" +
    "_____________________________________\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(662, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 7);
            this.label3.TabIndex = 74;
            this.label3.Text = "_________________________________________________________________________________" +
    "_____________________________________\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(662, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 7);
            this.label2.TabIndex = 73;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________________________________\r\n";
            // 
            // lbl_day_2
            // 
            this.lbl_day_2.AutoSize = true;
            this.lbl_day_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day_2.ForeColor = System.Drawing.Color.White;
            this.lbl_day_2.Location = new System.Drawing.Point(888, 146);
            this.lbl_day_2.Name = "lbl_day_2";
            this.lbl_day_2.Size = new System.Drawing.Size(77, 29);
            this.lbl_day_2.TabIndex = 47;
            this.lbl_day_2.Text = "DAYS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(661, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 7);
            this.label1.TabIndex = 72;
            this.label1.Text = "_________________________________________________________________________________" +
    "_____________________________________\r\n";
            // 
            // lbl_cond_2
            // 
            this.lbl_cond_2.AutoSize = true;
            this.lbl_cond_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cond_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cond_2.ForeColor = System.Drawing.Color.White;
            this.lbl_cond_2.Location = new System.Drawing.Point(669, 80);
            this.lbl_cond_2.Name = "lbl_cond_2";
            this.lbl_cond_2.Size = new System.Drawing.Size(60, 25);
            this.lbl_cond_2.TabIndex = 48;
            this.lbl_cond_2.Text = "Cond";
            // 
            // lbl_temp_6
            // 
            this.lbl_temp_6.AutoSize = true;
            this.lbl_temp_6.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_temp_6.ForeColor = System.Drawing.Color.White;
            this.lbl_temp_6.Location = new System.Drawing.Point(657, 604);
            this.lbl_temp_6.Name = "lbl_temp_6";
            this.lbl_temp_6.Size = new System.Drawing.Size(42, 39);
            this.lbl_temp_6.TabIndex = 71;
            this.lbl_temp_6.Text = "C";
            // 
            // lbl_des_2
            // 
            this.lbl_des_2.AutoSize = true;
            this.lbl_des_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_des_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_des_2.ForeColor = System.Drawing.Color.White;
            this.lbl_des_2.Location = new System.Drawing.Point(669, 108);
            this.lbl_des_2.Name = "lbl_des_2";
            this.lbl_des_2.Size = new System.Drawing.Size(109, 25);
            this.lbl_des_2.TabIndex = 49;
            this.lbl_des_2.Text = "Description";
            // 
            // lbl_wind_6
            // 
            this.lbl_wind_6.AutoSize = true;
            this.lbl_wind_6.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wind_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_wind_6.ForeColor = System.Drawing.Color.White;
            this.lbl_wind_6.Location = new System.Drawing.Point(889, 539);
            this.lbl_wind_6.Name = "lbl_wind_6";
            this.lbl_wind_6.Size = new System.Drawing.Size(56, 24);
            this.lbl_wind_6.TabIndex = 70;
            this.lbl_wind_6.Text = " km/h";
            // 
            // lbl_wind_2
            // 
            this.lbl_wind_2.AutoSize = true;
            this.lbl_wind_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wind_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_wind_2.ForeColor = System.Drawing.Color.White;
            this.lbl_wind_2.Location = new System.Drawing.Point(890, 84);
            this.lbl_wind_2.Name = "lbl_wind_2";
            this.lbl_wind_2.Size = new System.Drawing.Size(56, 24);
            this.lbl_wind_2.TabIndex = 50;
            this.lbl_wind_2.Text = " km/h";
            // 
            // lbl_des_6
            // 
            this.lbl_des_6.AutoSize = true;
            this.lbl_des_6.BackColor = System.Drawing.Color.Transparent;
            this.lbl_des_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_des_6.ForeColor = System.Drawing.Color.White;
            this.lbl_des_6.Location = new System.Drawing.Point(669, 567);
            this.lbl_des_6.Name = "lbl_des_6";
            this.lbl_des_6.Size = new System.Drawing.Size(109, 25);
            this.lbl_des_6.TabIndex = 69;
            this.lbl_des_6.Text = "Description";
            // 
            // lbl_temp_2
            // 
            this.lbl_temp_2.AutoSize = true;
            this.lbl_temp_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_temp_2.ForeColor = System.Drawing.Color.White;
            this.lbl_temp_2.Location = new System.Drawing.Point(656, 136);
            this.lbl_temp_2.Name = "lbl_temp_2";
            this.lbl_temp_2.Size = new System.Drawing.Size(42, 39);
            this.lbl_temp_2.TabIndex = 51;
            this.lbl_temp_2.Text = "C";
            // 
            // lbl_cond_6
            // 
            this.lbl_cond_6.AutoSize = true;
            this.lbl_cond_6.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cond_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cond_6.ForeColor = System.Drawing.Color.White;
            this.lbl_cond_6.Location = new System.Drawing.Point(669, 539);
            this.lbl_cond_6.Name = "lbl_cond_6";
            this.lbl_cond_6.Size = new System.Drawing.Size(60, 25);
            this.lbl_cond_6.TabIndex = 68;
            this.lbl_cond_6.Text = "Cond";
            // 
            // lbl_day_3
            // 
            this.lbl_day_3.AutoSize = true;
            this.lbl_day_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day_3.ForeColor = System.Drawing.Color.White;
            this.lbl_day_3.Location = new System.Drawing.Point(889, 259);
            this.lbl_day_3.Name = "lbl_day_3";
            this.lbl_day_3.Size = new System.Drawing.Size(77, 29);
            this.lbl_day_3.TabIndex = 52;
            this.lbl_day_3.Text = "DAYS";
            // 
            // lbl_day_6
            // 
            this.lbl_day_6.AutoSize = true;
            this.lbl_day_6.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day_6.ForeColor = System.Drawing.Color.White;
            this.lbl_day_6.Location = new System.Drawing.Point(889, 617);
            this.lbl_day_6.Name = "lbl_day_6";
            this.lbl_day_6.Size = new System.Drawing.Size(77, 29);
            this.lbl_day_6.TabIndex = 67;
            this.lbl_day_6.Text = "DAYS";
            // 
            // lbl_cond_3
            // 
            this.lbl_cond_3.AutoSize = true;
            this.lbl_cond_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cond_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cond_3.ForeColor = System.Drawing.Color.White;
            this.lbl_cond_3.Location = new System.Drawing.Point(669, 195);
            this.lbl_cond_3.Name = "lbl_cond_3";
            this.lbl_cond_3.Size = new System.Drawing.Size(60, 25);
            this.lbl_cond_3.TabIndex = 53;
            this.lbl_cond_3.Text = "Cond";
            // 
            // lbl_temp_5
            // 
            this.lbl_temp_5.AutoSize = true;
            this.lbl_temp_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_temp_5.ForeColor = System.Drawing.Color.White;
            this.lbl_temp_5.Location = new System.Drawing.Point(657, 482);
            this.lbl_temp_5.Name = "lbl_temp_5";
            this.lbl_temp_5.Size = new System.Drawing.Size(42, 39);
            this.lbl_temp_5.TabIndex = 66;
            this.lbl_temp_5.Text = "C";
            // 
            // lbl_des_3
            // 
            this.lbl_des_3.AutoSize = true;
            this.lbl_des_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_des_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_des_3.ForeColor = System.Drawing.Color.White;
            this.lbl_des_3.Location = new System.Drawing.Point(669, 223);
            this.lbl_des_3.Name = "lbl_des_3";
            this.lbl_des_3.Size = new System.Drawing.Size(109, 25);
            this.lbl_des_3.TabIndex = 54;
            this.lbl_des_3.Text = "Description";
            // 
            // lbl_wind_5
            // 
            this.lbl_wind_5.AutoSize = true;
            this.lbl_wind_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wind_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_wind_5.ForeColor = System.Drawing.Color.White;
            this.lbl_wind_5.Location = new System.Drawing.Point(889, 425);
            this.lbl_wind_5.Name = "lbl_wind_5";
            this.lbl_wind_5.Size = new System.Drawing.Size(56, 24);
            this.lbl_wind_5.TabIndex = 65;
            this.lbl_wind_5.Text = " km/h";
            // 
            // lbl_wind_3
            // 
            this.lbl_wind_3.AutoSize = true;
            this.lbl_wind_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wind_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_wind_3.ForeColor = System.Drawing.Color.White;
            this.lbl_wind_3.Location = new System.Drawing.Point(889, 195);
            this.lbl_wind_3.Name = "lbl_wind_3";
            this.lbl_wind_3.Size = new System.Drawing.Size(56, 24);
            this.lbl_wind_3.TabIndex = 55;
            this.lbl_wind_3.Text = " km/h";
            // 
            // lbl_des_5
            // 
            this.lbl_des_5.AutoSize = true;
            this.lbl_des_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_des_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_des_5.ForeColor = System.Drawing.Color.White;
            this.lbl_des_5.Location = new System.Drawing.Point(669, 454);
            this.lbl_des_5.Name = "lbl_des_5";
            this.lbl_des_5.Size = new System.Drawing.Size(109, 25);
            this.lbl_des_5.TabIndex = 64;
            this.lbl_des_5.Text = "Description";
            // 
            // lbl_temp_3
            // 
            this.lbl_temp_3.AutoSize = true;
            this.lbl_temp_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_temp_3.ForeColor = System.Drawing.Color.White;
            this.lbl_temp_3.Location = new System.Drawing.Point(657, 249);
            this.lbl_temp_3.Name = "lbl_temp_3";
            this.lbl_temp_3.Size = new System.Drawing.Size(42, 39);
            this.lbl_temp_3.TabIndex = 56;
            this.lbl_temp_3.Text = "C";
            // 
            // lbl_cond_5
            // 
            this.lbl_cond_5.AutoSize = true;
            this.lbl_cond_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cond_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cond_5.ForeColor = System.Drawing.Color.White;
            this.lbl_cond_5.Location = new System.Drawing.Point(669, 426);
            this.lbl_cond_5.Name = "lbl_cond_5";
            this.lbl_cond_5.Size = new System.Drawing.Size(60, 25);
            this.lbl_cond_5.TabIndex = 63;
            this.lbl_cond_5.Text = "Cond";
            // 
            // lbl_day_4
            // 
            this.lbl_day_4.AutoSize = true;
            this.lbl_day_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day_4.ForeColor = System.Drawing.Color.White;
            this.lbl_day_4.Location = new System.Drawing.Point(889, 377);
            this.lbl_day_4.Name = "lbl_day_4";
            this.lbl_day_4.Size = new System.Drawing.Size(77, 29);
            this.lbl_day_4.TabIndex = 57;
            this.lbl_day_4.Text = "DAYS";
            // 
            // lbl_day_5
            // 
            this.lbl_day_5.AutoSize = true;
            this.lbl_day_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day_5.ForeColor = System.Drawing.Color.White;
            this.lbl_day_5.Location = new System.Drawing.Point(889, 492);
            this.lbl_day_5.Name = "lbl_day_5";
            this.lbl_day_5.Size = new System.Drawing.Size(77, 29);
            this.lbl_day_5.TabIndex = 62;
            this.lbl_day_5.Text = "DAYS";
            // 
            // lbl_cond_4
            // 
            this.lbl_cond_4.AutoSize = true;
            this.lbl_cond_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cond_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cond_4.ForeColor = System.Drawing.Color.White;
            this.lbl_cond_4.Location = new System.Drawing.Point(669, 312);
            this.lbl_cond_4.Name = "lbl_cond_4";
            this.lbl_cond_4.Size = new System.Drawing.Size(60, 25);
            this.lbl_cond_4.TabIndex = 58;
            this.lbl_cond_4.Text = "Cond";
            // 
            // lbl_temp_4
            // 
            this.lbl_temp_4.AutoSize = true;
            this.lbl_temp_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_temp_4.ForeColor = System.Drawing.Color.White;
            this.lbl_temp_4.Location = new System.Drawing.Point(657, 368);
            this.lbl_temp_4.Name = "lbl_temp_4";
            this.lbl_temp_4.Size = new System.Drawing.Size(42, 39);
            this.lbl_temp_4.TabIndex = 61;
            this.lbl_temp_4.Text = "C";
            // 
            // lbl_des_4
            // 
            this.lbl_des_4.AutoSize = true;
            this.lbl_des_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_des_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_des_4.ForeColor = System.Drawing.Color.White;
            this.lbl_des_4.Location = new System.Drawing.Point(669, 340);
            this.lbl_des_4.Name = "lbl_des_4";
            this.lbl_des_4.Size = new System.Drawing.Size(109, 25);
            this.lbl_des_4.TabIndex = 59;
            this.lbl_des_4.Text = "Description";
            // 
            // lbl_wind_4
            // 
            this.lbl_wind_4.AutoSize = true;
            this.lbl_wind_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wind_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_wind_4.ForeColor = System.Drawing.Color.White;
            this.lbl_wind_4.Location = new System.Drawing.Point(889, 312);
            this.lbl_wind_4.Name = "lbl_wind_4";
            this.lbl_wind_4.Size = new System.Drawing.Size(56, 24);
            this.lbl_wind_4.TabIndex = 60;
            this.lbl_wind_4.Text = " km/h";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGetWeather;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 696);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_day_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cond_2);
            this.Controls.Add(this.lbl_temp_6);
            this.Controls.Add(this.lbl_des_2);
            this.Controls.Add(this.lbl_wind_6);
            this.Controls.Add(this.lbl_wind_2);
            this.Controls.Add(this.lbl_des_6);
            this.Controls.Add(this.lbl_temp_2);
            this.Controls.Add(this.lbl_cond_6);
            this.Controls.Add(this.lbl_day_3);
            this.Controls.Add(this.lbl_day_6);
            this.Controls.Add(this.lbl_cond_3);
            this.Controls.Add(this.lbl_temp_5);
            this.Controls.Add(this.lbl_des_3);
            this.Controls.Add(this.lbl_wind_5);
            this.Controls.Add(this.lbl_wind_3);
            this.Controls.Add(this.lbl_des_5);
            this.Controls.Add(this.lbl_temp_3);
            this.Controls.Add(this.lbl_cond_5);
            this.Controls.Add(this.lbl_day_4);
            this.Controls.Add(this.lbl_day_5);
            this.Controls.Add(this.lbl_cond_4);
            this.Controls.Add(this.lbl_temp_4);
            this.Controls.Add(this.lbl_des_4);
            this.Controls.Add(this.lbl_wind_4);
            this.Controls.Add(this.lbl_anlikcond);
            this.Controls.Add(this.lbl_anlikdes);
            this.Controls.Add(this.lbl_anlikgün);
            this.Controls.Add(this.lbl_anlikayyil);
            this.Controls.Add(this.lbl_Temp);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_cityName);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather App";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_anlikdes;
        private System.Windows.Forms.Label lbl_anlikayyil;
        private System.Windows.Forms.Label lbl_anlikgün;
        private System.Windows.Forms.Label lbl_anlikcond;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label lbl_cityName;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_day_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cond_2;
        private System.Windows.Forms.Label lbl_temp_6;
        private System.Windows.Forms.Label lbl_des_2;
        private System.Windows.Forms.Label lbl_wind_6;
        private System.Windows.Forms.Label lbl_wind_2;
        private System.Windows.Forms.Label lbl_des_6;
        private System.Windows.Forms.Label lbl_temp_2;
        private System.Windows.Forms.Label lbl_cond_6;
        private System.Windows.Forms.Label lbl_day_3;
        private System.Windows.Forms.Label lbl_day_6;
        private System.Windows.Forms.Label lbl_cond_3;
        private System.Windows.Forms.Label lbl_temp_5;
        private System.Windows.Forms.Label lbl_des_3;
        private System.Windows.Forms.Label lbl_wind_5;
        private System.Windows.Forms.Label lbl_wind_3;
        private System.Windows.Forms.Label lbl_des_5;
        private System.Windows.Forms.Label lbl_temp_3;
        private System.Windows.Forms.Label lbl_cond_5;
        private System.Windows.Forms.Label lbl_day_4;
        private System.Windows.Forms.Label lbl_day_5;
        private System.Windows.Forms.Label lbl_cond_4;
        private System.Windows.Forms.Label lbl_temp_4;
        private System.Windows.Forms.Label lbl_des_4;
        private System.Windows.Forms.Label lbl_wind_4;
    }
}

