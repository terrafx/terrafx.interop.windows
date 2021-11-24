// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("F6E022BA-BFF3-42EC-9033-E073F33E83C3")]
[NativeTypeName("struct IUIAnimationManagerEventHandler2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationManagerEventHandler2 : IUIAnimationManagerEventHandler2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationManagerEventHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationManagerEventHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationManagerEventHandler2*, uint>)(lpVtbl[1]))((IUIAnimationManagerEventHandler2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationManagerEventHandler2*, uint>)(lpVtbl[2]))((IUIAnimationManagerEventHandler2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnManagerStatusChanged(UI_ANIMATION_MANAGER_STATUS newStatus, UI_ANIMATION_MANAGER_STATUS previousStatus)
    {
        return ((delegate* unmanaged<IUIAnimationManagerEventHandler2*, UI_ANIMATION_MANAGER_STATUS, UI_ANIMATION_MANAGER_STATUS, int>)(lpVtbl[3]))((IUIAnimationManagerEventHandler2*)Unsafe.AsPointer(ref this), newStatus, previousStatus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnManagerStatusChanged(UI_ANIMATION_MANAGER_STATUS newStatus, UI_ANIMATION_MANAGER_STATUS previousStatus);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IUIAnimationManagerEventHandler2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IUIAnimationManagerEventHandler2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IUIAnimationManagerEventHandler2*, uint> Release;

        [NativeTypeName("HRESULT (UI_ANIMATION_MANAGER_STATUS, UI_ANIMATION_MANAGER_STATUS) __attribute__((stdcall))")]
        public delegate* unmanaged<IUIAnimationManagerEventHandler2*, UI_ANIMATION_MANAGER_STATUS, UI_ANIMATION_MANAGER_STATUS, int> OnManagerStatusChanged;
    }
}
