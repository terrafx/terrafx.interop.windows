// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactVideoCallActivatedEventArgs.xml' path='doc/member[@name="IContactVideoCallActivatedEventArgs"]/*' />
[Guid("61079DB8-E3E7-4B4F-858D-5C63A96EF684")]
[NativeTypeName("struct IContactVideoCallActivatedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactVideoCallActivatedEventArgs : IContactVideoCallActivatedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactVideoCallActivatedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactVideoCallActivatedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IContactVideoCallActivatedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactVideoCallActivatedEventArgs*, uint>)(lpVtbl[1]))((IContactVideoCallActivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactVideoCallActivatedEventArgs*, uint>)(lpVtbl[2]))((IContactVideoCallActivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactVideoCallActivatedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IContactVideoCallActivatedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactVideoCallActivatedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IContactVideoCallActivatedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactVideoCallActivatedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IContactVideoCallActivatedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactVideoCallActivatedEventArgs.xml' path='doc/member[@name="IContactVideoCallActivatedEventArgs.get_ServiceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ServiceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactVideoCallActivatedEventArgs*, HSTRING*, int>)(lpVtbl[6]))((IContactVideoCallActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactVideoCallActivatedEventArgs.xml' path='doc/member[@name="IContactVideoCallActivatedEventArgs.get_ServiceUserId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ServiceUserId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactVideoCallActivatedEventArgs*, HSTRING*, int>)(lpVtbl[7]))((IContactVideoCallActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactVideoCallActivatedEventArgs.xml' path='doc/member[@name="IContactVideoCallActivatedEventArgs.get_Contact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Contact([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact **")] IContact** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactVideoCallActivatedEventArgs*, IContact**, int>)(lpVtbl[8]))((IContactVideoCallActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ServiceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ServiceUserId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Contact([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact **")] IContact** value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ServiceId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ServiceUserId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact**, int> get_Contact;
    }
}
