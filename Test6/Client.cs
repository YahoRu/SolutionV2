using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    public class Client
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        private bool Admin { get;  set; }

        public Client()
        {
        }

        public Client(string name)
        {
            Id = 0;
            Name = name;
            Admin = false;
        }

        public void ChangeId(int id)
        {
            Id = id;
        }

        public void ChangeRights()
        {
            if (Admin == false)
            {
                Admin = true;
            }
            else Admin = false;
        }

    }
}
