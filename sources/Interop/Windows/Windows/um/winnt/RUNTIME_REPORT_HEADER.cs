// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RUNTIME_REPORT_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_HEADER"]/*' />
public partial struct RUNTIME_REPORT_HEADER
{
    /// <include file='RUNTIME_REPORT_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_HEADER.ReportType"]/*' />
    [NativeTypeName("UINT16")]
    public ushort ReportType;

    /// <include file='RUNTIME_REPORT_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_HEADER.Reserved"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Reserved;

    /// <include file='RUNTIME_REPORT_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_HEADER.ReportSize"]/*' />
    [NativeTypeName("UINT32")]
    public uint ReportSize;
}
