﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_6
{
    class ClsInstitute
    {
        private static Dictionary<string, ClsStudent> _StudentList = new Dictionary<string, ClsStudent>();

        public static Dictionary<string, ClsStudent> StudentList
        {
            get { return ClsInstitute._StudentList; }
            //set { ClsInstitute._StudentList = value; }
        }

        public static decimal TotalBalance()
        {
            decimal lcTotal = 0;
            foreach (ClsStudent lcStudent in _StudentList.Values)
                lcTotal += lcStudent.Balance;
            return lcTotal;
        }
    }
}
