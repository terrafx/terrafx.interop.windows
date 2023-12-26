// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PointOptions.xml' path='doc/member[@name="PointOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum PointOptions : uint
{
    /// <include file='PointOptions.xml' path='doc/member[@name="PointOptions.PointOptions_None"]/*' />
    PointOptions_None = 0,

    /// <include file='PointOptions.xml' path='doc/member[@name="PointOptions.PointOptions_IncludeInset"]/*' />
    PointOptions_IncludeInset = 0x1,

    /// <include file='PointOptions.xml' path='doc/member[@name="PointOptions.PointOptions_Start"]/*' />
    PointOptions_Start = 0x20,

    /// <include file='PointOptions.xml' path='doc/member[@name="PointOptions.PointOptions_ClientCoordinates"]/*' />
    PointOptions_ClientCoordinates = 0x100,

    /// <include file='PointOptions.xml' path='doc/member[@name="PointOptions.PointOptions_AllowOffClient"]/*' />
    PointOptions_AllowOffClient = 0x200,

    /// <include file='PointOptions.xml' path='doc/member[@name="PointOptions.PointOptions_Transform"]/*' />
    PointOptions_Transform = 0x400,

    /// <include file='PointOptions.xml' path='doc/member[@name="PointOptions.PointOptions_NoHorizontalScroll"]/*' />
    PointOptions_NoHorizontalScroll = 0x10000,

    /// <include file='PointOptions.xml' path='doc/member[@name="PointOptions.PointOptions_NoVerticalScroll"]/*' />
    PointOptions_NoVerticalScroll = 0x40000,
}
