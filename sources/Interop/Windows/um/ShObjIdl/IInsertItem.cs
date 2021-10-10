// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D2B57227-3D23-4B95-93C0-492BD454C356")]
    [NativeTypeName("struct IInsertItem : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInsertItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInsertItem*, Guid*, void**, int>)(lpVtbl[0]))((IInsertItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInsertItem*, uint>)(lpVtbl[1]))((IInsertItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInsertItem*, uint>)(lpVtbl[2]))((IInsertItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int InsertItem([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IInsertItem*, ITEMIDLIST*, int>)(lpVtbl[3]))((IInsertItem*)Unsafe.AsPointer(ref this), pidl);
        }
    }
}
