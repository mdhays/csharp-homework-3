﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Spy
    {
        private string codeName;
        private Agency agency;
        private DateTime dateLastSeen;
        private string notes;

        public string CodeName
        {
            get { return codeName; }
            set { codeName = value; }
        }

        public Agency SpyAgency
        {
            get { return agency; }
            set { agency = value; }
        }

        public DateTime DateLastSeen
        {
            get { return dateLastSeen; }
            set { dateLastSeen = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public void DisplaySpyInfo()
        {

        }

    }
}
