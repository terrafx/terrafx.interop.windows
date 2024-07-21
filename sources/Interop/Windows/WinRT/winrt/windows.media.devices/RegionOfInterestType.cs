// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RegionOfInterestType.xml' path='doc/member[@name="RegionOfInterestType"]/*' />
public enum RegionOfInterestType
{
    /// <include file='RegionOfInterestType.xml' path='doc/member[@name="RegionOfInterestType.RegionOfInterestType_Unknown"]/*' />
    RegionOfInterestType_Unknown = 0,

    /// <include file='RegionOfInterestType.xml' path='doc/member[@name="RegionOfInterestType.RegionOfInterestType_Face"]/*' />
    RegionOfInterestType_Face = 1,
}
