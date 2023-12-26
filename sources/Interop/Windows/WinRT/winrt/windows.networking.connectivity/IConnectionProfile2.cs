// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IConnectionProfile2.xml' path='doc/member[@name="IConnectionProfile2"]/*' />
[Guid("E2045145-4C9F-400C-9150-7EC7D6E2888A")]
[NativeTypeName("struct IConnectionProfile2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectionProfile2 : IConnectionProfile2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectionProfile2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, uint>)(lpVtbl[1]))((IConnectionProfile2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, uint>)(lpVtbl[2]))((IConnectionProfile2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, uint*, Guid**, int>)(lpVtbl[3]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, HSTRING*, int>)(lpVtbl[4]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, TrustLevel*, int>)(lpVtbl[5]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IConnectionProfile2.xml' path='doc/member[@name="IConnectionProfile2.get_IsWwanConnectionProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsWwanConnectionProfile([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, byte*, int>)(lpVtbl[6]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfile2.xml' path='doc/member[@name="IConnectionProfile2.get_IsWlanConnectionProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsWlanConnectionProfile([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, byte*, int>)(lpVtbl[7]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfile2.xml' path='doc/member[@name="IConnectionProfile2.get_WwanConnectionProfileDetails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_WwanConnectionProfileDetails([NativeTypeName("ABI::Windows::Networking::Connectivity::IWwanConnectionProfileDetails **")] IWwanConnectionProfileDetails** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, IWwanConnectionProfileDetails**, int>)(lpVtbl[8]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfile2.xml' path='doc/member[@name="IConnectionProfile2.get_WlanConnectionProfileDetails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_WlanConnectionProfileDetails([NativeTypeName("ABI::Windows::Networking::Connectivity::IWlanConnectionProfileDetails **")] IWlanConnectionProfileDetails** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, IWlanConnectionProfileDetails**, int>)(lpVtbl[9]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfile2.xml' path='doc/member[@name="IConnectionProfile2.get_ServiceProviderGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ServiceProviderGuid([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t **")] IReference<Guid>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, IReference<Guid>**, int>)(lpVtbl[10]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfile2.xml' path='doc/member[@name="IConnectionProfile2.GetSignalBars"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSignalBars([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_byte_t **")] IReference<byte>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, IReference<byte>**, int>)(lpVtbl[11]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfile2.xml' path='doc/member[@name="IConnectionProfile2.GetDomainConnectivityLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetDomainConnectivityLevel([NativeTypeName("ABI::Windows::Networking::Connectivity::DomainConnectivityLevel *")] DomainConnectivityLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, DomainConnectivityLevel*, int>)(lpVtbl[12]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfile2.xml' path='doc/member[@name="IConnectionProfile2.GetNetworkUsageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetNetworkUsageAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime, [NativeTypeName("ABI::Windows::Networking::Connectivity::DataUsageGranularity")] DataUsageGranularity granularity, [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")] NetworkUsageStates states, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CNetworkUsage_t **")] IAsyncOperation<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, WinRTDateTime, WinRTDateTime, DataUsageGranularity, NetworkUsageStates, IAsyncOperation<IntPtr>**, int>)(lpVtbl[13]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), startTime, endTime, granularity, states, value);
    }

    /// <include file='IConnectionProfile2.xml' path='doc/member[@name="IConnectionProfile2.GetConnectivityIntervalsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetConnectivityIntervalsAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime, [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")] NetworkUsageStates states, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CConnectivityInterval_t **")] IAsyncOperation<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile2*, WinRTDateTime, WinRTDateTime, NetworkUsageStates, IAsyncOperation<IntPtr>**, int>)(lpVtbl[14]))((IConnectionProfile2*)Unsafe.AsPointer(ref this), startTime, endTime, states, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsWwanConnectionProfile([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_IsWlanConnectionProfile([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_WwanConnectionProfileDetails([NativeTypeName("ABI::Windows::Networking::Connectivity::IWwanConnectionProfileDetails **")] IWwanConnectionProfileDetails** value);

        [VtblIndex(9)]
        HRESULT get_WlanConnectionProfileDetails([NativeTypeName("ABI::Windows::Networking::Connectivity::IWlanConnectionProfileDetails **")] IWlanConnectionProfileDetails** value);

        [VtblIndex(10)]
        HRESULT get_ServiceProviderGuid([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t **")] IReference<Guid>** value);

        [VtblIndex(11)]
        HRESULT GetSignalBars([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_byte_t **")] IReference<byte>** value);

        [VtblIndex(12)]
        HRESULT GetDomainConnectivityLevel([NativeTypeName("ABI::Windows::Networking::Connectivity::DomainConnectivityLevel *")] DomainConnectivityLevel* value);

        [VtblIndex(13)]
        HRESULT GetNetworkUsageAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime, [NativeTypeName("ABI::Windows::Networking::Connectivity::DataUsageGranularity")] DataUsageGranularity granularity, [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")] NetworkUsageStates states, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CNetworkUsage_t **")] IAsyncOperation<IntPtr>** value);

        [VtblIndex(14)]
        HRESULT GetConnectivityIntervalsAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime, [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")] NetworkUsageStates states, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CConnectivityInterval_t **")] IAsyncOperation<IntPtr>** value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsWwanConnectionProfile;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsWlanConnectionProfile;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::IWwanConnectionProfileDetails **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWwanConnectionProfileDetails**, int> get_WwanConnectionProfileDetails;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::IWlanConnectionProfileDetails **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWlanConnectionProfileDetails**, int> get_WlanConnectionProfileDetails;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_GUID_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Guid>**, int> get_ServiceProviderGuid;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_byte_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<byte>**, int> GetSignalBars;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::DomainConnectivityLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DomainConnectivityLevel*, int> GetDomainConnectivityLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::DateTime, ABI::Windows::Networking::Connectivity::DataUsageGranularity, ABI::Windows::Networking::Connectivity::NetworkUsageStates, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CNetworkUsage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, WinRTDateTime, DataUsageGranularity, NetworkUsageStates, IAsyncOperation<IntPtr>**, int> GetNetworkUsageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::DateTime, ABI::Windows::Networking::Connectivity::NetworkUsageStates, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CConnectivityInterval_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, WinRTDateTime, NetworkUsageStates, IAsyncOperation<IntPtr>**, int> GetConnectivityIntervalsAsync;
    }
}
