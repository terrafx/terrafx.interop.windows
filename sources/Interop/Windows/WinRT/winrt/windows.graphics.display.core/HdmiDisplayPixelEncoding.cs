// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HdmiDisplayPixelEncoding.xml' path='doc/member[@name="HdmiDisplayPixelEncoding"]/*' />
public enum HdmiDisplayPixelEncoding
{
    /// <include file='HdmiDisplayPixelEncoding.xml' path='doc/member[@name="HdmiDisplayPixelEncoding.HdmiDisplayPixelEncoding_Rgb444"]/*' />
    HdmiDisplayPixelEncoding_Rgb444 = 0,

    /// <include file='HdmiDisplayPixelEncoding.xml' path='doc/member[@name="HdmiDisplayPixelEncoding.HdmiDisplayPixelEncoding_Ycc444"]/*' />
    HdmiDisplayPixelEncoding_Ycc444 = 1,

    /// <include file='HdmiDisplayPixelEncoding.xml' path='doc/member[@name="HdmiDisplayPixelEncoding.HdmiDisplayPixelEncoding_Ycc422"]/*' />
    HdmiDisplayPixelEncoding_Ycc422 = 2,

    /// <include file='HdmiDisplayPixelEncoding.xml' path='doc/member[@name="HdmiDisplayPixelEncoding.HdmiDisplayPixelEncoding_Ycc420"]/*' />
    HdmiDisplayPixelEncoding_Ycc420 = 3,
}
