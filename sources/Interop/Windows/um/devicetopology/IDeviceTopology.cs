// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2A07407E-6497-4A18-9787-32F79BD0D98F")]
    [NativeTypeName("struct IDeviceTopology : IUnknown")]
    public unsafe partial struct IDeviceTopology
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDeviceTopology*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceTopology*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint>)(lpVtbl[1]))((IDeviceTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint>)(lpVtbl[2]))((IDeviceTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConnectorCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint*, int>)(lpVtbl[3]))((IDeviceTopology*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConnector([NativeTypeName("UINT")] uint nIndex, IConnector** ppConnector)
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint, IConnector**, int>)(lpVtbl[4]))((IDeviceTopology*)Unsafe.AsPointer(ref this), nIndex, ppConnector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubunitCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint*, int>)(lpVtbl[5]))((IDeviceTopology*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubunit([NativeTypeName("UINT")] uint nIndex, ISubunit** ppSubunit)
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint, ISubunit**, int>)(lpVtbl[6]))((IDeviceTopology*)Unsafe.AsPointer(ref this), nIndex, ppSubunit);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPartById([NativeTypeName("UINT")] uint nId, IPart** ppPart)
        {
            return ((delegate* unmanaged<IDeviceTopology*, uint, IPart**, int>)(lpVtbl[7]))((IDeviceTopology*)Unsafe.AsPointer(ref this), nId, ppPart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceId([NativeTypeName("LPWSTR *")] ushort** ppwstrDeviceId)
        {
            return ((delegate* unmanaged<IDeviceTopology*, ushort**, int>)(lpVtbl[8]))((IDeviceTopology*)Unsafe.AsPointer(ref this), ppwstrDeviceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSignalPath(IPart* pIPartFrom, IPart* pIPartTo, [NativeTypeName("BOOL")] int bRejectMixedPaths, IPartsList** ppParts)
        {
            return ((delegate* unmanaged<IDeviceTopology*, IPart*, IPart*, int, IPartsList**, int>)(lpVtbl[9]))((IDeviceTopology*)Unsafe.AsPointer(ref this), pIPartFrom, pIPartTo, bRejectMixedPaths, ppParts);
        }
    }
}
