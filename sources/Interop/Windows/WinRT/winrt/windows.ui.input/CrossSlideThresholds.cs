// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CrossSlideThresholds.xml' path='doc/member[@name="CrossSlideThresholds"]/*' />
public partial struct CrossSlideThresholds
{
    /// <include file='CrossSlideThresholds.xml' path='doc/member[@name="CrossSlideThresholds.SelectionStart"]/*' />
    public float SelectionStart;

    /// <include file='CrossSlideThresholds.xml' path='doc/member[@name="CrossSlideThresholds.SpeedBumpStart"]/*' />
    public float SpeedBumpStart;

    /// <include file='CrossSlideThresholds.xml' path='doc/member[@name="CrossSlideThresholds.SpeedBumpEnd"]/*' />
    public float SpeedBumpEnd;

    /// <include file='CrossSlideThresholds.xml' path='doc/member[@name="CrossSlideThresholds.RearrangeStart"]/*' />
    public float RearrangeStart;
}
