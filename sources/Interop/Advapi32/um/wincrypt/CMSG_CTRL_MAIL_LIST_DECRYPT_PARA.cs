// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_CTRL_MAIL_LIST_DECRYPT_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HCRYPTPROV")]
        public UIntPtr hCryptProv;

        [NativeTypeName("PCMSG_MAIL_LIST_RECIPIENT_INFO")]
        public CMSG_MAIL_LIST_RECIPIENT_INFO* pMailList;

        [NativeTypeName("DWORD")]
        public uint dwRecipientIndex;

        [NativeTypeName("DWORD")]
        public uint dwKeyChoice;

        [NativeTypeName("_CMSG_CTRL_MAIL_LIST_DECRYPT_PARA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wincrypt.h:8135:5)")]
        public _Anonymous_e__Union Anonymous

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HCRYPTKEY")]
            public UIntPtr hKeyEncryptionKey;

            [FieldOffset(0)]
            [NativeTypeName("void *")]
            public void* pvKeyEncryptionKey;
        }
    }
}
