// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CMSG_EXPORT_KEY_TRANS([NativeTypeName("PCMSG_CONTENT_ENCRYPT_INFO")] CMSG_CONTENT_ENCRYPT_INFO* pContentEncryptInfo, [NativeTypeName("PCMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO")] CMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO* pKeyTransEncodeInfo, [NativeTypeName("PCMSG_KEY_TRANS_ENCRYPT_INFO")] CMSG_KEY_TRANS_ENCRYPT_INFO* pKeyTransEncryptInfo, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved);
}
