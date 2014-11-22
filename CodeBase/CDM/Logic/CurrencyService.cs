using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CDM.Domain;
using CDM.Service;
using AutoNise.Core;
using AutoNise.Data.NHibernate;
using AutoNise.Logic;
using AutoNise.Service;
//using NHibernate.Linq;
//using SharpArchContrib.Castle.NHibernate;

namespace CDM.Logic
{
   
    public class CurrencyService : ICurrencyService
    {
        private readonly IRepository<Currency, int> _currencies;

        public CurrencyService( IRepository<Currency, int> currencies)
        {
            this._currencies = currencies;
        }

        public void RunTask()
        {
          Debug.WriteLine("Running Task . . .");

          
        }
       // [AutoNise.Data.NHibernate.ITransactionAttributeSettings]
       [Transaction4Logic]
        public void DoTrans()
        {
            var audd = EngineContext.Current.Resolve<IAuditService>();
            var pInfo = new PersonalInformation
            {
                FirstName = "Olawale",
                LastName = "Jekoyemi",
                UserRole = "SystemAdmin",
                UserId = new Guid("EBA7E310-A7B7-429F-A6D6-80A0B7F2D249"),
                EmailVerified = true,
                Email = "victor@AutoNisetech.com",
                PhoneNumber = "0394848412",
            };
            //MembershipCreateStatus status = new MembershipCreateStatus();
            // Membership.CreateUser(pInfo.Email, "password1", pInfo.Email, "What's your Email Address?", pInfo.Email, true, out status);

            var engineP = EngineContext.Current.Resolve<IRepository<PersonalInformation, long>>();
            engineP.Add(pInfo);
          // audd.Log("test","test","he did it");
            
        }
        public IList<Domain.Currency> GetCurrencies(int enabled)
        {
            //list = _studentRepository.GetAll().Fetch(s => s.Mark);
            //list=EagerFetch.Fetch(_studentRepository.GetAll(),s => s.Mark);
            //var query1 = EagerFetchingExtensionMethods.Fetch(this._currencies, x => x.Country);
            //var jj = query1.ToList();
            //var query2 = EagerFetch.Fetch(this._currencies, s => s.Country);
            //var jj2 = query2.ToList();

            var _count = this._currencies.Count(x=>x.Enabled);
          //  var hfh = this._currencies.FetchMany();
          //  var hhd = this._currencies.Provider;
            //var hhdj = this._currencies.All(x => x.Enabled);
            var uu = this._currencies.Fetch(x => x.Enabled);

            var hhff = this._currencies.Table.Fetch(x=>x.Country);//.FetchMany(x => x.Country);

            var j = this._currencies.Table.FirstOrDefault();
            var kk = this._currencies.Fetch(x => x.Enabled, mp => { mp.Asc(x => x.Country); });


            var query = this._currencies.Table;
            if (enabled > 0)
            {
                var _enabled = enabled == 1 ? true : false;
                query = query.Where(x => x.Enabled == _enabled);
            }
            return query.ToList();
        }

        public void Testing()
        {
            throw new NotImplementedException();
        }

       
    }
}
