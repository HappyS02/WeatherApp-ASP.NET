using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WeatherApp.Forcast;
using static WeatherApp.WeatherInfo;

namespace WeatherApp
{
    public partial class Form1 : Form
    {

        const string APPID = "3c2df8ce2e9a4ddbde02b21542e0de5f";

        private Image backgroundImage; // Arka plan resmi
        public Form1()
        {
            InitializeComponent();

            string city = "Ankara";

            getWeather(city); //one day weather
            getForcast(city); //more than one day 

            this.DoubleBuffered = true;  // Form üzerinde Double Buffering etkinleştir
            this.BackgroundImageLayout = ImageLayout.Stretch; // Resmi form boyutuna göre ayarla

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (backgroundImage != null)
            {
                // Arka plan resmini çizin
                e.Graphics.DrawImage(backgroundImage, this.ClientRectangle);

                // Şeffaf siyah katmanı çizin
                using (Brush brush = new SolidBrush(Color.FromArgb(128, Color.Black))) // %50 şeffaf siyah
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }

        private void btnGetWeather_Click_1(object sender, EventArgs e)
        {
            // Önce sayfayı temizle
            ClearWeatherInfo();

            // Kullanıcıdan TextBox'a girilen şehir bilgisini al
            string city = txtCity.Text.Trim();  // Trim ile boşlukları temizleyin
            if (!string.IsNullOrEmpty(city))
            {
                // Hava durumu verilerini getir
                getWeather(city);
                getForcast(city);
            }
            else
            {
                MessageBox.Show("Please enter a city.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void getWeather(string city)
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    // URL İÇİNDE APP İD BİZİM API ANAHTARIMIZ O OLMADAN ERİŞEMEYİZ HİÇBİR VERİYE
                    // units= metric fahrenheight mı yoksa celcius mu olduğunu söylüyor
                    // q= query nin kısaltımı, sorgu demek hangi şehrin havasını almak istediğimizi istiyor
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", city, APPID);
                    //Console.WriteLine("URL BURADA:  {0}", url);

                    var json = web.DownloadString(url); // verileri çektik
                    //Console.WriteLine("JSON BURADA:  {0}", json);
                    var result = JsonConvert.DeserializeObject<WeatherInfo.Root>(json); // çektiğimiz verileri modele koyduk ki sonradan gelen verileri kullanalım

                    // ÖRNEK :  result.wind.speed.ToString(); örneği gibi rüzgarın hızına eriştik

                    //Console.WriteLine("RESULT BURADA:  {0}", result);
                    WeatherInfo.Root outPut = result;  //int sayi = 23; gibi, değişken tanımlamak gibi

                    lbl_cityName.Text = string.Format("{0}", outPut.name);
                    lbl_country.Text = string.Format("{0}", outPut.sys.country);
                    lbl_Temp.Text = string.Format("{0} \u00B0" + "C", outPut.main.temp);  ////celcius/Farhanite symbol unicode : \u00B0C

                    lbl_anlikgün.Text = string.Format("{0}", getDate(outPut.dt).DayOfWeek);
                    lbl_anlikayyil.Text = getDate(outPut.dt).ToString("dd.MM.yyyy");

                    Form1_Load(lbl_anlikcond.Text);

                }
            }
            catch (WebException ex)
            {
                // WebException, veri çekme sırasında bir hata olursa yakalanır (örneğin, geçersiz şehir adı)
                MessageBox.Show("Invalid city name. Please enter a correct city name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Diğer olası hatalar
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void getForcast(string city)
        {
            try
            {
                using (WebClient web = new WebClient())
                 {
                string url = string.Format("https://api.openweathermap.org/data/2.5/forecast/daily?q={0}&appid=b1b15e88fa797225412429c1c50c122a1&units=metric", city);
                Console.WriteLine("URL BURADA 2 :::" + url);
                var json = web.DownloadString(url);

                var Object = JsonConvert.DeserializeObject<weatherForcast>(json);

                weatherForcast forcast = Object;
                Console.WriteLine(forcast.city.name.ToString());

                lbl_anlikdes.Text = string.Format("{0}", forcast.list[0].weather[0].description);
                lbl_anlikcond.Text = string.Format("{0}", forcast.list[0].weather[0].main);

                //next day
                lbl_day_2.Text = string.Format("{0}", getDate(forcast.list[1].dt).DayOfWeek); //returning date
                lbl_cond_2.Text = string.Format("{0}", forcast.list[1].weather[0].main); //weather condition
                lbl_des_2.Text = string.Format("{0}", forcast.list[1].weather[0].description); //description weather
                lbl_temp_2.Text = string.Format("{0}\u00B0" + "C", forcast.list[1].temp.day); //temp weather
                lbl_wind_2.Text = string.Format("{0} km/h", forcast.list[1].speed); //weather wind speed 

                //day after tomarow
                lbl_day_3.Text = string.Format("{0}", getDate(forcast.list[2].dt).DayOfWeek); //returning date
                lbl_cond_3.Text = string.Format("{0}", forcast.list[2].weather[0].main); //weather condition
                lbl_des_3.Text = string.Format("{0}", forcast.list[2].weather[0].description); //description weather
                lbl_temp_3.Text = string.Format("{0}\u00B0" + "C", forcast.list[2].temp.day); //temp weather
                lbl_wind_3.Text = string.Format("{0} km/h", forcast.list[2].speed); //weather wind speed 

                //2 day after tomarow
                lbl_day_4.Text = string.Format("{0}", getDate(forcast.list[3].dt).DayOfWeek); //returning date
                lbl_cond_4.Text = string.Format("{0}", forcast.list[3].weather[0].main); //weather condition
                lbl_des_4.Text = string.Format("{0}", forcast.list[3].weather[0].description); //description weather
                lbl_temp_4.Text = string.Format("{0}\u00B0" + "C", forcast.list[3].temp.day); //temp weather
                lbl_wind_4.Text = string.Format("{0} km/h", forcast.list[3].speed); //weather wind speed

                //3 day after tomarow
                lbl_day_5.Text = string.Format("{0}", getDate(forcast.list[4].dt).DayOfWeek); //returning date
                lbl_cond_5.Text = string.Format("{0}", forcast.list[4].weather[0].main); //weather condition
                lbl_des_5.Text = string.Format("{0}", forcast.list[4].weather[0].description); //description weather
                lbl_temp_5.Text = string.Format("{0}\u00B0" + "C", forcast.list[4].temp.day); //temp weather
                lbl_wind_5.Text = string.Format("{0} km/h", forcast.list[4].speed); //weather wind speed

                //4 day after tomarow
                lbl_day_6.Text = string.Format("{0}", getDate(forcast.list[5].dt).DayOfWeek); //returning date
                lbl_cond_6.Text = string.Format("{0}", forcast.list[5].weather[0].main); //weather condition
                lbl_des_6.Text = string.Format("{0}", forcast.list[5].weather[0].description); //description weather
                lbl_temp_6.Text = string.Format("{0}\u00B0" + "C", forcast.list[5].temp.day); //temp weather
                lbl_wind_6.Text = string.Format("{0} km/h", forcast.list[5].speed); //weather wind speed

                Form1_Load(lbl_anlikcond.Text);
                }

            }
            catch (WebException ex)
            {
                // WebException, veri çekme sırasında bir hata olursa yakalanır (örneğin, geçersiz şehir adı)
                MessageBox.Show("Invalid city name. Please enter a correct city name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Diğer olası hatalar
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // millisecound to DateTime methode
        DateTime getDate(double millisecound)
        {

            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisecound).ToLocalTime();

            return day;
        }

        private void Form1_Load(string condition)
        {
            switch (condition)
            {
                case "Clear":
                    backgroundImage = Image.FromFile("C:\\Ipek\\Projem\\Weather_app\\WeatherApp\\picture\\Clear.jpg");
                    break;

                case "Light rain":
                    backgroundImage = Image.FromFile("C:\\Ipek\\Projem\\Weather_app\\WeatherApp\\picture\\Light_rain.jpg");
                    break;

                case "Rain":
                    backgroundImage = Image.FromFile("C:\\Ipek\\Projem\\Weather_app\\WeatherApp\\picture\\rain.jpg");
                    /*  this.lbl_anlikgün.ForeColor = Color.Black;
                      this.lbl_anlikayyil.ForeColor = Color.Black;
                      this.lbl_anlikcond.ForeColor = Color.Black;
                      this.lbl_anlikdes.ForeColor = Color.Black; */
                    break;

                case "Clouds":
                    backgroundImage = Image.FromFile("C:\\Ipek\\Projem\\Weather_app\\WeatherApp\\picture\\clouds.jpg");
                    /*  this.lbl_anlikgün.ForeColor = Color.Black;
                      this.lbl_anlikayyil.ForeColor = Color.Black;
                      this.lbl_anlikcond.ForeColor = Color.Black;
                      this.lbl_anlikdes.ForeColor = Color.Black;
                      this.lbl_Temp.ForeColor = Color.Black; */
                    break;

                case "Broken clouds":
                    backgroundImage = Image.FromFile("C:\\Ipek\\Projem\\Weather_app\\WeatherApp\\picture\\Broken_clouds.jpg");
                    break;

                case "Overcast clouds":
                    backgroundImage = Image.FromFile("C:\\Ipek\\Projem\\Weather_app\\WeatherApp\\picture\\Overcast_clouds.jpg");
                    break;

                case "Scattered clouds":
                    backgroundImage = Image.FromFile("C:\\Ipek\\Projem\\Weather_app\\WeatherApp\\picture\\Scattered_clouds.jpeg");
                    break;

                case "Moderate rain":
                    backgroundImage = Image.FromFile("C:\\Ipek\\Projem\\Weather_app\\WeatherApp\\picture\\rain.jpg");
                    break;

                case "Light snow":
                    backgroundImage = Image.FromFile("C:\\Ipek\\Projem\\Weather_app\\WeatherApp\\picture\\light_snow.jpg");
                    break;
                    /*
                    3 komut
                        git add . // değişiklik yaptığımız her şeyi göndereceğimiz gemiye ekliyor
                        git commit -m "yaptığın şeyleri burada anlatabilirsin kısa not" // gemiye not bırakıyoruz hangi mallar var
                        git push origin master master ama senin değişikliklerini dosyalarını göndereceğin dal // gemiyi yolcu ediyoruz
                    şimdi bak projede bir şeyler değiştirdik dimi
                    yorum satırları falan ekledik buraya
                    terminal nerde aqmk
                     */
                case "Snow":
                    backgroundImage = Image.FromFile("C:\\Ipek\\Projem\\Weather_app\\WeatherApp\\picture\\snow.jpg");
                    /*   this.lbl_anlikgün.ForeColor = Color.DarkBlue;
                       this.lbl_anlikayyil.ForeColor = Color.DarkBlue;
                       this.lbl_anlikcond.ForeColor = Color.DarkBlue;
                       this.lbl_anlikdes.ForeColor = Color.DarkBlue;
                       this.lbl_Temp.ForeColor = Color.DarkBlue;
                       this.lbl_cond_2.ForeColor = Color.Black;
                       this.lbl_cond_3.ForeColor = Color.Black;
                       this.lbl_cond_4.ForeColor = Color.Black;
                       this.lbl_cond_5.ForeColor = Color.Black;
                       this.lbl_cond_6.ForeColor = Color.Black;
                       this.lbl_wind_2.ForeColor = Color.White;
                       this.lbl_wind_3.ForeColor = Color.White;
                       this.lbl_wind_4.ForeColor = Color.White;
                       this.lbl_wind_5.ForeColor = Color.White;
                       this.lbl_wind_6.ForeColor = Color.White;
                       this.lbl_day_2.ForeColor = Color.Black;
                       this.lbl_day_3.ForeColor = Color.Black;
                       this.lbl_day_4.ForeColor = Color.Black;
                       this.lbl_day_5.ForeColor = Color.Black;
                       this.lbl_day_6.ForeColor = Color.Black; */
                    break;

                default: 
                    // Eğer durum eşleşmezse, varsayılan bir resim kullan
                    backgroundImage = Image.FromFile("C:\\Ipek\\Projem\\Weather_app\\WeatherApp\\picture\\Few_clouds.jpg");
                    break;
            }
            // Formu yeniden çizerek eski resmi sil ve yenisini ekle
            this.Invalidate();

        }

       
        void ClearWeatherInfo()
        {
            lbl_cityName.Text = "";
            lbl_country.Text = "";
            lbl_Temp.Text = "";
            lbl_anlikgün.Text = "";
            lbl_anlikayyil.Text = "";
            lbl_anlikcond.Text = "";
            lbl_anlikdes.Text = "";

            lbl_day_2.Text = "";
            lbl_cond_2.Text = "";
            lbl_des_2.Text = "";
            lbl_temp_2.Text = "";
            lbl_wind_2.Text = "";

            lbl_day_3.Text = "";
            lbl_cond_3.Text = "";
            lbl_des_3.Text = "";
            lbl_temp_3.Text = "";
            lbl_wind_3.Text = "";

            lbl_day_4.Text = "";
            lbl_cond_4.Text = "";
            lbl_des_4.Text = "";
            lbl_temp_4.Text = "";
            lbl_wind_4.Text = "";

            lbl_day_5.Text = "";
            lbl_cond_5.Text = "";
            lbl_des_5.Text = "";
            lbl_temp_5.Text = "";
            lbl_wind_5.Text = "";

            lbl_day_6.Text = "";
            lbl_cond_6.Text = "";
            lbl_des_6.Text = "";
            lbl_temp_6.Text = "";
            lbl_wind_6.Text = "";
        }

        
    }
}
