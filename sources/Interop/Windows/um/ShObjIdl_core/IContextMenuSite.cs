// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0811AEBE-0B87-4C54-9E72-548CF649016B")]
    [NativeTypeName("struct IContextMenuSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IContextMenuSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IContextMenuSite*, Guid*, void**, int>)(lpVtbl[0]))((IContextMenuSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContextMenuSite*, uint>)(lpVtbl[1]))((IContextMenuSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContextMenuSite*, uint>)(lpVtbl[2]))((IContextMenuSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT DoContextMenuPopup(IUnknown* punkContextMenu, uint fFlags, POINT pt)
        {
            return ((delegate* unmanaged<IContextMenuSite*, IUnknown*, uint, POINT, int>)(lpVtbl[3]))((IContextMenuSite*)Unsafe.AsPointer(ref this), punkContextMenu, fFlags, pt);
        }
    }
}
