using System;
using System.Runtime.ExceptionServices;

namespace ExceptionExample
{
    static class RethrowException
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
                throw new Exception(e.Message, e);
            }
        }

        private static void MethodThrowingException()
        {
            throw new NotImplementedException();
        }
    }
}
