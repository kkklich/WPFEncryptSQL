using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFEncryptSQL
{

    class ClientWallet
    {

        public int id_client { get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
        public string Login_Name_Unique { get; set; }
        public string Password_text { get; set; }
        public string Name_wallet { get; set; }
        public string description_Wallet { get; set; }

    }


    class Class1
    {

      public static string[] alfabet = new string[36];
        int numberOfAscii = 800;


        public Class1()
        {

          

        }



         public  string cesar(string word, int number)
        {
            
            string encrypt = "";
            int nrword;
            int x;

            
            for(int i=0;i<word.Length;i++)
            {
                x = (int)word[i];

                nrword = (x + number) % numberOfAscii;

                encrypt += (char)nrword;
            }



            return encrypt;
        }


       public  string cesarEncrypt(string wordEncrypt, int number)
        {
           
            string word = "";
            int nrword;
            int x;



            for (int i = 0; i < wordEncrypt.Length; i++)
            {
                x = (int)wordEncrypt[i];

                if (x - number < 0)
                    nrword = (x - number + numberOfAscii) % numberOfAscii;
                else
                    nrword = (x - number) % numberOfAscii;

                word += (char)nrword;
            }



            return word;

        }


    }
}
