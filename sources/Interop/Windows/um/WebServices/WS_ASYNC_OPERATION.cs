// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_ASYNC_OPERATION
    {
        [NativeTypeName("WS_ASYNC_FUNCTION")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<int, WS_CALLBACK_MODEL, void*, WS_ASYNC_OPERATION*, WS_ASYNC_CONTEXT*, IntPtr, int> function;
#else
        public void* _function;

        public delegate* unmanaged[Stdcall]<int, WS_CALLBACK_MODEL, void*, WS_ASYNC_OPERATION*, WS_ASYNC_CONTEXT*, IntPtr, int> function
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<int, WS_CALLBACK_MODEL, void*, WS_ASYNC_OPERATION*, WS_ASYNC_CONTEXT*, IntPtr, int>)_function;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _function = value;
            }
        }
#endif
    }
}
