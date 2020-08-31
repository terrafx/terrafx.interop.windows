// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D66D782-1D4F-4DB7-8C63-CB8C77F1EF5E")]
    [NativeTypeName("struct IMFByteStreamBuffering : IUnknown")]
    public unsafe partial struct IMFByteStreamBuffering
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFByteStreamBuffering*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStreamBuffering*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFByteStreamBuffering*, uint>)(lpVtbl[1]))((IMFByteStreamBuffering*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFByteStreamBuffering*, uint>)(lpVtbl[2]))((IMFByteStreamBuffering*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBufferingParams([NativeTypeName("MFBYTESTREAM_BUFFERING_PARAMS *")] MFBYTESTREAM_BUFFERING_PARAMS* pParams)
        {
            return ((delegate* stdcall<IMFByteStreamBuffering*, MFBYTESTREAM_BUFFERING_PARAMS*, int>)(lpVtbl[3]))((IMFByteStreamBuffering*)Unsafe.AsPointer(ref this), pParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableBuffering([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* stdcall<IMFByteStreamBuffering*, int, int>)(lpVtbl[4]))((IMFByteStreamBuffering*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopBuffering()
        {
            return ((delegate* stdcall<IMFByteStreamBuffering*, int>)(lpVtbl[5]))((IMFByteStreamBuffering*)Unsafe.AsPointer(ref this));
        }
    }
}
