/*
'Program: EX02CarRentals
'Programmer: Theresa Berry and John Blyzka
'Date: August 2008
'Class: RentalRate
'Description: This class calculates the car rental rate.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment01
{

    public enum CarSize : int
    {
        Compact,
        MidSize,
        Luxury,
    }

    class RentalRate
    {
        protected int BeginInteger, EndInteger, SizeInteger, NumberDaysInteger, NumberMilesInteger;
        protected Decimal DailyRateDecimal, MileageRateDecimal, AvgDailyMilesDecimal, AmountDueDecimal;
        const Decimal COMPACT_DAILY_RATE_Decimal = 26.95M;
        const Decimal MIDSIZE_DAILY_RATE_Decimal = 32.95M;
        const Decimal LUXURY_DAILY_RATE_Decimal = 50.95M;
        const Decimal COMPACT_MILEAGE_RATE_Decimal = 0.12M;
        const Decimal MIDSIZE_MILEAGE_RATE_Decimal = 0.15M;
        const Decimal LUXURY_MILEAGE_RATE_Decimal = 0.2M;
        protected const int MAX_MILES_Integer = 100;

        public RentalRate(int BeginOdometerInteger, int EndOdometerInteger, int CarSizeInteger, int DaysInteger)
        {
            //Assign the property values.
            BeginInteger = BeginOdometerInteger;
            EndInteger = EndOdometerInteger;
            SizeInteger = CarSizeInteger;
            NumberDaysInteger = DaysInteger;
            FindRentalRates();
            FindNumberMiles();
            FindAmountDue();
        }

        // default constructor required
        public RentalRate()
        {
            BeginInteger = 0;
        }

        private void FindNumberMiles()
        {
            NumberMilesInteger = EndInteger - BeginInteger; // Determine the number of miles.
                                                            // Determine the average number of miles per day.
            Decimal.TryParse((NumberMilesInteger / NumberDaysInteger).ToString(), out AvgDailyMilesDecimal);
        }

        public Decimal getAmountDue()
        {
            return AmountDueDecimal;
        }

        private void FindAmountDue()
        {
            // There is no mileage charge if the average of the miles does not exceed an average of 100 miles per day rented.

            if (AvgDailyMilesDecimal <= MAX_MILES_Integer)

                AmountDueDecimal = (DailyRateDecimal * NumberDaysInteger);
            else
                AmountDueDecimal = (DailyRateDecimal * NumberDaysInteger) + (NumberMilesInteger * MileageRateDecimal);
        }

        private void FindRentalRates()
        {
            // Calculate the rental rate.
            switch ((CarSize)SizeInteger) // cast integer into type CarSize
            {
                case CarSize.Compact:
                    DailyRateDecimal = COMPACT_DAILY_RATE_Decimal;
                    MileageRateDecimal = COMPACT_MILEAGE_RATE_Decimal;
                    break;
                case CarSize.MidSize:
                    DailyRateDecimal = MIDSIZE_DAILY_RATE_Decimal;
                    MileageRateDecimal = MIDSIZE_MILEAGE_RATE_Decimal;
                    break;
                case CarSize.Luxury:
                    DailyRateDecimal = LUXURY_DAILY_RATE_Decimal;
                    MileageRateDecimal = LUXURY_MILEAGE_RATE_Decimal;
                    break;
            }
        }

    }
}