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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterNameSpace([NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] ushort* pwzProtocol, [NativeTypeName("ULONG")] uint cPatterns, [NativeTypeName("const LPCWSTR *")] ushort** ppwzPatterns, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->RegisterNameSpace((IInternetSession*)Unsafe.AsPointer(ref this), pCF, rclsid, pwzProtocol, cPatterns, ppwzPatterns, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterNameSpace([NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("LPCWSTR")] ushort* pszProtocol)
        {
            return lpVtbl->UnregisterNameSpace((IInternetSession*)Unsafe.AsPointer(ref this), pCF, pszProtocol);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterMimeFilter([NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] ushort* pwzType)
        {
            return lpVtbl->RegisterMimeFilter((IInternetSession*)Unsafe.AsPointer(ref this), pCF, rclsid, pwzType);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterMimeFilter([NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("LPCWSTR")] ushort* pwzType)
        {
            return lpVtbl->UnregisterMimeFilter((IInternetSession*)Unsafe.AsPointer(ref this), pCF, pwzType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBinding([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* szUrl, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("IUnknown **")] IUnknown** ppUnk, [NativeTypeName("IInternetProtocol **")] IInternetProtocol** ppOInetProt, [NativeTypeName("DWORD")] uint dwOption)
        {
            return lpVtbl->CreateBinding((IInternetSession*)Unsafe.AsPointer(ref this), pBC, szUrl, pUnkOuter, ppUnk, ppOInetProt, dwOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->SetSessionOption((IInternetSession*)Unsafe.AsPointer(ref this), dwOption, pBuffer, dwBufferLength, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pdwBufferLength, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->GetSessionOption((IInternetSession*)Unsafe.AsPointer(ref this), dwOption, pBuffer, pdwBufferLength, dwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetSession*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IInternetSession*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IInternetSession*, uint> Release;

            [NativeTypeName("HRESULT (IClassFactory *, const IID &, LPCWSTR, ULONG, const LPCWSTR *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetSession*, IClassFactory*, Guid*, ushort*, uint, ushort**, uint, int> RegisterNameSpace;

            [NativeTypeName("HRESULT (IClassFactory *, LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetSession*, IClassFactory*, ushort*, int> UnregisterNameSpace;

            [NativeTypeName("HRESULT (IClassFactory *, const IID &, LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetSession*, IClassFactory*, Guid*, ushort*, int> RegisterMimeFilter;

            [NativeTypeName("HRESULT (IClassFactory *, LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetSession*, IClassFactory*, ushort*, int> UnregisterMimeFilter;

            [NativeTypeName("HRESULT (LPBC, LPCWSTR, IUnknown *, IUnknown **, IInternetProtocol **, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetSession*, IBindCtx*, ushort*, IUnknown*, IUnknown**, IInternetProtocol**, uint, int> CreateBinding;

            [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetSession*, uint, void*, uint, uint, int> SetSessionOption;

            [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetSession*, uint, void*, uint*, uint, int> GetSessionOption;
        }
    }
}
