// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("814B5AF5-C2C8-4270-A9B7-A198CE8D02FA")]
    [NativeTypeName("struct IDirectManipulationDragDropBehavior : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectManipulationDragDropBehavior
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectManipulationDragDropBehavior*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationDragDropBehavior*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectManipulationDragDropBehavior*, uint>)(lpVtbl[1]))((IDirectManipulationDragDropBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectManipulationDragDropBehavior*, uint>)(lpVtbl[2]))((IDirectManipulationDragDropBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetConfiguration(DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION configuration)
        {
            return ((delegate* unmanaged<IDirectManipulationDragDropBehavior*, DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION, int>)(lpVtbl[3]))((IDirectManipulationDragDropBehavior*)Unsafe.AsPointer(ref this), configuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus(DIRECTMANIPULATION_DRAG_DROP_STATUS* status)
        {
            return ((delegate* unmanaged<IDirectManipulationDragDropBehavior*, DIRECTMANIPULATION_DRAG_DROP_STATUS*, int>)(lpVtbl[4]))((IDirectManipulationDragDropBehavior*)Unsafe.AsPointer(ref this), status);
        }
    }
}
