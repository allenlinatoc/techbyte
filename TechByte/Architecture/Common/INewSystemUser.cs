using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guitar32;


namespace TechByte.Architecture.Common
{
    public interface INewSystemUser
    {
        void Register(
            // User account
            String position,
            String username,
            String password1, 
            String password2,
            // Profile details
            String firstName,
            String middleName,
            String lastName,
            String gender,
            String birthdate,
            String birthplace,
            String nationality,
            String TIN,
            String SSS,
            String PAGIBIG,
            // Contact details
            String email,
            String mobile,
            String landline,
            String fax,
            // Address details
            String street,
            String city,
            String region,
            String country
            );
    }
}
