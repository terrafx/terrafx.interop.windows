// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("70BDDE00-C18E-11D0-A9CE-006097942311")]
    public unsafe partial struct IEncodingFilterFactory
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IEncodingFilterFactory* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IEncodingFilterFactory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IEncodingFilterFactory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindBestFilter(IEncodingFilterFactory* pThis, [NativeTypeName("LPCWSTR")] ushort* pwzCodeIn, [NativeTypeName("LPCWSTR")] ushort* pwzCodeOut, DATAINFO info, [NativeTypeName("IDataFilter **")] IDataFilter** ppDF);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDefaultFilter(IEncodingFilterFactory* pThis, [NativeTypeName("LPCWSTR")] ushort* pwzCodeIn, [NativeTypeName("LPCWSTR")] ushort* pwzCodeOut, [NativeTypeName("IDataFilter **")] IDataFilter** ppDF);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IEncodingFilterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IEncodingFilterFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IEncodingFilterFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int FindBestFilter([NativeTypeName("LPCWSTR")] ushort* pwzCodeIn, [NativeTypeName("LPCWSTR")] ushort* pwzCodeOut, DATAINFO info, [NativeTypeName("IDataFilter **")] IDataFilter** ppDF)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindBestFilter>(lpVtbl->FindBestFilter)((IEncodingFilterFactory*)Unsafe.AsPointer(ref this), pwzCodeIn, pwzCodeOut, info, ppDF);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultFilter([NativeTypeName("LPCWSTR")] ushort* pwzCodeIn, [NativeTypeName("LPCWSTR")] ushort* pwzCodeOut, [NativeTypeName("IDataFilter **")] IDataFilter** ppDF)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDefaultFilter>(lpVtbl->GetDefaultFilter)((IEncodingFilterFactory*)Unsafe.AsPointer(ref this), pwzCodeIn, pwzCodeOut, ppDF);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DATAINFO, IDataFilter **) __attribute__((stdcall))")]
            public IntPtr FindBestFilter;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IDataFilter **) __attribute__((stdcall))")]
            public IntPtr GetDefaultFilter;
        }
    }
}
