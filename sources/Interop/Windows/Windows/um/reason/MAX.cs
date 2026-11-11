// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/reason.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MAX
{
    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_REASON_NAME_LEN"]/*' />
    [NativeTypeName("#define MAX_REASON_NAME_LEN 64")]
    public const int MAX_REASON_NAME_LEN = 64;

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_REASON_DESC_LEN"]/*' />
    [NativeTypeName("#define MAX_REASON_DESC_LEN 256")]
    public const int MAX_REASON_DESC_LEN = 256;

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_REASON_BUGID_LEN"]/*' />
    [NativeTypeName("#define MAX_REASON_BUGID_LEN 32")]
    public const int MAX_REASON_BUGID_LEN = 32;

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_REASON_COMMENT_LEN"]/*' />
    [NativeTypeName("#define MAX_REASON_COMMENT_LEN 512")]
    public const int MAX_REASON_COMMENT_LEN = 512;

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_NUM_REASONS"]/*' />
    [NativeTypeName("#define MAX_NUM_REASONS 256")]
    public const int MAX_NUM_REASONS = 256;
}
