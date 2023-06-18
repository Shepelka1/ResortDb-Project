using BussinessLayer;
using DataLayer;
internal class Program
{
    private static void Main(string[] args)
    {
        Client client = new Client();
        client.Name = "Gosho";
        client.PhoneNumber = "0891234124";
        ClientDbContext clientDbContext = new ClientDbContext();
        clientDbContext.Create(client);
        Console.WriteLine("Success");
    }
}