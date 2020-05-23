// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate void PFN_CRYPT_ASYNC_RETRIEVAL_COMPLETION_FUNC([NativeTypeName("LPVOID")] void* pvCompletion, [NativeTypeName("DWORD")] uint dwCompletionCode, [NativeTypeName("LPCSTR")] sbyte* pszUrl, [NativeTypeName("LPSTR")] sbyte* pszObjectOid, [NativeTypeName("LPVOID")] void* pvObject);
}
