// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILauncherViewOptions.xml' path='doc/member[@name="ILauncherViewOptions"]/*' />
[Guid("8A9B29F1-7CA7-49DE-9BD3-3C5B7184F616")]
[NativeTypeName("struct ILauncherViewOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILauncherViewOptions : ILauncherViewOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILauncherViewOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherViewOptions*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherViewOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherViewOptions*, uint>)(lpVtbl[1]))((ILauncherViewOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherViewOptions*, uint>)(lpVtbl[2]))((ILauncherViewOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherViewOptions*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherViewOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherViewOptions*, HSTRING*, int>)(lpVtbl[4]))((ILauncherViewOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherViewOptions*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherViewOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILauncherViewOptions.xml' path='doc/member[@name="ILauncherViewOptions.get_DesiredRemainingView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DesiredRemainingView([NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference *")] ViewSizePreference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherViewOptions*, ViewSizePreference*, int>)(lpVtbl[6]))((ILauncherViewOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherViewOptions.xml' path='doc/member[@name="ILauncherViewOptions.put_DesiredRemainingView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DesiredRemainingView([NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")] ViewSizePreference value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherViewOptions*, ViewSizePreference, int>)(lpVtbl[7]))((ILauncherViewOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DesiredRemainingView([NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference *")] ViewSizePreference* value);

        [VtblIndex(7)]
        HRESULT put_DesiredRemainingView([NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")] ViewSizePreference value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::ViewSizePreference *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ViewSizePreference*, int> get_DesiredRemainingView;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::ViewSizePreference) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ViewSizePreference, int> put_DesiredRemainingView;
    }
}
