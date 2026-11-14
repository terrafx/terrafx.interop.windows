// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CDS
{
    /// <include file='CDS.xml' path='doc/member[@name="CDS.CDS_UPDATEREGISTRY"]/*' />
    [NativeTypeName("#define CDS_UPDATEREGISTRY 0x00000001")]
    public const int CDS_UPDATEREGISTRY = 0x00000001;

    /// <include file='CDS.xml' path='doc/member[@name="CDS.CDS_TEST"]/*' />
    [NativeTypeName("#define CDS_TEST 0x00000002")]
    public const int CDS_TEST = 0x00000002;

    /// <include file='CDS.xml' path='doc/member[@name="CDS.CDS_FULLSCREEN"]/*' />
    [NativeTypeName("#define CDS_FULLSCREEN 0x00000004")]
    public const int CDS_FULLSCREEN = 0x00000004;

    /// <include file='CDS.xml' path='doc/member[@name="CDS.CDS_GLOBAL"]/*' />
    [NativeTypeName("#define CDS_GLOBAL 0x00000008")]
    public const int CDS_GLOBAL = 0x00000008;

    /// <include file='CDS.xml' path='doc/member[@name="CDS.CDS_SET_PRIMARY"]/*' />
    [NativeTypeName("#define CDS_SET_PRIMARY 0x00000010")]
    public const int CDS_SET_PRIMARY = 0x00000010;

    /// <include file='CDS.xml' path='doc/member[@name="CDS.CDS_VIDEOPARAMETERS"]/*' />
    [NativeTypeName("#define CDS_VIDEOPARAMETERS 0x00000020")]
    public const int CDS_VIDEOPARAMETERS = 0x00000020;

    /// <include file='CDS.xml' path='doc/member[@name="CDS.CDS_ENABLE_UNSAFE_MODES"]/*' />
    [NativeTypeName("#define CDS_ENABLE_UNSAFE_MODES 0x00000100")]
    public const int CDS_ENABLE_UNSAFE_MODES = 0x00000100;

    /// <include file='CDS.xml' path='doc/member[@name="CDS.CDS_DISABLE_UNSAFE_MODES"]/*' />
    [NativeTypeName("#define CDS_DISABLE_UNSAFE_MODES 0x00000200")]
    public const int CDS_DISABLE_UNSAFE_MODES = 0x00000200;

    /// <include file='CDS.xml' path='doc/member[@name="CDS.CDS_RESET"]/*' />
    [NativeTypeName("#define CDS_RESET 0x40000000")]
    public const int CDS_RESET = 0x40000000;

    /// <include file='CDS.xml' path='doc/member[@name="CDS.CDS_RESET_EX"]/*' />
    [NativeTypeName("#define CDS_RESET_EX 0x20000000")]
    public const int CDS_RESET_EX = 0x20000000;

    /// <include file='CDS.xml' path='doc/member[@name="CDS.CDS_NORESET"]/*' />
    [NativeTypeName("#define CDS_NORESET 0x10000000")]
    public const int CDS_NORESET = 0x10000000;
}
