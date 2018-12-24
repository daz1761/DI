using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    // this will be used to new-up instances
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            // normally this typically would be more complex
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessageSender());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMessageSender()
        {
            //return new Emailer();
            return new Texter();
        }
    }
}
