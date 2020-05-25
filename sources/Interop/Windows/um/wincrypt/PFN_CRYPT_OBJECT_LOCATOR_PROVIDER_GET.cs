// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_GET([NativeTypeName("LPVOID")] void* pPluginContext, [NativeTypeName("PCRYPT_DATA_BLOB")] CRYPTOAPI_BLOB* pIdentifier, [NativeTypeName("DWORD")] uint dwNameType, [NativeTypeName("PCERT_NAME_BLOB")] CRYPTOAPI_BLOB* pNameBlob, [NativeTypeName("PBYTE *")] byte** ppbContent, [NativeTypeName("DWORD *")] uint* pcbContent, [NativeTypeName("PCWSTR *")] ushort** ppwszPassword, [NativeTypeName("PCRYPT_DATA_BLOB *")] CRYPTOAPI_BLOB** ppIdentifier);
}
