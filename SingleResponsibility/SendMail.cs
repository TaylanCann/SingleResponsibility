using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityUsingTrue
{
    public class SendMail
    {
        private MailAdressValidator _validator = new MailAdressValidator();

        public bool SendMailForX(string input, string mailAdress)
        {
            // Kural denetimini _validator nesnesine yaptır
            if (!_validator.IsMailAdressValid(mailAdress))
                return false;

            // Formatlama işlemini yap
            return true;
        }
    }
    
}
