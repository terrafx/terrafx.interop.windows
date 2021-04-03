// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1FA11B10-701B-41AE-B5F2-49E36BD595AA")]
    [NativeTypeName("struct IDirectManipulationDragDropEventHandler : IUnknown")]
    public unsafe partial struct IDirectManipulationDragDropEventHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectManipulationDragDropEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationDragDropEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectManipulationDragDropEventHandler*, uint>)(lpVtbl[1]))((IDirectManipulationDragDropEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectManipulationDragDropEventHandler*, uint>)(lpVtbl[2]))((IDirectManipulationDragDropEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDragDropStatusChange(IDirectManipulationViewport2* viewport, DIRECTMANIPULATION_DRAG_DROP_STATUS current, DIRECTMANIPULATION_DRAG_DROP_STATUS previous)
        {
            return ((delegate* unmanaged<IDirectManipulationDragDropEventHandler*, IDirectManipulationViewport2*, DIRECTMANIPULATION_DRAG_DROP_STATUS, DIRECTMANIPULATION_DRAG_DROP_STATUS, int>)(lpVtbl[3]))((IDirectManipulationDragDropEventHandler*)Unsafe.AsPointer(ref this), viewport, current, previous);
        }
    }
}
