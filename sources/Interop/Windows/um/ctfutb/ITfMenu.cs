// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6F8A98E4-AAA0-4F15-8C5B-07E0DF0A3DD8")]
    [NativeTypeName("struct ITfMenu : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfMenu
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfMenu*, Guid*, void**, int>)(lpVtbl[0]))((ITfMenu*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfMenu*, uint>)(lpVtbl[1]))((ITfMenu*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfMenu*, uint>)(lpVtbl[2]))((ITfMenu*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddMenuItem(uint uId, [NativeTypeName("DWORD")] uint dwFlags, HBITMAP hbmp, HBITMAP hbmpMask, [NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch, ITfMenu** ppMenu)
        {
            return ((delegate* unmanaged<ITfMenu*, uint, uint, HBITMAP, HBITMAP, ushort*, uint, ITfMenu**, int>)(lpVtbl[3]))((ITfMenu*)Unsafe.AsPointer(ref this), uId, dwFlags, hbmp, hbmpMask, pch, cch, ppMenu);
        }
    }
}
