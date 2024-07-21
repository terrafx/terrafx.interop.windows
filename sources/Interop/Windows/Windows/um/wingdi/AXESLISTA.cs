// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='AXESLISTA.xml' path='doc/member[@name="AXESLISTA"]/*' />
public partial struct AXESLISTA
{
    /// <include file='AXESLISTA.xml' path='doc/member[@name="AXESLISTA.axlReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint axlReserved;

    /// <include file='AXESLISTA.xml' path='doc/member[@name="AXESLISTA.axlNumAxes"]/*' />
    [NativeTypeName("DWORD")]
    public uint axlNumAxes;

    /// <include file='AXESLISTA.xml' path='doc/member[@name="AXESLISTA.axlAxisInfo"]/*' />
    [NativeTypeName("AXISINFOA[16]")]
    public _axlAxisInfo_e__FixedBuffer axlAxisInfo;

    /// <include file='_axlAxisInfo_e__FixedBuffer.xml' path='doc/member[@name="_axlAxisInfo_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _axlAxisInfo_e__FixedBuffer
    {
        public AXISINFOA e0;
    }
}
