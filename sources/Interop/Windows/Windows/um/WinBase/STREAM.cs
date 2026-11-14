// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class STREAM
{
    /// <include file='STREAM.xml' path='doc/member[@name="STREAM.STREAM_NORMAL_ATTRIBUTE"]/*' />
    [NativeTypeName("#define STREAM_NORMAL_ATTRIBUTE 0x00000000")]
    public const int STREAM_NORMAL_ATTRIBUTE = 0x00000000;

    /// <include file='STREAM.xml' path='doc/member[@name="STREAM.STREAM_MODIFIED_WHEN_READ"]/*' />
    [NativeTypeName("#define STREAM_MODIFIED_WHEN_READ 0x00000001")]
    public const int STREAM_MODIFIED_WHEN_READ = 0x00000001;

    /// <include file='STREAM.xml' path='doc/member[@name="STREAM.STREAM_CONTAINS_SECURITY"]/*' />
    [NativeTypeName("#define STREAM_CONTAINS_SECURITY 0x00000002")]
    public const int STREAM_CONTAINS_SECURITY = 0x00000002;

    /// <include file='STREAM.xml' path='doc/member[@name="STREAM.STREAM_CONTAINS_PROPERTIES"]/*' />
    [NativeTypeName("#define STREAM_CONTAINS_PROPERTIES 0x00000004")]
    public const int STREAM_CONTAINS_PROPERTIES = 0x00000004;

    /// <include file='STREAM.xml' path='doc/member[@name="STREAM.STREAM_SPARSE_ATTRIBUTE"]/*' />
    [NativeTypeName("#define STREAM_SPARSE_ATTRIBUTE 0x00000008")]
    public const int STREAM_SPARSE_ATTRIBUTE = 0x00000008;

    /// <include file='STREAM.xml' path='doc/member[@name="STREAM.STREAM_CONTAINS_GHOSTED_FILE_EXTENTS"]/*' />
    [NativeTypeName("#define STREAM_CONTAINS_GHOSTED_FILE_EXTENTS 0x00000010")]
    public const int STREAM_CONTAINS_GHOSTED_FILE_EXTENTS = 0x00000010;
}
