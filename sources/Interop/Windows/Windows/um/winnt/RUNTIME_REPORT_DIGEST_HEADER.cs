// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='RUNTIME_REPORT_DIGEST_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_DIGEST_HEADER"]/*' />
public partial struct RUNTIME_REPORT_DIGEST_HEADER
{
    /// <include file='RUNTIME_REPORT_DIGEST_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_DIGEST_HEADER.ReportType"]/*' />
    [NativeTypeName("UINT16")]
    public ushort ReportType;

    /// <include file='RUNTIME_REPORT_DIGEST_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_DIGEST_HEADER.Reserved"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Reserved;

    /// <include file='RUNTIME_REPORT_DIGEST_HEADER.xml' path='doc/member[@name="RUNTIME_REPORT_DIGEST_HEADER.ReportDigest"]/*' />
    [NativeTypeName("UINT8[64]")]
    public _ReportDigest_e__FixedBuffer ReportDigest;

    /// <include file='_ReportDigest_e__FixedBuffer.xml' path='doc/member[@name="_ReportDigest_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _ReportDigest_e__FixedBuffer
    {
        public byte e0;
    }
}
