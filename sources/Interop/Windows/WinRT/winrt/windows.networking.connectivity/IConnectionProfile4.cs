// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IConnectionProfile4.xml' path='doc/member[@name="IConnectionProfile4"]/*' />
[Guid("7A2D42CD-81E0-4AE6-ABED-AB9CA13EB714")]
[NativeTypeName("struct IConnectionProfile4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectionProfile4 : IConnectionProfile4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectionProfile4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile4*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionProfile4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile4*, uint>)(lpVtbl[1]))((IConnectionProfile4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile4*, uint>)(lpVtbl[2]))((IConnectionProfile4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile4*, uint*, Guid**, int>)(lpVtbl[3]))((IConnectionProfile4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile4*, HSTRING*, int>)(lpVtbl[4]))((IConnectionProfile4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile4*, TrustLevel*, int>)(lpVtbl[5]))((IConnectionProfile4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IConnectionProfile4.xml' path='doc/member[@name="IConnectionProfile4.GetProviderNetworkUsageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetProviderNetworkUsageAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime, [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")] NetworkUsageStates states, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CProviderNetworkUsage_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IProviderNetworkUsage>>>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile4*, WinRTDateTime, WinRTDateTime, NetworkUsageStates, IAsyncOperation<Pointer<IVectorView<Pointer<IProviderNetworkUsage>>>>**, int>)(lpVtbl[6]))((IConnectionProfile4*)Unsafe.AsPointer(ref this), startTime, endTime, states, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetProviderNetworkUsageAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime, [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")] NetworkUsageStates states, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CProviderNetworkUsage_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IProviderNetworkUsage>>>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::DateTime, ABI::Windows::Networking::Connectivity::NetworkUsageStates, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CProviderNetworkUsage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, WinRTDateTime, NetworkUsageStates, IAsyncOperation<Pointer<IVectorView<Pointer<IProviderNetworkUsage>>>>**, int> GetProviderNetworkUsageAsync;
    }
}
