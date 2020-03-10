// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct COSERVERINFO
    {
        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        [NativeTypeName("LPWSTR")]
        public ushort* pwszName;

        [NativeTypeName("COAUTHINFO *")]
        public COAUTHINFO* pAuthInfo;

        [NativeTypeName("DWORD")]
        public uint dwReserved2;
    }
}
