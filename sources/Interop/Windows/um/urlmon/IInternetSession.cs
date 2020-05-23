// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9E7-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IInternetSession
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IInternetSession* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IInternetSession* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IInternetSession* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterNameSpace(IInternetSession* pThis, [NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] ushort* pwzProtocol, [NativeTypeName("ULONG")] uint cPatterns, [NativeTypeName("const LPCWSTR *")] ushort** ppwzPatterns, [NativeTypeName("DWORD")] uint dwReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterNameSpace(IInternetSession* pThis, [NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("LPCWSTR")] ushort* pszProtocol);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterMimeFilter(IInternetSession* pThis, [NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] ushort* pwzType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterMimeFilter(IInternetSession* pThis, [NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("LPCWSTR")] ushort* pwzType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBinding(IInternetSession* pThis, [NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* szUrl, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("IUnknown **")] IUnknown** ppUnk, [NativeTypeName("IInternetProtocol **")] IInternetProtocol** ppOInetProt, [NativeTypeName("DWORD")] uint dwOption);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSessionOption(IInternetSession* pThis, [NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD")] uint dwReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSessionOption(IInternetSession* pThis, [NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pdwBufferLength, [NativeTypeName("DWORD")] uint dwReserved);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IInternetSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IInternetSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IInternetSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterNameSpace([NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] ushort* pwzProtocol, [NativeTypeName("ULONG")] uint cPatterns, [NativeTypeName("const LPCWSTR *")] ushort** ppwzPatterns, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterNameSpace>(lpVtbl->RegisterNameSpace)((IInternetSession*)Unsafe.AsPointer(ref this), pCF, rclsid, pwzProtocol, cPatterns, ppwzPatterns, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterNameSpace([NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("LPCWSTR")] ushort* pszProtocol)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnregisterNameSpace>(lpVtbl->UnregisterNameSpace)((IInternetSession*)Unsafe.AsPointer(ref this), pCF, pszProtocol);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterMimeFilter([NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] ushort* pwzType)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterMimeFilter>(lpVtbl->RegisterMimeFilter)((IInternetSession*)Unsafe.AsPointer(ref this), pCF, rclsid, pwzType);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterMimeFilter([NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("LPCWSTR")] ushort* pwzType)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnregisterMimeFilter>(lpVtbl->UnregisterMimeFilter)((IInternetSession*)Unsafe.AsPointer(ref this), pCF, pwzType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBinding([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* szUrl, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("IUnknown **")] IUnknown** ppUnk, [NativeTypeName("IInternetProtocol **")] IInternetProtocol** ppOInetProt, [NativeTypeName("DWORD")] uint dwOption)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBinding>(lpVtbl->CreateBinding)((IInternetSession*)Unsafe.AsPointer(ref this), pBC, szUrl, pUnkOuter, ppUnk, ppOInetProt, dwOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSessionOption>(lpVtbl->SetSessionOption)((IInternetSession*)Unsafe.AsPointer(ref this), dwOption, pBuffer, dwBufferLength, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pdwBufferLength, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSessionOption>(lpVtbl->GetSessionOption)((IInternetSession*)Unsafe.AsPointer(ref this), dwOption, pBuffer, pdwBufferLength, dwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IClassFactory *, const IID &, LPCWSTR, ULONG, const LPCWSTR *, DWORD) __attribute__((stdcall))")]
            public IntPtr RegisterNameSpace;

            [NativeTypeName("HRESULT (IClassFactory *, LPCWSTR) __attribute__((stdcall))")]
            public IntPtr UnregisterNameSpace;

            [NativeTypeName("HRESULT (IClassFactory *, const IID &, LPCWSTR) __attribute__((stdcall))")]
            public IntPtr RegisterMimeFilter;

            [NativeTypeName("HRESULT (IClassFactory *, LPCWSTR) __attribute__((stdcall))")]
            public IntPtr UnregisterMimeFilter;

            [NativeTypeName("HRESULT (LPBC, LPCWSTR, IUnknown *, IUnknown **, IInternetProtocol **, DWORD) __attribute__((stdcall))")]
            public IntPtr CreateBinding;

            [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD, DWORD) __attribute__((stdcall))")]
            public IntPtr SetSessionOption;

            [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD *, DWORD) __attribute__((stdcall))")]
            public IntPtr GetSessionOption;
        }
    }
}
