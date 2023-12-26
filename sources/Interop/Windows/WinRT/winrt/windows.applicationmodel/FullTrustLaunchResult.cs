// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FullTrustLaunchResult.xml' path='doc/member[@name="FullTrustLaunchResult"]/*' />
public enum FullTrustLaunchResult
{
    /// <include file='FullTrustLaunchResult.xml' path='doc/member[@name="FullTrustLaunchResult.FullTrustLaunchResult_Success"]/*' />
    FullTrustLaunchResult_Success = 0,

    /// <include file='FullTrustLaunchResult.xml' path='doc/member[@name="FullTrustLaunchResult.FullTrustLaunchResult_AccessDenied"]/*' />
    FullTrustLaunchResult_AccessDenied = 1,

    /// <include file='FullTrustLaunchResult.xml' path='doc/member[@name="FullTrustLaunchResult.FullTrustLaunchResult_FileNotFound"]/*' />
    FullTrustLaunchResult_FileNotFound = 2,

    /// <include file='FullTrustLaunchResult.xml' path='doc/member[@name="FullTrustLaunchResult.FullTrustLaunchResult_Unknown"]/*' />
    FullTrustLaunchResult_Unknown = 3,
}
