using System;
using System.Runtime.ExceptionServices;

namespace ExceptionExample
{
    static class ExceptionDispatchExample
    {
        internal static void Run() => MethodRethrowingException();

        private static void MethodRethrowingException()
        {
            try
            {
                MethodThrowingException();

                MethodThrowingException();
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
        }

        private static void MethodThrowingException()
        {
            throw new NotImplementedException();
        }
    }
}
