using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Model
{
    public class Key
    {
        public int From { get; set; } //stare
        public int Choice { get; set; } //alege de continuare

        //de implementat 
        public override int GetHashCode()
        {
            return 2 * From.GetHashCode() + 3 * Choice.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            Key key = (Key)obj;

            return (this.From == key.From) && (this.Choice == key.Choice);
        }
    }
}
