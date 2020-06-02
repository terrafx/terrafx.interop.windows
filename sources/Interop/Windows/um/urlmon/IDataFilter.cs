// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("69D14C80-C18E-11D0-A9CE-006097942311")]
    public unsafe partial struct IDataFilter
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDataFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDataFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDataFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DoEncode([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int lInBufferSize, [NativeTypeName("BYTE *")] byte* pbInBuffer, [NativeTypeName("LONG")] int lOutBufferSize, [NativeTypeName("BYTE *")] byte* pbOutBuffer, [NativeTypeName("LONG")] int lInBytesAvailable, [NativeTypeName("LONG *")] int* plInBytesRead, [NativeTypeName("LONG *")] int* plOutBytesWritten, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->DoEncode((IDataFilter*)Unsafe.AsPointer(ref this), dwFlags, lInBufferSize, pbInBuffer, lOutBufferSize, pbOutBuffer, lInBytesAvailable, plInBytesRead, plOutBytesWritten, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoDecode([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int lInBufferSize, [NativeTypeName("BYTE *")] byte* pbInBuffer, [NativeTypeName("LONG")] int lOutBufferSize, [NativeTypeName("BYTE *")] byte* pbOutBuffer, [NativeTypeName("LONG")] int lInBytesAvailable, [NativeTypeName("LONG *")] int* plInBytesRead, [NativeTypeName("LONG *")] int* plOutBytesWritten, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->DoDecode((IDataFilter*)Unsafe.AsPointer(ref this), dwFlags, lInBufferSize, pbInBuffer, lOutBufferSize, pbOutBuffer, lInBytesAvailable, plInBytesRead, plOutBytesWritten, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEncodingLevel([NativeTypeName("DWORD")] uint dwEncLevel)
        {
            return lpVtbl->SetEncodingLevel((IDataFilter*)Unsafe.AsPointer(ref this), dwEncLevel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDataFilter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDataFilter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDataFilter*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, LONG, BYTE *, LONG, BYTE *, LONG, LONG *, LONG *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IDataFilter*, uint, int, byte*, int, byte*, int, int*, int*, uint, int> DoEncode;

            [NativeTypeName("HRESULT (DWORD, LONG, BYTE *, LONG, BYTE *, LONG, LONG *, LONG *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IDataFilter*, uint, int, byte*, int, byte*, int, int*, int*, uint, int> DoDecode;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IDataFilter*, uint, int> SetEncodingLevel;
        }
    }
}
