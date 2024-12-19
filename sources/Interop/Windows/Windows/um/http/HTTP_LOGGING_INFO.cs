// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO"]/*' />
public unsafe partial struct HTTP_LOGGING_INFO
{
    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.Flags"]/*' />
    public HTTP_PROPERTY_FLAGS Flags;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.LoggingFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint LoggingFlags;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.SoftwareName"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* SoftwareName;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.SoftwareNameLength"]/*' />
    public ushort SoftwareNameLength;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.DirectoryNameLength"]/*' />
    public ushort DirectoryNameLength;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.DirectoryName"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* DirectoryName;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.Format"]/*' />
    public HTTP_LOGGING_TYPE Format;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.Fields"]/*' />
    [NativeTypeName("ULONG")]
    public uint Fields;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.pExtFields"]/*' />
    [NativeTypeName("PVOID")]
    public void* pExtFields;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.NumOfExtFields"]/*' />
    public ushort NumOfExtFields;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.MaxRecordSize"]/*' />
    public ushort MaxRecordSize;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.RolloverType"]/*' />
    public HTTP_LOGGING_ROLLOVER_TYPE RolloverType;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.RolloverSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint RolloverSize;

    /// <include file='HTTP_LOGGING_INFO.xml' path='doc/member[@name="HTTP_LOGGING_INFO.pSecurityDescriptor"]/*' />
    [NativeTypeName("PSECURITY_DESCRIPTOR")]
    public void* pSecurityDescriptor;
}
