// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HdcpSetProtectionResult.xml' path='doc/member[@name="HdcpSetProtectionResult"]/*' />
public enum HdcpSetProtectionResult
{
    /// <include file='HdcpSetProtectionResult.xml' path='doc/member[@name="HdcpSetProtectionResult.HdcpSetProtectionResult_Success"]/*' />
    HdcpSetProtectionResult_Success = 0,

    /// <include file='HdcpSetProtectionResult.xml' path='doc/member[@name="HdcpSetProtectionResult.HdcpSetProtectionResult_TimedOut"]/*' />
    HdcpSetProtectionResult_TimedOut = 1,

    /// <include file='HdcpSetProtectionResult.xml' path='doc/member[@name="HdcpSetProtectionResult.HdcpSetProtectionResult_NotSupported"]/*' />
    HdcpSetProtectionResult_NotSupported = 2,

    /// <include file='HdcpSetProtectionResult.xml' path='doc/member[@name="HdcpSetProtectionResult.HdcpSetProtectionResult_UnknownFailure"]/*' />
    HdcpSetProtectionResult_UnknownFailure = 3,
}
