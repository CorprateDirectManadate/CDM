using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDM.Domain;

namespace CDM.Service
{
    public partial interface ICurrencyService
    {
        void DoTrans();

        void RunTask();
        IList<Currency> GetCurrencies(int enabled);
    }
}
