// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6")]
    [NativeTypeName("struct IMMDeviceEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMMDeviceEnumerator : IMMDeviceEnumerator.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, uint>)(lpVtbl[1]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, uint>)(lpVtbl[2]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT EnumAudioEndpoints(EDataFlow dataFlow, [NativeTypeName("DWORD")] uint dwStateMask, IMMDeviceCollection** ppDevices)
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, EDataFlow, uint, IMMDeviceCollection**, int>)(lpVtbl[3]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), dataFlow, dwStateMask, ppDevices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, IMMDevice** ppEndpoint)
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, EDataFlow, ERole, IMMDevice**, int>)(lpVtbl[4]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), dataFlow, role, ppEndpoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetDevice([NativeTypeName("LPCWSTR")] ushort* pwstrId, IMMDevice** ppDevice)
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, ushort*, IMMDevice**, int>)(lpVtbl[5]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), pwstrId, ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RegisterEndpointNotificationCallback(IMMNotificationClient* pClient)
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, IMMNotificationClient*, int>)(lpVtbl[6]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), pClient);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT UnregisterEndpointNotificationCallback(IMMNotificationClient* pClient)
        {
            return ((delegate* unmanaged<IMMDeviceEnumerator*, IMMNotificationClient*, int>)(lpVtbl[7]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), pClient);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT EnumAudioEndpoints(EDataFlow dataFlow, [NativeTypeName("DWORD")] uint dwStateMask, IMMDeviceCollection** ppDevices);

            [VtblIndex(4)]
            HRESULT GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, IMMDevice** ppEndpoint);

            [VtblIndex(5)]
            HRESULT GetDevice([NativeTypeName("LPCWSTR")] ushort* pwstrId, IMMDevice** ppDevice);

            [VtblIndex(6)]
            HRESULT RegisterEndpointNotificationCallback(IMMNotificationClient* pClient);

            [VtblIndex(7)]
            HRESULT UnregisterEndpointNotificationCallback(IMMNotificationClient* pClient);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDeviceEnumerator*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDeviceEnumerator*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDeviceEnumerator*, uint> Release;

            [NativeTypeName("HRESULT (EDataFlow, DWORD, IMMDeviceCollection **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDeviceEnumerator*, EDataFlow, uint, IMMDeviceCollection**, int> EnumAudioEndpoints;

            [NativeTypeName("HRESULT (EDataFlow, ERole, IMMDevice **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDeviceEnumerator*, EDataFlow, ERole, IMMDevice**, int> GetDefaultAudioEndpoint;

            [NativeTypeName("HRESULT (LPCWSTR, IMMDevice **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDeviceEnumerator*, ushort*, IMMDevice**, int> GetDevice;

            [NativeTypeName("HRESULT (IMMNotificationClient *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDeviceEnumerator*, IMMNotificationClient*, int> RegisterEndpointNotificationCallback;

            [NativeTypeName("HRESULT (IMMNotificationClient *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDeviceEnumerator*, IMMNotificationClient*, int> UnregisterEndpointNotificationCallback;
        }
    }
}
