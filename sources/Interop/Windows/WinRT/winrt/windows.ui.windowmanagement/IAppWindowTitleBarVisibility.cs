// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppWindowTitleBarVisibility.xml' path='doc/member[@name="IAppWindowTitleBarVisibility"]/*' />
[Guid("A215A4E3-6E7E-5651-8C3B-624819528154")]
[NativeTypeName("struct IAppWindowTitleBarVisibility : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppWindowTitleBarVisibility : IAppWindowTitleBarVisibility.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppWindowTitleBarVisibility));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBarVisibility*, Guid*, void**, int>)(lpVtbl[0]))((IAppWindowTitleBarVisibility*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBarVisibility*, uint>)(lpVtbl[1]))((IAppWindowTitleBarVisibility*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBarVisibility*, uint>)(lpVtbl[2]))((IAppWindowTitleBarVisibility*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBarVisibility*, uint*, Guid**, int>)(lpVtbl[3]))((IAppWindowTitleBarVisibility*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBarVisibility*, HSTRING*, int>)(lpVtbl[4]))((IAppWindowTitleBarVisibility*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBarVisibility*, TrustLevel*, int>)(lpVtbl[5]))((IAppWindowTitleBarVisibility*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppWindowTitleBarVisibility.xml' path='doc/member[@name="IAppWindowTitleBarVisibility.GetPreferredVisibility"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPreferredVisibility([NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowTitleBarVisibility *")] AppWindowTitleBarVisibility* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBarVisibility*, AppWindowTitleBarVisibility*, int>)(lpVtbl[6]))((IAppWindowTitleBarVisibility*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppWindowTitleBarVisibility.xml' path='doc/member[@name="IAppWindowTitleBarVisibility.SetPreferredVisibility"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPreferredVisibility([NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowTitleBarVisibility")] AppWindowTitleBarVisibility visibilityMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBarVisibility*, AppWindowTitleBarVisibility, int>)(lpVtbl[7]))((IAppWindowTitleBarVisibility*)Unsafe.AsPointer(ref this), visibilityMode);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetPreferredVisibility([NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowTitleBarVisibility *")] AppWindowTitleBarVisibility* result);

        [VtblIndex(7)]
        HRESULT SetPreferredVisibility([NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowTitleBarVisibility")] AppWindowTitleBarVisibility visibilityMode);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::AppWindowTitleBarVisibility *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppWindowTitleBarVisibility*, int> GetPreferredVisibility;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::AppWindowTitleBarVisibility) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppWindowTitleBarVisibility, int> SetPreferredVisibility;
    }
}
