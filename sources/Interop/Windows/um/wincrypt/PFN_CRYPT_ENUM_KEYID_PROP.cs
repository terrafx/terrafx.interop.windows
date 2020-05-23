// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CRYPT_ENUM_KEYID_PROP([NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPTOAPI_BLOB* pKeyIdentifier, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("void *")] void* pvArg, [NativeTypeName("DWORD")] uint cProp, [NativeTypeName("DWORD *")] uint* rgdwPropId, [NativeTypeName("void **")] void** rgpvData, [NativeTypeName("DWORD *")] uint* rgcbData);
}
