// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2A07407E-6497-4A18-9787-32F79BD0D98F")]
    [NativeTypeName("struct IDeviceTopology : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDeviceTopology
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDeviceTopology*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceTopology*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint>)(lpVtbl[1]))((IDeviceTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint>)(lpVtbl[2]))((IDeviceTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetConnectorCount(uint* pCount)
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint*, int>)(lpVtbl[3]))((IDeviceTopology*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetConnector(uint nIndex, IConnector** ppConnector)
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint, IConnector**, int>)(lpVtbl[4]))((IDeviceTopology*)Unsafe.AsPointer(ref this), nIndex, ppConnector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetSubunitCount(uint* pCount)
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint*, int>)(lpVtbl[5]))((IDeviceTopology*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetSubunit(uint nIndex, ISubunit** ppSubunit)
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint, ISubunit**, int>)(lpVtbl[6]))((IDeviceTopology*)Unsafe.AsPointer(ref this), nIndex, ppSubunit);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetPartById(uint nId, IPart** ppPart)
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint, IPart**, int>)(lpVtbl[7]))((IDeviceTopology*)Unsafe.AsPointer(ref this), nId, ppPart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetDeviceId([NativeTypeName("LPWSTR *")] ushort** ppwstrDeviceId)
        {
            return ((delegate* unmanaged<IDeviceTopology*, ushort**, int>)(lpVtbl[8]))((IDeviceTopology*)Unsafe.AsPointer(ref this), ppwstrDeviceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetSignalPath(IPart* pIPartFrom, IPart* pIPartTo, BOOL bRejectMixedPaths, IPartsList** ppParts)
        {
            return ((delegate* unmanaged<IDeviceTopology*, IPart*, IPart*, BOOL, IPartsList**, int>)(lpVtbl[9]))((IDeviceTopology*)Unsafe.AsPointer(ref this), pIPartFrom, pIPartTo, bRejectMixedPaths, ppParts);
        }
    }
}
