
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

//for moq testing
namespace testproject
{
    public interface IGreetings
    {
        string from { get; set; }
        string to { get; set; }
        string msg { get; }
        string msgType { get; set; }
    }

    public class Greetings : IGreetings
    {
        public string from { get; set; }
        public string to { get; set; }
        public string msg { get => createmsg(); }
        public string msgType { get; set; }

        virtual protected string createmsg()
        {

            return "Vaccination Drive!!!";

        }
    }

    public class ActualGreetings
    {
        private IGreetings greet;
        public ActualGreetings(IGreetings g)
        {
            if (g == null)
                throw new ArgumentNullException(nameof(g));

            greet = g;

        }
        public string data1() => greet.from;
        public string data2() => greet.to;
        public string data3() => greet.msg;
        public string data4() => greet.msgType;


    }
}
