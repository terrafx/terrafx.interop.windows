// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate void PFN_CERT_SERVER_OCSP_RESPONSE_UPDATE_CALLBACK([NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext, [NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")] CERT_SERVER_OCSP_RESPONSE_CONTEXT* pServerOcspResponseContext, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pNewCrlContext, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext, [NativeTypeName("PVOID")] void* pvArg, [NativeTypeName("DWORD")] uint dwWriteOcspFileError);
}
