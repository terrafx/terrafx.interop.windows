// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CMSG_EXPORT_MAIL_LIST([NativeTypeName("PCMSG_CONTENT_ENCRYPT_INFO")] CMSG_CONTENT_ENCRYPT_INFO* pContentEncryptInfo, [NativeTypeName("PCMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO")] CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO* pMailListEncodeInfo, [NativeTypeName("PCMSG_MAIL_LIST_ENCRYPT_INFO")] CMSG_MAIL_LIST_ENCRYPT_INFO* pMailListEncryptInfo, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved);
}
