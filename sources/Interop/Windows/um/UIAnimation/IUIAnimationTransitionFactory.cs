// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FCD91E03-3E3B-45AD-BBB1-6DFC8153743D")]
    [NativeTypeName("struct IUIAnimationTransitionFactory : IUnknown")]
    public unsafe partial struct IUIAnimationTransitionFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IUIAnimationTransitionFactory*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTransitionFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IUIAnimationTransitionFactory*, uint>)(lpVtbl[1]))((IUIAnimationTransitionFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IUIAnimationTransitionFactory*, uint>)(lpVtbl[2]))((IUIAnimationTransitionFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTransition([NativeTypeName("IUIAnimationInterpolator *")] IUIAnimationInterpolator* interpolator, [NativeTypeName("IUIAnimationTransition **")] IUIAnimationTransition** transition)
        {
            return ((delegate* stdcall<IUIAnimationTransitionFactory*, IUIAnimationInterpolator*, IUIAnimationTransition**, int>)(lpVtbl[3]))((IUIAnimationTransitionFactory*)Unsafe.AsPointer(ref this), interpolator, transition);
        }
    }
}
