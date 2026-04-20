// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RUNTIME_REPORT_PACKAGE_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_PACKAGE_HEADER"]/*' />
public partial struct RUNTIME_REPORT_PACKAGE_HEADER
{
    /// <include file='RUNTIME_REPORT_PACKAGE_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_PACKAGE_HEADER.Magic"]/*' />
    [NativeTypeName("UINT32")]
    public uint Magic;

    /// <include file='RUNTIME_REPORT_PACKAGE_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_PACKAGE_HEADER.PackageVersion"]/*' />
    [NativeTypeName("UINT16")]
    public ushort PackageVersion;

    /// <include file='RUNTIME_REPORT_PACKAGE_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_PACKAGE_HEADER.NumberOfReports"]/*' />
    [NativeTypeName("UINT16")]
    public ushort NumberOfReports;

    /// <include file='RUNTIME_REPORT_PACKAGE_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_PACKAGE_HEADER.ReportTypesBitmap"]/*' />
    [NativeTypeName("UINT64")]
    public ulong ReportTypesBitmap;

    /// <include file='RUNTIME_REPORT_PACKAGE_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_PACKAGE_HEADER.PackageSize"]/*' />
    [NativeTypeName("UINT32")]
    public uint PackageSize;

    /// <include file='RUNTIME_REPORT_PACKAGE_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_PACKAGE_HEADER.ReportDigestType"]/*' />
    [NativeTypeName("UINT16")]
    public ushort ReportDigestType;

    /// <include file='RUNTIME_REPORT_PACKAGE_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_PACKAGE_HEADER.TotalReportDigestsSize"]/*' />
    [NativeTypeName("UINT16")]
    public ushort TotalReportDigestsSize;

    /// <include file='RUNTIME_REPORT_PACKAGE_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_PACKAGE_HEADER.Reserved"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Reserved;

    /// <include file='RUNTIME_REPORT_PACKAGE_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_PACKAGE_HEADER.SignatureScheme"]/*' />
    [NativeTypeName("UINT16")]
    public ushort SignatureScheme;

    /// <include file='RUNTIME_REPORT_PACKAGE_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_PACKAGE_HEADER.SignatureSize"]/*' />
    [NativeTypeName("UINT32")]
    public uint SignatureSize;

    /// <include file='RUNTIME_REPORT_PACKAGE_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_PACKAGE_HEADER.TotalAuthenticatedReportsSize"]/*' />
    [NativeTypeName("UINT32")]
    public uint TotalAuthenticatedReportsSize;
}
