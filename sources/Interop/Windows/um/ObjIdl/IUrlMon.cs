// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000026-0000-0000-C000-000000000046")]
    public unsafe partial struct IUrlMon
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IUrlMon*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IUrlMon*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IUrlMon*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AsyncGetClassBits([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] ushort* pszTYPE, [NativeTypeName("LPCWSTR")] ushort* pszExt, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] ushort* pszCodeBase, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwClassContext, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint flags)
        {
            return lpVtbl->AsyncGetClassBits((IUrlMon*)Unsafe.AsPointer(ref this), rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IUrlMon*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IUrlMon*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IUrlMon*, uint> Release;

            [NativeTypeName("HRESULT (const IID &, LPCWSTR, LPCWSTR, DWORD, DWORD, LPCWSTR, IBindCtx *, DWORD, const IID &, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IUrlMon*, Guid*, ushort*, ushort*, uint, uint, ushort*, IBindCtx*, uint, Guid*, uint, int> AsyncGetClassBits;
        }
    }
}
