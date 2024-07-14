// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CRYPT_X942_OTHER_INFO.xml' path='doc/member[@name="CRYPT_X942_OTHER_INFO"]/*' />
public unsafe partial struct CRYPT_X942_OTHER_INFO
{
    /// <include file='CRYPT_X942_OTHER_INFO.xml' path='doc/member[@name="CRYPT_X942_OTHER_INFO.pszContentEncryptionObjId"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszContentEncryptionObjId;

    /// <include file='CRYPT_X942_OTHER_INFO.xml' path='doc/member[@name="CRYPT_X942_OTHER_INFO.rgbCounter"]/*' />
    [NativeTypeName("BYTE[4]")]
    public _rgbCounter_e__FixedBuffer rgbCounter;

    /// <include file='CRYPT_X942_OTHER_INFO.xml' path='doc/member[@name="CRYPT_X942_OTHER_INFO.rgbKeyLength"]/*' />
    [NativeTypeName("BYTE[4]")]
    public _rgbKeyLength_e__FixedBuffer rgbKeyLength;

    /// <include file='CRYPT_X942_OTHER_INFO.xml' path='doc/member[@name="CRYPT_X942_OTHER_INFO.PubInfo"]/*' />
    public CRYPT_DATA_BLOB PubInfo;

    /// <include file='_rgbCounter_e__FixedBuffer.xml' path='doc/member[@name="_rgbCounter_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _rgbCounter_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_rgbKeyLength_e__FixedBuffer.xml' path='doc/member[@name="_rgbKeyLength_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _rgbKeyLength_e__FixedBuffer
    {
        public byte e0;
    }
}
