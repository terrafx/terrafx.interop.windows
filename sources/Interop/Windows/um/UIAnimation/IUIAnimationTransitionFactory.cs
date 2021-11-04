// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FCD91E03-3E3B-45AD-BBB1-6DFC8153743D")]
    [NativeTypeName("struct IUIAnimationTransitionFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationTransitionFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionFactory*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTransitionFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationTransitionFactory*, uint>)(lpVtbl[1]))((IUIAnimationTransitionFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationTransitionFactory*, uint>)(lpVtbl[2]))((IUIAnimationTransitionFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateTransition(IUIAnimationInterpolator* interpolator, IUIAnimationTransition** transition)
        {
            return ((delegate* unmanaged<IUIAnimationTransitionFactory*, IUIAnimationInterpolator*, IUIAnimationTransition**, int>)(lpVtbl[3]))((IUIAnimationTransitionFactory*)Unsafe.AsPointer(ref this), interpolator, transition);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionFactory*, uint> Release;

            [NativeTypeName("HRESULT (IUIAnimationInterpolator *, IUIAnimationTransition **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationTransitionFactory*, IUIAnimationInterpolator*, IUIAnimationTransition**, int> CreateTransition;
        }
    }
}
