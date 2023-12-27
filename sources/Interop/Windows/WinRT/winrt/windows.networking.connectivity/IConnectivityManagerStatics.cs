// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IConnectivityManagerStatics.xml' path='doc/member[@name="IConnectivityManagerStatics"]/*' />
[Guid("5120D4B1-4FB1-48B0-AFC9-42E0092A8164")]
[NativeTypeName("struct IConnectivityManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectivityManagerStatics : IConnectivityManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectivityManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IConnectivityManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityManagerStatics*, uint>)(lpVtbl[1]))((IConnectivityManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityManagerStatics*, uint>)(lpVtbl[2]))((IConnectivityManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IConnectivityManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IConnectivityManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IConnectivityManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IConnectivityManagerStatics.xml' path='doc/member[@name="IConnectivityManagerStatics.AcquireConnectionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AcquireConnectionAsync([NativeTypeName("ABI::Windows::Networking::Connectivity::ICellularApnContext *")] ICellularApnContext* cellularApnContext, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CConnectionSession_t **")] IAsyncOperation<Pointer<IConnectionSession>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityManagerStatics*, ICellularApnContext*, IAsyncOperation<Pointer<IConnectionSession>>**, int>)(lpVtbl[6]))((IConnectivityManagerStatics*)Unsafe.AsPointer(ref this), cellularApnContext, operation);
    }

    /// <include file='IConnectivityManagerStatics.xml' path='doc/member[@name="IConnectivityManagerStatics.AddHttpRoutePolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddHttpRoutePolicy([NativeTypeName("ABI::Windows::Networking::Connectivity::IRoutePolicy *")] IRoutePolicy* routePolicy)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityManagerStatics*, IRoutePolicy*, int>)(lpVtbl[7]))((IConnectivityManagerStatics*)Unsafe.AsPointer(ref this), routePolicy);
    }

    /// <include file='IConnectivityManagerStatics.xml' path='doc/member[@name="IConnectivityManagerStatics.RemoveHttpRoutePolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveHttpRoutePolicy([NativeTypeName("ABI::Windows::Networking::Connectivity::IRoutePolicy *")] IRoutePolicy* routePolicy)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityManagerStatics*, IRoutePolicy*, int>)(lpVtbl[8]))((IConnectivityManagerStatics*)Unsafe.AsPointer(ref this), routePolicy);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AcquireConnectionAsync([NativeTypeName("ABI::Windows::Networking::Connectivity::ICellularApnContext *")] ICellularApnContext* cellularApnContext, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CConnectionSession_t **")] IAsyncOperation<Pointer<IConnectionSession>>** operation);

        [VtblIndex(7)]
        HRESULT AddHttpRoutePolicy([NativeTypeName("ABI::Windows::Networking::Connectivity::IRoutePolicy *")] IRoutePolicy* routePolicy);

        [VtblIndex(8)]
        HRESULT RemoveHttpRoutePolicy([NativeTypeName("ABI::Windows::Networking::Connectivity::IRoutePolicy *")] IRoutePolicy* routePolicy);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::ICellularApnContext *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CConnectionSession_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICellularApnContext*, IAsyncOperation<Pointer<IConnectionSession>>**, int> AcquireConnectionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::IRoutePolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRoutePolicy*, int> AddHttpRoutePolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::IRoutePolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRoutePolicy*, int> RemoveHttpRoutePolicy;
    }
}
