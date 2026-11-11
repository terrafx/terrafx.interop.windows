// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='_CMSG_CTRL_KEM_DECRYPT_PARA.xml' path='doc/member[@name="_CMSG_CTRL_KEM_DECRYPT_PARA"]/*' />
public unsafe partial struct _CMSG_CTRL_KEM_DECRYPT_PARA
{
    /// <include file='_CMSG_CTRL_KEM_DECRYPT_PARA.xml' path='doc/member[@name="_CMSG_CTRL_KEM_DECRYPT_PARA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='_CMSG_CTRL_KEM_DECRYPT_PARA.xml' path='doc/member[@name="_CMSG_CTRL_KEM_DECRYPT_PARA.hNCryptKey"]/*' />
    [NativeTypeName("NCRYPT_KEY_HANDLE")]
    public nuint hNCryptKey;

    /// <include file='_CMSG_CTRL_KEM_DECRYPT_PARA.xml' path='doc/member[@name="_CMSG_CTRL_KEM_DECRYPT_PARA.pKem"]/*' />
    [NativeTypeName("PCMSG_KEM_RECIPIENT_INFO")]
    public _CMSG_KEM_RECIPIENT_INFO* pKem;

    /// <include file='_CMSG_CTRL_KEM_DECRYPT_PARA.xml' path='doc/member[@name="_CMSG_CTRL_KEM_DECRYPT_PARA.dwRecipientIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRecipientIndex;
}
