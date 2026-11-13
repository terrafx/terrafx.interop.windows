// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STI_DIAG.xml' path='doc/member[@name="STI_DIAG"]/*' />
public partial struct STI_DIAG
{
    /// <include file='STI_DIAG.xml' path='doc/member[@name="STI_DIAG.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='STI_DIAG.xml' path='doc/member[@name="STI_DIAG.dwBasicDiagCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBasicDiagCode;

    /// <include file='STI_DIAG.xml' path='doc/member[@name="STI_DIAG.dwVendorDiagCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVendorDiagCode;

    /// <include file='STI_DIAG.xml' path='doc/member[@name="STI_DIAG.dwStatusMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStatusMask;

    /// <include file='STI_DIAG.xml' path='doc/member[@name="STI_DIAG.sErrorInfo"]/*' />
    [NativeTypeName("STI_ERROR_INFO")]
    public STI_ERROR_INFOW sErrorInfo;
}
