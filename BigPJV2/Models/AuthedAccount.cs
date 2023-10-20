using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPJV2.Models
{
    public static class AuthedAccount
    {
        private static Account instance = null;

        public static Account Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Account();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
    }
}
