// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_SERVICE_CONTRACT
    {
        [NativeTypeName("const WS_CONTRACT_DESCRIPTION *")]
        public WS_CONTRACT_DESCRIPTION* contractDescription;

        [NativeTypeName("WS_SERVICE_MESSAGE_RECEIVE_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> defaultMessageHandlerCallback;
#else
        public void* _defaultMessageHandlerCallback;

        public delegate* unmanaged[Stdcall]<IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int> defaultMessageHandlerCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<IntPtr, WS_ASYNC_CONTEXT*, IntPtr, int>)_defaultMessageHandlerCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _defaultMessageHandlerCallback = value;
            }
        }
#endif

        [NativeTypeName("const void *")]
        public void* methodTable;
    }
}
