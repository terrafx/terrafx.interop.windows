// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objbase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class STG
{
    /// <include file='STG.xml' path='doc/member[@name="STG.STG_TOEND"]/*' />
    [NativeTypeName("#define STG_TOEND 0xFFFFFFFFL")]
    public const uint STG_TOEND = 0xFFFFFFFF;

    /// <include file='STG.xml' path='doc/member[@name="STG.STG_LAYOUT_SEQUENTIAL"]/*' />
    [NativeTypeName("#define STG_LAYOUT_SEQUENTIAL 0x00000000L")]
    public const int STG_LAYOUT_SEQUENTIAL = 0x00000000;

    /// <include file='STG.xml' path='doc/member[@name="STG.STG_LAYOUT_INTERLEAVED"]/*' />
    [NativeTypeName("#define STG_LAYOUT_INTERLEAVED 0x00000001L")]
    public const int STG_LAYOUT_INTERLEAVED = 0x00000001;
}
