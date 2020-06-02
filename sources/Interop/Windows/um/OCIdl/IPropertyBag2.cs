// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F55882-280B-11D0-A8A9-00A0C90C2004")]
    public unsafe partial struct IPropertyBag2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPropertyBag2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2 *")] PROPBAG2* pPropBag, [NativeTypeName("IErrorLog *")] IErrorLog* pErrLog, [NativeTypeName("VARIANT *")] VARIANT* pvarValue, [NativeTypeName("HRESULT *")] int* phrError)
        {
            return lpVtbl->Read((IPropertyBag2*)Unsafe.AsPointer(ref this), cProperties, pPropBag, pErrLog, pvarValue, phrError);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2 *")] PROPBAG2* pPropBag, [NativeTypeName("VARIANT *")] VARIANT* pvarValue)
        {
            return lpVtbl->Write((IPropertyBag2*)Unsafe.AsPointer(ref this), cProperties, pPropBag, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int CountProperties([NativeTypeName("ULONG *")] uint* pcProperties)
        {
            return lpVtbl->CountProperties((IPropertyBag2*)Unsafe.AsPointer(ref this), pcProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyInfo([NativeTypeName("ULONG")] uint iProperty, [NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2 *")] PROPBAG2* pPropBag, [NativeTypeName("ULONG *")] uint* pcProperties)
        {
            return lpVtbl->GetPropertyInfo((IPropertyBag2*)Unsafe.AsPointer(ref this), iProperty, cProperties, pPropBag, pcProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadObject([NativeTypeName("LPCOLESTR")] ushort* pstrName, [NativeTypeName("DWORD")] uint dwHint, [NativeTypeName("IUnknown *")] IUnknown* pUnkObject, [NativeTypeName("IErrorLog *")] IErrorLog* pErrLog)
        {
            return lpVtbl->LoadObject((IPropertyBag2*)Unsafe.AsPointer(ref this), pstrName, dwHint, pUnkObject, pErrLog);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag2*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, PROPBAG2 *, IErrorLog *, VARIANT *, HRESULT *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag2*, uint, PROPBAG2*, IErrorLog*, VARIANT*, int*, int> Read;

            [NativeTypeName("HRESULT (ULONG, PROPBAG2 *, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag2*, uint, PROPBAG2*, VARIANT*, int> Write;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag2*, uint*, int> CountProperties;

            [NativeTypeName("HRESULT (ULONG, ULONG, PROPBAG2 *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag2*, uint, uint, PROPBAG2*, uint*, int> GetPropertyInfo;

            [NativeTypeName("HRESULT (LPCOLESTR, DWORD, IUnknown *, IErrorLog *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyBag2*, ushort*, uint, IUnknown*, IErrorLog*, int> LoadObject;
        }
    }
}
