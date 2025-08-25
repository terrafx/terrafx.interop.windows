// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CREATEFILE3_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE3_EXTENDED_PARAMETERS"]/*' />
public unsafe partial struct CREATEFILE3_EXTENDED_PARAMETERS
{
    /// <include file='CREATEFILE3_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE3_EXTENDED_PARAMETERS.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='CREATEFILE3_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE3_EXTENDED_PARAMETERS.dwFileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;

    /// <include file='CREATEFILE3_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE3_EXTENDED_PARAMETERS.dwFileFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFileFlags;

    /// <include file='CREATEFILE3_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE3_EXTENDED_PARAMETERS.dwSecurityQosFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSecurityQosFlags;

    /// <include file='CREATEFILE3_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE3_EXTENDED_PARAMETERS.lpSecurityAttributes"]/*' />
    [NativeTypeName("LPSECURITY_ATTRIBUTES")]
    public SECURITY_ATTRIBUTES* lpSecurityAttributes;

    /// <include file='CREATEFILE3_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE3_EXTENDED_PARAMETERS.hTemplateFile"]/*' />
    public HANDLE hTemplateFile;
}
