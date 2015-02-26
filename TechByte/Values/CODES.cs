using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Guitar32;


namespace TechByte.Values
{
    /// <summary>
    /// Class containing TechByte's SystemResponse codes and messages
    /// </summary>
    public class CODES
    {

        public static SystemResponse 
            DATABASE_ERROR = new SystemResponse("02", "A database error occured, please try to contact the system administrator or further assistance"),
            INVALID_FORMAT = new SystemResponse("10", "Invalid format of data, please try your inputs and try again"),
            INVALID_LOGIN = new SystemResponse("20", "Invalid credentials, please try again"),
            REG_ERR_PASSWORDS = new SystemResponse("30", "Passwords didn't matched, please confirm and try again"),
            USERNAME_ALREADY_TAKEN = new SystemResponse("100", "Username is already taken, please try another username")
        ;


    }

    public class InvalidResponseCodeException : Exception {
        public InvalidResponseCodeException() 
            : base("Invalid response code was provided") { }
    }
    


}
