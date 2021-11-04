// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5CD52983-9449-11D2-963A-00C04F79ADF0")]
    [NativeTypeName("struct IResolveShellLink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IResolveShellLink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IResolveShellLink*, Guid*, void**, int>)(lpVtbl[0]))((IResolveShellLink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IResolveShellLink*, uint>)(lpVtbl[1]))((IResolveShellLink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IResolveShellLink*, uint>)(lpVtbl[2]))((IResolveShellLink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ResolveShellLink(IUnknown* punkLink, HWND hwnd, [NativeTypeName("DWORD")] uint fFlags)
        {
            return ((delegate* unmanaged<IResolveShellLink*, IUnknown*, HWND, uint, int>)(lpVtbl[3]))((IResolveShellLink*)Unsafe.AsPointer(ref this), punkLink, hwnd, fFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IResolveShellLink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IResolveShellLink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IResolveShellLink*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, HWND, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IResolveShellLink*, IUnknown*, HWND, uint, int> ResolveShellLink;
        }
    }
}
