using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Models;

namespace Lab04.Helpers
{
    public class Data
    {
        private static Data _instance = null;

        public ColaPrio<HospitalModel> Cola = new ColaPrio<HospitalModel>();
        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }
    }
}
