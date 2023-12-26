// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IViewModePreferencesStatics.xml' path='doc/member[@name="IViewModePreferencesStatics"]/*' />
[Guid("69B60A65-5DE5-40D8-8306-3833DF7A2274")]
[NativeTypeName("struct IViewModePreferencesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IViewModePreferencesStatics : IViewModePreferencesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IViewModePreferencesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IViewModePreferencesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IViewModePreferencesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IViewModePreferencesStatics*, uint>)(lpVtbl[1]))((IViewModePreferencesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IViewModePreferencesStatics*, uint>)(lpVtbl[2]))((IViewModePreferencesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IViewModePreferencesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IViewModePreferencesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IViewModePreferencesStatics*, HSTRING*, int>)(lpVtbl[4]))((IViewModePreferencesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IViewModePreferencesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IViewModePreferencesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IViewModePreferencesStatics.xml' path='doc/member[@name="IViewModePreferencesStatics.CreateDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateDefault([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")] ApplicationViewMode mode, [NativeTypeName("ABI::Windows::UI::ViewManagement::IViewModePreferences **")] IViewModePreferences** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IViewModePreferencesStatics*, ApplicationViewMode, IViewModePreferences**, int>)(lpVtbl[6]))((IViewModePreferencesStatics*)Unsafe.AsPointer(ref this), mode, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateDefault([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")] ApplicationViewMode mode, [NativeTypeName("ABI::Windows::UI::ViewManagement::IViewModePreferences **")] IViewModePreferences** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewMode, ABI::Windows::UI::ViewManagement::IViewModePreferences **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ApplicationViewMode, IViewModePreferences**, int> CreateDefault;
    }
}
