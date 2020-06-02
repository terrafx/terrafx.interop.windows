// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020410-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeChangeEvents
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ITypeChangeEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ITypeChangeEvents*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ITypeChangeEvents*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestTypeChange(CHANGEKIND changeKind, [NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfoBefore, [NativeTypeName("LPOLESTR")] ushort* pStrName, [NativeTypeName("INT *")] int* pfCancel)
        {
            return lpVtbl->RequestTypeChange((ITypeChangeEvents*)Unsafe.AsPointer(ref this), changeKind, pTInfoBefore, pStrName, pfCancel);
        }

        [return: NativeTypeName("HRESULT")]
        public int AfterTypeChange(CHANGEKIND changeKind, [NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfoAfter, [NativeTypeName("LPOLESTR")] ushort* pStrName)
        {
            return lpVtbl->AfterTypeChange((ITypeChangeEvents*)Unsafe.AsPointer(ref this), changeKind, pTInfoAfter, pStrName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeChangeEvents*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeChangeEvents*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeChangeEvents*, uint> Release;

            [NativeTypeName("HRESULT (CHANGEKIND, ITypeInfo *, LPOLESTR, INT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeChangeEvents*, CHANGEKIND, ITypeInfo*, ushort*, int*, int> RequestTypeChange;

            [NativeTypeName("HRESULT (CHANGEKIND, ITypeInfo *, LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeChangeEvents*, CHANGEKIND, ITypeInfo*, ushort*, int> AfterTypeChange;
        }
    }
}
