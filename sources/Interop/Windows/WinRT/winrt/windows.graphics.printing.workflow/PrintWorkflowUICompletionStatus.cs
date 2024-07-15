// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintWorkflowUICompletionStatus.xml' path='doc/member[@name="PrintWorkflowUICompletionStatus"]/*' />
public enum PrintWorkflowUICompletionStatus
{
    /// <include file='PrintWorkflowUICompletionStatus.xml' path='doc/member[@name="PrintWorkflowUICompletionStatus.PrintWorkflowUICompletionStatus_Completed"]/*' />
    PrintWorkflowUICompletionStatus_Completed = 0,

    /// <include file='PrintWorkflowUICompletionStatus.xml' path='doc/member[@name="PrintWorkflowUICompletionStatus.PrintWorkflowUICompletionStatus_LaunchFailed"]/*' />
    PrintWorkflowUICompletionStatus_LaunchFailed = 1,

    /// <include file='PrintWorkflowUICompletionStatus.xml' path='doc/member[@name="PrintWorkflowUICompletionStatus.PrintWorkflowUICompletionStatus_JobFailed"]/*' />
    PrintWorkflowUICompletionStatus_JobFailed = 2,

    /// <include file='PrintWorkflowUICompletionStatus.xml' path='doc/member[@name="PrintWorkflowUICompletionStatus.PrintWorkflowUICompletionStatus_UserCanceled"]/*' />
    PrintWorkflowUICompletionStatus_UserCanceled = 3,
}
