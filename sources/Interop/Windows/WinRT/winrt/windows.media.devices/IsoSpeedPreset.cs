// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset"]/*' />
[Obsolete("IsoSpeedPreset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead")]
public enum IsoSpeedPreset
{
    /// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset.IsoSpeedPreset_Auto"]/*' />
    IsoSpeedPreset_Auto = 0,

    /// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset.IsoSpeedPreset_Iso50"]/*' />
    IsoSpeedPreset_Iso50 = 1,

    /// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset.IsoSpeedPreset_Iso80"]/*' />
    IsoSpeedPreset_Iso80 = 2,

    /// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset.IsoSpeedPreset_Iso100"]/*' />
    IsoSpeedPreset_Iso100 = 3,

    /// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset.IsoSpeedPreset_Iso200"]/*' />
    IsoSpeedPreset_Iso200 = 4,

    /// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset.IsoSpeedPreset_Iso400"]/*' />
    IsoSpeedPreset_Iso400 = 5,

    /// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset.IsoSpeedPreset_Iso800"]/*' />
    IsoSpeedPreset_Iso800 = 6,

    /// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset.IsoSpeedPreset_Iso1600"]/*' />
    IsoSpeedPreset_Iso1600 = 7,

    /// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset.IsoSpeedPreset_Iso3200"]/*' />
    IsoSpeedPreset_Iso3200 = 8,

    /// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset.IsoSpeedPreset_Iso6400"]/*' />
    IsoSpeedPreset_Iso6400 = 9,

    /// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset.IsoSpeedPreset_Iso12800"]/*' />
    IsoSpeedPreset_Iso12800 = 10,

    /// <include file='IsoSpeedPreset.xml' path='doc/member[@name="IsoSpeedPreset.IsoSpeedPreset_Iso25600"]/*' />
    IsoSpeedPreset_Iso25600 = 11,
}
