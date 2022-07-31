// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE"]/*' />
public unsafe partial struct EVENTSFORLOGFILE
{
    /// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE.ulSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulSize;

    /// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE.szLogicalLogFile"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort szLogicalLogFile[256];

    /// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE.ulNumRecords"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulNumRecords;

    /// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE.pEventLogRecords"]/*' />
    [NativeTypeName("EVENTLOGRECORD[]")]
    public EVENTLOGRECORD pEventLogRecords;
}
