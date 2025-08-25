// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemNavigationManager2.xml' path='doc/member[@name="ISystemNavigationManager2"]/*' />
[Guid("8C510401-67BE-49AE-9509-671C1E54A389")]
[NativeTypeName("struct ISystemNavigationManager2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemNavigationManager2 : ISystemNavigationManager2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISystemNavigationManager2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemNavigationManager2*, Guid*, void**, int>)(lpVtbl[0]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemNavigationManager2*, uint>)(lpVtbl[1]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemNavigationManager2*, uint>)(lpVtbl[2]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemNavigationManager2*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemNavigationManager2*, HSTRING*, int>)(lpVtbl[4]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemNavigationManager2*, TrustLevel*, int>)(lpVtbl[5]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemNavigationManager2.xml' path='doc/member[@name="ISystemNavigationManager2.get_AppViewBackButtonVisibility"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppViewBackButtonVisibility([NativeTypeName("ABI::Windows::UI::Core::AppViewBackButtonVisibility *")] AppViewBackButtonVisibility* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemNavigationManager2*, AppViewBackButtonVisibility*, int>)(lpVtbl[6]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemNavigationManager2.xml' path='doc/member[@name="ISystemNavigationManager2.put_AppViewBackButtonVisibility"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AppViewBackButtonVisibility([NativeTypeName("ABI::Windows::UI::Core::AppViewBackButtonVisibility")] AppViewBackButtonVisibility value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemNavigationManager2*, AppViewBackButtonVisibility, int>)(lpVtbl[7]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppViewBackButtonVisibility([NativeTypeName("ABI::Windows::UI::Core::AppViewBackButtonVisibility *")] AppViewBackButtonVisibility* value);

        [VtblIndex(7)]
        HRESULT put_AppViewBackButtonVisibility([NativeTypeName("ABI::Windows::UI::Core::AppViewBackButtonVisibility")] AppViewBackButtonVisibility value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::AppViewBackButtonVisibility *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppViewBackButtonVisibility*, int> get_AppViewBackButtonVisibility;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::AppViewBackButtonVisibility) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppViewBackButtonVisibility, int> put_AppViewBackButtonVisibility;
    }
}
