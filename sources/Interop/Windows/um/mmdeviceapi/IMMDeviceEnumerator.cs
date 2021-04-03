// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6")]
    [NativeTypeName("struct IMMDeviceEnumerator : IUnknown")]
    public unsafe partial struct IMMDeviceEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, uint>)(lpVtbl[1]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, uint>)(lpVtbl[2]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumAudioEndpoints(EDataFlow dataFlow, [NativeTypeName("DWORD")] uint dwStateMask, IMMDeviceCollection** ppDevices)
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, EDataFlow, uint, IMMDeviceCollection**, int>)(lpVtbl[3]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), dataFlow, dwStateMask, ppDevices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, IMMDevice** ppEndpoint)
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, EDataFlow, ERole, IMMDevice**, int>)(lpVtbl[4]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), dataFlow, role, ppEndpoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("LPCWSTR")] ushort* pwstrId, IMMDevice** ppDevice)
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, ushort*, IMMDevice**, int>)(lpVtbl[5]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), pwstrId, ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterEndpointNotificationCallback(IMMNotificationClient* pClient)
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, IMMNotificationClient*, int>)(lpVtbl[6]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), pClient);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterEndpointNotificationCallback(IMMNotificationClient* pClient)
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, IMMNotificationClient*, int>)(lpVtbl[7]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), pClient);
        }
    }
}
