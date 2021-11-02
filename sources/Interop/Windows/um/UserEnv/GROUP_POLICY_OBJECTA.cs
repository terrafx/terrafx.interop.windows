// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct GROUP_POLICY_OBJECTA
    {
        [NativeTypeName("DWORD")]
        public uint dwOptions;

        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("LPSTR")]
        public sbyte* lpDSPath;

        [NativeTypeName("LPSTR")]
        public sbyte* lpFileSysPath;

        [NativeTypeName("LPSTR")]
        public sbyte* lpDisplayName;

        [NativeTypeName("CHAR [50]")]
        public fixed sbyte szGPOName[50];

        public GPO_LINK GPOLink;

        public LPARAM lParam;

        [NativeTypeName("struct _GROUP_POLICY_OBJECTA *")]
        public GROUP_POLICY_OBJECTA* pNext;

        [NativeTypeName("struct _GROUP_POLICY_OBJECTA *")]
        public GROUP_POLICY_OBJECTA* pPrev;

        [NativeTypeName("LPSTR")]
        public sbyte* lpExtensions;

        public LPARAM lParam2;

        [NativeTypeName("LPSTR")]
        public sbyte* lpLink;
    }
}
