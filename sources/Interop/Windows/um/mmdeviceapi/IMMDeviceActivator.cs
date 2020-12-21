// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3B0D0EA4-D0A9-4B0E-935B-09516746FAC0")]
    [NativeTypeName("struct IMMDeviceActivator : IUnknown")]
    public unsafe partial struct IMMDeviceActivator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMMDeviceActivator*, Guid*, void**, int>)(lpVtbl[0]))((IMMDeviceActivator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMMDeviceActivator*, uint>)(lpVtbl[1]))((IMMDeviceActivator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMMDeviceActivator*, uint>)(lpVtbl[2]))((IMMDeviceActivator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("IMMDevice *")] IMMDevice* pDevice, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pActivationParams, [NativeTypeName("void **")] void** ppInterface)
        {
            return ((delegate* unmanaged[Stdcall]<IMMDeviceActivator*, Guid*, IMMDevice*, PROPVARIANT*, void**, int>)(lpVtbl[3]))((IMMDeviceActivator*)Unsafe.AsPointer(ref this), iid, pDevice, pActivationParams, ppInterface);
        }
    }
}
