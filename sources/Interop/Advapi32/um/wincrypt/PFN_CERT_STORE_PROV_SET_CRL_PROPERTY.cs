// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CERT_STORE_PROV_SET_CRL_PROPERTY([NativeTypeName("HCERTSTOREPROV")] void* hStoreProv, [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext, [NativeTypeName("DWORD")] uint dwPropId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvData);
}
