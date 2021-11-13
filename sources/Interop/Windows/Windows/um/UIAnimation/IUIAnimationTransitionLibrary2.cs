// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("03CFAE53-9580-4EE3-B363-2ECE51B4AF6A")]
    [NativeTypeName("struct IUIAnimationTransitionLibrary2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationTransitionLibrary2 : IUIAnimationTransitionLibrary2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, uint>)(lpVtbl[1]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, uint>)(lpVtbl[2]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateInstantaneousTransition(double finalValue, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, IUIAnimationTransition2**, int>)(lpVtbl[3]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), finalValue, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateInstantaneousVectorTransition([NativeTypeName("const DOUBLE *")] double* finalValue, uint cDimension, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double*, uint, IUIAnimationTransition2**, int>)(lpVtbl[4]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), finalValue, cDimension, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateConstantTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, IUIAnimationTransition2**, int>)(lpVtbl[5]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateDiscreteTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double delay, double finalValue, [NativeTypeName("UI_ANIMATION_SECONDS")] double hold, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, IUIAnimationTransition2**, int>)(lpVtbl[6]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), delay, finalValue, hold, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CreateDiscreteVectorTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double delay, [NativeTypeName("const DOUBLE *")] double* finalValue, uint cDimension, [NativeTypeName("UI_ANIMATION_SECONDS")] double hold, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, uint, double, IUIAnimationTransition2**, int>)(lpVtbl[7]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), delay, finalValue, cDimension, hold, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CreateLinearTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, IUIAnimationTransition2**, int>)(lpVtbl[8]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CreateLinearVectorTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("const DOUBLE *")] double* finalValue, uint cDimension, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, uint, IUIAnimationTransition2**, int>)(lpVtbl[9]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, cDimension, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT CreateLinearTransitionFromSpeed(double speed, double finalValue, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, IUIAnimationTransition2**, int>)(lpVtbl[10]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), speed, finalValue, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CreateLinearVectorTransitionFromSpeed(double speed, [NativeTypeName("const DOUBLE *")] double* finalValue, uint cDimension, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, uint, IUIAnimationTransition2**, int>)(lpVtbl[11]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), speed, finalValue, cDimension, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT CreateSinusoidalTransitionFromVelocity([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("UI_ANIMATION_SECONDS")] double period, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, IUIAnimationTransition2**, int>)(lpVtbl[12]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, period, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT CreateSinusoidalTransitionFromRange([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double minimumValue, double maximumValue, [NativeTypeName("UI_ANIMATION_SECONDS")] double period, UI_ANIMATION_SLOPE slope, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, double, UI_ANIMATION_SLOPE, IUIAnimationTransition2**, int>)(lpVtbl[13]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, minimumValue, maximumValue, period, slope, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT CreateAccelerateDecelerateTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, double accelerationRatio, double decelerationRatio, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, double, IUIAnimationTransition2**, int>)(lpVtbl[14]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, accelerationRatio, decelerationRatio, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT CreateReversalTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, IUIAnimationTransition2**, int>)(lpVtbl[15]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT CreateCubicTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, double finalVelocity, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, IUIAnimationTransition2**, int>)(lpVtbl[16]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, finalVelocity, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CreateCubicVectorTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("const DOUBLE *")] double* finalValue, [NativeTypeName("const DOUBLE *")] double* finalVelocity, uint cDimension, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, double*, uint, IUIAnimationTransition2**, int>)(lpVtbl[17]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, finalVelocity, cDimension, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT CreateSmoothStopTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double maximumDuration, double finalValue, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, IUIAnimationTransition2**, int>)(lpVtbl[18]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), maximumDuration, finalValue, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT CreateParabolicTransitionFromAcceleration(double finalValue, double finalVelocity, double acceleration, IUIAnimationTransition2** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, IUIAnimationTransition2**, int>)(lpVtbl[19]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), finalValue, finalVelocity, acceleration, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT CreateCubicBezierLinearTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, double x1, double y1, double x2, double y2, IUIAnimationTransition2** ppTransition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, double, double, double, IUIAnimationTransition2**, int>)(lpVtbl[20]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, x1, y1, x2, y2, ppTransition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT CreateCubicBezierLinearVectorTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("const DOUBLE *")] double* finalValue, uint cDimension, double x1, double y1, double x2, double y2, IUIAnimationTransition2** ppTransition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, uint, double, double, double, double, IUIAnimationTransition2**, int>)(lpVtbl[21]))((IUIAnimationTransitionLibrary2*)Unsafe.AsPointer(ref this), duration, finalValue, cDimension, x1, y1, x2, y2, ppTransition);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateInstantaneousTransition(double finalValue, IUIAnimationTransition2** transition);

            [VtblIndex(4)]
            HRESULT CreateInstantaneousVectorTransition([NativeTypeName("const DOUBLE *")] double* finalValue, uint cDimension, IUIAnimationTransition2** transition);

            [VtblIndex(5)]
            HRESULT CreateConstantTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, IUIAnimationTransition2** transition);

            [VtblIndex(6)]
            HRESULT CreateDiscreteTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double delay, double finalValue, [NativeTypeName("UI_ANIMATION_SECONDS")] double hold, IUIAnimationTransition2** transition);

            [VtblIndex(7)]
            HRESULT CreateDiscreteVectorTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double delay, [NativeTypeName("const DOUBLE *")] double* finalValue, uint cDimension, [NativeTypeName("UI_ANIMATION_SECONDS")] double hold, IUIAnimationTransition2** transition);

            [VtblIndex(8)]
            HRESULT CreateLinearTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, IUIAnimationTransition2** transition);

            [VtblIndex(9)]
            HRESULT CreateLinearVectorTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("const DOUBLE *")] double* finalValue, uint cDimension, IUIAnimationTransition2** transition);

            [VtblIndex(10)]
            HRESULT CreateLinearTransitionFromSpeed(double speed, double finalValue, IUIAnimationTransition2** transition);

            [VtblIndex(11)]
            HRESULT CreateLinearVectorTransitionFromSpeed(double speed, [NativeTypeName("const DOUBLE *")] double* finalValue, uint cDimension, IUIAnimationTransition2** transition);

            [VtblIndex(12)]
            HRESULT CreateSinusoidalTransitionFromVelocity([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("UI_ANIMATION_SECONDS")] double period, IUIAnimationTransition2** transition);

            [VtblIndex(13)]
            HRESULT CreateSinusoidalTransitionFromRange([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double minimumValue, double maximumValue, [NativeTypeName("UI_ANIMATION_SECONDS")] double period, UI_ANIMATION_SLOPE slope, IUIAnimationTransition2** transition);

            [VtblIndex(14)]
            HRESULT CreateAccelerateDecelerateTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, double accelerationRatio, double decelerationRatio, IUIAnimationTransition2** transition);

            [VtblIndex(15)]
            HRESULT CreateReversalTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, IUIAnimationTransition2** transition);

            [VtblIndex(16)]
            HRESULT CreateCubicTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, double finalVelocity, IUIAnimationTransition2** transition);

            [VtblIndex(17)]
            HRESULT CreateCubicVectorTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("const DOUBLE *")] double* finalValue, [NativeTypeName("const DOUBLE *")] double* finalVelocity, uint cDimension, IUIAnimationTransition2** transition);

            [VtblIndex(18)]
            HRESULT CreateSmoothStopTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double maximumDuration, double finalValue, IUIAnimationTransition2** transition);

            [VtblIndex(19)]
            HRESULT CreateParabolicTransitionFromAcceleration(double finalValue, double finalVelocity, double acceleration, IUIAnimationTransition2** transition);

            [VtblIndex(20)]
            HRESULT CreateCubicBezierLinearTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, double x1, double y1, double x2, double y2, IUIAnimationTransition2** ppTransition);

            [VtblIndex(21)]
            HRESULT CreateCubicBezierLinearVectorTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("const DOUBLE *")] double* finalValue, uint cDimension, double x1, double y1, double x2, double y2, IUIAnimationTransition2** ppTransition);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, uint> Release;

            [NativeTypeName("HRESULT (DOUBLE, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, IUIAnimationTransition2**, int> CreateInstantaneousTransition;

            [NativeTypeName("HRESULT (const DOUBLE *, UINT, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double*, uint, IUIAnimationTransition2**, int> CreateInstantaneousVectorTransition;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, IUIAnimationTransition2**, int> CreateConstantTransition;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, UI_ANIMATION_SECONDS, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, IUIAnimationTransition2**, int> CreateDiscreteTransition;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, const DOUBLE *, UINT, UI_ANIMATION_SECONDS, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, uint, double, IUIAnimationTransition2**, int> CreateDiscreteVectorTransition;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, IUIAnimationTransition2**, int> CreateLinearTransition;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, const DOUBLE *, UINT, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, uint, IUIAnimationTransition2**, int> CreateLinearVectorTransition;

            [NativeTypeName("HRESULT (DOUBLE, DOUBLE, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, IUIAnimationTransition2**, int> CreateLinearTransitionFromSpeed;

            [NativeTypeName("HRESULT (DOUBLE, const DOUBLE *, UINT, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, uint, IUIAnimationTransition2**, int> CreateLinearVectorTransitionFromSpeed;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, UI_ANIMATION_SECONDS, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, IUIAnimationTransition2**, int> CreateSinusoidalTransitionFromVelocity;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, DOUBLE, UI_ANIMATION_SECONDS, UI_ANIMATION_SLOPE, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, double, UI_ANIMATION_SLOPE, IUIAnimationTransition2**, int> CreateSinusoidalTransitionFromRange;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, DOUBLE, DOUBLE, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, double, IUIAnimationTransition2**, int> CreateAccelerateDecelerateTransition;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, IUIAnimationTransition2**, int> CreateReversalTransition;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, DOUBLE, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, IUIAnimationTransition2**, int> CreateCubicTransition;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, const DOUBLE *, const DOUBLE *, UINT, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, double*, uint, IUIAnimationTransition2**, int> CreateCubicVectorTransition;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, IUIAnimationTransition2**, int> CreateSmoothStopTransition;

            [NativeTypeName("HRESULT (DOUBLE, DOUBLE, DOUBLE, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, IUIAnimationTransition2**, int> CreateParabolicTransitionFromAcceleration;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, DOUBLE, DOUBLE, DOUBLE, DOUBLE, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double, double, double, double, double, IUIAnimationTransition2**, int> CreateCubicBezierLinearTransition;

            [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, const DOUBLE *, UINT, DOUBLE, DOUBLE, DOUBLE, DOUBLE, IUIAnimationTransition2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionLibrary2*, double, double*, uint, double, double, double, double, IUIAnimationTransition2**, int> CreateCubicBezierLinearVectorTransition;
        }
    }
}
