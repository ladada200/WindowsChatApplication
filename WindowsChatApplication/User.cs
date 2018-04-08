using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsChatApplication
{
    public class User
    {
        public DateTime Created { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Psw { get; set; }
        public enum getInput
        {
            Id, Email, Psw, Created
        }
        public User (int Id, string Email, string Psw)
        {
            //DBconn = getResults;
            this.Id = Id;
            this.Email = Email;
            this.Psw = Psw;
            this.Created = Created;
        }


    }
}
