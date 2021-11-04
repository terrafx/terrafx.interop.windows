// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("69D14C80-C18E-11D0-A9CE-006097942311")]
    [NativeTypeName("struct IDataFilter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDataFilter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDataFilter*, Guid*, void**, int>)(lpVtbl[0]))((IDataFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDataFilter*, uint>)(lpVtbl[1]))((IDataFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDataFilter*, uint>)(lpVtbl[2]))((IDataFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT DoEncode([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int lInBufferSize, byte* pbInBuffer, [NativeTypeName("LONG")] int lOutBufferSize, byte* pbOutBuffer, [NativeTypeName("LONG")] int lInBytesAvailable, [NativeTypeName("LONG *")] int* plInBytesRead, [NativeTypeName("LONG *")] int* plOutBytesWritten, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IDataFilter*, uint, int, byte*, int, byte*, int, int*, int*, uint, int>)(lpVtbl[3]))((IDataFilter*)Unsafe.AsPointer(ref this), dwFlags, lInBufferSize, pbInBuffer, lOutBufferSize, pbOutBuffer, lInBytesAvailable, plInBytesRead, plOutBytesWritten, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT DoDecode([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int lInBufferSize, byte* pbInBuffer, [NativeTypeName("LONG")] int lOutBufferSize, byte* pbOutBuffer, [NativeTypeName("LONG")] int lInBytesAvailable, [NativeTypeName("LONG *")] int* plInBytesRead, [NativeTypeName("LONG *")] int* plOutBytesWritten, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IDataFilter*, uint, int, byte*, int, byte*, int, int*, int*, uint, int>)(lpVtbl[4]))((IDataFilter*)Unsafe.AsPointer(ref this), dwFlags, lInBufferSize, pbInBuffer, lOutBufferSize, pbOutBuffer, lInBytesAvailable, plInBytesRead, plOutBytesWritten, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetEncodingLevel([NativeTypeName("DWORD")] uint dwEncLevel)
        {
            return ((delegate* unmanaged<IDataFilter*, uint, int>)(lpVtbl[5]))((IDataFilter*)Unsafe.AsPointer(ref this), dwEncLevel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataFilter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDataFilter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDataFilter*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, LONG, BYTE *, LONG, BYTE *, LONG, LONG *, LONG *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataFilter*, uint, int, byte*, int, byte*, int, int*, int*, uint, int> DoEncode;

            [NativeTypeName("HRESULT (DWORD, LONG, BYTE *, LONG, BYTE *, LONG, LONG *, LONG *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataFilter*, uint, int, byte*, int, byte*, int, int*, int*, uint, int> DoDecode;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataFilter*, uint, int> SetEncodingLevel;
        }
    }
}
