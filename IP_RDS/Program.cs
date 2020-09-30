using Cassia;
using System;


namespace IP_RDS
{
    class Program
    {
        static void Main(string[] args)
        {
            ITerminalServicesManager manager = new TerminalServicesManager();
            using (ITerminalServer server = manager.GetLocalServer())
            {
                server.Open();
                foreach (ITerminalServicesSession session in server.GetSessions())
                    //Console.WriteLine(session.UserAccount.Value);
                    if (session.UserName == Environment.UserName)
                    {

                        Console.WriteLine(session.UserAccount + " on session " + session.SessionId + " ip address " + session.ClientIPAddress);
                    
            
                        
                
                //Console.WriteLine("It looks like you logged on at " + session.LoginTime + " and are now " + session.ConnectionState); 
                    } 
            }

            Console.ReadKey();
        }
    }
}
