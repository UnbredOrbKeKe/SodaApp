using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace SodaDispenser.Services
{
    class Arduino
    {
        public static void Cummunicate(string led)
        {
            //IPAddress ipAddress = IPAddress.Parse("192.168.1.65"); //laptop connection
            IPAddress ipAddress = IPAddress.Parse("192.168.178.17"); //desktop
            IPEndPoint endPoint = new IPEndPoint(ipAddress, 42069); //instellen op welke poort en ip wordt gecommunicate
            Socket s = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            s.Connect(endPoint);
            if (s.Connected)
            {
                //send
                byte[] msg = Encoding.ASCII.GetBytes(led);
                s.Send(msg);
                //// receive
                // byte[] buffer = new byte[100];
                // int bytesReceived = s.Receive(buffer);
                // result = Encoding.ASCII.GetString(buffer, 0, bytesReceived).Split('>')[1];
                // close
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }

        }

        public static string CummunicateR(string fris)
        {
            string result = "No Response";
            //IPAddress ipAddress = IPAddress.Parse("192.168.1.65"); //laptop connection
            IPAddress ipAddress = IPAddress.Parse("192.168.178.17"); //desktop
            IPEndPoint endPoint = new IPEndPoint(ipAddress, 42069); //instellen op welke poort en ip wordt gecommunicate
            Socket s = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            s.Connect(endPoint);
            if (s.Connected)
            {
                //sends
                byte[] msg = Encoding.ASCII.GetBytes(fris);
                s.Send(msg);
                // receive
                byte[] buffer = new byte[100];
                int bytesReceived = s.Receive(buffer);
                result = Encoding.ASCII.GetString(buffer, 0, bytesReceived);
                // close
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }

            return result;

        }
    }
}
