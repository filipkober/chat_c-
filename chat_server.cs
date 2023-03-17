using System.Net.Sockets;
using System.Net;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        UdpClient udpClient = new UdpClient();
        Console.WriteLine("nick gurr: ");
        var nick = Console.ReadLine();
        var PORT = 65432;
        var adresy = new List<string>();
        adresy.Add("localhost");
        adresy.Add("10.1.49.179");
        adresy.Add("10.1.49.149");
        adresy.Add("10.1.49.129");
        while (true)
        {
            try
            {
                Console.WriteLine("message: ");
                string message = Console.ReadLine();
                byte[] sendBytes = System.Text.Encoding.ASCII.GetBytes("["+nick + "]: " + message);

                foreach(var adres in adresy)
                {
                    udpClient.Send(sendBytes, sendBytes.Length, adres, 65432);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


    }
}