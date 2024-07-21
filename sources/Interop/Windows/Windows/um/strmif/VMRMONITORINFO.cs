// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO"]/*' />
public partial struct VMRMONITORINFO
{
    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.guid"]/*' />
    public VMRGUID guid;

    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.rcMonitor"]/*' />
    public RECT rcMonitor;

    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.hMon"]/*' />
    public HMONITOR hMon;

    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.szDevice"]/*' />
    [NativeTypeName("wchar_t[32]")]
    public _szDevice_e__FixedBuffer szDevice;

    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.szDescription"]/*' />
    [NativeTypeName("wchar_t[256]")]
    public _szDescription_e__FixedBuffer szDescription;

    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.liDriverVersion"]/*' />
    public LARGE_INTEGER liDriverVersion;

    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.dwVendorId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVendorId;

    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.dwDeviceId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDeviceId;

    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.dwSubSysId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSubSysId;

    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.dwRevision"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRevision;

    /// <include file='_szDevice_e__FixedBuffer.xml' path='doc/member[@name="_szDevice_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _szDevice_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szDescription_e__FixedBuffer.xml' path='doc/member[@name="_szDescription_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _szDescription_e__FixedBuffer
    {
        public char e0;
    }
}
