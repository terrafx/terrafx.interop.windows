// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='INetworkAdapter.xml' path='doc/member[@name="INetworkAdapter"]/*' />
[Guid("3B542E03-5388-496C-A8A3-AFFD39AEC2E6")]
[NativeTypeName("struct INetworkAdapter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INetworkAdapter : INetworkAdapter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INetworkAdapter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkAdapter*, Guid*, void**, int>)(lpVtbl[0]))((INetworkAdapter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkAdapter*, uint>)(lpVtbl[1]))((INetworkAdapter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkAdapter*, uint>)(lpVtbl[2]))((INetworkAdapter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkAdapter*, uint*, Guid**, int>)(lpVtbl[3]))((INetworkAdapter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkAdapter*, HSTRING*, int>)(lpVtbl[4]))((INetworkAdapter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkAdapter*, TrustLevel*, int>)(lpVtbl[5]))((INetworkAdapter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='INetworkAdapter.xml' path='doc/member[@name="INetworkAdapter.get_OutboundMaxBitsPerSecond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OutboundMaxBitsPerSecond([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkAdapter*, ulong*, int>)(lpVtbl[6]))((INetworkAdapter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkAdapter.xml' path='doc/member[@name="INetworkAdapter.get_InboundMaxBitsPerSecond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_InboundMaxBitsPerSecond([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkAdapter*, ulong*, int>)(lpVtbl[7]))((INetworkAdapter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkAdapter.xml' path='doc/member[@name="INetworkAdapter.get_IanaInterfaceType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IanaInterfaceType([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkAdapter*, uint*, int>)(lpVtbl[8]))((INetworkAdapter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkAdapter.xml' path='doc/member[@name="INetworkAdapter.get_NetworkItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_NetworkItem([NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkItem **")] INetworkItem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkAdapter*, INetworkItem**, int>)(lpVtbl[9]))((INetworkAdapter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkAdapter.xml' path='doc/member[@name="INetworkAdapter.get_NetworkAdapterId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_NetworkAdapterId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkAdapter*, Guid*, int>)(lpVtbl[10]))((INetworkAdapter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkAdapter.xml' path='doc/member[@name="INetworkAdapter.GetConnectedProfileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetConnectedProfileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CConnectionProfile_t **")] IAsyncOperation<Pointer<IConnectionProfile>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkAdapter*, IAsyncOperation<Pointer<IConnectionProfile>>**, int>)(lpVtbl[11]))((INetworkAdapter*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OutboundMaxBitsPerSecond([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT get_InboundMaxBitsPerSecond([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(8)]
        HRESULT get_IanaInterfaceType([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT get_NetworkItem([NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkItem **")] INetworkItem** value);

        [VtblIndex(10)]
        HRESULT get_NetworkAdapterId(Guid* value);

        [VtblIndex(11)]
        HRESULT GetConnectedProfileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CConnectionProfile_t **")] IAsyncOperation<Pointer<IConnectionProfile>>** value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_OutboundMaxBitsPerSecond;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_InboundMaxBitsPerSecond;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_IanaInterfaceType;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::INetworkItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, INetworkItem**, int> get_NetworkItem;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_NetworkAdapterId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CConnectionProfile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IConnectionProfile>>**, int> GetConnectedProfileAsync;
    }
}
