// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CRYPT_EXPORT_PUBLIC_KEY_INFO_EX2_FUNC([NativeTypeName("NCRYPT_KEY_HANDLE")] nuint hNCryptKey, [NativeTypeName("DWORD")] uint dwCertEncodingType, [NativeTypeName("LPSTR")] sbyte* pszPublicKeyObjId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvAuxInfo, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo, [NativeTypeName("DWORD *")] uint* pcbInfo);
}
