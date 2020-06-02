// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("376BD3AA-3845-101B-84ED-08002B2EC713")]
    public unsafe partial struct IPerPropertyBrowsing
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayString([NativeTypeName("DISPID")] int dispID, [NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return lpVtbl->GetDisplayString((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, pBstr);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapPropertyToPage([NativeTypeName("DISPID")] int dispID, [NativeTypeName("CLSID *")] Guid* pClsid)
        {
            return lpVtbl->MapPropertyToPage((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, pClsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPredefinedStrings([NativeTypeName("DISPID")] int dispID, [NativeTypeName("CALPOLESTR *")] CALPOLESTR* pCaStringsOut, [NativeTypeName("CADWORD *")] CADWORD* pCaCookiesOut)
        {
            return lpVtbl->GetPredefinedStrings((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, pCaStringsOut, pCaCookiesOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPredefinedValue([NativeTypeName("DISPID")] int dispID, [NativeTypeName("DWORD")] uint dwCookie, [NativeTypeName("VARIANT *")] VARIANT* pVarOut)
        {
            return lpVtbl->GetPredefinedValue((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, dwCookie, pVarOut);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPerPropertyBrowsing*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPerPropertyBrowsing*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPerPropertyBrowsing*, uint> Release;

            [NativeTypeName("HRESULT (DISPID, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IPerPropertyBrowsing*, int, ushort**, int> GetDisplayString;

            [NativeTypeName("HRESULT (DISPID, CLSID *) __attribute__((stdcall))")]
            public delegate* stdcall<IPerPropertyBrowsing*, int, Guid*, int> MapPropertyToPage;

            [NativeTypeName("HRESULT (DISPID, CALPOLESTR *, CADWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IPerPropertyBrowsing*, int, CALPOLESTR*, CADWORD*, int> GetPredefinedStrings;

            [NativeTypeName("HRESULT (DISPID, DWORD, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IPerPropertyBrowsing*, int, uint, VARIANT*, int> GetPredefinedValue;
        }
    }
}
