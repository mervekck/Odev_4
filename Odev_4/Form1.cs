using Odev_4.Models.Classes;
using Odev_4.Models.Factory;
using Odev_4.Models.Interfaces;

namespace Odev_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbLog.SelectedItem == null || cmbLog.SelectedItem.ToString() == "Seçiniz")
            {
                MessageBox.Show("Lütfen bir log tipi seçiniz");
            }
            else if (txtDurum.Text.Length == 0)
            {
                MessageBox.Show("Lütfen bir mesaj yazýnýz");
            }
            else
            {
                string secilenLogTipi = cmbLog.SelectedItem.ToString();
                string durum = txtDurum.Text;
                string mesaj = "";
                ILog iLog;
                LogFactory factory = new LogFactory();
                iLog = factory.NesneOlustur(secilenLogTipi);
                Logger log = new Logger(iLog);
                mesaj = log.LogKaydet(durum);
                lblSonuc.Text = mesaj;
            }
        }
    }
}
