// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("55272A00-42CB-11CE-8135-00AA004BB851")]
    public unsafe partial struct IPropertyBag
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("LPCOLESTR")] ushort* pszPropName, [NativeTypeName("VARIANT *")] VARIANT* pVar, [NativeTypeName("IErrorLog *")] IErrorLog* pErrorLog)
        {
            return lpVtbl->Read((IPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar, pErrorLog);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("LPCOLESTR")] ushort* pszPropName, [NativeTypeName("VARIANT *")] VARIANT* pVar)
        {
            return lpVtbl->Write((IPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag*, uint> Release;

            [NativeTypeName("HRESULT (LPCOLESTR, VARIANT *, IErrorLog *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag*, ushort*, VARIANT*, IErrorLog*, int> Read;

            [NativeTypeName("HRESULT (LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag*, ushort*, VARIANT*, int> Write;
        }
    }
}
