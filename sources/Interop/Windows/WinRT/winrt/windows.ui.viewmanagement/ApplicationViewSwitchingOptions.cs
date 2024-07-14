// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ApplicationViewSwitchingOptions.xml' path='doc/member[@name="ApplicationViewSwitchingOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum ApplicationViewSwitchingOptions : uint
{
    /// <include file='ApplicationViewSwitchingOptions.xml' path='doc/member[@name="ApplicationViewSwitchingOptions.ApplicationViewSwitchingOptions_Default"]/*' />
    ApplicationViewSwitchingOptions_Default = 0,

    /// <include file='ApplicationViewSwitchingOptions.xml' path='doc/member[@name="ApplicationViewSwitchingOptions.ApplicationViewSwitchingOptions_SkipAnimation"]/*' />
    ApplicationViewSwitchingOptions_SkipAnimation = 0x1,

    /// <include file='ApplicationViewSwitchingOptions.xml' path='doc/member[@name="ApplicationViewSwitchingOptions.ApplicationViewSwitchingOptions_ConsolidateViews"]/*' />
    ApplicationViewSwitchingOptions_ConsolidateViews = 0x2,
}
