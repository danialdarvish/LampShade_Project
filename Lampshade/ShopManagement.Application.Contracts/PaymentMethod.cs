using System.Collections.Generic;
using System.Linq;

namespace ShopManagement.Application.Contracts
{
    public class PaymentMethod
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        private PaymentMethod(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public static List<PaymentMethod> GetList()
        {
            return new List<PaymentMethod>
            {
                new PaymentMethod(1, "پرداخت اینترنتی", "از طریق زرین پال"),
                new PaymentMethod(2, "پرداخت حضوری", "هنگام تحویل")
            };
        }

        public static PaymentMethod GetBy(int id)
        {
            return GetList().FirstOrDefault(x => x.Id == id);
        }
    }
}
