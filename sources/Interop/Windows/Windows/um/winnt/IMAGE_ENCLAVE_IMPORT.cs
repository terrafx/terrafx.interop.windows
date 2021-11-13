// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.16299.0")]
    public unsafe partial struct IMAGE_ENCLAVE_IMPORT
    {
        [NativeTypeName("DWORD")]
        public uint MatchType;

        [NativeTypeName("DWORD")]
        public uint MinimumSecurityVersion;

        [NativeTypeName("BYTE [32]")]
        public fixed byte UniqueOrAuthorID[32];

        [NativeTypeName("BYTE [16]")]
        public fixed byte FamilyID[16];

        [NativeTypeName("BYTE [16]")]
        public fixed byte ImageID[16];

        [NativeTypeName("DWORD")]
        public uint ImportName;

        [NativeTypeName("DWORD")]
        public uint Reserved;
    }
}
