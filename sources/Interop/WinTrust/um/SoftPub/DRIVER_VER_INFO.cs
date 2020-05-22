// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DRIVER_VER_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("ULONG_PTR")]
        public nuint dwReserved1;

        [NativeTypeName("ULONG_PTR")]
        public nuint dwReserved2;

        [NativeTypeName("DWORD")]
        public uint dwPlatform;

        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort wszVersion[260];

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort wszSignedBy[260];

        [NativeTypeName("PCCERT_CONTEXT")]
        public CERT_CONTEXT* pcSignerCertContext;

        public DRIVER_VER_MAJORMINOR sOSVersionLow;

        public DRIVER_VER_MAJORMINOR sOSVersionHigh;

        [NativeTypeName("DWORD")]
        public uint dwBuildNumberLow;

        [NativeTypeName("DWORD")]
        public uint dwBuildNumberHigh;
    }
}
