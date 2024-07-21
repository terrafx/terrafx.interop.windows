// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintWorkflowPdlConversionType.xml' path='doc/member[@name="PrintWorkflowPdlConversionType"]/*' />
public enum PrintWorkflowPdlConversionType
{
    /// <include file='PrintWorkflowPdlConversionType.xml' path='doc/member[@name="PrintWorkflowPdlConversionType.PrintWorkflowPdlConversionType_XpsToPdf"]/*' />
    PrintWorkflowPdlConversionType_XpsToPdf = 0,

    /// <include file='PrintWorkflowPdlConversionType.xml' path='doc/member[@name="PrintWorkflowPdlConversionType.PrintWorkflowPdlConversionType_XpsToPwgr"]/*' />
    PrintWorkflowPdlConversionType_XpsToPwgr = 1,

    /// <include file='PrintWorkflowPdlConversionType.xml' path='doc/member[@name="PrintWorkflowPdlConversionType.PrintWorkflowPdlConversionType_XpsToPclm"]/*' />
    PrintWorkflowPdlConversionType_XpsToPclm = 2,

    /// <include file='PrintWorkflowPdlConversionType.xml' path='doc/member[@name="PrintWorkflowPdlConversionType.PrintWorkflowPdlConversionType_XpsToTiff"]/*' />
    PrintWorkflowPdlConversionType_XpsToTiff = 3,
}
