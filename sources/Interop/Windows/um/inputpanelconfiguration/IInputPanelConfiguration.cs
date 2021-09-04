// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inputpanelconfiguration.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("41C81592-514C-48BD-A22E-E6AF638521A6")]
    [NativeTypeName("struct IInputPanelConfiguration : IUnknown")]
    public unsafe partial struct IInputPanelConfiguration
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInputPanelConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((IInputPanelConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInputPanelConfiguration*, uint>)(lpVtbl[1]))((IInputPanelConfiguration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInputPanelConfiguration*, uint>)(lpVtbl[2]))((IInputPanelConfiguration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableFocusTracking()
        {
            return ((delegate* unmanaged<IInputPanelConfiguration*, int>)(lpVtbl[3]))((IInputPanelConfiguration*)Unsafe.AsPointer(ref this));
        }
    }
}
