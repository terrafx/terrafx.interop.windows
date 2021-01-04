// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. License information available at https://github.com/MicrosoftDocs/win32/blob/docs/LICENSE-CODE

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("mssign32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SignerSignEx2([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("SIGNER_SUBJECT_INFO *")] SIGNER_SUBJECT_INFO* pSubjectInfo, [NativeTypeName("SIGNER_CERT *")] SIGNER_CERT* pSignerCert, [NativeTypeName("SIGNER_SIGNATURE_INFO *")] SIGNER_SIGNATURE_INFO* pSignatureInfo, [NativeTypeName("SIGNER_PROVIDER_INFO *")] SIGNER_PROVIDER_INFO* pProviderInfo, [NativeTypeName("DWORD")] uint dwTimestampFlags, [NativeTypeName("PCSTR")] sbyte* pszTimestampAlgorithmOid, [NativeTypeName("PCWSTR")] ushort* pwszHttpTimeStamp, [NativeTypeName("PCRYPT_ATTRIBUTES")] CRYPT_ATTRIBUTES* psRequest, [NativeTypeName("PVOID")] void* pSipData, [NativeTypeName("SIGNER_CONTEXT **")] SIGNER_CONTEXT** ppSignerContext, [NativeTypeName("PCERT_STRONG_SIGN_PARA")] CERT_STRONG_SIGN_PARA* pCryptoPolicy, [NativeTypeName("PVOID")] void* pReserved);

        [NativeTypeName("#define SIGNER_SUBJECT_FILE 0x01")]
        public const int SIGNER_SUBJECT_FILE = 0x01;

        [NativeTypeName("#define SIGNER_SUBJECT_BLOB 0x02")]
        public const int SIGNER_SUBJECT_BLOB = 0x02;

        [NativeTypeName("#define SIGNER_NO_ATTR 0x00")]
        public const int SIGNER_NO_ATTR = 0x00;

        [NativeTypeName("#define SIGNER_AUTHCODE_ATTR 0x01")]
        public const int SIGNER_AUTHCODE_ATTR = 0x01;

        [NativeTypeName("#define PVK_TYPE_FILE_NAME 0x01")]
        public const int PVK_TYPE_FILE_NAME = 0x01;

        [NativeTypeName("#define PVK_TYPE_KEYCONTAINER 0x02")]
        public const int PVK_TYPE_KEYCONTAINER = 0x02;

        [NativeTypeName("#define SIGNER_CERT_POLICY_STORE 0x01")]
        public const int SIGNER_CERT_POLICY_STORE = 0x01;

        [NativeTypeName("#define SIGNER_CERT_POLICY_CHAIN 0x02")]
        public const int SIGNER_CERT_POLICY_CHAIN = 0x02;

        [NativeTypeName("#define SIGNER_CERT_POLICY_SPC 0x04")]
        public const int SIGNER_CERT_POLICY_SPC = 0x04;

        [NativeTypeName("#define SIGNER_CERT_POLICY_CHAIN_NO_ROOT 0x08")]
        public const int SIGNER_CERT_POLICY_CHAIN_NO_ROOT = 0x08;

        [NativeTypeName("#define SIGNER_CERT_SPC_FILE 0x01")]
        public const int SIGNER_CERT_SPC_FILE = 0x01;

        [NativeTypeName("#define SIGNER_CERT_STORE 0x02")]
        public const int SIGNER_CERT_STORE = 0x02;

        [NativeTypeName("#define SIGNER_CERT_SPC_CHAIN 0x03")]
        public const int SIGNER_CERT_SPC_CHAIN = 0x03;
    }
}
