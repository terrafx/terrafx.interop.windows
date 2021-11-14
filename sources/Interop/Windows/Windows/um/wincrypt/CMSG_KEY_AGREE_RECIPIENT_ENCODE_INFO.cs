// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        public void* pvKeyEncryptionAuxInfo;

        public CRYPT_ALGORITHM_IDENTIFIER KeyWrapAlgorithm;

        public void* pvKeyWrapAuxInfo;

        public HCRYPTPROV_LEGACY hCryptProv;

        [NativeTypeName("DWORD")]
        public uint dwKeySpec;

        [NativeTypeName("DWORD")]
        public uint dwKeyChoice;

        [NativeTypeName("_CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wincrypt.h:6946:5)")]
        public _Anonymous_e__Union Anonymous;

        public CRYPT_DATA_BLOB UserKeyingMaterial;

        [NativeTypeName("DWORD")]
        public uint cRecipientEncryptedKeys;

        [NativeTypeName("PCMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO *")]
        public CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO** rgpRecipientEncryptedKeys;

        public ref CRYPT_ALGORITHM_IDENTIFIER* pEphemeralAlgorithm
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pEphemeralAlgorithm;
            }
        }

        public ref CERT_ID* pSenderId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pSenderId;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")]
            public CRYPT_ALGORITHM_IDENTIFIER* pEphemeralAlgorithm;

            [FieldOffset(0)]
            [NativeTypeName("PCERT_ID")]
            public CERT_ID* pSenderId;
        }
    }
}
