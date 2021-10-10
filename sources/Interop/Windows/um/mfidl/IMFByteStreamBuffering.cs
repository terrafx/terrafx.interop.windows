// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D66D782-1D4F-4DB7-8C63-CB8C77F1EF5E")]
    [NativeTypeName("struct IMFByteStreamBuffering : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFByteStreamBuffering
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFByteStreamBuffering*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStreamBuffering*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFByteStreamBuffering*, uint>)(lpVtbl[1]))((IMFByteStreamBuffering*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFByteStreamBuffering*, uint>)(lpVtbl[2]))((IMFByteStreamBuffering*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetBufferingParams(MFBYTESTREAM_BUFFERING_PARAMS* pParams)
        {
            return ((delegate* unmanaged<IMFByteStreamBuffering*, MFBYTESTREAM_BUFFERING_PARAMS*, int>)(lpVtbl[3]))((IMFByteStreamBuffering*)Unsafe.AsPointer(ref this), pParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int EnableBuffering([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* unmanaged<IMFByteStreamBuffering*, int, int>)(lpVtbl[4]))((IMFByteStreamBuffering*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int StopBuffering()
        {
            return ((delegate* unmanaged<IMFByteStreamBuffering*, int>)(lpVtbl[5]))((IMFByteStreamBuffering*)Unsafe.AsPointer(ref this));
        }
    }
}
