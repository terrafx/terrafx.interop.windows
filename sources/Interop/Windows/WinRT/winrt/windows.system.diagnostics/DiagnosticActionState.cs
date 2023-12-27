// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DiagnosticActionState.xml' path='doc/member[@name="DiagnosticActionState"]/*' />
public enum DiagnosticActionState
{
    /// <include file='DiagnosticActionState.xml' path='doc/member[@name="DiagnosticActionState.DiagnosticActionState_Initializing"]/*' />
    DiagnosticActionState_Initializing = 0,

    /// <include file='DiagnosticActionState.xml' path='doc/member[@name="DiagnosticActionState.DiagnosticActionState_Downloading"]/*' />
    DiagnosticActionState_Downloading = 1,

    /// <include file='DiagnosticActionState.xml' path='doc/member[@name="DiagnosticActionState.DiagnosticActionState_VerifyingTrust"]/*' />
    DiagnosticActionState_VerifyingTrust = 2,

    /// <include file='DiagnosticActionState.xml' path='doc/member[@name="DiagnosticActionState.DiagnosticActionState_Detecting"]/*' />
    DiagnosticActionState_Detecting = 3,

    /// <include file='DiagnosticActionState.xml' path='doc/member[@name="DiagnosticActionState.DiagnosticActionState_Resolving"]/*' />
    DiagnosticActionState_Resolving = 4,

    /// <include file='DiagnosticActionState.xml' path='doc/member[@name="DiagnosticActionState.DiagnosticActionState_VerifyingResolution"]/*' />
    DiagnosticActionState_VerifyingResolution = 5,

    /// <include file='DiagnosticActionState.xml' path='doc/member[@name="DiagnosticActionState.DiagnosticActionState_Executing"]/*' />
    DiagnosticActionState_Executing = 6,
}
