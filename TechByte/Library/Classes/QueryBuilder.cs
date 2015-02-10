using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Library.Classes
{
    public class QueryBuilder
    {
        private String queryString;

        public QueryBuilder(String __queryString="")
        {
            this.queryString = __queryString;
        }

        public void Select(String query)
        {
            this.queryString += query;
        }


        private void padQuery()
        {
            this.queryString = Utilities.STRING.rightTrim(this.queryString);
        }
    }
}
