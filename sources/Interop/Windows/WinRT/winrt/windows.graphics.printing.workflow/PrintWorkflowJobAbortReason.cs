// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintWorkflowJobAbortReason.xml' path='doc/member[@name="PrintWorkflowJobAbortReason"]/*' />
public enum PrintWorkflowJobAbortReason
{
    /// <include file='PrintWorkflowJobAbortReason.xml' path='doc/member[@name="PrintWorkflowJobAbortReason.PrintWorkflowJobAbortReason_JobFailed"]/*' />
    PrintWorkflowJobAbortReason_JobFailed = 0,

    /// <include file='PrintWorkflowJobAbortReason.xml' path='doc/member[@name="PrintWorkflowJobAbortReason.PrintWorkflowJobAbortReason_UserCanceled"]/*' />
    PrintWorkflowJobAbortReason_UserCanceled = 1,
}
