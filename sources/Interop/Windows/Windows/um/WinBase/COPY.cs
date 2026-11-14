// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class COPY
{
    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_FAIL_IF_EXISTS"]/*' />
    [NativeTypeName("#define COPY_FILE_FAIL_IF_EXISTS 0x00000001")]
    public const int COPY_FILE_FAIL_IF_EXISTS = 0x00000001;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_RESTARTABLE"]/*' />
    [NativeTypeName("#define COPY_FILE_RESTARTABLE 0x00000002")]
    public const int COPY_FILE_RESTARTABLE = 0x00000002;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_OPEN_SOURCE_FOR_WRITE"]/*' />
    [NativeTypeName("#define COPY_FILE_OPEN_SOURCE_FOR_WRITE 0x00000004")]
    public const int COPY_FILE_OPEN_SOURCE_FOR_WRITE = 0x00000004;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_ALLOW_DECRYPTED_DESTINATION"]/*' />
    [NativeTypeName("#define COPY_FILE_ALLOW_DECRYPTED_DESTINATION 0x00000008")]
    public const int COPY_FILE_ALLOW_DECRYPTED_DESTINATION = 0x00000008;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_COPY_SYMLINK"]/*' />
    [NativeTypeName("#define COPY_FILE_COPY_SYMLINK 0x00000800")]
    public const int COPY_FILE_COPY_SYMLINK = 0x00000800;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_NO_BUFFERING"]/*' />
    [NativeTypeName("#define COPY_FILE_NO_BUFFERING 0x00001000")]
    public const int COPY_FILE_NO_BUFFERING = 0x00001000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_REQUEST_SECURITY_PRIVILEGES"]/*' />
    [NativeTypeName("#define COPY_FILE_REQUEST_SECURITY_PRIVILEGES 0x00002000")]
    public const int COPY_FILE_REQUEST_SECURITY_PRIVILEGES = 0x00002000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_RESUME_FROM_PAUSE"]/*' />
    [NativeTypeName("#define COPY_FILE_RESUME_FROM_PAUSE 0x00004000")]
    public const int COPY_FILE_RESUME_FROM_PAUSE = 0x00004000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_NO_OFFLOAD"]/*' />
    [NativeTypeName("#define COPY_FILE_NO_OFFLOAD 0x00040000")]
    public const int COPY_FILE_NO_OFFLOAD = 0x00040000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_IGNORE_EDP_BLOCK"]/*' />
    [NativeTypeName("#define COPY_FILE_IGNORE_EDP_BLOCK 0x00400000")]
    public const int COPY_FILE_IGNORE_EDP_BLOCK = 0x00400000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_IGNORE_SOURCE_ENCRYPTION"]/*' />
    [NativeTypeName("#define COPY_FILE_IGNORE_SOURCE_ENCRYPTION 0x00800000")]
    public const int COPY_FILE_IGNORE_SOURCE_ENCRYPTION = 0x00800000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_DONT_REQUEST_DEST_WRITE_DAC"]/*' />
    [NativeTypeName("#define COPY_FILE_DONT_REQUEST_DEST_WRITE_DAC 0x02000000")]
    public const int COPY_FILE_DONT_REQUEST_DEST_WRITE_DAC = 0x02000000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_REQUEST_COMPRESSED_TRAFFIC"]/*' />
    [NativeTypeName("#define COPY_FILE_REQUEST_COMPRESSED_TRAFFIC 0x10000000")]
    public const int COPY_FILE_REQUEST_COMPRESSED_TRAFFIC = 0x10000000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_OPEN_AND_COPY_REPARSE_POINT"]/*' />
    [NativeTypeName("#define COPY_FILE_OPEN_AND_COPY_REPARSE_POINT 0x00200000")]
    public const int COPY_FILE_OPEN_AND_COPY_REPARSE_POINT = 0x00200000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_DIRECTORY"]/*' />
    [NativeTypeName("#define COPY_FILE_DIRECTORY 0x00000080")]
    public const int COPY_FILE_DIRECTORY = 0x00000080;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_SKIP_ALTERNATE_STREAMS"]/*' />
    [NativeTypeName("#define COPY_FILE_SKIP_ALTERNATE_STREAMS 0x00008000")]
    public const int COPY_FILE_SKIP_ALTERNATE_STREAMS = 0x00008000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_DISABLE_PRE_ALLOCATION"]/*' />
    [NativeTypeName("#define COPY_FILE_DISABLE_PRE_ALLOCATION 0x04000000")]
    public const int COPY_FILE_DISABLE_PRE_ALLOCATION = 0x04000000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_ENABLE_LOW_FREE_SPACE_MODE"]/*' />
    [NativeTypeName("#define COPY_FILE_ENABLE_LOW_FREE_SPACE_MODE 0x08000000")]
    public const int COPY_FILE_ENABLE_LOW_FREE_SPACE_MODE = 0x08000000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_ENABLE_SPARSE_COPY"]/*' />
    [NativeTypeName("#define COPY_FILE_ENABLE_SPARSE_COPY 0x20000000")]
    public const int COPY_FILE_ENABLE_SPARSE_COPY = 0x20000000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE_DISABLE_SPARSE_COPY"]/*' />
    [NativeTypeName("#define COPY_FILE_DISABLE_SPARSE_COPY 0x80000000")]
    public const uint COPY_FILE_DISABLE_SPARSE_COPY = 0x80000000;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE2_V2_DONT_COPY_JUNCTIONS"]/*' />
    [NativeTypeName("#define COPY_FILE2_V2_DONT_COPY_JUNCTIONS 0x00000001")]
    public const int COPY_FILE2_V2_DONT_COPY_JUNCTIONS = 0x00000001;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE2_V2_DISABLE_BLOCK_CLONING"]/*' />
    [NativeTypeName("#define COPY_FILE2_V2_DISABLE_BLOCK_CLONING 0x00000002")]
    public const int COPY_FILE2_V2_DISABLE_BLOCK_CLONING = 0x00000002;

    /// <include file='COPY.xml' path='doc/member[@name="COPY.COPY_FILE2_V2_VALID_FLAGS"]/*' />
    [NativeTypeName("#define COPY_FILE2_V2_VALID_FLAGS (COPY_FILE2_V2_DONT_COPY_JUNCTIONS)         \\\r\n |  (COPY_FILE2_V2_DISABLE_BLOCK_CLONING)")]
    public const int COPY_FILE2_V2_VALID_FLAGS = (0x00000001) | (0x00000002);
}
