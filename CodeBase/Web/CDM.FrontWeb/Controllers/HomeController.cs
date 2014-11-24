using System.Linq;
using System.Web.Mvc;
using AutoNise.Service;
using CDM.Service;

namespace CDM.FrontWeb.Controllers
{
    public class HomeController : Controller //BaseController
    {
         private readonly IDateTimeHelper _dateTime;
         private readonly ICurrencyService _CurrencyService;
         public HomeController(IDateTimeHelper dateTime, ICurrencyService currency)
        {
            this._dateTime = dateTime;
             this._CurrencyService = currency;
        }
         //public HomeController()
         //{
         //    this._dateTime = EngineContext.Resolve<IDateTimeHelper>();

         //}
        public ActionResult Index()
        {
        
            return View();
        }

        public ActionResult About()
        {
          //  var ITransactionAttributeSettings = EngineContext.Current.Resolve<ITransactionAttributeSettings>();
          //ITransactionAttributeSettings.Testing();
       //      this._CurrencyService.DoTrans();

           // var Engine = EngineContext.Current.Resolve<IAsyncTask>();
            //Engine.RunDelayed<ICurrencyService>(x => x.RunTask(), TimeSpan.FromSeconds(2));

            //Engine.RunCronJob<ICurrencyService>(x => x.RunTask(), "* * * * *");

            //var _setup = SplsWorkflow.WorkflowSetup;
            //_setup.SetupWorkflow(new Workflow
            //{
            //    Name = "Olawale",OnRejection = Operator.OnRejection.StartWorkflowAgain, MaxLevel = 8
                

            //});
           var hh =  this._CurrencyService.GetCurrencies(-1);
           // list = _studentRepository.GetAll().Fetch(s => s.Mark);
            //И Так: list=EagerFetch.Fetch(_studentRepository.GetAll(),s => s.Mark);
            ViewBag.Message = "Your application description page." +
                              this._CurrencyService.GetCurrencies(1).FirstOrDefault().Country;

            return View();
        }

        public ActionResult Login()
        {
            return PartialView();
        }

        public ActionResult Main()
        {
            return PartialView();
        }
       
        public ActionResult Contact()
        {
            
            //Roles.CreateRole("Agency");
            //Roles.CreateRole("Organization");
            //Roles.CreateRole("SystemAdmin");
            //var _user = Membership.GetUser("victor@AutoNisetech.com");
            //var pInfo = new PersonalInformation
            //{
            //    FirstName = "Olawale",
            //    LastName = "Jekoyemi",
            //    UserRole = "SystemAdmin",
            //    UserId = new Guid(_user.ProviderUserKey.ToString()),
            //    EmailVerified = true,
            //    Email = "victor@AutoNisetech.com",
            //    PhoneNumber = "0394848412",
            //};
            ////MembershipCreateStatus status = new MembershipCreateStatus();
            //// Membership.CreateUser(pInfo.Email, "password1", pInfo.Email, "What's your Email Address?", pInfo.Email, true, out status);

            //var engineP = EngineContext.Current.Resolve<IRepository<PersonalInformation, long>>();
            //engineP.Add(pInfo);


            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}