using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial class Windows
    {
        private static Dictionary<IntPtr, Delegate> _cachedDelegates = new Dictionary<IntPtr, Delegate>();

        public static TDelegate GetDelegateForFunctionPointer<TDelegate>(IntPtr handle)
            where TDelegate : Delegate
        {
            if (!_cachedDelegates.TryGetValue(handle, out var result))
            {
                result = Marshal.GetDelegateForFunctionPointer<TDelegate>(handle);
                _cachedDelegates[handle] = result;
            }

            return (TDelegate)result;
        }
    }
}
