using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFEncryptSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

      
        public encryptBaseEntities db;
        Class1 classa;
        int numberCode = 2;


        public MainWindow()
        {
            InitializeComponent();
                       

          db = new encryptBaseEntities();

            Load(db);
           
        }



        private void Load(encryptBaseEntities db)
        {

            listView.ItemsSource = db.client.ToList();

            classa = new Class1();

            List<ClientWallet> CLientList = new List<ClientWallet>();



            foreach (var item in db.client)
            {
                //item.firstname = classa.cesarEncrypt(item.firstname, 2);
                ClientWallet clientWallet1 = new ClientWallet();

                clientWallet1.id_client = item.id_client;
                clientWallet1.firstname = classa.cesarEncrypt(item.firstname, numberCode);

                CLientList.Add(clientWallet1);


            }


            cmb_Klient.ItemsSource = CLientList.ToList();




            var linqWalletClient = from x in db.client
                                   join w in db.wallet on x.id_client equals w.id_client
                                   select new ClientWallet { id_client = x.id_client, firstname = x.firstname, surname = x.surname, Login_Name_Unique = x.Login_Name_Unique, Password_text = x.Password_text, Name_wallet = w.Name_wallet, description_Wallet = w.description_Wallet };



            List<ClientWallet> CLientList2 = new List<ClientWallet>();


            foreach (var item in linqWalletClient)
            {
                //item.firstname = classa.cesarEncrypt(item.firstname, 2);
                ClientWallet clientWallet2 = new ClientWallet();

                clientWallet2.id_client = item.id_client;
                clientWallet2.firstname = classa.cesarEncrypt(item.firstname, numberCode);
                clientWallet2.surname = classa.cesarEncrypt(item.surname, numberCode);
                clientWallet2.Login_Name_Unique = classa.cesarEncrypt(item.Login_Name_Unique, numberCode);
                clientWallet2.Password_text = classa.cesarEncrypt(item.Password_text, numberCode);
                clientWallet2.Name_wallet = classa.cesarEncrypt(item.Name_wallet, numberCode);
                clientWallet2.description_Wallet = classa.cesarEncrypt(item.description_Wallet, numberCode);


                CLientList2.Add(clientWallet2);


            }




            listView_CLientWallet.ItemsSource = CLientList2.ToList();



        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                
                client client1 = new client();
                client1.firstname = classa.cesar(txt_firstName.Text, numberCode);
                client1.surname = classa.cesar(txt_Name.Text, numberCode);
                client1.Login_Name_Unique = classa.cesar(txt_Login.Text, numberCode);
                client1.Password_text = classa.cesar(txt_Pass.Text, numberCode);

                db.client.Add(client1);
                db.SaveChanges();

                //listView.ItemsSource = db.client.ToList();
                Load(db);
                
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }

        }

       

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            client client2 = (client)listView.SelectedItem;


            ChooseNr chooseNr1 = new ChooseNr(db, client2,numberCode);
            chooseNr1.Show();


        }

        private void btn_save_Copy_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var idClient = (ClientWallet)cmb_Klient.SelectedItem;

                int id_client = idClient.id_client;



                wallet wallet1 = new wallet();

                wallet1.Name_wallet = classa.cesar(txt_Name_Wallet.Text, numberCode);
                wallet1.description_Wallet = classa.cesar(txt_Description.Text, numberCode);
                wallet1.id_client = id_client;

                db.wallet.Add(wallet1);
                db.SaveChanges();

                Load(db);

            }
            catch(FormatException )
            {
                MessageBox.Show("Zły format");
            }catch(SqlException f)
            {
                MessageBox.Show(f.Message);

            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
