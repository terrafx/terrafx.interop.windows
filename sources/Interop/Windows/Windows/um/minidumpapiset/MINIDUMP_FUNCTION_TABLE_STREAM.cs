// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_FUNCTION_TABLE_STREAM.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_STREAM"]/*' />
public partial struct MINIDUMP_FUNCTION_TABLE_STREAM
{
    /// <include file='MINIDUMP_FUNCTION_TABLE_STREAM.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_STREAM.SizeOfHeader"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfHeader;

    /// <include file='MINIDUMP_FUNCTION_TABLE_STREAM.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_STREAM.SizeOfDescriptor"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfDescriptor;

    /// <include file='MINIDUMP_FUNCTION_TABLE_STREAM.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_STREAM.SizeOfNativeDescriptor"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfNativeDescriptor;

    /// <include file='MINIDUMP_FUNCTION_TABLE_STREAM.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_STREAM.SizeOfFunctionEntry"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfFunctionEntry;

    /// <include file='MINIDUMP_FUNCTION_TABLE_STREAM.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_STREAM.NumberOfDescriptors"]/*' />
    [NativeTypeName("ULONG32")]
    public uint NumberOfDescriptors;

    /// <include file='MINIDUMP_FUNCTION_TABLE_STREAM.xml' path='doc/member[@name="MINIDUMP_FUNCTION_TABLE_STREAM.SizeOfAlignPad"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfAlignPad;
}
