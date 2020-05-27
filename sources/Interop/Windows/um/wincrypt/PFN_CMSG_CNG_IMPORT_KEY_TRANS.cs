// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CMSG_CNG_IMPORT_KEY_TRANS([NativeTypeName("PCMSG_CNG_CONTENT_DECRYPT_INFO")] CMSG_CNG_CONTENT_DECRYPT_INFO* pCNGContentDecryptInfo, [NativeTypeName("PCMSG_CTRL_KEY_TRANS_DECRYPT_PARA")] CMSG_CTRL_KEY_TRANS_DECRYPT_PARA* pKeyTransDecryptPara, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved);
}
