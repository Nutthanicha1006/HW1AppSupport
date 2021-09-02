using System;
using System.Collections.Generic;

namespace HWclothingstore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tshirt> OrderTshirt = new List<Tshirt>();

            Tshirt tshirt1 = new Tshirt("L", "RED", 500f, "A");
            Tshirt tshirt2 = new Tshirt("M", "BLACK", 750f, "B");
            Tshirt tshirt3 = new Tshirt("S", "BROWN", 625f, "C");
            OrderTshirt.Add(tshirt1);
            OrderTshirt.Add(tshirt2);
            OrderTshirt.Add(tshirt3);
            Address jameaddress = new Address("131/75 ถนนพุทธมณฑล", "จังหวัด นครปฐม", "10180");
            ShoppingCart ShopPingCart = new ShoppingCart(jameaddress);
            User jame = new User("jame watson", "jame@gmail.com", ShopPingCart);

            jame.ShoppingCart.addTS(tshirt1);
            jame.ShoppingCart.addTS(tshirt2);
            jame.ShoppingCart.addTS(tshirt3);

            foreach (Tshirt shoppingCart in OrderTshirt)
            {
                Console.WriteLine("SIZE : {0}",shoppingCart.size);
                Console.WriteLine("COLOR : {0}",shoppingCart.color);
                Console.WriteLine("PRICE : {0} bath",shoppingCart.price);
                Console.WriteLine("IMAGE : {0}", shoppingCart.image);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("NAME : {0}",jame.name);
            Console.WriteLine("EMAIL : {0}",jame.email);
            Console.Write("ADDRESS : ");
            Console.WriteLine(jameaddress.street);
            Console.WriteLine(jameaddress.city);
            Console.WriteLine(jameaddress.zipcode);
            Console.WriteLine("");
            Console.WriteLine("************************");
            jame.ShoppingCart.TotalCost();
            Console.WriteLine("************************");
        }
    }
    class Tshirt
    {
        public string size;
        public string color;
        public float price;
        public string image;

        public Tshirt(string valueSize, string valueColor, float valuePrice, string valueImage)
        {
            size = valueSize;
            color = valueColor;
            price = valuePrice;
            image = valueImage;
        }
    }
    class User
    {
        public string name;
        public string email;
        public ShoppingCart ShoppingCart;
        
        public User(string valueName, string valueEmail, ShoppingCart valueShoppingCart)
        {
            name = valueName;
            email = valueEmail;
            ShoppingCart = valueShoppingCart;
        }
    }
    class ShoppingCart
    {
        private List<Tshirt> OrderTshirt;
        public float Totalcost = 0;
        public Address Address;

        public ShoppingCart(Address valueAddress)
        {
            Address = valueAddress;
            OrderTshirt = new List<Tshirt>();
        }
        public void TotalCost()
        {
            foreach (Tshirt tshirt in OrderTshirt)
            {
                Totalcost += tshirt.price;
            }
            Console.WriteLine("Total Cost : {0} BATH", Totalcost);
        }
        public void addTS(Tshirt tshirt)
        {
            OrderTshirt.Add(tshirt);
        }
    }
    class Address
    {
        public string street;
        public string city;
        public string zipcode;

        public Address(string valueStreet, string valueCity, string valueZipcode)
        {
            street = valueStreet;
            city = valueCity;
            zipcode = valueZipcode;
        }
    }
   
}
