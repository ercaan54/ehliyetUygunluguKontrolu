namespace ehliyetUygunluguKontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.Write("Lütfen Yaşınızı Giriniz:");
            int yas = Convert.ToInt32(Console.ReadLine());



            Console.Write("Sağlık Durumunuz iyi mi? ( evet/hayır):");
            string saglik = Console.ReadLine().ToLower().Trim();


            Console.Write("Sabıkanız var mı? (evet/hayır):");
            string sabika = Console.ReadLine().ToLower().Trim();


            if (yas >= 18 && saglik == "evet" && sabika == "hayır")


            {
                Console.WriteLine("Ehliyeti Alabilirsiniz");

            }
            else
            {

                Console.WriteLine("Ehliyeti alamazsınız");
            }
            




          






















        }
    }
}
