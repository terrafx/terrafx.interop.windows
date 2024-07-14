// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IApplicationViewStatics.xml' path='doc/member[@name="IApplicationViewStatics"]/*' />
[Guid("010A6306-C433-44E5-A9F2-BD84D4030A95")]
[NativeTypeName("struct IApplicationViewStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ApplicationView static methods may be altered or unavailable for releases after Windows 8.1. Instead, use ApplicationView.GetForCurrentView to get an instance of ApplicationView.")]
public unsafe partial struct IApplicationViewStatics : IApplicationViewStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationViewStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewStatics*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationViewStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewStatics*, uint>)(lpVtbl[1]))((IApplicationViewStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewStatics*, uint>)(lpVtbl[2]))((IApplicationViewStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationViewStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewStatics*, HSTRING*, int>)(lpVtbl[4]))((IApplicationViewStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewStatics*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationViewStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IApplicationViewStatics.xml' path='doc/member[@name="IApplicationViewStatics.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Value may be altered or unavailable for releases after Windows 8.1. Instead, query for window layout sizes directly.")]
    public HRESULT get_Value([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewState *")] ApplicationViewState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewStatics*, ApplicationViewState*, int>)(lpVtbl[6]))((IApplicationViewStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationViewStatics.xml' path='doc/member[@name="IApplicationViewStatics.TryUnsnap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("TryUnsnap may be altered or unavailable for releases after Windows 8.1. Apps can be continuously resized, but cannot be snapped, starting in Windows 8.1.")]
    public HRESULT TryUnsnap([NativeTypeName("boolean *")] byte* success)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewStatics*, byte*, int>)(lpVtbl[7]))((IApplicationViewStatics*)Unsafe.AsPointer(ref this), success);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Value may be altered or unavailable for releases after Windows 8.1. Instead, query for window layout sizes directly.")]
        HRESULT get_Value([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewState *")] ApplicationViewState* value);

        [VtblIndex(7)]
        [Obsolete("TryUnsnap may be altered or unavailable for releases after Windows 8.1. Apps can be continuously resized, but cannot be snapped, starting in Windows 8.1.")]
        HRESULT TryUnsnap([NativeTypeName("boolean *")] byte* success);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewState *) __attribute__((stdcall))")]
        [Obsolete("Value may be altered or unavailable for releases after Windows 8.1. Instead, query for window layout sizes directly.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ApplicationViewState*, int> get_Value;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("TryUnsnap may be altered or unavailable for releases after Windows 8.1. Apps can be continuously resized, but cannot be snapped, starting in Windows 8.1.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> TryUnsnap;
    }
}
