// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/swdevice.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("cfgmgr32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SwDeviceCreate([NativeTypeName("PCWSTR")] ushort* pszEnumeratorName, [NativeTypeName("PCWSTR")] ushort* pszParentDeviceInstance, [NativeTypeName("const SW_DEVICE_CREATE_INFO *")] SW_DEVICE_CREATE_INFO* pCreateInfo, [NativeTypeName("ULONG")] uint cPropertyCount, [NativeTypeName("const DEVPROPERTY *")] DEVPROPERTY* pProperties, [NativeTypeName("SW_DEVICE_CREATE_CALLBACK")] delegate* unmanaged<IntPtr, int, void*, ushort*, void> pCallback, [NativeTypeName("PVOID")] void* pContext, [NativeTypeName("PHSWDEVICE")] IntPtr* phSwDevice);

        [DllImport("cfgmgr32", ExactSpelling = true)]
        public static extern void SwDeviceClose([NativeTypeName("HSWDEVICE")] IntPtr hSwDevice);

        [DllImport("cfgmgr32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SwDeviceSetLifetime([NativeTypeName("HSWDEVICE")] IntPtr hSwDevice, SW_DEVICE_LIFETIME Lifetime);

        [DllImport("cfgmgr32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SwDeviceGetLifetime([NativeTypeName("HSWDEVICE")] IntPtr hSwDevice, [NativeTypeName("PSW_DEVICE_LIFETIME")] SW_DEVICE_LIFETIME* pLifetime);

        [DllImport("cfgmgr32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SwDevicePropertySet([NativeTypeName("HSWDEVICE")] IntPtr hSwDevice, [NativeTypeName("ULONG")] uint cPropertyCount, [NativeTypeName("const DEVPROPERTY *")] DEVPROPERTY* pProperties);

        [DllImport("cfgmgr32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SwDeviceInterfaceRegister([NativeTypeName("HSWDEVICE")] IntPtr hSwDevice, [NativeTypeName("const GUID *")] Guid* pInterfaceClassGuid, [NativeTypeName("PCWSTR")] ushort* pszReferenceString, [NativeTypeName("ULONG")] uint cPropertyCount, [NativeTypeName("const DEVPROPERTY *")] DEVPROPERTY* pProperties, BOOL fEnabled, [NativeTypeName("PWSTR *")] ushort** ppszDeviceInterfaceId);

        [DllImport("cfgmgr32", ExactSpelling = true)]
        public static extern void SwMemFree([NativeTypeName("PVOID")] void* pMem);

        [DllImport("cfgmgr32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SwDeviceInterfaceSetState([NativeTypeName("HSWDEVICE")] IntPtr hSwDevice, [NativeTypeName("PCWSTR")] ushort* pszDeviceInterfaceId, BOOL fEnabled);

        [DllImport("cfgmgr32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SwDeviceInterfacePropertySet([NativeTypeName("HSWDEVICE")] IntPtr hSwDevice, [NativeTypeName("PCWSTR")] ushort* pszDeviceInterfaceId, [NativeTypeName("ULONG")] uint cPropertyCount, [NativeTypeName("const DEVPROPERTY *")] DEVPROPERTY* pProperties);
    }
}
