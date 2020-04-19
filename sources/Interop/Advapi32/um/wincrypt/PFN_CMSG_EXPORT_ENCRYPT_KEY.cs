// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CMSG_EXPORT_ENCRYPT_KEY([NativeTypeName("HCRYPTPROV")] UIntPtr hCryptProv, [NativeTypeName("HCRYPTKEY")] UIntPtr hEncryptKey, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKeyInfo, [NativeTypeName("PBYTE")] byte* pbData, [NativeTypeName("PDWORD")] uint* pcbData);
}
