using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guitar32
{
    public abstract class Model
    {
        private int id;
        private SystemResponse response;

        public int getId() {
            return this.id;
        }

        public SystemResponse getResponse() {
            return this.response;
        }

        public void setId(int id) {
            this.id = id;
        }

        public void setResponse(SystemResponse response) {
            this.response = response;
        }
    }
}
