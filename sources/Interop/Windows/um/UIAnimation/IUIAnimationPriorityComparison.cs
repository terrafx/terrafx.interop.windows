// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83FA9B74-5F86-4618-BC6A-A2FAC19B3F44")]
    [NativeTypeName("struct IUIAnimationPriorityComparison : IUnknown")]
    public unsafe partial struct IUIAnimationPriorityComparison
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IUIAnimationPriorityComparison*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationPriorityComparison*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IUIAnimationPriorityComparison*, uint>)(lpVtbl[1]))((IUIAnimationPriorityComparison*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IUIAnimationPriorityComparison*, uint>)(lpVtbl[2]))((IUIAnimationPriorityComparison*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HasPriority([NativeTypeName("IUIAnimationStoryboard *")] IUIAnimationStoryboard* scheduledStoryboard, [NativeTypeName("IUIAnimationStoryboard *")] IUIAnimationStoryboard* newStoryboard, UI_ANIMATION_PRIORITY_EFFECT priorityEffect)
        {
            return ((delegate* stdcall<IUIAnimationPriorityComparison*, IUIAnimationStoryboard*, IUIAnimationStoryboard*, UI_ANIMATION_PRIORITY_EFFECT, int>)(lpVtbl[3]))((IUIAnimationPriorityComparison*)Unsafe.AsPointer(ref this), scheduledStoryboard, newStoryboard, priorityEffect);
        }
    }
}
