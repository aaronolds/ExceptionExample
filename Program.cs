using System;
using System.Runtime.ExceptionServices;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionDispatchExample.Run();
            // Unhandled Exception: System.NotImplementedException: The method or operation is not implemented.
            //    at ExceptionExample.ExceptionDispatchExample.MethodThrowingException() in E:\Research\Exception\ExceptionDispatchExample.cs:line 26
            //    at ExceptionExample.ExceptionDispatchExample.MethodRethrowingException() in E:\Research\Exception\ExceptionDispatchExample.cs:line 14
            // --- End of stack trace from previous location where exception was thrown ---
            //    at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
            //    at ExceptionExample.ExceptionDispatchExample.MethodRethrowingException() in E:\Research\Exception\ExceptionDispatchExample.cs:line 20
            //    at ExceptionExample.ExceptionDispatchExample.Run() in E:\Research\Exception\ExceptionDispatchExample.cs:line 8
            //    at ExceptionExample.Program.Main(String[] args) in E:\Research\Exception\Program.cs:line 10

            // RethrowException.Run();
            // Unhandled Exception: System.Exception: The method or operation is not implemented. ---> System.NotImplementedException: The method or operation is not implemented.
            //    at ExceptionExample.RethrowException.MethodThrowingException() in E:\Research\Exception\RethrowException.cs:line 26
            //    at ExceptionExample.RethrowException.MethodRethrowingException() in E:\Research\Exception\RethrowException.cs:line 14
            //    --- End of inner exception stack trace ---
            //    at ExceptionExample.RethrowException.MethodRethrowingException() in E:\Research\Exception\RethrowException.cs:line 20
            //    at ExceptionExample.RethrowException.Run() in E:\Research\Exception\RethrowException.cs:line 8
            //    at ExceptionExample.Program.Main(String[] args) in E:\Research\Exception\Program.cs:line 10            
        }
    }
}
