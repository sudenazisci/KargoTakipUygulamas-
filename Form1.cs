namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        private class Arac
        {
            public string Plaka { get; set; }
            public string Marka { get; set; }
            public int Hiz { get; set; }
            public double Boylam { get; set; }
            public bool MesajGonderildi { get; set; } = false;
            public bool HizKontrolYapildi { get; set; } = false;
        }
        private Arac[] araclar;
        private const int HizLimiti = 110;
        private const int MaksimumHiz = 135;
        private bool devamEdiyor = false;


        public Form1()
        {
            InitializeComponent();
            araclar = new Arac[]
            {
                new Arac { Plaka = "37AB123", Marka = "Ford", Hiz = 80, Boylam = 0 },
                new Arac { Plaka = "37CD456", Marka = "Mercedes", Hiz = 80, Boylam = 0 },
                new Arac { Plaka = "37EF789", Marka = "Toyota", Hiz = 80, Boylam = 0 },
                new Arac { Plaka = "37GH012", Marka = "BMW", Hiz = 80, Boylam = 0 },
                new Arac { Plaka = "37JK345", Marka = "Audi", Hiz = 80, Boylam = 0 }
            };

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            devamEdiyor = true;

            while (devamEdiyor)
            {
                string durumMesaji = "";
                for (int i = 0; i < araclar.Length; i++)
                {
                    if (araclar[i].Hiz > MaksimumHiz)
                        continue;
                    araclar[i].Hiz += 5;
                    araclar[i].Boylam += 212.5; 

                  
                    string bilgi = $"{araclar[i].Plaka} plakalý aracýn hýzý = {araclar[i].Hiz} km/h";
                    ListBox hedefListe = (ListBox)this.Controls[$"listBox{i + 1}"];
                    hedefListe.Items.Add(bilgi);

                  
                    if (araclar[i].Hiz > HizLimiti && !araclar[i].MesajGonderildi)
                    {
                        durumMesaji += $"{araclar[i].Plaka} plakalý {araclar[i].Marka} marka kargo aracý hýz limitini aþtý.\n" +
                                       $"Anlýk hýz: {araclar[i].Hiz} km/h, Boylam: {araclar[i].Boylam}°\n";


                        if (araclar[i].Hiz > MaksimumHiz)
                        {
                            araclar[i].MesajGonderildi = true; 
                        }
                    }
                   
                    if (araclar[i].Hiz > MaksimumHiz && !araclar[i].HizKontrolYapildi)
                    {
                        araclar[i].HizKontrolYapildi = true;
                        label6.Text = "Hýz kontrolü yapýldý";
                    }


                }
                if (!string.IsNullOrEmpty(durumMesaji))
                {
                    label6.Text = durumMesaji;

                    
                    await Task.Delay(4000);
                    label6.Text = " Durum Bekleniyor ";
                }

                await Task.Delay(1000); 


            }


        }

        private async void button2_Click(object sender, EventArgs e)
        {
            devamEdiyor = false;
            label6.Text = " Program kapanýyor...";
            await Task.Delay(3000); 

           
            Application.Exit();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
