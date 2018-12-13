using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ProduitDAO pdao = new ProduitDAO("clone_kijiji","root","root");
            UserDao udao = new UserDao("clone_kijiji", "root", "root");

            pdao.CreateProduit(new Produit("zxc","patate","food"));
            udao.CreateProduit(new User("zxc","secure"));

            foreach (Produit prod in pdao.GetAllProduit())
            {
                Console.WriteLine(prod.name);
            }


            foreach (User user in udao.GetAllProduit())
            {
                Console.WriteLine(user.password);
            }

            Console.ReadKey();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
