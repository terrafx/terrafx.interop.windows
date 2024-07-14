// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DisplayOrientations.xml' path='doc/member[@name="DisplayOrientations"]/*' />
[NativeTypeName("unsigned int")]
public enum DisplayOrientations : uint
{
    /// <include file='DisplayOrientations.xml' path='doc/member[@name="DisplayOrientations.DisplayOrientations_None"]/*' />
    DisplayOrientations_None = 0,

    /// <include file='DisplayOrientations.xml' path='doc/member[@name="DisplayOrientations.DisplayOrientations_Landscape"]/*' />
    DisplayOrientations_Landscape = 0x1,

    /// <include file='DisplayOrientations.xml' path='doc/member[@name="DisplayOrientations.DisplayOrientations_Portrait"]/*' />
    DisplayOrientations_Portrait = 0x2,

    /// <include file='DisplayOrientations.xml' path='doc/member[@name="DisplayOrientations.DisplayOrientations_LandscapeFlipped"]/*' />
    DisplayOrientations_LandscapeFlipped = 0x4,

    /// <include file='DisplayOrientations.xml' path='doc/member[@name="DisplayOrientations.DisplayOrientations_PortraitFlipped"]/*' />
    DisplayOrientations_PortraitFlipped = 0x8,
}
