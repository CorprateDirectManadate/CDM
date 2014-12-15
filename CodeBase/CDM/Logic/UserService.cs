using AutoNise.Service;
using CDM.Domain;
using CDM.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace CDM.Logic
{
    public class UserService: IUserService
    {
        private readonly IRepository<PersonalInformation, long> _personalInformation;

        public UserService(IRepository<PersonalInformation, long> personalInformation)
        {
            _personalInformation = personalInformation;
        }
        public string CreateUser(PersonalInformation pInfo, string password)
        {
            MembershipCreateStatus status;
            MembershipUser user = null;
            string msg = "";

            Membership.CreateUser(pInfo.Email, password, pInfo.Email, "What's your email address", pInfo.Email, false, out status);
            if (status == MembershipCreateStatus.Success)
            {
                user = Membership.GetUser(pInfo.Email);

                pInfo.UserId = (Guid)user.ProviderUserKey;

                _personalInformation.Add(pInfo);
                _personalInformation.Refresh(pInfo);

                //Send Mails
                
            }
            else
            {
                msg = GetErrorMessage(status);
            }

            return msg;
        }

        private string GetErrorMessage(MembershipCreateStatus membershipCreateStatus)
        {


            switch (membershipCreateStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "Username already exists. Please enter a different user name.";
                case MembershipCreateStatus.DuplicateEmail:
                    return "A username for that e-mail address already exists. Please enter a different e-mail address.";
                case MembershipCreateStatus.InvalidPassword:
                    return string.Format("The password provided is invalid. Please enter a valid password value .\n\n\t Your password must be alphanumeric and must be at least 8 character(Any Case)");
                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";
                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";
                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";
                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";
                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }

        }
        public PersonalInformation GetPersonalInformation(string email)
        {
            var query = from p in _personalInformation.Table
                        where p.Email.ToLower() == email.ToLower()
                        select p;

            return query.FirstOrDefault();
        }
    }
}
