// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_KEY_AGREE_RECIPIENT_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("DWORD")]
        public uint dwOriginatorChoice;

        [NativeTypeName("_CMSG_KEY_AGREE_RECIPIENT_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:7799:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref CERT_ID OriginatorCertId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.OriginatorCertId, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->OriginatorCertId;
#endif
            }
        }

        public unsafe ref CERT_PUBLIC_KEY_INFO OriginatorPublicKeyInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.OriginatorPublicKeyInfo, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->OriginatorPublicKeyInfo;
#endif
            }
        }

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB UserKeyingMaterial;

        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        [NativeTypeName("DWORD")]
        public uint cRecipientEncryptedKeys;

        [NativeTypeName("PCMSG_RECIPIENT_ENCRYPTED_KEY_INFO *")]
        public CMSG_RECIPIENT_ENCRYPTED_KEY_INFO** rgpRecipientEncryptedKeys;

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
