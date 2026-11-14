// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MAX
{
    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_COMPUTERNAME_LENGTH"]/*' />
    [NativeTypeName("#define MAX_COMPUTERNAME_LENGTH 15")]
    public const int MAX_COMPUTERNAME_LENGTH = 15;

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_PROFILE_LEN"]/*' />
    [NativeTypeName("#define MAX_PROFILE_LEN 80")]
    public const int MAX_PROFILE_LEN = 80;
}
