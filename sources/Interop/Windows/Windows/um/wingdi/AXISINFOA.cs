// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='AXISINFOA.xml' path='doc/member[@name="AXISINFOA"]/*' />
public partial struct AXISINFOA
{
    /// <include file='AXISINFOA.xml' path='doc/member[@name="AXISINFOA.axMinValue"]/*' />
    [NativeTypeName("LONG")]
    public int axMinValue;

    /// <include file='AXISINFOA.xml' path='doc/member[@name="AXISINFOA.axMaxValue"]/*' />
    [NativeTypeName("LONG")]
    public int axMaxValue;

    /// <include file='AXISINFOA.xml' path='doc/member[@name="AXISINFOA.axAxisName"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _axAxisName_e__FixedBuffer axAxisName;

    /// <include file='_axAxisName_e__FixedBuffer.xml' path='doc/member[@name="_axAxisName_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _axAxisName_e__FixedBuffer
    {
        public byte e0;
    }
}
