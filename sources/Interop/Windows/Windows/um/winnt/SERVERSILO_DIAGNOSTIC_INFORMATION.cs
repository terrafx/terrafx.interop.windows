// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SERVERSILO_DIAGNOSTIC_INFORMATION.xml' path='doc/member[@name="SERVERSILO_DIAGNOSTIC_INFORMATION"]/*' />
public partial struct SERVERSILO_DIAGNOSTIC_INFORMATION
{
    /// <include file='SERVERSILO_DIAGNOSTIC_INFORMATION.xml' path='doc/member[@name="SERVERSILO_DIAGNOSTIC_INFORMATION.ReportId"]/*' />
    public Guid ReportId;

    /// <include file='SERVERSILO_DIAGNOSTIC_INFORMATION.xml' path='doc/member[@name="SERVERSILO_DIAGNOSTIC_INFORMATION.ExitStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint ExitStatus;

    /// <include file='SERVERSILO_DIAGNOSTIC_INFORMATION.xml' path='doc/member[@name="SERVERSILO_DIAGNOSTIC_INFORMATION.CriticalProcessName"]/*' />
    [NativeTypeName("WCHAR[15]")]
    public _CriticalProcessName_e__FixedBuffer CriticalProcessName;

    /// <include file='_CriticalProcessName_e__FixedBuffer.xml' path='doc/member[@name="_CriticalProcessName_e__FixedBuffer"]/*' />
    [InlineArray(15)]
    public partial struct _CriticalProcessName_e__FixedBuffer
    {
        public char e0;
    }
}
