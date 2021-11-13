// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SP_PROPSHEETPAGE_REQUEST32
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint PageRequested;

        public HDEVINFO DeviceInfoSet;

        [NativeTypeName("PSP_DEVINFO_DATA")]
        public SP_DEVINFO_DATA32* DeviceInfoData;
    }
}
