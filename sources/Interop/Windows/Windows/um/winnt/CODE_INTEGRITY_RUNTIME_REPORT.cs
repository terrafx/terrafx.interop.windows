// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CODE_INTEGRITY_RUNTIME_REPORT.xml' path='doc/member[@name="CODE_INTEGRITY_RUNTIME_REPORT"]/*' />
public partial struct CODE_INTEGRITY_RUNTIME_REPORT
{
    /// <include file='CODE_INTEGRITY_RUNTIME_REPORT.xml' path='doc/member[@name="CODE_INTEGRITY_RUNTIME_REPORT.Header"]/*' />
    public RUNTIME_REPORT_HEADER Header;

    /// <include file='CODE_INTEGRITY_RUNTIME_REPORT.xml' path='doc/member[@name="CODE_INTEGRITY_RUNTIME_REPORT.CurrentGeneration"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CurrentGeneration;

    /// <include file='CODE_INTEGRITY_RUNTIME_REPORT.xml' path='doc/member[@name="CODE_INTEGRITY_RUNTIME_REPORT.NumberOfGenerations"]/*' />
    [NativeTypeName("UINT32")]
    public uint NumberOfGenerations;
}
