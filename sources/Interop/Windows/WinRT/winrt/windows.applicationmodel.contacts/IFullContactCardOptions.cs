// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFullContactCardOptions.xml' path='doc/member[@name="IFullContactCardOptions"]/*' />
[Guid("8744436C-5CF9-4683-BDCA-A1FDEBF8DBCE")]
[NativeTypeName("struct IFullContactCardOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFullContactCardOptions : IFullContactCardOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFullContactCardOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullContactCardOptions*, Guid*, void**, int>)(lpVtbl[0]))((IFullContactCardOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFullContactCardOptions*, uint>)(lpVtbl[1]))((IFullContactCardOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFullContactCardOptions*, uint>)(lpVtbl[2]))((IFullContactCardOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullContactCardOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IFullContactCardOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullContactCardOptions*, HSTRING*, int>)(lpVtbl[4]))((IFullContactCardOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullContactCardOptions*, TrustLevel*, int>)(lpVtbl[5]))((IFullContactCardOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFullContactCardOptions.xml' path='doc/member[@name="IFullContactCardOptions.get_DesiredRemainingView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DesiredRemainingView([NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference *")] ViewSizePreference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullContactCardOptions*, ViewSizePreference*, int>)(lpVtbl[6]))((IFullContactCardOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFullContactCardOptions.xml' path='doc/member[@name="IFullContactCardOptions.put_DesiredRemainingView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DesiredRemainingView([NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")] ViewSizePreference value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullContactCardOptions*, ViewSizePreference, int>)(lpVtbl[7]))((IFullContactCardOptions*)Unsafe.AsPointer(ref this), value);
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
