// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct CMSG_SIGNED_AND_ENVELOPED_ENCODE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public CMSG_SIGNED_ENCODE_INFO SignedInfo;

        public CMSG_ENVELOPED_ENCODE_INFO EnvelopedInfo;
    }
}
