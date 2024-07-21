// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DEVICE_DSM_REPORT_ZONES_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_PARAMETERS"]/*' />
public partial struct DEVICE_DSM_REPORT_ZONES_PARAMETERS
{
    /// <include file='DEVICE_DSM_REPORT_ZONES_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_PARAMETERS.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='DEVICE_DSM_REPORT_ZONES_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_PARAMETERS.ReportOption"]/*' />
    public byte ReportOption;

    /// <include file='DEVICE_DSM_REPORT_ZONES_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_PARAMETERS.Partial"]/*' />
    public byte Partial;

    /// <include file='DEVICE_DSM_REPORT_ZONES_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_PARAMETERS.Reserved"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
