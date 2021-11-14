// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/swdevice.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [SupportedOSPlatform("windows8.0")]
        [DllImport("cfgmgr32", ExactSpelling = true)]
        public static extern HRESULT SwDeviceCreate([NativeTypeName("PCWSTR")] ushort* pszEnumeratorName, [NativeTypeName("PCWSTR")] ushort* pszParentDeviceInstance, [NativeTypeName("const SW_DEVICE_CREATE_INFO *")] SW_DEVICE_CREATE_INFO* pCreateInfo, [NativeTypeName("ULONG")] uint cPropertyCount, [NativeTypeName("const DEVPROPERTY *")] DEVPROPERTY* pProperties, [NativeTypeName("SW_DEVICE_CREATE_CALLBACK")] delegate* unmanaged<HSWDEVICE, HRESULT, void*, ushort*, void> pCallback, [NativeTypeName("PVOID")] void* pContext, [NativeTypeName("PHSWDEVICE")] HSWDEVICE* phSwDevice);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("cfgmgr32", ExactSpelling = true)]
        public static extern void SwDeviceClose(HSWDEVICE hSwDevice);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("cfgmgr32", ExactSpelling = true)]
        public static extern HRESULT SwDeviceSetLifetime(HSWDEVICE hSwDevice, SW_DEVICE_LIFETIME Lifetime);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("cfgmgr32", ExactSpelling = true)]
        public static extern HRESULT SwDeviceGetLifetime(HSWDEVICE hSwDevice, [NativeTypeName("PSW_DEVICE_LIFETIME")] SW_DEVICE_LIFETIME* pLifetime);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("cfgmgr32", ExactSpelling = true)]
        public static extern HRESULT SwDevicePropertySet(HSWDEVICE hSwDevice, [NativeTypeName("ULONG")] uint cPropertyCount, [NativeTypeName("const DEVPROPERTY *")] DEVPROPERTY* pProperties);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("cfgmgr32", ExactSpelling = true)]
        public static extern HRESULT SwDeviceInterfaceRegister(HSWDEVICE hSwDevice, [NativeTypeName("const GUID *")] Guid* pInterfaceClassGuid, [NativeTypeName("PCWSTR")] ushort* pszReferenceString, [NativeTypeName("ULONG")] uint cPropertyCount, [NativeTypeName("const DEVPROPERTY *")] DEVPROPERTY* pProperties, BOOL fEnabled, [NativeTypeName("PWSTR *")] ushort** ppszDeviceInterfaceId);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("cfgmgr32", ExactSpelling = true)]
        public static extern void SwMemFree([NativeTypeName("PVOID")] void* pMem);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("cfgmgr32", ExactSpelling = true)]
        public static extern HRESULT SwDeviceInterfaceSetState(HSWDEVICE hSwDevice, [NativeTypeName("PCWSTR")] ushort* pszDeviceInterfaceId, BOOL fEnabled);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("cfgmgr32", ExactSpelling = true)]
        public static extern HRESULT SwDeviceInterfacePropertySet(HSWDEVICE hSwDevice, [NativeTypeName("PCWSTR")] ushort* pszDeviceInterfaceId, [NativeTypeName("ULONG")] uint cPropertyCount, [NativeTypeName("const DEVPROPERTY *")] DEVPROPERTY* pProperties);
    }
}
