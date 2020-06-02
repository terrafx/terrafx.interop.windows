// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000148-0000-0000-C000-000000000046")]
    public unsafe partial struct IAddrExclusionControl
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IAddrExclusionControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IAddrExclusionControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IAddrExclusionControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentAddrExclusionList([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppEnumerator)
        {
            return lpVtbl->GetCurrentAddrExclusionList((IAddrExclusionControl*)Unsafe.AsPointer(ref this), riid, ppEnumerator);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateAddrExclusionList([NativeTypeName("IUnknown *")] IUnknown* pEnumerator)
        {
            return lpVtbl->UpdateAddrExclusionList((IAddrExclusionControl*)Unsafe.AsPointer(ref this), pEnumerator);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IAddrExclusionControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IAddrExclusionControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IAddrExclusionControl*, uint> Release;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IAddrExclusionControl*, Guid*, void**, int> GetCurrentAddrExclusionList;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IAddrExclusionControl*, IUnknown*, int> UpdateAddrExclusionList;
        }
    }
}
