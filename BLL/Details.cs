using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Details
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Details(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
