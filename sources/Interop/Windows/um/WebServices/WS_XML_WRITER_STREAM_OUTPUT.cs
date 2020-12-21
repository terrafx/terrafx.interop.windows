// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_XML_WRITER_STREAM_OUTPUT
    {
        public WS_XML_WRITER_OUTPUT output;

        [NativeTypeName("WS_WRITE_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int> writeCallback;
#else
        public void* _writeCallback;

        public delegate* unmanaged[Stdcall]<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int> writeCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int>)_writeCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _writeCallback = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* writeCallbackState;
    }
}
