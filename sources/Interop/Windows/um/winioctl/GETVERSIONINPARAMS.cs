// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct GETVERSIONINPARAMS
    {
        [NativeTypeName("BYTE")]
        public byte bVersion;

        [NativeTypeName("BYTE")]
        public byte bRevision;

        [NativeTypeName("BYTE")]
        public byte bReserved;

        [NativeTypeName("BYTE")]
        public byte bIDEDeviceMap;

        [NativeTypeName("DWORD")]
        public uint fCapabilities;

        [NativeTypeName("DWORD [4]")]
        public fixed uint dwReserved[4];
    }
}
