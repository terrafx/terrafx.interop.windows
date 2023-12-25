// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GraphicsTrustStatus.xml' path='doc/member[@name="GraphicsTrustStatus"]/*' />
public enum GraphicsTrustStatus
{
    /// <include file='GraphicsTrustStatus.xml' path='doc/member[@name="GraphicsTrustStatus.GraphicsTrustStatus_TrustNotRequired"]/*' />
    GraphicsTrustStatus_TrustNotRequired = 0,

    /// <include file='GraphicsTrustStatus.xml' path='doc/member[@name="GraphicsTrustStatus.GraphicsTrustStatus_TrustEstablished"]/*' />
    GraphicsTrustStatus_TrustEstablished = 1,

    /// <include file='GraphicsTrustStatus.xml' path='doc/member[@name="GraphicsTrustStatus.GraphicsTrustStatus_EnvironmentNotSupported"]/*' />
    GraphicsTrustStatus_EnvironmentNotSupported = 2,

    /// <include file='GraphicsTrustStatus.xml' path='doc/member[@name="GraphicsTrustStatus.GraphicsTrustStatus_DriverNotSupported"]/*' />
    GraphicsTrustStatus_DriverNotSupported = 3,

    /// <include file='GraphicsTrustStatus.xml' path='doc/member[@name="GraphicsTrustStatus.GraphicsTrustStatus_DriverSigningFailure"]/*' />
    GraphicsTrustStatus_DriverSigningFailure = 4,

    /// <include file='GraphicsTrustStatus.xml' path='doc/member[@name="GraphicsTrustStatus.GraphicsTrustStatus_UnknownFailure"]/*' />
    GraphicsTrustStatus_UnknownFailure = 5,
}
