// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CMSG_IMPORT_KEY_AGREE([NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")] CRYPT_ALGORITHM_IDENTIFIER* pContentEncryptionAlgorithm, [NativeTypeName("PCMSG_CTRL_KEY_AGREE_DECRYPT_PARA")] CMSG_CTRL_KEY_AGREE_DECRYPT_PARA* pKeyAgreeDecryptPara, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void *")] void* pvReserved, [NativeTypeName("HCRYPTKEY *")] uint* phContentEncryptKey);
}
