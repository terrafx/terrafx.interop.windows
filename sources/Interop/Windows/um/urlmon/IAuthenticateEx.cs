// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2AD1EDAF-D83D-48B5-9ADF-03DBE19F53BD")]
    [NativeTypeName("struct IAuthenticateEx : IAuthenticate")]
    [NativeInheritance("IAuthenticate")]
    public unsafe partial struct IAuthenticateEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAuthenticateEx*, Guid*, void**, int>)(lpVtbl[0]))((IAuthenticateEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAuthenticateEx*, uint>)(lpVtbl[1]))((IAuthenticateEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAuthenticateEx*, uint>)(lpVtbl[2]))((IAuthenticateEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Authenticate(HWND* phwnd, [NativeTypeName("LPWSTR *")] ushort** pszUsername, [NativeTypeName("LPWSTR *")] ushort** pszPassword)
        {
            return ((delegate* unmanaged<IAuthenticateEx*, HWND*, ushort**, ushort**, int>)(lpVtbl[3]))((IAuthenticateEx*)Unsafe.AsPointer(ref this), phwnd, pszUsername, pszPassword);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AuthenticateEx(HWND* phwnd, [NativeTypeName("LPWSTR *")] ushort** pszUsername, [NativeTypeName("LPWSTR *")] ushort** pszPassword, AUTHENTICATEINFO* pauthinfo)
        {
            return ((delegate* unmanaged<IAuthenticateEx*, HWND*, ushort**, ushort**, AUTHENTICATEINFO*, int>)(lpVtbl[4]))((IAuthenticateEx*)Unsafe.AsPointer(ref this), phwnd, pszUsername, pszPassword, pauthinfo);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAuthenticateEx*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAuthenticateEx*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAuthenticateEx*, uint> Release;

            [NativeTypeName("HRESULT (HWND *, LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAuthenticateEx*, HWND*, ushort**, ushort**, int> Authenticate;

            [NativeTypeName("HRESULT (HWND *, LPWSTR *, LPWSTR *, AUTHENTICATEINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAuthenticateEx*, HWND*, ushort**, ushort**, AUTHENTICATEINFO*, int> AuthenticateEx;
        }
    }
}
