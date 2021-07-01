// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SCH_CRED
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("DWORD")]
        public uint cCreds;

        [NativeTypeName("PVOID *")]
        public void** paSecret;

        [NativeTypeName("PVOID *")]
        public void** paPublic;

        [NativeTypeName("DWORD")]
        public uint cMappers;

        [NativeTypeName("struct _HMAPPER **")]
        public void** aphMappers;
    }
}
