// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BAC5F55A-BA7C-414C-B599-FBF850F553C6")]
    [NativeTypeName("struct IUIAnimationStoryboardEventHandler2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationStoryboardEventHandler2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationStoryboardEventHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler2*, uint>)(lpVtbl[1]))((IUIAnimationStoryboardEventHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler2*, uint>)(lpVtbl[2]))((IUIAnimationStoryboardEventHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnStoryboardStatusChanged(IUIAnimationStoryboard2* storyboard, UI_ANIMATION_STORYBOARD_STATUS newStatus, UI_ANIMATION_STORYBOARD_STATUS previousStatus)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler2*, IUIAnimationStoryboard2*, UI_ANIMATION_STORYBOARD_STATUS, UI_ANIMATION_STORYBOARD_STATUS, int>)(lpVtbl[3]))((IUIAnimationStoryboardEventHandler2*)Unsafe.AsPointer(ref this), storyboard, newStatus, previousStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int OnStoryboardUpdated(IUIAnimationStoryboard2* storyboard)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler2*, IUIAnimationStoryboard2*, int>)(lpVtbl[4]))((IUIAnimationStoryboardEventHandler2*)Unsafe.AsPointer(ref this), storyboard);
        }
    }
}
