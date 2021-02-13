using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message) // implemente ettiğimiz Result'a atıfta bulunur base yapısı.
        {

        }

        public SuccessResult():base(true) //default olarak true veriyoruz.
        {

        }
    }
}
