using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Models
{
    public abstract class Model
    {
        protected int id;

        public int getId() {
            return this.id;
        }

        public void setId(int id) {
            this.id = id;
        }
    }
}
