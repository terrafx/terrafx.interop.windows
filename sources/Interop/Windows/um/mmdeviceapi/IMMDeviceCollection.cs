// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0BD7A1BE-7A1A-44DB-8397-CC5392387B5E")]
    [NativeTypeName("struct IMMDeviceCollection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMMDeviceCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMMDeviceCollection*, Guid*, void**, int>)(lpVtbl[0]))((IMMDeviceCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMMDeviceCollection*, uint>)(lpVtbl[1]))((IMMDeviceCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMMDeviceCollection*, uint>)(lpVtbl[2]))((IMMDeviceCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcDevices)
        {
            return ((delegate* unmanaged<IMMDeviceCollection*, uint*, int>)(lpVtbl[3]))((IMMDeviceCollection*)Unsafe.AsPointer(ref this), pcDevices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Item([NativeTypeName("UINT")] uint nDevice, IMMDevice** ppDevice)
        {
            return ((delegate* unmanaged<IMMDeviceCollection*, uint, IMMDevice**, int>)(lpVtbl[4]))((IMMDeviceCollection*)Unsafe.AsPointer(ref this), nDevice, ppDevice);
        }
    }
}
