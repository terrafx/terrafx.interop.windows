// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.extensions.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='Print3DWorkflowStatus.xml' path='doc/member[@name="Print3DWorkflowStatus"]/*' />
public enum Print3DWorkflowStatus
{
    /// <include file='Print3DWorkflowStatus.xml' path='doc/member[@name="Print3DWorkflowStatus.Print3DWorkflowStatus_Abandoned"]/*' />
    Print3DWorkflowStatus_Abandoned = 0,

    /// <include file='Print3DWorkflowStatus.xml' path='doc/member[@name="Print3DWorkflowStatus.Print3DWorkflowStatus_Canceled"]/*' />
    Print3DWorkflowStatus_Canceled = 1,

    /// <include file='Print3DWorkflowStatus.xml' path='doc/member[@name="Print3DWorkflowStatus.Print3DWorkflowStatus_Failed"]/*' />
    Print3DWorkflowStatus_Failed = 2,

    /// <include file='Print3DWorkflowStatus.xml' path='doc/member[@name="Print3DWorkflowStatus.Print3DWorkflowStatus_Slicing"]/*' />
    Print3DWorkflowStatus_Slicing = 3,

    /// <include file='Print3DWorkflowStatus.xml' path='doc/member[@name="Print3DWorkflowStatus.Print3DWorkflowStatus_Submitted"]/*' />
    Print3DWorkflowStatus_Submitted = 4,
}
