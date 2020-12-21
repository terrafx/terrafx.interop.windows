// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_SERVICE_PROPERTY_CLOSE_CALLBACK
    {
        [NativeTypeName("WS_SERVICE_CLOSE_CHANNEL_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<IntPtr, WS_ASYNC_CONTEXT*, int> callback;
#else
        public void* _callback;

        public delegate* unmanaged[Stdcall]<IntPtr, WS_ASYNC_CONTEXT*, int> callback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<IntPtr, WS_ASYNC_CONTEXT*, int>)_callback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _callback = value;
            }
        }
#endif
    }
}
