// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public static partial class SSL
    {
        [NativeTypeName("#define SSL_F12_ERROR_TEXT_LENGTH 256")]
        public const int SSL_F12_ERROR_TEXT_LENGTH = 256;

        [NativeTypeName("#define SSL_HPKP_PKP_HEADER_INDEX 0")]
        public const int SSL_HPKP_PKP_HEADER_INDEX = 0;

        [NativeTypeName("#define SSL_HPKP_PKP_RO_HEADER_INDEX 1")]
        public const int SSL_HPKP_PKP_RO_HEADER_INDEX = 1;

        [NativeTypeName("#define SSL_HPKP_HEADER_COUNT 2")]
        public const int SSL_HPKP_HEADER_COUNT = 2;

        [NativeTypeName("#define SSL_KEY_PIN_ERROR_TEXT_LENGTH 512")]
        public const int SSL_KEY_PIN_ERROR_TEXT_LENGTH = 512;

        [NativeTypeName("#define SSL_OBJECT_LOCATOR_PFX_FUNC \"SslObjectLocatorInitializePfx\"")]
        public static ReadOnlySpan<byte> SSL_OBJECT_LOCATOR_PFX_FUNC => new byte[] { 0x53, 0x73, 0x6C, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x6F, 0x72, 0x49, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x50, 0x66, 0x78, 0x00 };

        [NativeTypeName("#define SSL_OBJECT_LOCATOR_ISSUER_LIST_FUNC \"SslObjectLocatorInitializeIssuerList\"")]
        public static ReadOnlySpan<byte> SSL_OBJECT_LOCATOR_ISSUER_LIST_FUNC => new byte[] { 0x53, 0x73, 0x6C, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x6F, 0x72, 0x49, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x49, 0x73, 0x73, 0x75, 0x65, 0x72, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define SSL_OBJECT_LOCATOR_CERT_VALIDATION_CONFIG_FUNC \"SslObjectLocatorInitializeCertValidationConfig\"")]
        public static ReadOnlySpan<byte> SSL_OBJECT_LOCATOR_CERT_VALIDATION_CONFIG_FUNC => new byte[] { 0x53, 0x73, 0x6C, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x6F, 0x72, 0x49, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x43, 0x65, 0x72, 0x74, 0x56, 0x61, 0x6C, 0x69, 0x64, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x43, 0x6F, 0x6E, 0x66, 0x69, 0x67, 0x00 };
    }
}
