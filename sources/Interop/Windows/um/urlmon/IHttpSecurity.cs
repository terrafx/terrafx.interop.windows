// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9D7-BAFA-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IHttpSecurity : IWindowForBindingUI")]
    public unsafe partial struct IHttpSecurity
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHttpSecurity*, Guid*, void**, int>)(lpVtbl[0]))((IHttpSecurity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHttpSecurity*, uint>)(lpVtbl[1]))((IHttpSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHttpSecurity*, uint>)(lpVtbl[2]))((IHttpSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, [NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IHttpSecurity*, Guid*, IntPtr*, int>)(lpVtbl[3]))((IHttpSecurity*)Unsafe.AsPointer(ref this), rguidReason, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSecurityProblem([NativeTypeName("DWORD")] uint dwProblem)
        {
            return ((delegate* unmanaged<IHttpSecurity*, uint, int>)(lpVtbl[4]))((IHttpSecurity*)Unsafe.AsPointer(ref this), dwProblem);
        }
    }
}
