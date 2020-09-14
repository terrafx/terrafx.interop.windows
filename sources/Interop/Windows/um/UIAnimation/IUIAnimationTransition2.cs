// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("62FF9123-A85A-4E9B-A218-435A93E268FD")]
    [NativeTypeName("struct IUIAnimationTransition2 : IUnknown")]
    public unsafe partial struct IUIAnimationTransition2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IUIAnimationTransition2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IUIAnimationTransition2*, uint>)(lpVtbl[1]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IUIAnimationTransition2*, uint>)(lpVtbl[2]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDimension([NativeTypeName("UINT *")] uint* dimension)
        {
            return ((delegate* stdcall<IUIAnimationTransition2*, uint*, int>)(lpVtbl[3]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), dimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInitialValue([NativeTypeName("DOUBLE")] double value)
        {
            return ((delegate* stdcall<IUIAnimationTransition2*, double, int>)(lpVtbl[4]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInitialVectorValue([NativeTypeName("const DOUBLE *")] double* value, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* stdcall<IUIAnimationTransition2*, double*, uint, int>)(lpVtbl[5]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), value, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInitialVelocity([NativeTypeName("DOUBLE")] double velocity)
        {
            return ((delegate* stdcall<IUIAnimationTransition2*, double, int>)(lpVtbl[6]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInitialVectorVelocity([NativeTypeName("const DOUBLE *")] double* velocity, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* stdcall<IUIAnimationTransition2*, double*, uint, int>)(lpVtbl[7]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), velocity, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDurationKnown()
        {
            return ((delegate* stdcall<IUIAnimationTransition2*, int>)(lpVtbl[8]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration)
        {
            return ((delegate* stdcall<IUIAnimationTransition2*, double*, int>)(lpVtbl[9]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), duration);
        }
    }
}
