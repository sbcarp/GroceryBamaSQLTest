using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace GroceryBama.Entities
{
    [DataContract]
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }
        

    }
}
