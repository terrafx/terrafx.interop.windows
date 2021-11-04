// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9C2C4058-23F5-41DE-877A-DF3AF236A09E")]
    [NativeTypeName("struct IConnector : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IConnector
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IConnector*, Guid*, void**, int>)(lpVtbl[0]))((IConnector*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IConnector*, uint>)(lpVtbl[1]))((IConnector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IConnector*, uint>)(lpVtbl[2]))((IConnector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetType(ConnectorType* pType)
        {
            return ((delegate* unmanaged<IConnector*, ConnectorType*, int>)(lpVtbl[3]))((IConnector*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetDataFlow(DataFlow* pFlow)
        {
            return ((delegate* unmanaged<IConnector*, DataFlow*, int>)(lpVtbl[4]))((IConnector*)Unsafe.AsPointer(ref this), pFlow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ConnectTo(IConnector* pConnectTo)
        {
            return ((delegate* unmanaged<IConnector*, IConnector*, int>)(lpVtbl[5]))((IConnector*)Unsafe.AsPointer(ref this), pConnectTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Disconnect()
        {
            return ((delegate* unmanaged<IConnector*, int>)(lpVtbl[6]))((IConnector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsConnected(BOOL* pbConnected)
        {
            return ((delegate* unmanaged<IConnector*, BOOL*, int>)(lpVtbl[7]))((IConnector*)Unsafe.AsPointer(ref this), pbConnected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetConnectedTo(IConnector** ppConTo)
        {
            return ((delegate* unmanaged<IConnector*, IConnector**, int>)(lpVtbl[8]))((IConnector*)Unsafe.AsPointer(ref this), ppConTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetConnectorIdConnectedTo([NativeTypeName("LPWSTR *")] ushort** ppwstrConnectorId)
        {
            return ((delegate* unmanaged<IConnector*, ushort**, int>)(lpVtbl[9]))((IConnector*)Unsafe.AsPointer(ref this), ppwstrConnectorId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetDeviceIdConnectedTo([NativeTypeName("LPWSTR *")] ushort** ppwstrDeviceId)
        {
            return ((delegate* unmanaged<IConnector*, ushort**, int>)(lpVtbl[10]))((IConnector*)Unsafe.AsPointer(ref this), ppwstrDeviceId);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnector*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IConnector*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IConnector*, uint> Release;

            [NativeTypeName("HRESULT (ConnectorType *) __attribute__((stdcall))")]
            public new delegate* unmanaged<IConnector*, ConnectorType*, int> GetType;

            [NativeTypeName("HRESULT (DataFlow *) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnector*, DataFlow*, int> GetDataFlow;

            [NativeTypeName("HRESULT (IConnector *) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnector*, IConnector*, int> ConnectTo;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IConnector*, int> Disconnect;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnector*, BOOL*, int> IsConnected;

            [NativeTypeName("HRESULT (IConnector **) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnector*, IConnector**, int> GetConnectedTo;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnector*, ushort**, int> GetConnectorIdConnectedTo;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnector*, ushort**, int> GetDeviceIdConnectedTo;
        }
    }
}
