// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintWorkflowSessionStatus.xml' path='doc/member[@name="PrintWorkflowSessionStatus"]/*' />
public enum PrintWorkflowSessionStatus
{
    /// <include file='PrintWorkflowSessionStatus.xml' path='doc/member[@name="PrintWorkflowSessionStatus.PrintWorkflowSessionStatus_Started"]/*' />
    PrintWorkflowSessionStatus_Started = 0,

    /// <include file='PrintWorkflowSessionStatus.xml' path='doc/member[@name="PrintWorkflowSessionStatus.PrintWorkflowSessionStatus_Completed"]/*' />
    PrintWorkflowSessionStatus_Completed = 1,

    /// <include file='PrintWorkflowSessionStatus.xml' path='doc/member[@name="PrintWorkflowSessionStatus.PrintWorkflowSessionStatus_Aborted"]/*' />
    PrintWorkflowSessionStatus_Aborted = 2,

    /// <include file='PrintWorkflowSessionStatus.xml' path='doc/member[@name="PrintWorkflowSessionStatus.PrintWorkflowSessionStatus_Closed"]/*' />
    PrintWorkflowSessionStatus_Closed = 3,

    /// <include file='PrintWorkflowSessionStatus.xml' path='doc/member[@name="PrintWorkflowSessionStatus.PrintWorkflowSessionStatus_PdlDataAvailableForModification"]/*' />
    PrintWorkflowSessionStatus_PdlDataAvailableForModification = 4,
}
