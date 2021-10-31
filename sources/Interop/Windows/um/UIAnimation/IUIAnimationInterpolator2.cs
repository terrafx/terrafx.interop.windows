// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA76AFF8-EA22-4A23-A0EF-A6A966703518")]
    [NativeTypeName("struct IUIAnimationInterpolator2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationInterpolator2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationInterpolator2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationInterpolator2*, uint>)(lpVtbl[1]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationInterpolator2*, uint>)(lpVtbl[2]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDimension([NativeTypeName("UINT *")] uint* dimension)
        {
            return ((delegate* unmanaged<IUIAnimationInterpolator2*, uint*, int>)(lpVtbl[3]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), dimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetInitialValueAndVelocity([NativeTypeName("DOUBLE *")] double* initialValue, [NativeTypeName("DOUBLE *")] double* initialVelocity, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationInterpolator2*, double*, double*, uint, int>)(lpVtbl[4]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), initialValue, initialVelocity, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetDuration([NativeTypeName("UI_ANIMATION_SECONDS")] double duration)
        {
            return ((delegate* unmanaged<IUIAnimationInterpolator2*, double, int>)(lpVtbl[5]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), duration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration)
        {
            return ((delegate* unmanaged<IUIAnimationInterpolator2*, double*, int>)(lpVtbl[6]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), duration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetFinalValue([NativeTypeName("DOUBLE *")] double* value, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationInterpolator2*, double*, uint, int>)(lpVtbl[7]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), value, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT InterpolateValue([NativeTypeName("UI_ANIMATION_SECONDS")] double offset, [NativeTypeName("DOUBLE *")] double* value, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationInterpolator2*, double, double*, uint, int>)(lpVtbl[8]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), offset, value, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT InterpolateVelocity([NativeTypeName("UI_ANIMATION_SECONDS")] double offset, [NativeTypeName("DOUBLE *")] double* velocity, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationInterpolator2*, double, double*, uint, int>)(lpVtbl[9]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), offset, velocity, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetPrimitiveInterpolation(IUIAnimationPrimitiveInterpolation* interpolation, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationInterpolator2*, IUIAnimationPrimitiveInterpolation*, uint, int>)(lpVtbl[10]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), interpolation, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetDependencies(UI_ANIMATION_DEPENDENCIES* initialValueDependencies, UI_ANIMATION_DEPENDENCIES* initialVelocityDependencies, UI_ANIMATION_DEPENDENCIES* durationDependencies)
        {
            return ((delegate* unmanaged<IUIAnimationInterpolator2*, UI_ANIMATION_DEPENDENCIES*, UI_ANIMATION_DEPENDENCIES*, UI_ANIMATION_DEPENDENCIES*, int>)(lpVtbl[11]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), initialValueDependencies, initialVelocityDependencies, durationDependencies);
        }
    }
}
