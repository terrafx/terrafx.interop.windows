// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WIN_CERTIFICATE
    {
        [NativeTypeName("DWORD")]
        public uint dwLength;

        [NativeTypeName("WORD")]
        public ushort wRevision;

        [NativeTypeName("WORD")]
        public ushort wCertificateType;

        [NativeTypeName("BYTE [1]")]
        public fixed byte bCertificate[1];
    }
}
