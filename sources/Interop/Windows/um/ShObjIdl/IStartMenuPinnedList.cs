// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4CD19ADA-25A5-4A32-B3B7-347BEE5BE36B")]
    [NativeTypeName("struct IStartMenuPinnedList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IStartMenuPinnedList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IStartMenuPinnedList*, Guid*, void**, int>)(lpVtbl[0]))((IStartMenuPinnedList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStartMenuPinnedList*, uint>)(lpVtbl[1]))((IStartMenuPinnedList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStartMenuPinnedList*, uint>)(lpVtbl[2]))((IStartMenuPinnedList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RemoveFromList(IShellItem* pitem)
        {
            return ((delegate* unmanaged<IStartMenuPinnedList*, IShellItem*, int>)(lpVtbl[3]))((IStartMenuPinnedList*)Unsafe.AsPointer(ref this), pitem);
        }
    }
}
