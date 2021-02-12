using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Adi = "Kübra";
            customer.Soyadi = "Moğul";

            Customer customer1 = new Customer();
            customer1.Id = 2;
            customer1.Adi = "Emrah";
            customer1.Soyadi = "Erçelik";

            Customer[] customers = new Customer[] { customer,customer1};
            foreach (Customer item in customers)
            {
                CustomerManager customerManager = new CustomerManager();
                customerManager.Ekle();
                customerManager.Listele();
                customerManager.Sil();

                Console.WriteLine("------------------------------");
            }

        }
    }
}
