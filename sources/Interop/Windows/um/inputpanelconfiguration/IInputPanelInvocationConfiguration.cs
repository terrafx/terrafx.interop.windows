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
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInputPanelInvocationConfiguration : IInputPanelInvocationConfiguration.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInputPanelInvocationConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((IInputPanelInvocationConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInputPanelInvocationConfiguration*, uint>)(lpVtbl[1]))((IInputPanelInvocationConfiguration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInputPanelInvocationConfiguration*, uint>)(lpVtbl[2]))((IInputPanelInvocationConfiguration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RequireTouchInEditControl()
        {
            return ((delegate* unmanaged<IInputPanelInvocationConfiguration*, int>)(lpVtbl[3]))((IInputPanelInvocationConfiguration*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT RequireTouchInEditControl();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IInputPanelInvocationConfiguration*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInputPanelInvocationConfiguration*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInputPanelInvocationConfiguration*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IInputPanelInvocationConfiguration*, int> RequireTouchInEditControl;
        }
    }
}
