// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FocusPreset.xml' path='doc/member[@name="FocusPreset"]/*' />
public enum FocusPreset
{
    /// <include file='FocusPreset.xml' path='doc/member[@name="FocusPreset.FocusPreset_Auto"]/*' />
    FocusPreset_Auto = 0,

    /// <include file='FocusPreset.xml' path='doc/member[@name="FocusPreset.FocusPreset_Manual"]/*' />
    FocusPreset_Manual = 1,

    /// <include file='FocusPreset.xml' path='doc/member[@name="FocusPreset.FocusPreset_AutoMacro"]/*' />
    FocusPreset_AutoMacro = 2,

    /// <include file='FocusPreset.xml' path='doc/member[@name="FocusPreset.FocusPreset_AutoNormal"]/*' />
    FocusPreset_AutoNormal = 3,

    /// <include file='FocusPreset.xml' path='doc/member[@name="FocusPreset.FocusPreset_AutoInfinity"]/*' />
    FocusPreset_AutoInfinity = 4,

    /// <include file='FocusPreset.xml' path='doc/member[@name="FocusPreset.FocusPreset_AutoHyperfocal"]/*' />
    FocusPreset_AutoHyperfocal = 5,
}
