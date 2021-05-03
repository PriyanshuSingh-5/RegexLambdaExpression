using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegisLambdaExpression
{
    public class ValidateEmails
    {
        public static void emailValidation(List<string> emailList)
        {

            //Invalid emails list
            emailList.Add("abc@yahoo.com");
            emailList.Add("abc-100@yahoo.com");
            emailList.Add("abc.100@yahoo.com");
            emailList.Add("abc111@abc.com");
            emailList.Add("abc-100@abc.net");
            emailList.Add("abc.100@abc.com.au");
            emailList.Add("abc@1.com");
            emailList.Add("abc@gmail.com.com");
            emailList.Add("abc+100@gmail.com");
            emailList.Add("abc@.com.my");
            emailList.Add("abc123@gmail.a");
            emailList.Add("abc123@.com");
            emailList.Add("abc123@.com.com");
            emailList.Add(".abc@abc.com");
            emailList.Add("abc()*@gmail.com");
            emailList.Add("abc@%*.com");
            emailList.Add("abc..2002@gmail.com");
            emailList.Add("abc.@gmail.com");
            emailList.Add("abc@abc@gmail.com");

            //pattern for email
            string regexPattern = "^([A-Za-z\\d-_\\+]+)(\\.[A-Za-z\\d-_]+)?@([a-zA-Z\\d]+)\\.([a-zA-Z]{2,4})(\\.[A-Za-z]{2,4})?$";
            RegexPattern emailPattern = new RegexPattern(regexPattern);
            foreach (string item in emailList)
            {
                Console.WriteLine(item + " : " + emailPattern.Equals(item));
            }
        }
    }
}
    

    


    }
}
