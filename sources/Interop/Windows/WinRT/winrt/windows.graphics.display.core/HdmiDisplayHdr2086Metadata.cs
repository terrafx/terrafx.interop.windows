// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata"]/*' />
public partial struct HdmiDisplayHdr2086Metadata
{
    /// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata.RedPrimaryX"]/*' />
    [NativeTypeName("UINT16")]
    public ushort RedPrimaryX;

    /// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata.RedPrimaryY"]/*' />
    [NativeTypeName("UINT16")]
    public ushort RedPrimaryY;

    /// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata.GreenPrimaryX"]/*' />
    [NativeTypeName("UINT16")]
    public ushort GreenPrimaryX;

    /// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata.GreenPrimaryY"]/*' />
    [NativeTypeName("UINT16")]
    public ushort GreenPrimaryY;

    /// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata.BluePrimaryX"]/*' />
    [NativeTypeName("UINT16")]
    public ushort BluePrimaryX;

    /// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata.BluePrimaryY"]/*' />
    [NativeTypeName("UINT16")]
    public ushort BluePrimaryY;

    /// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata.WhitePointX"]/*' />
    [NativeTypeName("UINT16")]
    public ushort WhitePointX;

    /// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata.WhitePointY"]/*' />
    [NativeTypeName("UINT16")]
    public ushort WhitePointY;

    /// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata.MaxMasteringLuminance"]/*' />
    [NativeTypeName("UINT16")]
    public ushort MaxMasteringLuminance;

    /// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata.MinMasteringLuminance"]/*' />
    [NativeTypeName("UINT16")]
    public ushort MinMasteringLuminance;

    /// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata.MaxContentLightLevel"]/*' />
    [NativeTypeName("UINT16")]
    public ushort MaxContentLightLevel;

    /// <include file='HdmiDisplayHdr2086Metadata.xml' path='doc/member[@name="HdmiDisplayHdr2086Metadata.MaxFrameAverageLightLevel"]/*' />
    [NativeTypeName("UINT16")]
    public ushort MaxFrameAverageLightLevel;
}
