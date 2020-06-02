// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000019-0000-0000-C000-000000000046")]
    public unsafe partial struct IExternalConnection
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IExternalConnection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IExternalConnection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IExternalConnection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("DWORD")]
        public uint AddConnection([NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved)
        {
            return lpVtbl->AddConnection((IExternalConnection*)Unsafe.AsPointer(ref this), extconn, reserved);
        }

        [return: NativeTypeName("DWORD")]
        public uint ReleaseConnection([NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved, [NativeTypeName("BOOL")] int fLastReleaseCloses)
        {
            return lpVtbl->ReleaseConnection((IExternalConnection*)Unsafe.AsPointer(ref this), extconn, reserved, fLastReleaseCloses);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IExternalConnection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IExternalConnection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IExternalConnection*, uint> Release;

            [NativeTypeName("DWORD (DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IExternalConnection*, uint, uint, uint> AddConnection;

            [NativeTypeName("DWORD (DWORD, DWORD, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IExternalConnection*, uint, uint, int, uint> ReleaseConnection;
        }
    }
}
