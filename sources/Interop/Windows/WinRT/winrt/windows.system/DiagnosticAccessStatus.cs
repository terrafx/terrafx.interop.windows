// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DiagnosticAccessStatus.xml' path='doc/member[@name="DiagnosticAccessStatus"]/*' />
public enum DiagnosticAccessStatus
{
    /// <include file='DiagnosticAccessStatus.xml' path='doc/member[@name="DiagnosticAccessStatus.DiagnosticAccessStatus_Unspecified"]/*' />
    DiagnosticAccessStatus_Unspecified = 0,

    /// <include file='DiagnosticAccessStatus.xml' path='doc/member[@name="DiagnosticAccessStatus.DiagnosticAccessStatus_Denied"]/*' />
    DiagnosticAccessStatus_Denied = 1,

    /// <include file='DiagnosticAccessStatus.xml' path='doc/member[@name="DiagnosticAccessStatus.DiagnosticAccessStatus_Limited"]/*' />
    DiagnosticAccessStatus_Limited = 2,

    /// <include file='DiagnosticAccessStatus.xml' path='doc/member[@name="DiagnosticAccessStatus.DiagnosticAccessStatus_Allowed"]/*' />
    DiagnosticAccessStatus_Allowed = 3,
}
