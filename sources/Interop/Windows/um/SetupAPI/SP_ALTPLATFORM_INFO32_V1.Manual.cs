// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SP_ALTPLATFORM_INFO32_V1
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint Platform;

        [NativeTypeName("DWORD")]
        public uint MajorVersion;

        [NativeTypeName("DWORD")]
        public uint MinorVersion;

        [NativeTypeName("WORD")]
        public ushort ProcessorArchitecture;

        [NativeTypeName("WORD")]
        public ushort Reserved;
    }
}
