// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IConnector.xml' path='doc/member[@name="IConnector"]/*' />
[Guid("9C2C4058-23F5-41DE-877A-DF3AF236A09E")]
[NativeTypeName("struct IConnector : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IConnector : IConnector.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnector));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnector*, Guid*, void**, int>)(lpVtbl[0]))((IConnector*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnector*, uint>)(lpVtbl[1]))((IConnector*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnector*, uint>)(lpVtbl[2]))((IConnector*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IConnector.xml' path='doc/member[@name="IConnector.GetType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetType(ConnectorType* pType)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnector*, ConnectorType*, int>)(lpVtbl[3]))((IConnector*)Unsafe.AsPointer(ref this), pType);
    }

    /// <include file='IConnector.xml' path='doc/member[@name="IConnector.GetDataFlow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDataFlow(DataFlow* pFlow)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnector*, DataFlow*, int>)(lpVtbl[4]))((IConnector*)Unsafe.AsPointer(ref this), pFlow);
    }

    /// <include file='IConnector.xml' path='doc/member[@name="IConnector.ConnectTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ConnectTo(IConnector* pConnectTo)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnector*, IConnector*, int>)(lpVtbl[5]))((IConnector*)Unsafe.AsPointer(ref this), pConnectTo);
    }

    /// <include file='IConnector.xml' path='doc/member[@name="IConnector.Disconnect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Disconnect()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnector*, int>)(lpVtbl[6]))((IConnector*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IConnector.xml' path='doc/member[@name="IConnector.IsConnected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsConnected(BOOL* pbConnected)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnector*, BOOL*, int>)(lpVtbl[7]))((IConnector*)Unsafe.AsPointer(ref this), pbConnected);
    }

    /// <include file='IConnector.xml' path='doc/member[@name="IConnector.GetConnectedTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetConnectedTo(IConnector** ppConTo)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnector*, IConnector**, int>)(lpVtbl[8]))((IConnector*)Unsafe.AsPointer(ref this), ppConTo);
    }

    /// <include file='IConnector.xml' path='doc/member[@name="IConnector.GetConnectorIdConnectedTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetConnectorIdConnectedTo([NativeTypeName("LPWSTR *")] char** ppwstrConnectorId)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnector*, char**, int>)(lpVtbl[9]))((IConnector*)Unsafe.AsPointer(ref this), ppwstrConnectorId);
    }

    /// <include file='IConnector.xml' path='doc/member[@name="IConnector.GetDeviceIdConnectedTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeviceIdConnectedTo([NativeTypeName("LPWSTR *")] char** ppwstrDeviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnector*, char**, int>)(lpVtbl[10]))((IConnector*)Unsafe.AsPointer(ref this), ppwstrDeviceId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetType(ConnectorType* pType);

        [VtblIndex(4)]
        HRESULT GetDataFlow(DataFlow* pFlow);

        [VtblIndex(5)]
        HRESULT ConnectTo(IConnector* pConnectTo);

        [VtblIndex(6)]
        HRESULT Disconnect();

        [VtblIndex(7)]
        HRESULT IsConnected(BOOL* pbConnected);

        [VtblIndex(8)]
        HRESULT GetConnectedTo(IConnector** ppConTo);

        [VtblIndex(9)]
        HRESULT GetConnectorIdConnectedTo([NativeTypeName("LPWSTR *")] char** ppwstrConnectorId);

        [VtblIndex(10)]
        HRESULT GetDeviceIdConnectedTo([NativeTypeName("LPWSTR *")] char** ppwstrDeviceId);
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

        [NativeTypeName("HRESULT (ConnectorType *) __attribute__((stdcall))")]
        public new delegate* unmanaged[MemberFunction]<TSelf*, ConnectorType*, int> GetType;

        [NativeTypeName("HRESULT (DataFlow *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DataFlow*, int> GetDataFlow;

        [NativeTypeName("HRESULT (IConnector *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IConnector*, int> ConnectTo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Disconnect;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> IsConnected;

        [NativeTypeName("HRESULT (IConnector **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IConnector**, int> GetConnectedTo;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetConnectorIdConnectedTo;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetDeviceIdConnectedTo;
    }
}
