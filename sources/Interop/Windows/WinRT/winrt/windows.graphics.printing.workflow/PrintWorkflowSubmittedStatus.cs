// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintWorkflowSubmittedStatus.xml' path='doc/member[@name="PrintWorkflowSubmittedStatus"]/*' />
public enum PrintWorkflowSubmittedStatus
{
    /// <include file='PrintWorkflowSubmittedStatus.xml' path='doc/member[@name="PrintWorkflowSubmittedStatus.PrintWorkflowSubmittedStatus_Succeeded"]/*' />
    PrintWorkflowSubmittedStatus_Succeeded = 0,

    /// <include file='PrintWorkflowSubmittedStatus.xml' path='doc/member[@name="PrintWorkflowSubmittedStatus.PrintWorkflowSubmittedStatus_Canceled"]/*' />
    PrintWorkflowSubmittedStatus_Canceled = 1,

    /// <include file='PrintWorkflowSubmittedStatus.xml' path='doc/member[@name="PrintWorkflowSubmittedStatus.PrintWorkflowSubmittedStatus_Failed"]/*' />
    PrintWorkflowSubmittedStatus_Failed = 2,
}
