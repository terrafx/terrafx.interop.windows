// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PackageUpdateAvailability.xml' path='doc/member[@name="PackageUpdateAvailability"]/*' />
public enum PackageUpdateAvailability
{
    /// <include file='PackageUpdateAvailability.xml' path='doc/member[@name="PackageUpdateAvailability.PackageUpdateAvailability_Unknown"]/*' />
    PackageUpdateAvailability_Unknown = 0,

    /// <include file='PackageUpdateAvailability.xml' path='doc/member[@name="PackageUpdateAvailability.PackageUpdateAvailability_NoUpdates"]/*' />
    PackageUpdateAvailability_NoUpdates = 1,

    /// <include file='PackageUpdateAvailability.xml' path='doc/member[@name="PackageUpdateAvailability.PackageUpdateAvailability_Available"]/*' />
    PackageUpdateAvailability_Available = 2,

    /// <include file='PackageUpdateAvailability.xml' path='doc/member[@name="PackageUpdateAvailability.PackageUpdateAvailability_Required"]/*' />
    PackageUpdateAvailability_Required = 3,

    /// <include file='PackageUpdateAvailability.xml' path='doc/member[@name="PackageUpdateAvailability.PackageUpdateAvailability_Error"]/*' />
    PackageUpdateAvailability_Error = 4,
}
