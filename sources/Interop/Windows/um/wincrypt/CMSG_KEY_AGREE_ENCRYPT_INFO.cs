// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_KEY_AGREE_ENCRYPT_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwRecipientIndex;

        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB UserKeyingMaterial;

        [NativeTypeName("DWORD")]
        public uint dwOriginatorChoice;

        [NativeTypeName("_CMSG_KEY_AGREE_ENCRYPT_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:8615:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DWORD")]
        public uint cKeyAgreeKeyEncryptInfo;

        [NativeTypeName("PCMSG_KEY_AGREE_KEY_ENCRYPT_INFO *")]
        public CMSG_KEY_AGREE_KEY_ENCRYPT_INFO** rgpKeyAgreeKeyEncryptInfo;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public CERT_ID OriginatorCertId;

            [FieldOffset(0)]
            public CERT_PUBLIC_KEY_INFO OriginatorPublicKeyInfo;
        }
    }
}
