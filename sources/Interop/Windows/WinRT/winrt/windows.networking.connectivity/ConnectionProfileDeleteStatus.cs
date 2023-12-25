// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ConnectionProfileDeleteStatus.xml' path='doc/member[@name="ConnectionProfileDeleteStatus"]/*' />
public enum ConnectionProfileDeleteStatus
{
    /// <include file='ConnectionProfileDeleteStatus.xml' path='doc/member[@name="ConnectionProfileDeleteStatus.ConnectionProfileDeleteStatus_Success"]/*' />
    ConnectionProfileDeleteStatus_Success = 0,

    /// <include file='ConnectionProfileDeleteStatus.xml' path='doc/member[@name="ConnectionProfileDeleteStatus.ConnectionProfileDeleteStatus_DeniedByUser"]/*' />
    ConnectionProfileDeleteStatus_DeniedByUser = 1,

    /// <include file='ConnectionProfileDeleteStatus.xml' path='doc/member[@name="ConnectionProfileDeleteStatus.ConnectionProfileDeleteStatus_DeniedBySystem"]/*' />
    ConnectionProfileDeleteStatus_DeniedBySystem = 2,

    /// <include file='ConnectionProfileDeleteStatus.xml' path='doc/member[@name="ConnectionProfileDeleteStatus.ConnectionProfileDeleteStatus_UnknownError"]/*' />
    ConnectionProfileDeleteStatus_UnknownError = 3,
}
