// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83FA9B74-5F86-4618-BC6A-A2FAC19B3F44")]
    [NativeTypeName("struct IUIAnimationPriorityComparison : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationPriorityComparison
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationPriorityComparison*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationPriorityComparison*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationPriorityComparison*, uint>)(lpVtbl[1]))((IUIAnimationPriorityComparison*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationPriorityComparison*, uint>)(lpVtbl[2]))((IUIAnimationPriorityComparison*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT HasPriority(IUIAnimationStoryboard* scheduledStoryboard, IUIAnimationStoryboard* newStoryboard, UI_ANIMATION_PRIORITY_EFFECT priorityEffect)
        {
            return ((delegate* unmanaged<IUIAnimationPriorityComparison*, IUIAnimationStoryboard*, IUIAnimationStoryboard*, UI_ANIMATION_PRIORITY_EFFECT, int>)(lpVtbl[3]))((IUIAnimationPriorityComparison*)Unsafe.AsPointer(ref this), scheduledStoryboard, newStoryboard, priorityEffect);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationPriorityComparison*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationPriorityComparison*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationPriorityComparison*, uint> Release;

            [NativeTypeName("HRESULT (IUIAnimationStoryboard *, IUIAnimationStoryboard *, UI_ANIMATION_PRIORITY_EFFECT) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationPriorityComparison*, IUIAnimationStoryboard*, IUIAnimationStoryboard*, UI_ANIMATION_PRIORITY_EFFECT, int> HasPriority;
        }
    }
}
