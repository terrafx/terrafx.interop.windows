// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9E7-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetSession : IUnknown")]
    public unsafe partial struct IInternetSession
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInternetSession*, Guid*, void**, int>)(lpVtbl[0]))((IInternetSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInternetSession*, uint>)(lpVtbl[1]))((IInternetSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInternetSession*, uint>)(lpVtbl[2]))((IInternetSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterNameSpace([NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] ushort* pwzProtocol, [NativeTypeName("ULONG")] uint cPatterns, [NativeTypeName("const LPCWSTR *")] ushort** ppwzPatterns, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IInternetSession*, IClassFactory*, Guid*, ushort*, uint, ushort**, uint, int>)(lpVtbl[3]))((IInternetSession*)Unsafe.AsPointer(ref this), pCF, rclsid, pwzProtocol, cPatterns, ppwzPatterns, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterNameSpace([NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("LPCWSTR")] ushort* pszProtocol)
        {
            return ((delegate* stdcall<IInternetSession*, IClassFactory*, ushort*, int>)(lpVtbl[4]))((IInternetSession*)Unsafe.AsPointer(ref this), pCF, pszProtocol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterMimeFilter([NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] ushort* pwzType)
        {
            return ((delegate* stdcall<IInternetSession*, IClassFactory*, Guid*, ushort*, int>)(lpVtbl[5]))((IInternetSession*)Unsafe.AsPointer(ref this), pCF, rclsid, pwzType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterMimeFilter([NativeTypeName("IClassFactory *")] IClassFactory* pCF, [NativeTypeName("LPCWSTR")] ushort* pwzType)
        {
            return ((delegate* stdcall<IInternetSession*, IClassFactory*, ushort*, int>)(lpVtbl[6]))((IInternetSession*)Unsafe.AsPointer(ref this), pCF, pwzType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBinding([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* szUrl, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("IUnknown **")] IUnknown** ppUnk, [NativeTypeName("IInternetProtocol **")] IInternetProtocol** ppOInetProt, [NativeTypeName("DWORD")] uint dwOption)
        {
            return ((delegate* stdcall<IInternetSession*, IBindCtx*, ushort*, IUnknown*, IUnknown**, IInternetProtocol**, uint, int>)(lpVtbl[7]))((IInternetSession*)Unsafe.AsPointer(ref this), pBC, szUrl, pUnkOuter, ppUnk, ppOInetProt, dwOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IInternetSession*, uint, void*, uint, uint, int>)(lpVtbl[8]))((IInternetSession*)Unsafe.AsPointer(ref this), dwOption, pBuffer, dwBufferLength, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pdwBufferLength, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IInternetSession*, uint, void*, uint*, uint, int>)(lpVtbl[9]))((IInternetSession*)Unsafe.AsPointer(ref this), dwOption, pBuffer, pdwBufferLength, dwReserved);
        }
    }
}
