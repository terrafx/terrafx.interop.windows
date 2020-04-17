// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_EXPORT_PRIV_KEY_FUNC([NativeTypeName("HCRYPTPROV")] uint hCryptProv, [NativeTypeName("DWORD")] uint dwKeySpec, [NativeTypeName("LPSTR")] sbyte* pszPrivateKeyObjId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvAuxInfo, [NativeTypeName("CRYPT_PRIVATE_KEY_INFO *")] CRYPT_PRIVATE_KEY_INFO* pPrivateKeyInfo, [NativeTypeName("DWORD *")] uint* pcbPrivateKeyInfo);
}
