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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPerPropertyBrowsing* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPerPropertyBrowsing* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPerPropertyBrowsing* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplayString(IPerPropertyBrowsing* pThis, [NativeTypeName("DISPID")] int dispID, [NativeTypeName("BSTR *")] ushort** pBstr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapPropertyToPage(IPerPropertyBrowsing* pThis, [NativeTypeName("DISPID")] int dispID, [NativeTypeName("CLSID *")] Guid* pClsid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPredefinedStrings(IPerPropertyBrowsing* pThis, [NativeTypeName("DISPID")] int dispID, [NativeTypeName("CALPOLESTR *")] CALPOLESTR* pCaStringsOut, [NativeTypeName("CADWORD *")] CADWORD* pCaCookiesOut);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPredefinedValue(IPerPropertyBrowsing* pThis, [NativeTypeName("DISPID")] int dispID, [NativeTypeName("DWORD")] uint dwCookie, [NativeTypeName("VARIANT *")] VARIANT* pVarOut);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayString([NativeTypeName("DISPID")] int dispID, [NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDisplayString>(lpVtbl->GetDisplayString)((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, pBstr);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapPropertyToPage([NativeTypeName("DISPID")] int dispID, [NativeTypeName("CLSID *")] Guid* pClsid)
        {
            return Marshal.GetDelegateForFunctionPointer<_MapPropertyToPage>(lpVtbl->MapPropertyToPage)((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, pClsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPredefinedStrings([NativeTypeName("DISPID")] int dispID, [NativeTypeName("CALPOLESTR *")] CALPOLESTR* pCaStringsOut, [NativeTypeName("CADWORD *")] CADWORD* pCaCookiesOut)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPredefinedStrings>(lpVtbl->GetPredefinedStrings)((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, pCaStringsOut, pCaCookiesOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPredefinedValue([NativeTypeName("DISPID")] int dispID, [NativeTypeName("DWORD")] uint dwCookie, [NativeTypeName("VARIANT *")] VARIANT* pVarOut)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPredefinedValue>(lpVtbl->GetPredefinedValue)((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, dwCookie, pVarOut);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DISPID, BSTR *) __attribute__((stdcall))")]
            public IntPtr GetDisplayString;

            [NativeTypeName("HRESULT (DISPID, CLSID *) __attribute__((stdcall))")]
            public IntPtr MapPropertyToPage;

            [NativeTypeName("HRESULT (DISPID, CALPOLESTR *, CADWORD *) __attribute__((stdcall))")]
            public IntPtr GetPredefinedStrings;

            [NativeTypeName("HRESULT (DISPID, DWORD, VARIANT *) __attribute__((stdcall))")]
            public IntPtr GetPredefinedValue;
        }
    }
}
