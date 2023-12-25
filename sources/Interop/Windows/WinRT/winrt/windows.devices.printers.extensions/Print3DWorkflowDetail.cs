// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.extensions.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='Print3DWorkflowDetail.xml' path='doc/member[@name="Print3DWorkflowDetail"]/*' />
public enum Print3DWorkflowDetail
{
    /// <include file='Print3DWorkflowDetail.xml' path='doc/member[@name="Print3DWorkflowDetail.Print3DWorkflowDetail_Unknown"]/*' />
    Print3DWorkflowDetail_Unknown = 0,

    /// <include file='Print3DWorkflowDetail.xml' path='doc/member[@name="Print3DWorkflowDetail.Print3DWorkflowDetail_ModelExceedsPrintBed"]/*' />
    Print3DWorkflowDetail_ModelExceedsPrintBed = 1,

    /// <include file='Print3DWorkflowDetail.xml' path='doc/member[@name="Print3DWorkflowDetail.Print3DWorkflowDetail_UploadFailed"]/*' />
    Print3DWorkflowDetail_UploadFailed = 2,

    /// <include file='Print3DWorkflowDetail.xml' path='doc/member[@name="Print3DWorkflowDetail.Print3DWorkflowDetail_InvalidMaterialSelection"]/*' />
    Print3DWorkflowDetail_InvalidMaterialSelection = 3,

    /// <include file='Print3DWorkflowDetail.xml' path='doc/member[@name="Print3DWorkflowDetail.Print3DWorkflowDetail_InvalidModel"]/*' />
    Print3DWorkflowDetail_InvalidModel = 4,

    /// <include file='Print3DWorkflowDetail.xml' path='doc/member[@name="Print3DWorkflowDetail.Print3DWorkflowDetail_ModelNotManifold"]/*' />
    Print3DWorkflowDetail_ModelNotManifold = 5,

    /// <include file='Print3DWorkflowDetail.xml' path='doc/member[@name="Print3DWorkflowDetail.Print3DWorkflowDetail_InvalidPrintTicket"]/*' />
    Print3DWorkflowDetail_InvalidPrintTicket = 6,
}
