// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HdmiDisplayColorSpace.xml' path='doc/member[@name="HdmiDisplayColorSpace"]/*' />
public enum HdmiDisplayColorSpace
{
    /// <include file='HdmiDisplayColorSpace.xml' path='doc/member[@name="HdmiDisplayColorSpace.HdmiDisplayColorSpace_RgbLimited"]/*' />
    HdmiDisplayColorSpace_RgbLimited = 0,

    /// <include file='HdmiDisplayColorSpace.xml' path='doc/member[@name="HdmiDisplayColorSpace.HdmiDisplayColorSpace_RgbFull"]/*' />
    HdmiDisplayColorSpace_RgbFull = 1,

    /// <include file='HdmiDisplayColorSpace.xml' path='doc/member[@name="HdmiDisplayColorSpace.HdmiDisplayColorSpace_BT2020"]/*' />
    HdmiDisplayColorSpace_BT2020 = 2,

    /// <include file='HdmiDisplayColorSpace.xml' path='doc/member[@name="HdmiDisplayColorSpace.HdmiDisplayColorSpace_BT709"]/*' />
    HdmiDisplayColorSpace_BT709 = 3,
}
