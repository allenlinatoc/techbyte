using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Models.Architecture.Accounts
{
    public class SystemUser : Model
    {
        public String
            username,
            password
            ;
        public Userprofile
            profile
            ;
        public Status status;


        public String getPassword() {
            return this.password;
        }

        public Status getStatus() {
            return this.status;
        }

        public String getUsername() {
            return this.username;
        }

        public Userprofile getProfile() {
            return this.profile;
        }

        public void setPassword(String password) {
            this.password = password;
        }

        public void setStatus(Status status) {
            this.status = status;
        }

        public void setUsername(String username) {
            this.username = username;
        }

        public void setProfile(Userprofile profile) {
            this.profile = profile;
        }



        public enum Status
        {
            ACTIVE,
            INACTIVE
        }
    }
}