// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("PCCERT_CONTEXT")]
    public unsafe delegate CERT_CONTEXT* PFN_CRYPT_GET_SIGNER_CERTIFICATE([NativeTypeName("void *")] void* pvGetArg, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("PCERT_INFO")] CERT_INFO* pSignerId, [NativeTypeName("HCERTSTORE")] void* hMsgCertStore);
}
