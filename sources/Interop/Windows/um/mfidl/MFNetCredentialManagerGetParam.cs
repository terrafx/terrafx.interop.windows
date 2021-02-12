// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MFNetCredentialManagerGetParam
    {
        [NativeTypeName("HRESULT")]
        public int hrOp;

        [NativeTypeName("BOOL")]
        public int fAllowLoggedOnUser;

        [NativeTypeName("BOOL")]
        public int fClearTextPackage;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszUrl;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszSite;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszRealm;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszPackage;

        [NativeTypeName("LONG")]
        public int nRetries;
    }
}
