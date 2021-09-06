// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inputpanelconfiguration.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A213F136-3B45-4362-A332-EFB6547CD432")]
    [NativeTypeName("struct IInputPanelInvocationConfiguration : IUnknown")]
    public unsafe partial struct IInputPanelInvocationConfiguration
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInputPanelInvocationConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((IInputPanelInvocationConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInputPanelInvocationConfiguration*, uint>)(lpVtbl[1]))((IInputPanelInvocationConfiguration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInputPanelInvocationConfiguration*, uint>)(lpVtbl[2]))((IInputPanelInvocationConfiguration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequireTouchInEditControl()
        {
            return ((delegate* unmanaged<IInputPanelInvocationConfiguration*, int>)(lpVtbl[3]))((IInputPanelInvocationConfiguration*)Unsafe.AsPointer(ref this));
        }
    }
}
