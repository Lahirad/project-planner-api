using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Domain.Projectes
{
   public sealed class Result<T>
    {
        public string Status { get; set; } // "success" | "error"
        public int Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public List<Error> Errors { get; set; }
        public Meta Meta { get; set; }

        public Result(string status, int code, string message, T data, List<Error> errors,string apiVersion = "v1")
        {
            Status = status;
            Code = code;
            Message = message;
            Data = data;
            Errors = errors;
            Meta = Meta.Create(apiVersion);
        }

        // ✅ Success factory
        public static Result<T> Success(T data, string message = "Success", int code = 200)
        {
            return new Result<T>("success", code, message, data, null);
        }

        // ❌ Error factory
        public static Result<T> Error(string message = "Error", int code = 500, List<Error> errors = null)
        {
            return new Result<T>("error", code, message, default, errors);
        }
    }
}
