// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CRYPT_SMART_CARD_ROOT_INFO.xml' path='doc/member[@name="CRYPT_SMART_CARD_ROOT_INFO"]/*' />
public partial struct CRYPT_SMART_CARD_ROOT_INFO
{
    /// <include file='CRYPT_SMART_CARD_ROOT_INFO.xml' path='doc/member[@name="CRYPT_SMART_CARD_ROOT_INFO.rgbCardID"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _rgbCardID_e__FixedBuffer rgbCardID;

    /// <include file='CRYPT_SMART_CARD_ROOT_INFO.xml' path='doc/member[@name="CRYPT_SMART_CARD_ROOT_INFO.luid"]/*' />
    public ROOT_INFO_LUID luid;

    /// <include file='_rgbCardID_e__FixedBuffer.xml' path='doc/member[@name="_rgbCardID_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _rgbCardID_e__FixedBuffer
    {
        public byte e0;
    }
}
