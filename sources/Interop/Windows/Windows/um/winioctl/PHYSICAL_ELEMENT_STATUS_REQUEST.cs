// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PHYSICAL_ELEMENT_STATUS_REQUEST.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_REQUEST"]/*' />
public partial struct PHYSICAL_ELEMENT_STATUS_REQUEST
{
    /// <include file='PHYSICAL_ELEMENT_STATUS_REQUEST.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_REQUEST.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='PHYSICAL_ELEMENT_STATUS_REQUEST.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_REQUEST.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='PHYSICAL_ELEMENT_STATUS_REQUEST.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_REQUEST.StartingElement"]/*' />
    [NativeTypeName("DWORD")]
    public uint StartingElement;

    /// <include file='PHYSICAL_ELEMENT_STATUS_REQUEST.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_REQUEST.Filter"]/*' />
    public byte Filter;

    /// <include file='PHYSICAL_ELEMENT_STATUS_REQUEST.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_REQUEST.ReportType"]/*' />
    public byte ReportType;

    /// <include file='PHYSICAL_ELEMENT_STATUS_REQUEST.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_REQUEST.Reserved"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
