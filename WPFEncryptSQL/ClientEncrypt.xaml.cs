using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFEncryptSQL
{
    /// <summary>
    /// Interaction logic for ClientEncrypt.xaml
    /// </summary>
    public partial class ClientEncrypt : Window
    {


        encryptBaseEntities db;
        client client1;
        int numberCode;

        public ClientEncrypt()
        {
            InitializeComponent();
        }

        public ClientEncrypt(encryptBaseEntities db,client client1,string code,int numberCode)
        {
            InitializeComponent();

            this.db = db;
            this.client1 = client1;
            this.numberCode = numberCode;
            Class1 classa = new Class1();

            try
            {

                int number = int.Parse(code.ToString());


                txt_firstName.Text = classa.cesarEncrypt(client1.firstname.ToString(), number);
                txt_Name.Text = classa.cesarEncrypt(client1.surname.ToString(), number);
                txt_Login.Text = classa.cesarEncrypt(client1.Login_Name_Unique.ToString(), number);
                txt_Pass.Text = classa.cesarEncrypt(client1.Password_text.ToString(), number);


                List<ClientWallet> CLientList2 = new List<ClientWallet>();


                foreach (var x in db.client)
                {
                    ClientWallet clientWallet2 = new ClientWallet();

                    clientWallet2.id_client = x.id_client;
                    clientWallet2.firstname = classa.cesarEncrypt(x.firstname, numberCode);
                    clientWallet2.surname = classa.cesarEncrypt(x.surname, numberCode);
                    clientWallet2.Login_Name_Unique = classa.cesarEncrypt(x.Login_Name_Unique, numberCode);
                    clientWallet2.Password_text = classa.cesarEncrypt(x.Password_text, numberCode);


                    CLientList2.Add(clientWallet2);
                }


                listView.ItemsSource = CLientList2;


            }catch(FormatException)
            {
                MessageBox.Show("Zły format");

            }catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }

           
        }
    }
}
