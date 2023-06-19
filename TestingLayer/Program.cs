using BussinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Name = "Pesho";
            client.PhoneNumber = "089234567890";
            ClientDbContext clientDbContext = new ClientDbContext();
            clientDbContext.Create(client);
            Console.WriteLine("Success");
        }
    }
}
