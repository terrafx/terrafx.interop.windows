// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CA5A14B1-D24F-48B8-8FE4-C78169BA954E")]
    [NativeTypeName("struct IUIAnimationTransitionLibrary : IUnknown")]
    public unsafe partial struct IUIAnimationTransitionLibrary
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, uint>)(lpVtbl[1]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, uint>)(lpVtbl[2]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstantaneousTransition([NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, double, IUIAnimationTransition**, int>)(lpVtbl[3]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), finalValue, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateConstantTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, double, IUIAnimationTransition**, int>)(lpVtbl[4]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDiscreteTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double delay, [NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("UI_ANIMATION_SECONDS")] double hold, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, double, double, double, IUIAnimationTransition**, int>)(lpVtbl[5]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), delay, finalValue, hold, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateLinearTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, double, double, IUIAnimationTransition**, int>)(lpVtbl[6]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, finalValue, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateLinearTransitionFromSpeed([NativeTypeName("DOUBLE")] double speed, [NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, double, double, IUIAnimationTransition**, int>)(lpVtbl[7]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), speed, finalValue, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSinusoidalTransitionFromVelocity([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("UI_ANIMATION_SECONDS")] double period, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, double, double, IUIAnimationTransition**, int>)(lpVtbl[8]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, period, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSinusoidalTransitionFromRange([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("DOUBLE")] double minimumValue, [NativeTypeName("DOUBLE")] double maximumValue, [NativeTypeName("UI_ANIMATION_SECONDS")] double period, UI_ANIMATION_SLOPE slope, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, double, double, double, double, UI_ANIMATION_SLOPE, IUIAnimationTransition**, int>)(lpVtbl[9]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, minimumValue, maximumValue, period, slope, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAccelerateDecelerateTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("DOUBLE")] double accelerationRatio, [NativeTypeName("DOUBLE")] double decelerationRatio, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, double, double, double, double, IUIAnimationTransition**, int>)(lpVtbl[10]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, finalValue, accelerationRatio, decelerationRatio, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateReversalTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, double, IUIAnimationTransition**, int>)(lpVtbl[11]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCubicTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("DOUBLE")] double finalVelocity, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, double, double, double, IUIAnimationTransition**, int>)(lpVtbl[12]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, finalValue, finalVelocity, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSmoothStopTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double maximumDuration, [NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, double, double, IUIAnimationTransition**, int>)(lpVtbl[13]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), maximumDuration, finalValue, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateParabolicTransitionFromAcceleration([NativeTypeName("DOUBLE")] double finalValue, [NativeTypeName("DOUBLE")] double finalVelocity, [NativeTypeName("DOUBLE")] double acceleration, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionLibrary*, double, double, double, IUIAnimationTransition**, int>)(lpVtbl[14]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), finalValue, finalVelocity, acceleration, transition);
        }
    }
}
