// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7815CBBA-DDF7-478C-A46C-7B6C738B7978")]
    [NativeTypeName("struct IUIAnimationInterpolator : IUnknown")]
    public unsafe partial struct IUIAnimationInterpolator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IUIAnimationInterpolator*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IUIAnimationInterpolator*, uint>)(lpVtbl[1]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IUIAnimationInterpolator*, uint>)(lpVtbl[2]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInitialValueAndVelocity([NativeTypeName("DOUBLE")] double initialValue, [NativeTypeName("DOUBLE")] double initialVelocity)
        {
            return ((delegate* stdcall<IUIAnimationInterpolator*, double, double, int>)(lpVtbl[3]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), initialValue, initialVelocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDuration([NativeTypeName("UI_ANIMATION_SECONDS")] double duration)
        {
            return ((delegate* stdcall<IUIAnimationInterpolator*, double, int>)(lpVtbl[4]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), duration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration)
        {
            return ((delegate* stdcall<IUIAnimationInterpolator*, double*, int>)(lpVtbl[5]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), duration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFinalValue([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* stdcall<IUIAnimationInterpolator*, double*, int>)(lpVtbl[6]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InterpolateValue([NativeTypeName("UI_ANIMATION_SECONDS")] double offset, [NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* stdcall<IUIAnimationInterpolator*, double, double*, int>)(lpVtbl[7]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), offset, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InterpolateVelocity([NativeTypeName("UI_ANIMATION_SECONDS")] double offset, [NativeTypeName("DOUBLE *")] double* velocity)
        {
            return ((delegate* stdcall<IUIAnimationInterpolator*, double, double*, int>)(lpVtbl[8]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), offset, velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDependencies([NativeTypeName("UI_ANIMATION_DEPENDENCIES *")] UI_ANIMATION_DEPENDENCIES* initialValueDependencies, [NativeTypeName("UI_ANIMATION_DEPENDENCIES *")] UI_ANIMATION_DEPENDENCIES* initialVelocityDependencies, [NativeTypeName("UI_ANIMATION_DEPENDENCIES *")] UI_ANIMATION_DEPENDENCIES* durationDependencies)
        {
            return ((delegate* stdcall<IUIAnimationInterpolator*, UI_ANIMATION_DEPENDENCIES*, UI_ANIMATION_DEPENDENCIES*, UI_ANIMATION_DEPENDENCIES*, int>)(lpVtbl[9]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), initialValueDependencies, initialVelocityDependencies, durationDependencies);
        }
    }
}
