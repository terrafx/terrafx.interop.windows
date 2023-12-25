// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FocusMode.xml' path='doc/member[@name="FocusMode"]/*' />
public enum FocusMode
{
    /// <include file='FocusMode.xml' path='doc/member[@name="FocusMode.FocusMode_Auto"]/*' />
    FocusMode_Auto = 0,

    /// <include file='FocusMode.xml' path='doc/member[@name="FocusMode.FocusMode_Single"]/*' />
    FocusMode_Single = 1,

    /// <include file='FocusMode.xml' path='doc/member[@name="FocusMode.FocusMode_Continuous"]/*' />
    FocusMode_Continuous = 2,

    /// <include file='FocusMode.xml' path='doc/member[@name="FocusMode.FocusMode_Manual"]/*' />
    FocusMode_Manual = 3,
}
