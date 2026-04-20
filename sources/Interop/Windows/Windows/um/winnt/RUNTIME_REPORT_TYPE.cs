// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RUNTIME_REPORT_TYPE.xml' path='doc/member[@name="RUNTIME_REPORT_TYPE"]/*' />
public enum RUNTIME_REPORT_TYPE
{
    /// <include file='RUNTIME_REPORT_TYPE.xml' path='doc/member[@name="RUNTIME_REPORT_TYPE.RuntimeReportTypeDriver"]/*' />
    RuntimeReportTypeDriver = 0,

    /// <include file='RUNTIME_REPORT_TYPE.xml' path='doc/member[@name="RUNTIME_REPORT_TYPE.RuntimeReportTypeCodeIntegrity"]/*' />
    RuntimeReportTypeCodeIntegrity = 1,

    /// <include file='RUNTIME_REPORT_TYPE.xml' path='doc/member[@name="RUNTIME_REPORT_TYPE.RuntimeReportTypeMax"]/*' />
    RuntimeReportTypeMax,
}
