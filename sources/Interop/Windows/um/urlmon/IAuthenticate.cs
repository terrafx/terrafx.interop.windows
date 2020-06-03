// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9D0-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IAuthenticate
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAuthenticate*, Guid*, void**, int>)(lpVtbl[0]))((IAuthenticate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAuthenticate*, uint>)(lpVtbl[1]))((IAuthenticate*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAuthenticate*, uint>)(lpVtbl[2]))((IAuthenticate*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Authenticate([NativeTypeName("HWND *")] IntPtr* phwnd, [NativeTypeName("LPWSTR *")] ushort** pszUsername, [NativeTypeName("LPWSTR *")] ushort** pszPassword)
        {
            return ((delegate* stdcall<IAuthenticate*, IntPtr*, ushort**, ushort**, int>)(lpVtbl[3]))((IAuthenticate*)Unsafe.AsPointer(ref this), phwnd, pszUsername, pszPassword);
        }
    }
}
