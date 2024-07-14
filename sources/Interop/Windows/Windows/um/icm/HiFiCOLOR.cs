// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='HiFiCOLOR.xml' path='doc/member[@name="HiFiCOLOR"]/*' />
public partial struct HiFiCOLOR
{
    /// <include file='HiFiCOLOR.xml' path='doc/member[@name="HiFiCOLOR.channel"]/*' />
    [NativeTypeName("BYTE[8]")]
    public _channel_e__FixedBuffer channel;

    /// <include file='_channel_e__FixedBuffer.xml' path='doc/member[@name="_channel_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _channel_e__FixedBuffer
    {
        public byte e0;
    }
}
