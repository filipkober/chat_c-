using System.Net.Sockets;
using System.Net;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        UdpClient udpClient = new UdpClient();
        IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 65432);
        udpClient.Client.Bind(RemoteIpEndPoint);
        while (true)
        {
            try
            {
                byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = System.Text.Encoding.ASCII.GetString(receiveBytes);
                Console.WriteLine(returnData);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}