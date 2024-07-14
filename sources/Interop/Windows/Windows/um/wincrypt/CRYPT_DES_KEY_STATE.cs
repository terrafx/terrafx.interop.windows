// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CRYPT_DES_KEY_STATE.xml' path='doc/member[@name="CRYPT_DES_KEY_STATE"]/*' />
public partial struct CRYPT_DES_KEY_STATE
{
    /// <include file='CRYPT_DES_KEY_STATE.xml' path='doc/member[@name="CRYPT_DES_KEY_STATE.Key"]/*' />
    [NativeTypeName("unsigned char[8]")]
    public _Key_e__FixedBuffer Key;

    /// <include file='CRYPT_DES_KEY_STATE.xml' path='doc/member[@name="CRYPT_DES_KEY_STATE.IV"]/*' />
    [NativeTypeName("unsigned char[8]")]
    public _IV_e__FixedBuffer IV;

    /// <include file='CRYPT_DES_KEY_STATE.xml' path='doc/member[@name="CRYPT_DES_KEY_STATE.Feedback"]/*' />
    [NativeTypeName("unsigned char[8]")]
    public _Feedback_e__FixedBuffer Feedback;

    /// <include file='_Key_e__FixedBuffer.xml' path='doc/member[@name="_Key_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _Key_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_IV_e__FixedBuffer.xml' path='doc/member[@name="_IV_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _IV_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Feedback_e__FixedBuffer.xml' path='doc/member[@name="_Feedback_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _Feedback_e__FixedBuffer
    {
        public byte e0;
    }
}
