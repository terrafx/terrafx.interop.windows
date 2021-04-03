// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E43F45B8-42B4-403E-B1F2-273B8F510830")]
    [NativeTypeName("struct IDirectManipulationInteractionEventHandler : IUnknown")]
    public unsafe partial struct IDirectManipulationInteractionEventHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectManipulationInteractionEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationInteractionEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectManipulationInteractionEventHandler*, uint>)(lpVtbl[1]))((IDirectManipulationInteractionEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectManipulationInteractionEventHandler*, uint>)(lpVtbl[2]))((IDirectManipulationInteractionEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnInteraction(IDirectManipulationViewport2* viewport, DIRECTMANIPULATION_INTERACTION_TYPE interaction)
        {
            return ((delegate* unmanaged<IDirectManipulationInteractionEventHandler*, IDirectManipulationViewport2*, DIRECTMANIPULATION_INTERACTION_TYPE, int>)(lpVtbl[3]))((IDirectManipulationInteractionEventHandler*)Unsafe.AsPointer(ref this), viewport, interaction);
        }
    }
}
