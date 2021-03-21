using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FileData;
using Models;

namespace BlazorAssignment.Data.Adapter
{
    public class AdulsService
    {
        private FileContext fileContext = new FileContext();
        public IList<Adult> GetAdultsList()
        {
            IList<Adult> list =fileContext.Adults;
            return list;
        }
    }
}