using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Account
    {
        public int Sum { get; private set; }
        public IMessenger Messanger { get; set; }
        
        public void  Add(int sum)
        {
            if (Messanger != null)
                Messanger.SendMessage("вы добавили 1000 тенге");
            Sum += sum;
        }
        public void Withdraw(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                if(Messanger!=null)
                Messanger.SendMessage("остаток:" + Sum);
            }
            else
            {
                if (Messanger != null)
                    Console.WriteLine("недостаточно средств");
            }
        }      
    }
}
