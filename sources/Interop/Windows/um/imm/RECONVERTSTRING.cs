// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct RECONVERTSTRING
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("DWORD")]
        public uint dwStrLen;

        [NativeTypeName("DWORD")]
        public uint dwStrOffset;

        [NativeTypeName("DWORD")]
        public uint dwCompStrLen;

        [NativeTypeName("DWORD")]
        public uint dwCompStrOffset;

        [NativeTypeName("DWORD")]
        public uint dwTargetStrLen;

        [NativeTypeName("DWORD")]
        public uint dwTargetStrOffset;
    }
}
