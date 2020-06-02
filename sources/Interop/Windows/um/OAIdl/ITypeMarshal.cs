// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002D-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeMarshal
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ITypeMarshal*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ITypeMarshal*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ITypeMarshal*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Size([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("PVOID")] void* pvDestContext, [NativeTypeName("ULONG *")] uint* pSize)
        {
            return lpVtbl->Size((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType, dwDestContext, pvDestContext, pSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int Marshal([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("PVOID")] void* pvDestContext, [NativeTypeName("ULONG")] uint cbBufferLength, [NativeTypeName("BYTE *")] byte* pBuffer, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return lpVtbl->Marshal((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType, dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unmarshal([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cbBufferLength, [NativeTypeName("BYTE *")] byte* pBuffer, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return lpVtbl->Unmarshal((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType, dwFlags, cbBufferLength, pBuffer, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Free([NativeTypeName("PVOID")] void* pvType)
        {
            return lpVtbl->Free((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeMarshal*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeMarshal*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeMarshal*, uint> Release;

            [NativeTypeName("HRESULT (PVOID, DWORD, PVOID, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeMarshal*, void*, uint, void*, uint*, int> Size;

            [NativeTypeName("HRESULT (PVOID, DWORD, PVOID, ULONG, BYTE *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int> Marshal;

            [NativeTypeName("HRESULT (PVOID, DWORD, ULONG, BYTE *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeMarshal*, void*, uint, uint, byte*, uint*, int> Unmarshal;

            [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeMarshal*, void*, int> Free;
        }
    }
}
