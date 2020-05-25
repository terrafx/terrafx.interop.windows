// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2AD1EDAF-D83D-48B5-9ADF-03DBE19F53BD")]
    public unsafe partial struct IAuthenticateEx
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IAuthenticateEx* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IAuthenticateEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IAuthenticateEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Authenticate(IAuthenticateEx* pThis, [NativeTypeName("HWND *")] IntPtr* phwnd, [NativeTypeName("LPWSTR *")] ushort** pszUsername, [NativeTypeName("LPWSTR *")] ushort** pszPassword);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AuthenticateEx(IAuthenticateEx* pThis, [NativeTypeName("HWND *")] IntPtr* phwnd, [NativeTypeName("LPWSTR *")] ushort** pszUsername, [NativeTypeName("LPWSTR *")] ushort** pszPassword, [NativeTypeName("AUTHENTICATEINFO *")] AUTHENTICATEINFO* pauthinfo);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IAuthenticateEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IAuthenticateEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IAuthenticateEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Authenticate([NativeTypeName("HWND *")] IntPtr* phwnd, [NativeTypeName("LPWSTR *")] ushort** pszUsername, [NativeTypeName("LPWSTR *")] ushort** pszPassword)
        {
            return Marshal.GetDelegateForFunctionPointer<_Authenticate>(lpVtbl->Authenticate)((IAuthenticateEx*)Unsafe.AsPointer(ref this), phwnd, pszUsername, pszPassword);
        }

        [return: NativeTypeName("HRESULT")]
        public int AuthenticateEx([NativeTypeName("HWND *")] IntPtr* phwnd, [NativeTypeName("LPWSTR *")] ushort** pszUsername, [NativeTypeName("LPWSTR *")] ushort** pszPassword, [NativeTypeName("AUTHENTICATEINFO *")] AUTHENTICATEINFO* pauthinfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_AuthenticateEx>(lpVtbl->AuthenticateEx)((IAuthenticateEx*)Unsafe.AsPointer(ref this), phwnd, pszUsername, pszPassword, pauthinfo);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (HWND *, LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
            public IntPtr Authenticate;

            [NativeTypeName("HRESULT (HWND *, LPWSTR *, LPWSTR *, AUTHENTICATEINFO *) __attribute__((stdcall))")]
            public IntPtr AuthenticateEx;
        }
    }
}
