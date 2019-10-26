using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Email
    {
        private string content;
        private string subject;
        private DateTime dueTime;

        public Email(string content , string subject , DateTime dueTime)
        {
            this.content = content;
            this.subject = subject;
            this.dueTime = dueTime;
        }

        public void setContent(string content)
        {
            this.content = content;
        }
        public void setSubject(string Subject)
        {
            this.subject = Subject;
        }

        public void setDueTime(DateTime DueTime)
        {
            this.dueTime = DueTime;
        }

       

        public string getContent()
        {
            return this.content;
        }

        public string getSubject()
        {
            return this.subject;
        }

        public DateTime getDuetime()
        {
            return this.dueTime;
        }

    }



}