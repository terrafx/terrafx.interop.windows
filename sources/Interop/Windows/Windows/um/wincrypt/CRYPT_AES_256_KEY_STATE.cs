// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CRYPT_AES_256_KEY_STATE.xml' path='doc/member[@name="CRYPT_AES_256_KEY_STATE"]/*' />
public partial struct CRYPT_AES_256_KEY_STATE
{
    /// <include file='CRYPT_AES_256_KEY_STATE.xml' path='doc/member[@name="CRYPT_AES_256_KEY_STATE.Key"]/*' />
    [NativeTypeName("unsigned char[32]")]
    public _Key_e__FixedBuffer Key;

    /// <include file='CRYPT_AES_256_KEY_STATE.xml' path='doc/member[@name="CRYPT_AES_256_KEY_STATE.IV"]/*' />
    [NativeTypeName("unsigned char[16]")]
    public _IV_e__FixedBuffer IV;

    /// <include file='CRYPT_AES_256_KEY_STATE.xml' path='doc/member[@name="CRYPT_AES_256_KEY_STATE.EncryptionState"]/*' />
    [NativeTypeName("unsigned char[15][16]")]
    public _EncryptionState_e__FixedBuffer EncryptionState;

    /// <include file='CRYPT_AES_256_KEY_STATE.xml' path='doc/member[@name="CRYPT_AES_256_KEY_STATE.DecryptionState"]/*' />
    [NativeTypeName("unsigned char[15][16]")]
    public _DecryptionState_e__FixedBuffer DecryptionState;

    /// <include file='CRYPT_AES_256_KEY_STATE.xml' path='doc/member[@name="CRYPT_AES_256_KEY_STATE.Feedback"]/*' />
    [NativeTypeName("unsigned char[16]")]
    public _Feedback_e__FixedBuffer Feedback;

    /// <include file='_Key_e__FixedBuffer.xml' path='doc/member[@name="_Key_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _Key_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_IV_e__FixedBuffer.xml' path='doc/member[@name="_IV_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _IV_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_EncryptionState_e__FixedBuffer.xml' path='doc/member[@name="_EncryptionState_e__FixedBuffer"]/*' />
    [InlineArray(15 * 16)]
    public partial struct _EncryptionState_e__FixedBuffer
    {
        public byte e0_0;
    }

    /// <include file='_DecryptionState_e__FixedBuffer.xml' path='doc/member[@name="_DecryptionState_e__FixedBuffer"]/*' />
    [InlineArray(15 * 16)]
    public partial struct _DecryptionState_e__FixedBuffer
    {
        public byte e0_0;
    }

    /// <include file='_Feedback_e__FixedBuffer.xml' path='doc/member[@name="_Feedback_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _Feedback_e__FixedBuffer
    {
        public byte e0;
    }
}
