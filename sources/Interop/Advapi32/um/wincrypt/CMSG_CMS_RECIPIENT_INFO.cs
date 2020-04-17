// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct CMSG_CMS_RECIPIENT_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwRecipientChoice;

        [NativeTypeName("_CMSG_CMS_RECIPIENT_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wincrypt.h:7829:5)")]
        public _Anonymous_e__Union _Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("PCMSG_KEY_TRANS_RECIPIENT_INFO")]
            public CMSG_KEY_TRANS_RECIPIENT_INFO* pKeyTrans;

            [FieldOffset(0)]
            [NativeTypeName("PCMSG_KEY_AGREE_RECIPIENT_INFO")]
            public CMSG_KEY_AGREE_RECIPIENT_INFO* pKeyAgree;

            [FieldOffset(0)]
            [NativeTypeName("PCMSG_MAIL_LIST_RECIPIENT_INFO")]
            public CMSG_MAIL_LIST_RECIPIENT_INFO* pMailList;
        }
    }
}
