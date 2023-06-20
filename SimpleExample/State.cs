using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleExample.Interfaces;

namespace SimpleExample
{
    public class State : IState
    {
        public State(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}