// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6B0EFAD1-A053-41D6-9085-33A689144665")]
    [NativeTypeName("struct IUIAnimationTimer : IUnknown")]
    public unsafe partial struct IUIAnimationTimer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IUIAnimationTimer*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IUIAnimationTimer*, uint>)(lpVtbl[1]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IUIAnimationTimer*, uint>)(lpVtbl[2]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTimerUpdateHandler([NativeTypeName("IUIAnimationTimerUpdateHandler *")] IUIAnimationTimerUpdateHandler* updateHandler, UI_ANIMATION_IDLE_BEHAVIOR idleBehavior)
        {
            return ((delegate* stdcall<IUIAnimationTimer*, IUIAnimationTimerUpdateHandler*, UI_ANIMATION_IDLE_BEHAVIOR, int>)(lpVtbl[3]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), updateHandler, idleBehavior);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTimerEventHandler([NativeTypeName("IUIAnimationTimerEventHandler *")] IUIAnimationTimerEventHandler* handler)
        {
            return ((delegate* stdcall<IUIAnimationTimer*, IUIAnimationTimerEventHandler*, int>)(lpVtbl[4]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Enable()
        {
            return ((delegate* stdcall<IUIAnimationTimer*, int>)(lpVtbl[5]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Disable()
        {
            return ((delegate* stdcall<IUIAnimationTimer*, int>)(lpVtbl[6]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEnabled()
        {
            return ((delegate* stdcall<IUIAnimationTimer*, int>)(lpVtbl[7]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* seconds)
        {
            return ((delegate* stdcall<IUIAnimationTimer*, double*, int>)(lpVtbl[8]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), seconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFrameRateThreshold([NativeTypeName("UINT32")] uint framesPerSecond)
        {
            return ((delegate* stdcall<IUIAnimationTimer*, uint, int>)(lpVtbl[9]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), framesPerSecond);
        }
    }
}
