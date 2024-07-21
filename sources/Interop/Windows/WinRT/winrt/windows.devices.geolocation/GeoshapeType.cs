// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GeoshapeType.xml' path='doc/member[@name="GeoshapeType"]/*' />
public enum GeoshapeType
{
    /// <include file='GeoshapeType.xml' path='doc/member[@name="GeoshapeType.GeoshapeType_Geopoint"]/*' />
    GeoshapeType_Geopoint = 0,

    /// <include file='GeoshapeType.xml' path='doc/member[@name="GeoshapeType.GeoshapeType_Geocircle"]/*' />
    GeoshapeType_Geocircle = 1,

    /// <include file='GeoshapeType.xml' path='doc/member[@name="GeoshapeType.GeoshapeType_Geopath"]/*' />
    GeoshapeType_Geopath = 2,

    /// <include file='GeoshapeType.xml' path='doc/member[@name="GeoshapeType.GeoshapeType_GeoboundingBox"]/*' />
    GeoshapeType_GeoboundingBox = 3,
}
