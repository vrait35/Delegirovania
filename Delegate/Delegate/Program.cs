using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Account account = new Account();
            //account.Messanger = new Messenger();
            account.Messanger = new Email();
            account.Add(1000);            
            account.Withdraw(500);            
            Console.WriteLine(account.Sum);
            
        }
       
    }
}
