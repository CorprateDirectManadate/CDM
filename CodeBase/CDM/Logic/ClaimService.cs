using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using CDM.Domain;
using CDM.Service;

namespace CDM.Logic
{
    public class ClaimService: IClaimService
    {
        private readonly IUserService _userService;
        public ClaimService(IUserService userService)
        {
            _userService = userService;
        }
        public Claim GetClaim()
        {
            Claim claim = null;

            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

            if (authenticationManager != null)
            {
                var _User = authenticationManager.User;
                if (_User != null && _User.Identity.IsAuthenticated)
                {
                    var _UserName = _User.Identity.Name;
                    //var membershipUser = Membership.GetUser(_UserName);
                    var user = _userService.GetPersonalInformation(_UserName);
                    claim = new Claim
                    {
                        FullName = user.FullName,
                        UserId = user.UserId,
                        UserName = user.Email,
                        OrganizationName = (user.Organization != null) ? user.Organization.Name : "Admin",

                        //OrganizationName = user.marketParticipant.ParticipantType.ToString()
                    };
                }
            }
            return claim;
        }
    }
}
