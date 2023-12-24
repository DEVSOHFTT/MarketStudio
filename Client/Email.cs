using System;
using System.Collections.Generic;

namespace Client
{
    public class Email:Data
    {
        string error = "";
        public Email(string to, string subject, string body) :base(to, subject)
        {
            error = SendEmail(body);
        }

        public Email(string to, string subject, string body, List<string> paths) : base(to, subject)
        {
            error = SendFiles(body, paths);
        }

        public string Error { get => error; set => error = value; }
    }
}
