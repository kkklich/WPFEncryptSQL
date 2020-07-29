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
    /// Interaction logic for ChooseNr.xaml
    /// </summary>
    public partial class ChooseNr : Window
    {

        encryptBaseEntities db;
        client client1;
        int numberCode;


        public ChooseNr()
        {
            InitializeComponent();
        }



        public ChooseNr(encryptBaseEntities db,client client,int numberCode)
        {
            InitializeComponent();

            this.db = db;
            this.client1 = client;
            this.numberCode = numberCode;

          

        }

        private void btn_conti_Click(object sender, RoutedEventArgs e)
        {
            string code = txt_kod.Text.ToString();


            ClientEncrypt clientEncrypt1 = new ClientEncrypt(db, client1, code,numberCode);
            this.Close();
            clientEncrypt1.Show();
        }
    }
}
