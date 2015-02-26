using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TechByte.Architecture.Usecases;



namespace TechByte.Controllers
{
    /// <summary>
    /// Utility Model for System logins
    /// </summary>
    public class SystemLogin : Guitar32.Model, TechByte.Architecture.Common.IRegisteredUser
    {

        public SystemLogin() { }

        public void Login(String username, String password) {
            // Check datatype
            Guitar32.Validations.SingleWordAlphaNumeric valUsername = new Guitar32.Validations.SingleWordAlphaNumeric(username);
            Guitar32.Validations.Password valPassword = new Guitar32.Validations.Password(password);
            if (!(valUsername.isValid() && valPassword.isValid())) {
                this.setResponse(TechByte.Values.CODES.INVALID_FORMAT);
                return;
            }

            UCSystemUser uc_SystemUser = new UCSystemUser();
            uc_SystemUser.Authenticate(valUsername.getValue(), valPassword.getValue());
            Guitar32.SystemResponse response = uc_SystemUser.getResponse();
            this.setResponse(response);
        }
    }
}
