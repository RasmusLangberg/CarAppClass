using System;
using System.Collections.Generic;
using System.Text;

namespace CarAppClass
{
    internal interface ISellable
    {
        double Price { get; }
        string GetSalesSummary();
    }
}
