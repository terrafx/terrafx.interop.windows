// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintWorkflowPrinterJobStatus.xml' path='doc/member[@name="PrintWorkflowPrinterJobStatus"]/*' />
public enum PrintWorkflowPrinterJobStatus
{
    /// <include file='PrintWorkflowPrinterJobStatus.xml' path='doc/member[@name="PrintWorkflowPrinterJobStatus.PrintWorkflowPrinterJobStatus_Error"]/*' />
    PrintWorkflowPrinterJobStatus_Error = 0,

    /// <include file='PrintWorkflowPrinterJobStatus.xml' path='doc/member[@name="PrintWorkflowPrinterJobStatus.PrintWorkflowPrinterJobStatus_Aborted"]/*' />
    PrintWorkflowPrinterJobStatus_Aborted = 1,

    /// <include file='PrintWorkflowPrinterJobStatus.xml' path='doc/member[@name="PrintWorkflowPrinterJobStatus.PrintWorkflowPrinterJobStatus_InProgress"]/*' />
    PrintWorkflowPrinterJobStatus_InProgress = 2,

    /// <include file='PrintWorkflowPrinterJobStatus.xml' path='doc/member[@name="PrintWorkflowPrinterJobStatus.PrintWorkflowPrinterJobStatus_Completed"]/*' />
    PrintWorkflowPrinterJobStatus_Completed = 3,
}
