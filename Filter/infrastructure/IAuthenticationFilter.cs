using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc.Filters;

namespace Filter.infrastructure
{
    public interface IAuthenticationFilter
    {
        void OnAuthentication(AuthenticationContext context);
        void OnAuthenticationChallenge(AuthenticationChallengeContext context);
    }
}
