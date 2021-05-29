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
    public unsafe partial struct IConnector
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IConnector*, Guid*, void**, int>)(lpVtbl[0]))((IConnector*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IConnector*, uint>)(lpVtbl[1]))((IConnector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IConnector*, uint>)(lpVtbl[2]))((IConnector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetType(ConnectorType* pType)
        {
            return ((delegate* unmanaged<IConnector*, ConnectorType*, int>)(lpVtbl[3]))((IConnector*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDataFlow(DataFlow* pFlow)
        {
            return ((delegate* unmanaged<IConnector*, DataFlow*, int>)(lpVtbl[4]))((IConnector*)Unsafe.AsPointer(ref this), pFlow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConnectTo(IConnector* pConnectTo)
        {
            return ((delegate* unmanaged<IConnector*, IConnector*, int>)(lpVtbl[5]))((IConnector*)Unsafe.AsPointer(ref this), pConnectTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Disconnect()
        {
            return ((delegate* unmanaged<IConnector*, int>)(lpVtbl[6]))((IConnector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsConnected([NativeTypeName("BOOL *")] int* pbConnected)
        {
            return ((delegate* unmanaged<IConnector*, int*, int>)(lpVtbl[7]))((IConnector*)Unsafe.AsPointer(ref this), pbConnected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConnectedTo(IConnector** ppConTo)
        {
            return ((delegate* unmanaged<IConnector*, IConnector**, int>)(lpVtbl[8]))((IConnector*)Unsafe.AsPointer(ref this), ppConTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConnectorIdConnectedTo([NativeTypeName("LPWSTR *")] ushort** ppwstrConnectorId)
        {
            return ((delegate* unmanaged<IConnector*, ushort**, int>)(lpVtbl[9]))((IConnector*)Unsafe.AsPointer(ref this), ppwstrConnectorId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceIdConnectedTo([NativeTypeName("LPWSTR *")] ushort** ppwstrDeviceId)
        {
            return ((delegate* unmanaged<IConnector*, ushort**, int>)(lpVtbl[10]))((IConnector*)Unsafe.AsPointer(ref this), ppwstrDeviceId);
        }
    }
}
