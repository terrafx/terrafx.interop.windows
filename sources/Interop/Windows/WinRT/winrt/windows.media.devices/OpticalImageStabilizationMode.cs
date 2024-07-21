// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='OpticalImageStabilizationMode.xml' path='doc/member[@name="OpticalImageStabilizationMode"]/*' />
public enum OpticalImageStabilizationMode
{
    /// <include file='OpticalImageStabilizationMode.xml' path='doc/member[@name="OpticalImageStabilizationMode.OpticalImageStabilizationMode_Off"]/*' />
    OpticalImageStabilizationMode_Off = 0,

    /// <include file='OpticalImageStabilizationMode.xml' path='doc/member[@name="OpticalImageStabilizationMode.OpticalImageStabilizationMode_On"]/*' />
    OpticalImageStabilizationMode_On = 1,

    /// <include file='OpticalImageStabilizationMode.xml' path='doc/member[@name="OpticalImageStabilizationMode.OpticalImageStabilizationMode_Auto"]/*' />
    OpticalImageStabilizationMode_Auto = 2,
}
