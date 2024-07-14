// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CRYPT_RC4_KEY_STATE.xml' path='doc/member[@name="CRYPT_RC4_KEY_STATE"]/*' />
public partial struct CRYPT_RC4_KEY_STATE
{
    /// <include file='CRYPT_RC4_KEY_STATE.xml' path='doc/member[@name="CRYPT_RC4_KEY_STATE.Key"]/*' />
    [NativeTypeName("unsigned char[16]")]
    public _Key_e__FixedBuffer Key;

    /// <include file='CRYPT_RC4_KEY_STATE.xml' path='doc/member[@name="CRYPT_RC4_KEY_STATE.SBox"]/*' />
    [NativeTypeName("unsigned char[256]")]
    public _SBox_e__FixedBuffer SBox;

    /// <include file='CRYPT_RC4_KEY_STATE.xml' path='doc/member[@name="CRYPT_RC4_KEY_STATE.i"]/*' />
    [NativeTypeName("unsigned char")]
    public byte i;

    /// <include file='CRYPT_RC4_KEY_STATE.xml' path='doc/member[@name="CRYPT_RC4_KEY_STATE.j"]/*' />
    [NativeTypeName("unsigned char")]
    public byte j;

    /// <include file='_Key_e__FixedBuffer.xml' path='doc/member[@name="_Key_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _Key_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_SBox_e__FixedBuffer.xml' path='doc/member[@name="_SBox_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _SBox_e__FixedBuffer
    {
        public byte e0;
    }
}
