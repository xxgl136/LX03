using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service
{
    public class Result<T>
    {
        public int Code = 1;
        public string msg = "";
        public T res = default(T);
        public static Result Ok(T result)
        {
            return new Result() { res = result };
        }
        public static Result Ok(string message,T Result = default(T))
        {
            return new Result() { msg = message, res = Result };
        }
        public static Result Err(string message)
        {
            return new Result() { Code = -1, msg = message };
        }
    }
    public class Result : Result<dynamic>
    {

    }
}
