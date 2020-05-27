// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7857AEAC-D31F-49BF-884E-DD46DF36780A")]
    public unsafe partial struct IWinInetCacheHints2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWinInetCacheHints2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWinInetCacheHints2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWinInetCacheHints2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCacheExtension(IWinInetCacheHints2* pThis, [NativeTypeName("LPCWSTR")] ushort* pwzExt, [NativeTypeName("LPVOID")] void* pszCacheFile, [NativeTypeName("DWORD *")] uint* pcbCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCacheExtension2(IWinInetCacheHints2* pThis, [NativeTypeName("LPCWSTR")] ushort* pwzExt, [NativeTypeName("WCHAR *")] ushort* pwzCacheFile, [NativeTypeName("DWORD *")] uint* pcchCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWinInetCacheHints2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWinInetCacheHints2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWinInetCacheHints2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCacheExtension([NativeTypeName("LPCWSTR")] ushort* pwzExt, [NativeTypeName("LPVOID")] void* pszCacheFile, [NativeTypeName("DWORD *")] uint* pcbCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCacheExtension>(lpVtbl->SetCacheExtension)((IWinInetCacheHints2*)Unsafe.AsPointer(ref this), pwzExt, pszCacheFile, pcbCacheFile, pdwWinInetError, pdwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCacheExtension2([NativeTypeName("LPCWSTR")] ushort* pwzExt, [NativeTypeName("WCHAR *")] ushort* pwzCacheFile, [NativeTypeName("DWORD *")] uint* pcchCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCacheExtension2>(lpVtbl->SetCacheExtension2)((IWinInetCacheHints2*)Unsafe.AsPointer(ref this), pwzExt, pwzCacheFile, pcchCacheFile, pdwWinInetError, pdwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPVOID, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public IntPtr SetCacheExtension;

            [NativeTypeName("HRESULT (LPCWSTR, WCHAR *, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public IntPtr SetCacheExtension2;
        }
    }
}
