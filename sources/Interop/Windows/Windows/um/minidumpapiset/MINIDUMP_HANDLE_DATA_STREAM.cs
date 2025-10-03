// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_HANDLE_DATA_STREAM.xml' path='doc/member[@name="MINIDUMP_HANDLE_DATA_STREAM"]/*' />
public partial struct MINIDUMP_HANDLE_DATA_STREAM
{
    /// <include file='MINIDUMP_HANDLE_DATA_STREAM.xml' path='doc/member[@name="MINIDUMP_HANDLE_DATA_STREAM.SizeOfHeader"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfHeader;

    /// <include file='MINIDUMP_HANDLE_DATA_STREAM.xml' path='doc/member[@name="MINIDUMP_HANDLE_DATA_STREAM.SizeOfDescriptor"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfDescriptor;

    /// <include file='MINIDUMP_HANDLE_DATA_STREAM.xml' path='doc/member[@name="MINIDUMP_HANDLE_DATA_STREAM.NumberOfDescriptors"]/*' />
    [NativeTypeName("ULONG32")]
    public uint NumberOfDescriptors;

    /// <include file='MINIDUMP_HANDLE_DATA_STREAM.xml' path='doc/member[@name="MINIDUMP_HANDLE_DATA_STREAM.Reserved"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Reserved;
}
