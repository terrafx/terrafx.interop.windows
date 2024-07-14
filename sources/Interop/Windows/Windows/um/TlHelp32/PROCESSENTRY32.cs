// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROCESSENTRY32.xml' path='doc/member[@name="PROCESSENTRY32"]/*' />
public partial struct PROCESSENTRY32
{
    /// <include file='PROCESSENTRY32.xml' path='doc/member[@name="PROCESSENTRY32.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='PROCESSENTRY32.xml' path='doc/member[@name="PROCESSENTRY32.cntUsage"]/*' />
    [NativeTypeName("DWORD")]
    public uint cntUsage;

    /// <include file='PROCESSENTRY32.xml' path='doc/member[@name="PROCESSENTRY32.th32ProcessID"]/*' />
    [NativeTypeName("DWORD")]
    public uint th32ProcessID;

    /// <include file='PROCESSENTRY32.xml' path='doc/member[@name="PROCESSENTRY32.th32DefaultHeapID"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint th32DefaultHeapID;

    /// <include file='PROCESSENTRY32.xml' path='doc/member[@name="PROCESSENTRY32.th32ModuleID"]/*' />
    [NativeTypeName("DWORD")]
    public uint th32ModuleID;

    /// <include file='PROCESSENTRY32.xml' path='doc/member[@name="PROCESSENTRY32.cntThreads"]/*' />
    [NativeTypeName("DWORD")]
    public uint cntThreads;

    /// <include file='PROCESSENTRY32.xml' path='doc/member[@name="PROCESSENTRY32.th32ParentProcessID"]/*' />
    [NativeTypeName("DWORD")]
    public uint th32ParentProcessID;

    /// <include file='PROCESSENTRY32.xml' path='doc/member[@name="PROCESSENTRY32.pcPriClassBase"]/*' />
    [NativeTypeName("LONG")]
    public int pcPriClassBase;

    /// <include file='PROCESSENTRY32.xml' path='doc/member[@name="PROCESSENTRY32.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='PROCESSENTRY32.xml' path='doc/member[@name="PROCESSENTRY32.szExeFile"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _szExeFile_e__FixedBuffer szExeFile;

    /// <include file='_szExeFile_e__FixedBuffer.xml' path='doc/member[@name="_szExeFile_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _szExeFile_e__FixedBuffer
    {
        public sbyte e0;
    }
}
