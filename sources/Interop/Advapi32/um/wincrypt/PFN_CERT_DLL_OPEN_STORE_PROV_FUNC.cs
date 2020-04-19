// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CERT_DLL_OPEN_STORE_PROV_FUNC([NativeTypeName("LPCSTR")] sbyte* lpszStoreProvider, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("HCRYPTPROV_LEGACY")] UIntPtr hCryptProv, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const void *")] void* pvPara, [NativeTypeName("HCERTSTORE")] void* hCertStore, [NativeTypeName("PCERT_STORE_PROV_INFO")] CERT_STORE_PROV_INFO* pStoreProvInfo);
}
