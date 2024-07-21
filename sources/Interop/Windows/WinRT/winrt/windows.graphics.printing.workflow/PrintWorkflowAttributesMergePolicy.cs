// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintWorkflowAttributesMergePolicy.xml' path='doc/member[@name="PrintWorkflowAttributesMergePolicy"]/*' />
public enum PrintWorkflowAttributesMergePolicy
{
    /// <include file='PrintWorkflowAttributesMergePolicy.xml' path='doc/member[@name="PrintWorkflowAttributesMergePolicy.PrintWorkflowAttributesMergePolicy_MergePreferPrintTicketOnConflict"]/*' />
    PrintWorkflowAttributesMergePolicy_MergePreferPrintTicketOnConflict = 0,

    /// <include file='PrintWorkflowAttributesMergePolicy.xml' path='doc/member[@name="PrintWorkflowAttributesMergePolicy.PrintWorkflowAttributesMergePolicy_MergePreferPsaOnConflict"]/*' />
    PrintWorkflowAttributesMergePolicy_MergePreferPsaOnConflict = 1,

    /// <include file='PrintWorkflowAttributesMergePolicy.xml' path='doc/member[@name="PrintWorkflowAttributesMergePolicy.PrintWorkflowAttributesMergePolicy_DoNotMergeWithPrintTicket"]/*' />
    PrintWorkflowAttributesMergePolicy_DoNotMergeWithPrintTicket = 2,
}
