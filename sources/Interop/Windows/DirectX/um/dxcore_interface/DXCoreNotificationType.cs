// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreNotificationType.xml' path='doc/member[@name="DXCoreNotificationType"]/*' />
[NativeTypeName("uint32_t")]
[SupportedOSPlatform("windows10.0.19041.0")]
public enum DXCoreNotificationType : uint
{
    /// <include file='DXCoreNotificationType.xml' path='doc/member[@name="DXCoreNotificationType.AdapterListStale"]/*' />
    AdapterListStale = 0,

    /// <include file='DXCoreNotificationType.xml' path='doc/member[@name="DXCoreNotificationType.AdapterNoLongerValid"]/*' />
    AdapterNoLongerValid = 1,

    /// <include file='DXCoreNotificationType.xml' path='doc/member[@name="DXCoreNotificationType.AdapterBudgetChange"]/*' />
    AdapterBudgetChange = 2,

    /// <include file='DXCoreNotificationType.xml' path='doc/member[@name="DXCoreNotificationType.AdapterHardwareContentProtectionTeardown"]/*' />
    AdapterHardwareContentProtectionTeardown = 3,
}
