/*
 * Created by SharpDevelop.
 * User: pjohnson
 * Date: 11/01/2010
 * Time: 16:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;

namespace dns
{ 
	public class dns
	{
        public static int Main (string [] args)
        {
        
          String strHostName = "";
          if (args.Length == 0)
          {
              // Getting Ip address of local machine...
              // First get the host name of local machine.
              strHostName = Dns.GetHostName ();
              Console.WriteLine ("Local Machine's Host Name: " +  strHostName);
          }
          else
          {
              strHostName = args[0];
          }
          
          // Then using host name, get the IP address list..
          // IPHostEntry ipEntry = Dns.GetHostByName (strHostName);
          IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
          IPAddress [] addr = ipEntry.AddressList;
          
          int ips = 0;
          foreach (IPAddress ipaddr in ipEntry.AddressList)
          {
          	Console.WriteLine("IP #" + ++ips + ": " + ipaddr.ToString());
          }
          Console.ReadKey();
          return 0;
        }    
	}
}
