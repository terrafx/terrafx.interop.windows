// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6")]
    public unsafe partial struct IMMDeviceEnumerator
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMMDeviceEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMMDeviceEnumerator*, uint>)(lpVtbl[1]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMMDeviceEnumerator*, uint>)(lpVtbl[2]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAudioEndpoints(EDataFlow dataFlow, [NativeTypeName("DWORD")] uint dwStateMask, [NativeTypeName("IMMDeviceCollection **")] IMMDeviceCollection** ppDevices)
        {
            return ((delegate* stdcall<IMMDeviceEnumerator*, EDataFlow, uint, IMMDeviceCollection**, int>)(lpVtbl[3]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), dataFlow, dwStateMask, ppDevices);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, [NativeTypeName("IMMDevice **")] IMMDevice** ppEndpoint)
        {
            return ((delegate* stdcall<IMMDeviceEnumerator*, EDataFlow, ERole, IMMDevice**, int>)(lpVtbl[4]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), dataFlow, role, ppEndpoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("LPCWSTR")] ushort* pwstrId, [NativeTypeName("IMMDevice **")] IMMDevice** ppDevice)
        {
            return ((delegate* stdcall<IMMDeviceEnumerator*, ushort*, IMMDevice**, int>)(lpVtbl[5]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), pwstrId, ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterEndpointNotificationCallback([NativeTypeName("IMMNotificationClient *")] IMMNotificationClient* pClient)
        {
            return ((delegate* stdcall<IMMDeviceEnumerator*, IMMNotificationClient*, int>)(lpVtbl[6]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), pClient);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterEndpointNotificationCallback([NativeTypeName("IMMNotificationClient *")] IMMNotificationClient* pClient)
        {
            return ((delegate* stdcall<IMMDeviceEnumerator*, IMMNotificationClient*, int>)(lpVtbl[7]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), pClient);
        }
    }
}
