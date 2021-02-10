using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //this tek parametre ile çalışmak için kullanılır.classın kendisidir.
        public Result(bool success, string message):this(success)
        {
            Message = message;            
        }
        //Eger mesaj verdirmek istemiyorsak
        public Result(bool success)
        {           
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
