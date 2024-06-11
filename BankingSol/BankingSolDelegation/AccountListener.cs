using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSolDelegation
{
    public class AccountListener
    {
        public AccountListener() { }

        public void DeactivateAccount(object? sender, EventArgs e)
        {
            Console.WriteLine("acct deactivated");
        }

        public void ActivateAccount(object? sender, EventArgs e)
        {
            Console.WriteLine("acct activated");
        }

        public void SendEmail(object? sender, EventArgs e)
        {
            Console.WriteLine("email sent");
        }
        public void SendSMS(object? sender, EventArgs e)
        {
            Console.WriteLine("SMS Sent");
        }

        public void SendNotificationOnWhatsApp(object? sender, EventArgs e)
        {
            Console.WriteLine("Whatsapp msg sent");
        }
    }
}
