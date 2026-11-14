// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MIM
{
    /// <include file='MIM.xml' path='doc/member[@name="MIM.MIM_OPEN"]/*' />
    [NativeTypeName("#define MIM_OPEN MM_MIM_OPEN")]
    public const int MIM_OPEN = 0x3C1;

    /// <include file='MIM.xml' path='doc/member[@name="MIM.MIM_CLOSE"]/*' />
    [NativeTypeName("#define MIM_CLOSE MM_MIM_CLOSE")]
    public const int MIM_CLOSE = 0x3C2;

    /// <include file='MIM.xml' path='doc/member[@name="MIM.MIM_DATA"]/*' />
    [NativeTypeName("#define MIM_DATA MM_MIM_DATA")]
    public const int MIM_DATA = 0x3C3;

    /// <include file='MIM.xml' path='doc/member[@name="MIM.MIM_LONGDATA"]/*' />
    [NativeTypeName("#define MIM_LONGDATA MM_MIM_LONGDATA")]
    public const int MIM_LONGDATA = 0x3C4;

    /// <include file='MIM.xml' path='doc/member[@name="MIM.MIM_ERROR"]/*' />
    [NativeTypeName("#define MIM_ERROR MM_MIM_ERROR")]
    public const int MIM_ERROR = 0x3C5;

    /// <include file='MIM.xml' path='doc/member[@name="MIM.MIM_LONGERROR"]/*' />
    [NativeTypeName("#define MIM_LONGERROR MM_MIM_LONGERROR")]
    public const int MIM_LONGERROR = 0x3C6;

    /// <include file='MIM.xml' path='doc/member[@name="MIM.MIM_MOREDATA"]/*' />
    [NativeTypeName("#define MIM_MOREDATA MM_MIM_MOREDATA")]
    public const int MIM_MOREDATA = 0x3CC;
}
