// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HdmiDisplayHdrOption.xml' path='doc/member[@name="HdmiDisplayHdrOption"]/*' />
public enum HdmiDisplayHdrOption
{
    /// <include file='HdmiDisplayHdrOption.xml' path='doc/member[@name="HdmiDisplayHdrOption.HdmiDisplayHdrOption_None"]/*' />
    HdmiDisplayHdrOption_None = 0,

    /// <include file='HdmiDisplayHdrOption.xml' path='doc/member[@name="HdmiDisplayHdrOption.HdmiDisplayHdrOption_EotfSdr"]/*' />
    HdmiDisplayHdrOption_EotfSdr = 1,

    /// <include file='HdmiDisplayHdrOption.xml' path='doc/member[@name="HdmiDisplayHdrOption.HdmiDisplayHdrOption_Eotf2084"]/*' />
    HdmiDisplayHdrOption_Eotf2084 = 2,

    /// <include file='HdmiDisplayHdrOption.xml' path='doc/member[@name="HdmiDisplayHdrOption.HdmiDisplayHdrOption_DolbyVisionLowLatency"]/*' />
    HdmiDisplayHdrOption_DolbyVisionLowLatency = 3,
}
