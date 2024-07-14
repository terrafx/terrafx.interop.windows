// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='WTS_THUMBNAILID.xml' path='doc/member[@name="WTS_THUMBNAILID"]/*' />
public partial struct WTS_THUMBNAILID
{
    /// <include file='WTS_THUMBNAILID.xml' path='doc/member[@name="WTS_THUMBNAILID.rgbKey"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _rgbKey_e__FixedBuffer rgbKey;

    /// <include file='_rgbKey_e__FixedBuffer.xml' path='doc/member[@name="_rgbKey_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _rgbKey_e__FixedBuffer
    {
        public byte e0;
    }
}
