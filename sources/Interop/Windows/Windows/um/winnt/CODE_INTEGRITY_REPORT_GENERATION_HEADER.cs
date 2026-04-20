// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CODE_INTEGRITY_REPORT_GENERATION_HEADER.xml' path='doc/member[@name="CODE_INTEGRITY_REPORT_GENERATION_HEADER"]/*' />
public partial struct CODE_INTEGRITY_REPORT_GENERATION_HEADER
{
    /// <include file='CODE_INTEGRITY_REPORT_GENERATION_HEADER.xml' path='doc/member[@name="CODE_INTEGRITY_REPORT_GENERATION_HEADER.Version"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Version;

    /// <include file='CODE_INTEGRITY_REPORT_GENERATION_HEADER.xml' path='doc/member[@name="CODE_INTEGRITY_REPORT_GENERATION_HEADER.Reserved"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Reserved;

    /// <include file='CODE_INTEGRITY_REPORT_GENERATION_HEADER.xml' path='doc/member[@name="CODE_INTEGRITY_REPORT_GENERATION_HEADER.RecordSize"]/*' />
    [NativeTypeName("UINT32")]
    public uint RecordSize;

    /// <include file='CODE_INTEGRITY_REPORT_GENERATION_HEADER.xml' path='doc/member[@name="CODE_INTEGRITY_REPORT_GENERATION_HEADER.CommitTime"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CommitTime;
}
