// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class CONTEXT
    {
        [NativeTypeName("#define CONTEXT_OID_CREATE_OBJECT_CONTEXT_FUNC \"ContextDllCreateObjectContext\"")]
        public static ReadOnlySpan<byte> CONTEXT_OID_CREATE_OBJECT_CONTEXT_FUNC => new byte[] { 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x78, 0x74, 0x44, 0x6C, 0x6C, 0x43, 0x72, 0x65, 0x61, 0x74, 0x65, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x43, 0x6F, 0x6E, 0x74, 0x65, 0x78, 0x74, 0x00 };

        [NativeTypeName("#define CONTEXT_OID_CERTIFICATE ((LPCSTR)1)")]
        public static sbyte* CONTEXT_OID_CERTIFICATE => ((sbyte*)(1));

        [NativeTypeName("#define CONTEXT_OID_CRL ((LPCSTR)2)")]
        public static sbyte* CONTEXT_OID_CRL => ((sbyte*)(2));

        [NativeTypeName("#define CONTEXT_OID_CTL ((LPCSTR)3)")]
        public static sbyte* CONTEXT_OID_CTL => ((sbyte*)(3));

        [NativeTypeName("#define CONTEXT_OID_PKCS7 ((LPCSTR)4)")]
        public static sbyte* CONTEXT_OID_PKCS7 => ((sbyte*)(4));

        [NativeTypeName("#define CONTEXT_OID_CAPI2_ANY ((LPCSTR)5)")]
        public static sbyte* CONTEXT_OID_CAPI2_ANY => ((sbyte*)(5));

        [NativeTypeName("#define CONTEXT_OID_OCSP_RESP ((LPCSTR)6)")]
        public static sbyte* CONTEXT_OID_OCSP_RESP => ((sbyte*)(6));
    }
}
