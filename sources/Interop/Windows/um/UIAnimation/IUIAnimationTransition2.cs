// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("62FF9123-A85A-4E9B-A218-435A93E268FD")]
    [NativeTypeName("struct IUIAnimationTransition2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationTransition2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationTransition2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationTransition2*, uint>)(lpVtbl[1]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationTransition2*, uint>)(lpVtbl[2]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDimension(uint* dimension)
        {
            return ((delegate* unmanaged<IUIAnimationTransition2*, uint*, int>)(lpVtbl[3]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), dimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetInitialValue(double value)
        {
            return ((delegate* unmanaged<IUIAnimationTransition2*, double, int>)(lpVtbl[4]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetInitialVectorValue([NativeTypeName("const DOUBLE *")] double* value, uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationTransition2*, double*, uint, int>)(lpVtbl[5]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), value, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetInitialVelocity(double velocity)
        {
            return ((delegate* unmanaged<IUIAnimationTransition2*, double, int>)(lpVtbl[6]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetInitialVectorVelocity([NativeTypeName("const DOUBLE *")] double* velocity, uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationTransition2*, double*, uint, int>)(lpVtbl[7]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), velocity, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT IsDurationKnown()
        {
            return ((delegate* unmanaged<IUIAnimationTransition2*, int>)(lpVtbl[8]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration)
        {
            return ((delegate* unmanaged<IUIAnimationTransition2*, double*, int>)(lpVtbl[9]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), duration);
        }
    }
}
