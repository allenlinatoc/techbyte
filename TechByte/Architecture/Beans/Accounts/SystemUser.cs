using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guitar32;

using TechByte.Architecture;

namespace TechByte.Architecture.Beans.Accounts
{
    public class SystemUser : Model
    {
        private String
            username,
            password
            ;
        private Userprofile
            profile
            ;
        private String status;
        private String power;


        public String getPassword() {
            return this.password;
        }

        public String getPower() {
            return this.power;
        }

        public String getStatus() {
            return this.status;
        }

        public String getUsername() {
            return this.username;
        }

        public Userprofile getProfile() {
            return this.profile;
        }

        public void setPassword(Guitar32.Validations.Password password) {
            this.password = password.getValue();
        }

        public void setPower(TechByte.Architecture.Validations.UserPower userPower) {
            this.power = userPower.getValue();
        }

        public void setStatus(Architecture.Validations.AccountStatus status) {
            this.status = status.getValue();
        }

        public void setUsername(Guitar32.Validations.SingleWordAlphaNumeric username) {
            this.username = username.getValue();
        }

        public void setProfile(Userprofile profile) {
            this.profile = profile;
        }

    }
}