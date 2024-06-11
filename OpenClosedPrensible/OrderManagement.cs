using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrensible
{
    //public enum CardType
    //{
    //    Standard,
    //    Silver,
    //    Gold,
    //    Premium
    //}

    public abstract class CardType
    {
        public abstract decimal GetDiscountedPrice(decimal totalAmount);
    }
    public class StandardCard : CardType
    {
        public override decimal GetDiscountedPrice(decimal totalAmount)
        {
            return totalAmount * 0.95m;
        }
    }
    public class SilverCard : CardType
    {
        public override decimal GetDiscountedPrice(decimal totalAmount)
        {
            return totalAmount * 0.90m;
        }
    }
    public class GoldCard : CardType
    {
        public override decimal GetDiscountedPrice(decimal totalAmount)
        {
            return totalAmount * 0.85m;
        }
    }
    public class PremiumCard : CardType
    {
        public override decimal GetDiscountedPrice(decimal totalAmount)
        {
            return totalAmount * 0.80m;
        }
    }
    public class  Customer
    {
        public string Name { get; set; }
        public CardType CardType { get; set; }

    }
    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public decimal GetDiscountedPrice(decimal totalAmount)
        {
            //switch (Customer.CardType)
            //{
            //    case CardType.Standard:
            //        return totalAmount * 0.95m;
            //    case CardType.Silver:
            //        return  totalAmount * 0.90m;
            //    case CardType.Gold:
            //        return totalAmount * 0.85m;
            //    default:
            //        return totalAmount;
            //}

            return Customer.CardType.GetDiscountedPrice(totalAmount);
        }
    }
}
