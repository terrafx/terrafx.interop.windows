// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MAX
{
    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_SCOPE_NAME_LEN"]/*' />
    [NativeTypeName("#define MAX_SCOPE_NAME_LEN 255")]
    public const int MAX_SCOPE_NAME_LEN = 255;

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_MIB_OFFSET"]/*' />
    [NativeTypeName("#define MAX_MIB_OFFSET 8")]
    public const int MAX_MIB_OFFSET = 8;
}
