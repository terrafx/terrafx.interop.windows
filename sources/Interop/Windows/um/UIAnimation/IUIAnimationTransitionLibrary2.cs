// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("03CFAE53-9580-4EE3-B363-2ECE51B4AF6A")]
    [NativeTypeName("struct IUIAnimationTransitionLibrary2 : IUnknown")]
    public unsafe partial struct IUIAnimationTransitionLibrary2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, uint>)(lpVtbl[1]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, uint>)(lpVtbl[2]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstantaneousTransition([NativeTypeName("DOUBLE")] double finalValue, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, IUIAnimationTransition2**, int>)(lpVtbl[3]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), finalValue, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstantaneousVectorTransition([NativeTypeName("const DOUBLE *")] double* finalValue, [NativeTypeName("UINT")] uint cDimension, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double*, uint, IUIAnimationTransition2**, int>)(lpVtbl[4]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), finalValue, cDimension, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateConstantTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, IUIAnimationTransition2**, int>)(lpVtbl[5]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDiscreteTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double delay, [NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("UI_ANIMATION_SECONDS")] double hold, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, IUIAnimationTransition2**, int>)(lpVtbl[6]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), delay, finalValue, hold, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDiscreteVectorTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double delay, [NativeTypeName("const DOUBLE *")] double* finalValue, [NativeTypeName("UINT")] uint cDimension, [NativeTypeName("UI_ANIMATION_SECONDS")] double hold, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, uint, double, IUIAnimationTransition2**, int>)(lpVtbl[7]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), delay, finalValue, cDimension, hold, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateLinearTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("DOUBLE")] double finalValue, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, IUIAnimationTransition2**, int>)(lpVtbl[8]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateLinearVectorTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("const DOUBLE *")] double* finalValue, [NativeTypeName("UINT")] uint cDimension, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, uint, IUIAnimationTransition2**, int>)(lpVtbl[9]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, cDimension, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateLinearTransitionFromSpeed([NativeTypeName("DOUBLE")] double speed, [NativeTypeName("DOUBLE")] double finalValue, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, IUIAnimationTransition2**, int>)(lpVtbl[10]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), speed, finalValue, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateLinearVectorTransitionFromSpeed([NativeTypeName("DOUBLE")] double speed, [NativeTypeName("const DOUBLE *")] double* finalValue, [NativeTypeName("UINT")] uint cDimension, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, uint, IUIAnimationTransition2**, int>)(lpVtbl[11]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), speed, finalValue, cDimension, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSinusoidalTransitionFromVelocity([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("UI_ANIMATION_SECONDS")] double period, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, IUIAnimationTransition2**, int>)(lpVtbl[12]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, period, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSinusoidalTransitionFromRange([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("DOUBLE")] double minimumValue, [NativeTypeName("DOUBLE")] double maximumValue, [NativeTypeName("UI_ANIMATION_SECONDS")] double period, UI_ANIMATION_SLOPE slope, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, double, UI_ANIMATION_SLOPE, IUIAnimationTransition2**, int>)(lpVtbl[13]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, minimumValue, maximumValue, period, slope, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAccelerateDecelerateTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("DOUBLE")] double accelerationRatio, [NativeTypeName("DOUBLE")] double decelerationRatio, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, double, IUIAnimationTransition2**, int>)(lpVtbl[14]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, accelerationRatio, decelerationRatio, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateReversalTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, IUIAnimationTransition2**, int>)(lpVtbl[15]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCubicTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("DOUBLE")] double finalVelocity, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, IUIAnimationTransition2**, int>)(lpVtbl[16]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, finalVelocity, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCubicVectorTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("const DOUBLE *")] double* finalValue, [NativeTypeName("const DOUBLE *")] double* finalVelocity, [NativeTypeName("UINT")] uint cDimension, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, double*, uint, IUIAnimationTransition2**, int>)(lpVtbl[17]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, finalVelocity, cDimension, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSmoothStopTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double maximumDuration, [NativeTypeName("DOUBLE")] double finalValue, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, IUIAnimationTransition2**, int>)(lpVtbl[18]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), maximumDuration, finalValue, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateParabolicTransitionFromAcceleration([NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("DOUBLE")] double finalVelocity, [NativeTypeName("DOUBLE")] double acceleration, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, IUIAnimationTransition2**, int>)(lpVtbl[19]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), finalValue, finalVelocity, acceleration, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCubicBezierLinearTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("DOUBLE")] double x1, [NativeTypeName("DOUBLE")] double y1, [NativeTypeName("DOUBLE")] double x2, [NativeTypeName("DOUBLE")] double y2, IUIAnimationTransition2** ppTransition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, double, double, double, IUIAnimationTransition2**, int>)(lpVtbl[20]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, x1, y1, x2, y2, ppTransition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCubicBezierLinearVectorTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("const DOUBLE *")] double* finalValue, [NativeTypeName("UINT")] uint cDimension, [NativeTypeName("DOUBLE")] double x1, [NativeTypeName("DOUBLE")] double y1, [NativeTypeName("DOUBLE")] double x2, [NativeTypeName("DOUBLE")] double y2, IUIAnimationTransition2** ppTransition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, uint, double, double, double, double, IUIAnimationTransition2**, int>)(lpVtbl[21]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, cDimension, x1, y1, x2, y2, ppTransition);
        }
    }
}
