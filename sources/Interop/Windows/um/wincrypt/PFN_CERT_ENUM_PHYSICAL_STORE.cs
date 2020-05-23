// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CERT_ENUM_PHYSICAL_STORE([NativeTypeName("const void *")] void* pvSystemStore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pwszStoreName, [NativeTypeName("PCERT_PHYSICAL_STORE_INFO")] CERT_PHYSICAL_STORE_INFO* pStoreInfo, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("void *")] void* pvArg);
}
