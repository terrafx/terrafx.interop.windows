// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("274A7DEA-D771-4095-ABBD-8DF7ABD23CE3")]
    [NativeTypeName("struct IUIAnimationTimerEventHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationTimerEventHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationTimerEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTimerEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationTimerEventHandler*, uint>)(lpVtbl[1]))((IUIAnimationTimerEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationTimerEventHandler*, uint>)(lpVtbl[2]))((IUIAnimationTimerEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnPreUpdate()
        {
            return ((delegate* unmanaged<IUIAnimationTimerEventHandler*, int>)(lpVtbl[3]))((IUIAnimationTimerEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int OnPostUpdate()
        {
            return ((delegate* unmanaged<IUIAnimationTimerEventHandler*, int>)(lpVtbl[4]))((IUIAnimationTimerEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int OnRenderingTooSlow([NativeTypeName("UINT32")] uint framesPerSecond)
        {
            return ((delegate* unmanaged<IUIAnimationTimerEventHandler*, uint, int>)(lpVtbl[5]))((IUIAnimationTimerEventHandler*)Unsafe.AsPointer(ref this), framesPerSecond);
        }
    }
}
