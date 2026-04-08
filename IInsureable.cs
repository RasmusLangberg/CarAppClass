using System;
using System.Collections.Generic;
using System.Text;

namespace CarAppClass
{
    internal interface IInsureable
    {
        string RegistrationNumber { get; }
        double GetInsuranceRate();
    }
}
