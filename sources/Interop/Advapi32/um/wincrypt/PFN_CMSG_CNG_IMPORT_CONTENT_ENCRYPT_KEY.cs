// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CMSG_CNG_IMPORT_CONTENT_ENCRYPT_KEY([NativeTypeName("PCMSG_CNG_CONTENT_DECRYPT_INFO")] CMSG_CNG_CONTENT_DECRYPT_INFO* pCNGContentDecryptInfo, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved);
}
