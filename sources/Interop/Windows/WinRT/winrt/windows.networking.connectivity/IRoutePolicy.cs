// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRoutePolicy.xml' path='doc/member[@name="IRoutePolicy"]/*' />
[Guid("11ABC4AC-0FC7-42E4-8742-569923B1CA11")]
[NativeTypeName("struct IRoutePolicy : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRoutePolicy : IRoutePolicy.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRoutePolicy));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRoutePolicy*, Guid*, void**, int>)(lpVtbl[0]))((IRoutePolicy*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRoutePolicy*, uint>)(lpVtbl[1]))((IRoutePolicy*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRoutePolicy*, uint>)(lpVtbl[2]))((IRoutePolicy*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRoutePolicy*, uint*, Guid**, int>)(lpVtbl[3]))((IRoutePolicy*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRoutePolicy*, HSTRING*, int>)(lpVtbl[4]))((IRoutePolicy*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRoutePolicy*, TrustLevel*, int>)(lpVtbl[5]))((IRoutePolicy*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRoutePolicy.xml' path='doc/member[@name="IRoutePolicy.get_ConnectionProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ConnectionProfile([NativeTypeName("ABI::Windows::Networking::Connectivity::IConnectionProfile **")] IConnectionProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRoutePolicy*, IConnectionProfile**, int>)(lpVtbl[6]))((IRoutePolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRoutePolicy.xml' path='doc/member[@name="IRoutePolicy.get_HostName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_HostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRoutePolicy*, IHostName**, int>)(lpVtbl[7]))((IRoutePolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRoutePolicy.xml' path='doc/member[@name="IRoutePolicy.get_HostNameType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_HostNameType([NativeTypeName("ABI::Windows::Networking::DomainNameType *")] DomainNameType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRoutePolicy*, DomainNameType*, int>)(lpVtbl[8]))((IRoutePolicy*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ConnectionProfile([NativeTypeName("ABI::Windows::Networking::Connectivity::IConnectionProfile **")] IConnectionProfile** value);

        [VtblIndex(7)]
        HRESULT get_HostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);

        [VtblIndex(8)]
        HRESULT get_HostNameType([NativeTypeName("ABI::Windows::Networking::DomainNameType *")] DomainNameType* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::IConnectionProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IConnectionProfile**, int> get_ConnectionProfile;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_HostName;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::DomainNameType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DomainNameType*, int> get_HostNameType;
    }
}
