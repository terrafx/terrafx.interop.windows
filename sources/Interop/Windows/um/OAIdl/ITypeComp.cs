// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020403-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeComp
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ITypeComp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ITypeComp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ITypeComp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Bind([NativeTypeName("LPOLESTR")] ushort* szName, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo, [NativeTypeName("DESCKIND *")] DESCKIND* pDescKind, [NativeTypeName("BINDPTR *")] BINDPTR* pBindPtr)
        {
            return lpVtbl->Bind((ITypeComp*)Unsafe.AsPointer(ref this), szName, lHashVal, wFlags, ppTInfo, pDescKind, pBindPtr);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindType([NativeTypeName("LPOLESTR")] ushort* szName, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo, [NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return lpVtbl->BindType((ITypeComp*)Unsafe.AsPointer(ref this), szName, lHashVal, ppTInfo, ppTComp);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeComp*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeComp*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeComp*, uint> Release;

            [NativeTypeName("HRESULT (LPOLESTR, ULONG, WORD, ITypeInfo **, DESCKIND *, BINDPTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeComp*, ushort*, uint, ushort, ITypeInfo**, DESCKIND*, BINDPTR*, int> Bind;

            [NativeTypeName("HRESULT (LPOLESTR, ULONG, ITypeInfo **, ITypeComp **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeComp*, ushort*, uint, ITypeInfo**, ITypeComp**, int> BindType;
        }
    }
}
