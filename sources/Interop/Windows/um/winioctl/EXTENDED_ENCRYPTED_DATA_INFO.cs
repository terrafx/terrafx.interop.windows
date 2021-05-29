// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct EXTENDED_ENCRYPTED_DATA_INFO
    {
        [NativeTypeName("DWORD")]
        public uint ExtendedCode;

        [NativeTypeName("DWORD")]
        public uint Length;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint Reserved;
    }
}
