// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_CUSTOM_TYPE_DESCRIPTION
    {
        [NativeTypeName("ULONG")]
        public uint size;

        [NativeTypeName("ULONG")]
        public uint alignment;

        [NativeTypeName("WS_READ_TYPE_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<IntPtr, WS_TYPE_MAPPING, void*, IntPtr, void*, uint, IntPtr, int> readCallback;
#else
        public void* _readCallback;

        public delegate* unmanaged[Stdcall]<IntPtr, WS_TYPE_MAPPING, void*, IntPtr, void*, uint, IntPtr, int> readCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<IntPtr, WS_TYPE_MAPPING, void*, IntPtr, void*, uint, IntPtr, int>)_readCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _readCallback = value;
            }
        }
#endif

        [NativeTypeName("WS_WRITE_TYPE_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<IntPtr, WS_TYPE_MAPPING, void*, void*, uint, IntPtr, int> writeCallback;
#else
        public void* _writeCallback;

        public delegate* unmanaged[Stdcall]<IntPtr, WS_TYPE_MAPPING, void*, void*, uint, IntPtr, int> writeCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<IntPtr, WS_TYPE_MAPPING, void*, void*, uint, IntPtr, int>)_writeCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _writeCallback = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* descriptionData;

        [NativeTypeName("WS_IS_DEFAULT_VALUE_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, void*, void*, uint, int*, IntPtr, int> isDefaultValueCallback;
#else
        public void* _isDefaultValueCallback;

        public delegate* unmanaged[Stdcall]<void*, void*, void*, uint, int*, IntPtr, int> isDefaultValueCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, void*, void*, uint, int*, IntPtr, int>)_isDefaultValueCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _isDefaultValueCallback = value;
            }
        }
#endif
    }
}
