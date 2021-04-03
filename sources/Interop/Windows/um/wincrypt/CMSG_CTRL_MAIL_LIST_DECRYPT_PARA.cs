// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_CTRL_MAIL_LIST_DECRYPT_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HCRYPTPROV")]
        public nuint hCryptProv;

        [NativeTypeName("PCMSG_MAIL_LIST_RECIPIENT_INFO")]
        public CMSG_MAIL_LIST_RECIPIENT_INFO* pMailList;

        [NativeTypeName("DWORD")]
        public uint dwRecipientIndex;

        [NativeTypeName("DWORD")]
        public uint dwKeyChoice;

        [NativeTypeName("_CMSG_CTRL_MAIL_LIST_DECRYPT_PARA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:8135:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref nuint hKeyEncryptionKey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hKeyEncryptionKey, 1));
            }
        }

        public ref void* pvKeyEncryptionKey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pvKeyEncryptionKey;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HCRYPTKEY")]
            public nuint hKeyEncryptionKey;

            [FieldOffset(0)]
            public void* pvKeyEncryptionKey;
        }
    }
}
