// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IConnectionProfile3.xml' path='doc/member[@name="IConnectionProfile3"]/*' />
[Guid("578C2528-4CD9-4161-8045-201CFD5B115C")]
[NativeTypeName("struct IConnectionProfile3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectionProfile3 : IConnectionProfile3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IConnectionProfile3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile3*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionProfile3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile3*, uint>)(lpVtbl[1]))((IConnectionProfile3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile3*, uint>)(lpVtbl[2]))((IConnectionProfile3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile3*, uint*, Guid**, int>)(lpVtbl[3]))((IConnectionProfile3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile3*, HSTRING*, int>)(lpVtbl[4]))((IConnectionProfile3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile3*, TrustLevel*, int>)(lpVtbl[5]))((IConnectionProfile3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IConnectionProfile3.xml' path='doc/member[@name="IConnectionProfile3.GetAttributedNetworkUsageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAttributedNetworkUsageAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime, [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")] NetworkUsageStates states, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CAttributedNetworkUsage_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAttributedNetworkUsage>>>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfile3*, WinRTDateTime, WinRTDateTime, NetworkUsageStates, IAsyncOperation<Pointer<IVectorView<Pointer<IAttributedNetworkUsage>>>>**, int>)(lpVtbl[6]))((IConnectionProfile3*)Unsafe.AsPointer(ref this), startTime, endTime, states, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAttributedNetworkUsageAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime, [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")] NetworkUsageStates states, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CAttributedNetworkUsage_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAttributedNetworkUsage>>>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::DateTime, ABI::Windows::Networking::Connectivity::NetworkUsageStates, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CAttributedNetworkUsage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, WinRTDateTime, NetworkUsageStates, IAsyncOperation<Pointer<IVectorView<Pointer<IAttributedNetworkUsage>>>>**, int> GetAttributedNetworkUsageAsync;
    }
}
