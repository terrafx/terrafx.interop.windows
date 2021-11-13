// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    public partial struct FSCTL_SET_INTEGRITY_INFORMATION_BUFFER
    {
        [NativeTypeName("WORD")]
        public ushort ChecksumAlgorithm;

        [NativeTypeName("WORD")]
        public ushort Reserved;

        [NativeTypeName("DWORD")]
        public uint Flags;
    }
}
