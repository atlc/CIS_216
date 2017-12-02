using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public enum Discount : int
    {
        Corporate = 1,
        Insurance
    }

    // Corporate Rate Class
    class CorporateRate : RentalRate
    {
        private int DiscountRateInteger;
        const Decimal CORPORATE_DISCOUNT_Decimal = 0.05M;
        const Decimal INSURANCE_DISCOUNT_Decimal = 0.01M;

        public CorporateRate(int BeginnerOdometerInteger, int EndingOdometerInteger, int CarSizeInteger, int DaysInteger, int DiscountInteger)
            : base (BeginnerOdometerInteger, EndingOdometerInteger, CarSizeInteger, DaysInteger)
        {
            DiscountRateInteger = DiscountInteger;
            FindAmountDue();
        }

        // overrides base form method FindAmountDue()
        private new Decimal FindAmountDue()
        {

            // Determine the amount due.
            Decimal SubTotalDecimal, DiscountedDailyRateDecimal;

            switch ((Discount)DiscountRateInteger)  // uses enum Discount defined above
            {
                case Discount.Corporate:

                    // do math to determine AmountDueDecimal
                    // Corporate accounts waive the mileage rate and have a 5 percent discount.


                    break;

                case Discount.Insurance:

                    // Insurance accounts have a 10 percent discount on the daily rate.
                    // do math here
                    // There is no mileage charge if the average of the miles
                    // does not exceed an average of 100 miles per day rented.

                    // if statement to decide the correct calculation

                    break;
            }

            return AmountDueDecimal;
        }


    }
}
