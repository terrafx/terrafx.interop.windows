// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MS_ADDINFO_BLOB
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("DWORD")]
        public uint cbMemObject;

        public byte* pbMemObject;

        [NativeTypeName("DWORD")]
        public uint cbMemSignedMsg;

        public byte* pbMemSignedMsg;
    }
}
