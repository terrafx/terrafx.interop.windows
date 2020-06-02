// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6BC3AC0-DBAA-11CE-9DE3-00AA004BB851")]
    public unsafe partial struct IProvideClassInfo2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IProvideClassInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IProvideClassInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IProvideClassInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassInfoA([NativeTypeName("ITypeInfo **")] ITypeInfo** ppTI)
        {
            return lpVtbl->GetClassInfoA((IProvideClassInfo2*)Unsafe.AsPointer(ref this), ppTI);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("DWORD")] uint dwGuidKind, [NativeTypeName("GUID *")] Guid* pGUID)
        {
            return lpVtbl->GetGUID((IProvideClassInfo2*)Unsafe.AsPointer(ref this), dwGuidKind, pGUID);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IProvideClassInfo2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IProvideClassInfo2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IProvideClassInfo2*, uint> Release;

            [NativeTypeName("HRESULT (ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IProvideClassInfo2*, ITypeInfo**, int> GetClassInfoA;

            [NativeTypeName("HRESULT (DWORD, GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IProvideClassInfo2*, uint, Guid*, int> GetGUID;
        }
    }
}
