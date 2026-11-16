// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class OPEN
{
    /// <include file='OPEN.xml' path='doc/member[@name="OPEN.OPEN_EXISTING"]/*' />
    [NativeTypeName("#define OPEN_EXISTING 3")]
    public const int OPEN_EXISTING = 3;

    /// <include file='OPEN.xml' path='doc/member[@name="OPEN.OPEN_ALWAYS"]/*' />
    [NativeTypeName("#define OPEN_ALWAYS 4")]
    public const int OPEN_ALWAYS = 4;
}
