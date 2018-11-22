using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp26
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }


    class Nationality
    {
        public string Name { get; set; }
        public string Username { get; set; }
    }
    class Button
    {
        public event Deleg Click;
        public void InvokeClick()
        {
            Click.Invoke();
        }
    }
    delegate void Deleg();
    class Program
    {
        private static void Button_Click()
        {
            Console.WriteLine("Clicked");
        }
        static void Main(string[] args)
        {
            Button button = new Button();
            button.Click += Button_Click;
            button.InvokeClick();
            ///11111111111
            //        List<User> users = new List<User>()
            //        {
            //            new User(){ Name="User", Surname="Surname",Age = 25},
            //            new User(){ Name="User1", Surname="Surname1",Age = 25},
            //            new User(){ Name="User2", Surname="Surname2",Age = 26},
            //        };
            //List<Nationality> nationalities = new List<Nationality>()
            //        {
            //            new Nationality(){ Name="Az", Username = "User"},
            //            new Nationality(){ Name="Az", Username = "User"},
            //            new Nationality(){ Name="Turk", Username = "User1"},
            //            new Nationality(){ Name="Eng", Username = "User2"},
            //        };
            //        var query = from t in users
            //                    join n in nationalities
            //                    on t.Name equals n.Username
            //                    let NameAndNationality = t.Name + " " + n.Name
            //                    where t.Age == 25 && n.Name == "Az"
            //                    select NameAndNationality;
            //        foreach (var item in query)
            //        {
            //            Console.WriteLine(item);
            //        }
            //        var query = from t in users
            //                    join n in nationalities
            //                    on t.Name equals n.Username
            //                    let NameAndNationality = t.Name + " " + n.Name
            //                    where t.Age == 25 && n.Name == "Az"
            //                    select NameAndNationality;  
            //////2222222222222
            //var listAuto = new List<Auto>
            //                   {
            //                       new Auto("Fiat", "Bravo", 2005, "red"),
            //                       new Auto("Mersedes", "E", 2010, "black"),
            //                       new Auto("Skoda", "Fabia", 2009, "yellow"),
            //                       new Auto("Mersedes","A", 2009, "grey")
            //                   };

            //var listCustomer = new List<Customer>
            //                       {
            //                           new Customer( "Petrov","Mersedes", "0509864578"),
            //                           new Customer( "Ivanov", "Fiat", "0509876545"),
            //                           new Customer( "Vasiliev", "Skoda", "0504789863")
            //                       };
            //var nquery = from a in listAuto
            //             join c in listCustomer
            //             on a.v1 equals c.v2
            //             where a.v1 == "Mersedes"
            //             select new { c.v1, a.v2, a.v3 };


            //foreach (var item in nquery)
            //{
            //    Console.WriteLine($" {item.v1} {item.v2} {item.v3} ");
            //}
        }


    }
}
