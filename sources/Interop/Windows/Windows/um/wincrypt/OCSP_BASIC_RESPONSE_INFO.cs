// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct OCSP_BASIC_RESPONSE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("DWORD")]
        public uint dwResponderIdChoice;

        [NativeTypeName("_OCSP_BASIC_RESPONSE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wincrypt.h:5706:5)")]
        public _Anonymous_e__Union Anonymous;

        public FILETIME ProducedAt;

        [NativeTypeName("DWORD")]
        public uint cResponseEntry;

        [NativeTypeName("POCSP_BASIC_RESPONSE_ENTRY")]
        public OCSP_BASIC_RESPONSE_ENTRY* rgResponseEntry;

        [NativeTypeName("DWORD")]
        public uint cExtension;

        [NativeTypeName("PCERT_EXTENSION")]
        public CERT_EXTENSION* rgExtension;

        public ref CRYPT_DATA_BLOB ByNameResponderId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ByNameResponderId, 1));
            }
        }

        public ref CRYPT_DATA_BLOB ByKeyResponderId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ByKeyResponderId, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("CERT_NAME_BLOB")]
            public CRYPT_DATA_BLOB ByNameResponderId;

            [FieldOffset(0)]
            [NativeTypeName("CRYPT_HASH_BLOB")]
            public CRYPT_DATA_BLOB ByKeyResponderId;
        }
    }
}
