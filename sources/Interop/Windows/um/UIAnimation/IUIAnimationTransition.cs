// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC6CE252-F731-41CF-B610-614B6CA049AD")]
    [NativeTypeName("struct IUIAnimationTransition : IUnknown")]
    public unsafe partial struct IUIAnimationTransition
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationTransition*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationTransition*, uint>)(lpVtbl[1]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationTransition*, uint>)(lpVtbl[2]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInitialValue([NativeTypeName("DOUBLE")] double value)
        {
            return ((delegate* unmanaged<IUIAnimationTransition*, double, int>)(lpVtbl[3]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInitialVelocity([NativeTypeName("DOUBLE")] double velocity)
        {
            return ((delegate* unmanaged<IUIAnimationTransition*, double, int>)(lpVtbl[4]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this), velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDurationKnown()
        {
            return ((delegate* unmanaged<IUIAnimationTransition*, int>)(lpVtbl[5]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration)
        {
            return ((delegate* unmanaged<IUIAnimationTransition*, double*, int>)(lpVtbl[6]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this), duration);
        }
    }
}
