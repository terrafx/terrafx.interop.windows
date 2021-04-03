// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct COAUTHINFO
    {
        [NativeTypeName("DWORD")]
        public uint dwAuthnSvc;

        [NativeTypeName("DWORD")]
        public uint dwAuthzSvc;

        [NativeTypeName("LPWSTR")]
        public ushort* pwszServerPrincName;

        [NativeTypeName("DWORD")]
        public uint dwAuthnLevel;

        [NativeTypeName("DWORD")]
        public uint dwImpersonationLevel;

        public COAUTHIDENTITY* pAuthIdentityData;

        [NativeTypeName("DWORD")]
        public uint dwCapabilities;
    }
}
