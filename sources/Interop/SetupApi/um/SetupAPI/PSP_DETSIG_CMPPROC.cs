// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("DWORD")]
    public unsafe delegate uint PSP_DETSIG_CMPPROC([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* NewDeviceData, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* ExistingDeviceData, [NativeTypeName("PVOID")] void* CompareContext);
}
