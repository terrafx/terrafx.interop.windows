// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='AXISINFOW.xml' path='doc/member[@name="AXISINFOW"]/*' />
public partial struct AXISINFOW
{
    /// <include file='AXISINFOW.xml' path='doc/member[@name="AXISINFOW.axMinValue"]/*' />
    [NativeTypeName("LONG")]
    public int axMinValue;

    /// <include file='AXISINFOW.xml' path='doc/member[@name="AXISINFOW.axMaxValue"]/*' />
    [NativeTypeName("LONG")]
    public int axMaxValue;

    /// <include file='AXISINFOW.xml' path='doc/member[@name="AXISINFOW.axAxisName"]/*' />
    [NativeTypeName("WCHAR[16]")]
    public _axAxisName_e__FixedBuffer axAxisName;

    /// <include file='_axAxisName_e__FixedBuffer.xml' path='doc/member[@name="_axAxisName_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _axAxisName_e__FixedBuffer
    {
        public char e0;
    }
}
