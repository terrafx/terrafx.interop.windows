// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_OPERATION_DESCRIPTION
    {
        [NativeTypeName("ULONG")]
        public uint versionInfo;

        [NativeTypeName("WS_MESSAGE_DESCRIPTION *")]
        public WS_MESSAGE_DESCRIPTION* inputMessageDescription;

        [NativeTypeName("WS_MESSAGE_DESCRIPTION *")]
        public WS_MESSAGE_DESCRIPTION* outputMessageDescription;

        [NativeTypeName("ULONG")]
        public uint inputMessageOptions;

        [NativeTypeName("ULONG")]
        public uint outputMessageOptions;

        [NativeTypeName("USHORT")]
        public ushort parameterCount;

        [NativeTypeName("WS_PARAMETER_DESCRIPTION *")]
        public WS_PARAMETER_DESCRIPTION* parameterDescription;

        [NativeTypeName("WS_SERVICE_STUB_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<IntPtr, void*, void*, WS_ASYNC_CONTEXT*, IntPtr, int> stubCallback;
#else
        public void* _stubCallback;

        public delegate* unmanaged[Stdcall]<IntPtr, void*, void*, WS_ASYNC_CONTEXT*, IntPtr, int> stubCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<IntPtr, void*, void*, WS_ASYNC_CONTEXT*, IntPtr, int>)_stubCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _stubCallback = value;
            }
        }
#endif

        public WS_OPERATION_STYLE style;
    }
}
