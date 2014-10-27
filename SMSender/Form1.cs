using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSender
{
    public partial class SMSender : Form
    {
        public SMSender()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e1)
        {
            try
            {
                SMSApi.Api.Client client = new SMSApi.Api.Client("login");
                client.SetPasswordHash("haslo");

                var smsApi = new SMSApi.Api.SMSFactory(client);

                var senderName = senderBox.Text;
                var number = numberBox.Text;
                var content = contentBox.Text;

                var result =
                    smsApi.ActionSend()
                        .SetText(content)
                        .SetTo(number)
                        .SetSender(senderName) //Pole nadawcy lub typ wiadomość 'ECO', '2Way'
                        .Execute();

  //              System.Console.WriteLine("Send: " + result.Count);
                MessageBox.Show("Wysłano: " + result.Count);
            }
            catch (SMSApi.Api.ActionException e)
            {
                /**
                 * Błędy związane z akcją (z wyłączeniem błędów 101,102,103,105,110,1000,1001 i 8,666,999,201)
                 * http://www.smsapi.pl/sms-api/kody-bledow
                 */
                MessageBox.Show(e.Message);
            }
            catch (SMSApi.Api.ClientException e)
            {
                /**
                 * 101 Niepoprawne lub brak danych autoryzacji.
                 * 102 Nieprawidłowy login lub hasło
                 * 103 Brak punków dla tego użytkownika
                 * 105 Błędny adres IP
                 * 110 Usługa nie jest dostępna na danym koncie
                 * 1000 Akcja dostępna tylko dla użytkownika głównego
                 * 1001 Nieprawidłowa akcja
                 */
                MessageBox.Show(e.Message);
            }
            catch (SMSApi.Api.HostException e)
            {
                /* błąd po stronie servera lub problem z parsowaniem danych
                 * 
                 * 8 - Błąd w odwołaniu
                 * 666 - Wewnętrzny błąd systemu
                 * 999 - Wewnętrzny błąd systemu
                 * 201 - Wewnętrzny błąd systemu
                 * SMSApi.Api.HostException.E_JSON_DECODE - problem z parsowaniem danych
                 */
                MessageBox.Show(e.Message);
            }
            catch (SMSApi.Api.ProxyException e)
            {
                // błąd w komunikacji pomiedzy klientem a serverem
                MessageBox.Show(e.Message);
            }
        }

        private void contentBox_TextChanged(object sender, EventArgs e)
        {
            charNumber.Text = contentBox.Text.Length + " (" + Math.Ceiling(contentBox.Text.Length / 160.0) + " SMS)";
        }

        private void numberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '+') && ((sender as TextBox).Text.Length > 0))
            {
                e.Handled = true;
            }
        }

    }
}
