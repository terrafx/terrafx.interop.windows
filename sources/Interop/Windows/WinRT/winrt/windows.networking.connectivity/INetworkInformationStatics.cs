// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='INetworkInformationStatics.xml' path='doc/member[@name="INetworkInformationStatics"]/*' />
[Guid("5074F851-950D-4165-9C15-365619481EEA")]
[NativeTypeName("struct INetworkInformationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INetworkInformationStatics : INetworkInformationStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_INetworkInformationStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, Guid*, void**, int>)(lpVtbl[0]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, uint>)(lpVtbl[1]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, uint>)(lpVtbl[2]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, uint*, Guid**, int>)(lpVtbl[3]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, HSTRING*, int>)(lpVtbl[4]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, TrustLevel*, int>)(lpVtbl[5]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='INetworkInformationStatics.xml' path='doc/member[@name="INetworkInformationStatics.GetConnectionProfiles"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetConnectionProfiles([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CConnectivity__CConnectionProfile_t **")] IVectorView<Pointer<IConnectionProfile>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, IVectorView<Pointer<IConnectionProfile>>**, int>)(lpVtbl[6]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkInformationStatics.xml' path='doc/member[@name="INetworkInformationStatics.GetInternetConnectionProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetInternetConnectionProfile([NativeTypeName("ABI::Windows::Networking::Connectivity::IConnectionProfile **")] IConnectionProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, IConnectionProfile**, int>)(lpVtbl[7]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkInformationStatics.xml' path='doc/member[@name="INetworkInformationStatics.GetLanIdentifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetLanIdentifiers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CConnectivity__CLanIdentifier_t **")] IVectorView<Pointer<ILanIdentifier>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, IVectorView<Pointer<ILanIdentifier>>**, int>)(lpVtbl[8]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkInformationStatics.xml' path='doc/member[@name="INetworkInformationStatics.GetHostNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetHostNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CHostName_t **")] IVectorView<Pointer<IHostName>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, IVectorView<Pointer<IHostName>>**, int>)(lpVtbl[9]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkInformationStatics.xml' path='doc/member[@name="INetworkInformationStatics.GetProxyConfigurationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetProxyConfigurationAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CProxyConfiguration_t **")] IAsyncOperation<Pointer<IProxyConfiguration>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, IUriRuntimeClass*, IAsyncOperation<Pointer<IProxyConfiguration>>**, int>)(lpVtbl[10]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this), uri, value);
    }

    /// <include file='INetworkInformationStatics.xml' path='doc/member[@name="INetworkInformationStatics.GetSortedEndpointPairs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSortedEndpointPairs([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CEndpointPair_t *")] IIterable<Pointer<IEndpointPair>>* destinationList, [NativeTypeName("ABI::Windows::Networking::HostNameSortOptions")] HostNameSortOptions sortOptions, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CEndpointPair_t **")] IVectorView<Pointer<IEndpointPair>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, IIterable<Pointer<IEndpointPair>>*, HostNameSortOptions, IVectorView<Pointer<IEndpointPair>>**, int>)(lpVtbl[11]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this), destinationList, sortOptions, value);
    }

    /// <include file='INetworkInformationStatics.xml' path='doc/member[@name="INetworkInformationStatics.add_NetworkStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_NetworkStatusChanged([NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkStatusChangedEventHandler *")] INetworkStatusChangedEventHandler* networkStatusHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, INetworkStatusChangedEventHandler*, EventRegistrationToken*, int>)(lpVtbl[12]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this), networkStatusHandler, eventCookie);
    }

    /// <include file='INetworkInformationStatics.xml' path='doc/member[@name="INetworkInformationStatics.remove_NetworkStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_NetworkStatusChanged(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkInformationStatics*, EventRegistrationToken, int>)(lpVtbl[13]))((INetworkInformationStatics*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetConnectionProfiles([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CConnectivity__CConnectionProfile_t **")] IVectorView<Pointer<IConnectionProfile>>** value);

        [VtblIndex(7)]
        HRESULT GetInternetConnectionProfile([NativeTypeName("ABI::Windows::Networking::Connectivity::IConnectionProfile **")] IConnectionProfile** value);

        [VtblIndex(8)]
        HRESULT GetLanIdentifiers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CConnectivity__CLanIdentifier_t **")] IVectorView<Pointer<ILanIdentifier>>** value);

        [VtblIndex(9)]
        HRESULT GetHostNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CHostName_t **")] IVectorView<Pointer<IHostName>>** value);

        [VtblIndex(10)]
        HRESULT GetProxyConfigurationAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CProxyConfiguration_t **")] IAsyncOperation<Pointer<IProxyConfiguration>>** value);

        [VtblIndex(11)]
        HRESULT GetSortedEndpointPairs([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CEndpointPair_t *")] IIterable<Pointer<IEndpointPair>>* destinationList, [NativeTypeName("ABI::Windows::Networking::HostNameSortOptions")] HostNameSortOptions sortOptions, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CEndpointPair_t **")] IVectorView<Pointer<IEndpointPair>>** value);

        [VtblIndex(12)]
        HRESULT add_NetworkStatusChanged([NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkStatusChangedEventHandler *")] INetworkStatusChangedEventHandler* networkStatusHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(13)]
        HRESULT remove_NetworkStatusChanged(EventRegistrationToken eventCookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CConnectivity__CConnectionProfile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IConnectionProfile>>**, int> GetConnectionProfiles;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::IConnectionProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IConnectionProfile**, int> GetInternetConnectionProfile;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CConnectivity__CLanIdentifier_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<ILanIdentifier>>**, int> GetLanIdentifiers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CHostName_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IHostName>>**, int> GetHostNames;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CProxyConfiguration_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperation<Pointer<IProxyConfiguration>>**, int> GetProxyConfigurationAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CEndpointPair_t *, ABI::Windows::Networking::HostNameSortOptions, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CEndpointPair_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IEndpointPair>>*, HostNameSortOptions, IVectorView<Pointer<IEndpointPair>>**, int> GetSortedEndpointPairs;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::INetworkStatusChangedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, INetworkStatusChangedEventHandler*, EventRegistrationToken*, int> add_NetworkStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_NetworkStatusChanged;
    }
}
