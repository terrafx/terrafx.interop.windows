// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintWorkflowJobIssueKind.xml' path='doc/member[@name="PrintWorkflowJobIssueKind"]/*' />
public enum PrintWorkflowJobIssueKind
{
    /// <include file='PrintWorkflowJobIssueKind.xml' path='doc/member[@name="PrintWorkflowJobIssueKind.PrintWorkflowJobIssueKind_Other"]/*' />
    PrintWorkflowJobIssueKind_Other = 0,

    /// <include file='PrintWorkflowJobIssueKind.xml' path='doc/member[@name="PrintWorkflowJobIssueKind.PrintWorkflowJobIssueKind_AttentionRequired"]/*' />
    PrintWorkflowJobIssueKind_AttentionRequired = 1,

    /// <include file='PrintWorkflowJobIssueKind.xml' path='doc/member[@name="PrintWorkflowJobIssueKind.PrintWorkflowJobIssueKind_DoorOpen"]/*' />
    PrintWorkflowJobIssueKind_DoorOpen = 2,

    /// <include file='PrintWorkflowJobIssueKind.xml' path='doc/member[@name="PrintWorkflowJobIssueKind.PrintWorkflowJobIssueKind_MarkerSupplyLow"]/*' />
    PrintWorkflowJobIssueKind_MarkerSupplyLow = 3,

    /// <include file='PrintWorkflowJobIssueKind.xml' path='doc/member[@name="PrintWorkflowJobIssueKind.PrintWorkflowJobIssueKind_MarkerSupplyEmpty"]/*' />
    PrintWorkflowJobIssueKind_MarkerSupplyEmpty = 4,

    /// <include file='PrintWorkflowJobIssueKind.xml' path='doc/member[@name="PrintWorkflowJobIssueKind.PrintWorkflowJobIssueKind_MediaJam"]/*' />
    PrintWorkflowJobIssueKind_MediaJam = 5,

    /// <include file='PrintWorkflowJobIssueKind.xml' path='doc/member[@name="PrintWorkflowJobIssueKind.PrintWorkflowJobIssueKind_MediaEmpty"]/*' />
    PrintWorkflowJobIssueKind_MediaEmpty = 6,

    /// <include file='PrintWorkflowJobIssueKind.xml' path='doc/member[@name="PrintWorkflowJobIssueKind.PrintWorkflowJobIssueKind_MediaLow"]/*' />
    PrintWorkflowJobIssueKind_MediaLow = 7,

    /// <include file='PrintWorkflowJobIssueKind.xml' path='doc/member[@name="PrintWorkflowJobIssueKind.PrintWorkflowJobIssueKind_OutputAreaAlmostFull"]/*' />
    PrintWorkflowJobIssueKind_OutputAreaAlmostFull = 8,

    /// <include file='PrintWorkflowJobIssueKind.xml' path='doc/member[@name="PrintWorkflowJobIssueKind.PrintWorkflowJobIssueKind_OutputAreaFull"]/*' />
    PrintWorkflowJobIssueKind_OutputAreaFull = 9,

    /// <include file='PrintWorkflowJobIssueKind.xml' path='doc/member[@name="PrintWorkflowJobIssueKind.PrintWorkflowJobIssueKind_JobPrintingError"]/*' />
    PrintWorkflowJobIssueKind_JobPrintingError = 10,
}
