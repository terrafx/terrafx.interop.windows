// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("814B5AF5-C2C8-4270-A9B7-A198CE8D02FA")]
    [NativeTypeName("struct IDirectManipulationDragDropBehavior : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectManipulationDragDropBehavior : IDirectManipulationDragDropBehavior.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        public HRESULT SetConfiguration(DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION configuration)
        {
            return ((delegate* unmanaged<IDirectManipulationDragDropBehavior*, DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION, int>)(lpVtbl[3]))((IDirectManipulationDragDropBehavior*)Unsafe.AsPointer(ref this), configuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetStatus(DIRECTMANIPULATION_DRAG_DROP_STATUS* status)
        {
            return ((delegate* unmanaged<IDirectManipulationDragDropBehavior*, DIRECTMANIPULATION_DRAG_DROP_STATUS*, int>)(lpVtbl[4]))((IDirectManipulationDragDropBehavior*)Unsafe.AsPointer(ref this), status);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetConfiguration(DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION configuration);

            [VtblIndex(4)]
            HRESULT GetStatus(DIRECTMANIPULATION_DRAG_DROP_STATUS* status);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectManipulationDragDropBehavior*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectManipulationDragDropBehavior*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectManipulationDragDropBehavior*, uint> Release;

            [NativeTypeName("HRESULT (DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectManipulationDragDropBehavior*, DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION, int> SetConfiguration;

            [NativeTypeName("HRESULT (DIRECTMANIPULATION_DRAG_DROP_STATUS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectManipulationDragDropBehavior*, DIRECTMANIPULATION_DRAG_DROP_STATUS*, int> GetStatus;
        }
    }
}
