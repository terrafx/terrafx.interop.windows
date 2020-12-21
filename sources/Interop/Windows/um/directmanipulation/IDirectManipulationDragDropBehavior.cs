// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("814B5AF5-C2C8-4270-A9B7-A198CE8D02FA")]
    [NativeTypeName("struct IDirectManipulationDragDropBehavior : IUnknown")]
    public unsafe partial struct IDirectManipulationDragDropBehavior
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationDragDropBehavior*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationDragDropBehavior*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationDragDropBehavior*, uint>)(lpVtbl[1]))((IDirectManipulationDragDropBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationDragDropBehavior*, uint>)(lpVtbl[2]))((IDirectManipulationDragDropBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetConfiguration(DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION configuration)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationDragDropBehavior*, DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION, int>)(lpVtbl[3]))((IDirectManipulationDragDropBehavior*)Unsafe.AsPointer(ref this), configuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("DIRECTMANIPULATION_DRAG_DROP_STATUS *")] DIRECTMANIPULATION_DRAG_DROP_STATUS* status)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationDragDropBehavior*, DIRECTMANIPULATION_DRAG_DROP_STATUS*, int>)(lpVtbl[4]))((IDirectManipulationDragDropBehavior*)Unsafe.AsPointer(ref this), status);
        }
    }
}
