// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. License information available at https://github.com/MicrosoftDocs/win32/blob/docs/LICENSE-CODE

namespace TerraFX.Interop
{
    public unsafe partial struct SIGNER_ATTR_AUTHCODE
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("BOOL")]
        public int fCommercial;

        [NativeTypeName("BOOL")]
        public int fIndividual;

        [NativeTypeName("LPCWSTR")]
        public ushort* pwszName;

        [NativeTypeName("LPCWSTR")]
        public ushort* pwszInfo;
    }
}