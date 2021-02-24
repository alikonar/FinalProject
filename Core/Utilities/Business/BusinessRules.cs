using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) // bu params ile istediğimiz kadar IResult ekleyebiliriz demek.
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)  //bütün kuralları gez. Kurala uymayan bir logic varsa döndür.
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
