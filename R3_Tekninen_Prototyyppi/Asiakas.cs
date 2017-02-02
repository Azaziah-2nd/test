using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3_Tekninen_Prototyyppi
{
    class Customer
    {
        // Määritellään tarvittavat ominaisuudet.
        protected string first_name;
        protected string last_name;
        protected int age;
        protected string gender;
        protected string email;
        protected string phone_number;
        protected string adress;
        protected string post_office;
        protected int postal_code;
        protected string country;
        // Customer luokan aksessorit ja mutaattorit.
        public string First_name { get { return first_name; } set { first_name = value; } }
        public string Last_name { get { return last_name; } set { last_name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone_number { get { return phone_number; } set { phone_number = value; } }
        public string Adress { get { return adress; } set { adress = value; } }
        public string Post_office { get { return post_office; } set { post_office = value; } }
        public int Postal_code { get { return postal_code; } set { postal_code = value; } }
        public string Country { get { return country; } set { country = value; } }

        public void Customer_ask_details(Customer Customer_details)
        {
            string str_input;
            Console.WriteLine("Syötä asiakkaan tiedot.");
            Console.Write("Etunimi: ");
            str_input = Console.ReadLine();
            while (str_input.Length == 0)
            {
                Console.Write("Nimesi ei voi olla tyhjä, yritä uudelleen: ");
                str_input = Console.ReadLine();
            }
            First_name = str_input;
            Console.Write("Sukunimi: ");
            str_input = Console.ReadLine();
            while (str_input.Length == 0)
            {
                Console.Write("Nimesi ei voi olla tyhjä, yritä uudelleen: ");
                str_input = Console.ReadLine();
            }
            Last_name = str_input;
            Console.Write("Ikä: ");
            str_input = Console.ReadLine();
            // Tämä ei toimi jos age = Age
            while (!int.TryParse(str_input, out age))
            {
                Console.Write("Numerosi on virheellinen, yritä uudestaan: ");
                str_input = Console.ReadLine();
            }
            Console.Write("Sukupuoli (Mies/Nainen/Muu): ");
            // Muuntaa syötteen pienellä kirjoitetuksi.
            str_input = Console.ReadLine().ToLower();
            // Tarkistaa syötteen oikeellisuuden.
            while(!(str_input != "mies" || str_input != "nainen" || str_input != "muu"))
            {
                Console.Write("Sukupuoli (Mies/Nainen/Muu): ");
                str_input = Console.ReadLine().ToLower();
            }
            // Muuntaa ensimäisen kirjaimen isoksi ja tallentaa sen Genderiksi.
            Gender = char.ToUpper(str_input[0]) + str_input.Substring(1);
            Console.Write("Sähköpostiosoite: ");
            Email = Console.ReadLine();
            Console.Write("Puhelinnumero: ");
            Phone_number = Console.ReadLine();
            Console.Write("Katuosoite: ");
            Adress = Console.ReadLine();
            Console.Write("Postitoimipaikka: ");
            Post_office = Console.ReadLine();
            Console.Write("Postinumero: ");
            str_input = Console.ReadLine();
            // Tämä ei toimi jos age = Age
            while (!int.TryParse(str_input, out postal_code))
            {
                Console.Write("Numerosi on virheellinen, yritä uudestaan: ");
                str_input = Console.ReadLine();
            }
            Console.Write("Maa: ");
            Country = Console.ReadLine();
        }
        // Asiakkaan tietojen tulostaminen.
        public void Customer_print_details(Customer Customer_details)
        {
            Console.WriteLine("\nAsiakastietojen yhteenveto:\n");
            Console.WriteLine("Nimi: {0} {1}", Customer_details.first_name, Customer_details.Last_name);
            Console.WriteLine("Ikä: " + Customer_details.age);
            Console.WriteLine("Sukupuoli: " + Customer_details.gender);
            Console.WriteLine("Sähköpostiosoite: " + Customer_details.email);
            Console.WriteLine("Puhelinnumero: " + Customer_details.phone_number);
            Console.WriteLine("Katuosoite: " + Customer_details.adress);
            Console.WriteLine("Postitoimipaikka: " + Customer_details.post_office);
            Console.WriteLine("Postinumero: " + Customer_details.postal_code);
            Console.WriteLine("Maa: " + Customer_details.country);
        }
    }
}
