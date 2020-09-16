// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("195509B7-5D5E-4E3E-B278-EE3759B367AD")]
    [NativeTypeName("struct IUIAnimationTimerUpdateHandler : IUnknown")]
    public unsafe partial struct IUIAnimationTimerUpdateHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationTimerUpdateHandler*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTimerUpdateHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationTimerUpdateHandler*, uint>)(lpVtbl[1]))((IUIAnimationTimerUpdateHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationTimerUpdateHandler*, uint>)(lpVtbl[2]))((IUIAnimationTimerUpdateHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnUpdate([NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow, [NativeTypeName("UI_ANIMATION_UPDATE_RESULT *")] UI_ANIMATION_UPDATE_RESULT* result)
        {
            return ((delegate* unmanaged<IUIAnimationTimerUpdateHandler*, double, UI_ANIMATION_UPDATE_RESULT*, int>)(lpVtbl[3]))((IUIAnimationTimerUpdateHandler*)Unsafe.AsPointer(ref this), timeNow, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTimerClientEventHandler([NativeTypeName("IUIAnimationTimerClientEventHandler *")] IUIAnimationTimerClientEventHandler* handler)
        {
            return ((delegate* unmanaged<IUIAnimationTimerUpdateHandler*, IUIAnimationTimerClientEventHandler*, int>)(lpVtbl[4]))((IUIAnimationTimerUpdateHandler*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearTimerClientEventHandler()
        {
            return ((delegate* unmanaged<IUIAnimationTimerUpdateHandler*, int>)(lpVtbl[5]))((IUIAnimationTimerUpdateHandler*)Unsafe.AsPointer(ref this));
        }
    }
}
