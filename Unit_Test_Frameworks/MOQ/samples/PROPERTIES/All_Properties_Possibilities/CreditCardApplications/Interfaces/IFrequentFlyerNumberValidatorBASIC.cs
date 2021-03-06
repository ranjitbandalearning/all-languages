using System;

namespace CreditCardApplications
{
    public interface IFrequentFlyerNumberBASIC
    {
        bool IsValid(string frequentFlyerNumber);
        void IsValid(string frequentFlyerNumber, out bool isValid);
        string LicenseKey { get; }
    }
}