using System;

namespace Fabi.Next.Chain.Lib
{
    public static class NextChainObjectExtension
    {
        public static object Next(this object obj, Func<object, object> func) 
        {
            if(func == null) throw new ArgumentNullException(nameof(func));
            return func(obj);
        }
    }
}
