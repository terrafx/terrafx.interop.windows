// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("937D4916-C1A6-42D5-88D8-30344D6EFE31")]
    [NativeTypeName("struct IUIAnimationTransitionFactory2 : IUnknown")]
    public unsafe partial struct IUIAnimationTransitionFactory2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IUIAnimationTransitionFactory2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTransitionFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IUIAnimationTransitionFactory2*, uint>)(lpVtbl[1]))((IUIAnimationTransitionFactory2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IUIAnimationTransitionFactory2*, uint>)(lpVtbl[2]))((IUIAnimationTransitionFactory2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTransition([NativeTypeName("IUIAnimationInterpolator2 *")] IUIAnimationInterpolator2* interpolator, [NativeTypeName("IUIAnimationTransition2 **")] IUIAnimationTransition2** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionFactory2*, IUIAnimationInterpolator2*, IUIAnimationTransition2**, int>)(lpVtbl[3]))((IUIAnimationTransitionFactory2*)Unsafe.AsPointer(ref this), interpolator, transition);
        }
    }
}
