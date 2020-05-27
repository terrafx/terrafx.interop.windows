// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CMSG_EXPORT_KEY_AGREE([NativeTypeName("PCMSG_CONTENT_ENCRYPT_INFO")] CMSG_CONTENT_ENCRYPT_INFO* pContentEncryptInfo, [NativeTypeName("PCMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO")] CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO* pKeyAgreeEncodeInfo, [NativeTypeName("PCMSG_KEY_AGREE_ENCRYPT_INFO")] CMSG_KEY_AGREE_ENCRYPT_INFO* pKeyAgreeEncryptInfo, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved);
}
