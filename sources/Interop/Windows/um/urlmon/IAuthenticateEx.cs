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
    public unsafe partial struct IAuthenticateEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAuthenticateEx*, Guid*, void**, int>)(lpVtbl[0]))((IAuthenticateEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAuthenticateEx*, uint>)(lpVtbl[1]))((IAuthenticateEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAuthenticateEx*, uint>)(lpVtbl[2]))((IAuthenticateEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Authenticate([NativeTypeName("HWND *")] IntPtr* phwnd, [NativeTypeName("LPWSTR *")] ushort** pszUsername, [NativeTypeName("LPWSTR *")] ushort** pszPassword)
        {
            return ((delegate* unmanaged<IAuthenticateEx*, IntPtr*, ushort**, ushort**, int>)(lpVtbl[3]))((IAuthenticateEx*)Unsafe.AsPointer(ref this), phwnd, pszUsername, pszPassword);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AuthenticateEx([NativeTypeName("HWND *")] IntPtr* phwnd, [NativeTypeName("LPWSTR *")] ushort** pszUsername, [NativeTypeName("LPWSTR *")] ushort** pszPassword, AUTHENTICATEINFO* pauthinfo)
        {
            return ((delegate* unmanaged<IAuthenticateEx*, IntPtr*, ushort**, ushort**, AUTHENTICATEINFO*, int>)(lpVtbl[4]))((IAuthenticateEx*)Unsafe.AsPointer(ref this), phwnd, pszUsername, pszPassword, pauthinfo);
        }
    }
}
