// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DI
{
    /// <include file='DI.xml' path='doc/member[@name="DI.DI_MASK"]/*' />
    [NativeTypeName("#define DI_MASK 0x0001")]
    public const int DI_MASK = 0x0001;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_IMAGE"]/*' />
    [NativeTypeName("#define DI_IMAGE 0x0002")]
    public const int DI_IMAGE = 0x0002;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_NORMAL"]/*' />
    [NativeTypeName("#define DI_NORMAL 0x0003")]
    public const int DI_NORMAL = 0x0003;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_COMPAT"]/*' />
    [NativeTypeName("#define DI_COMPAT 0x0004")]
    public const int DI_COMPAT = 0x0004;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_DEFAULTSIZE"]/*' />
    [NativeTypeName("#define DI_DEFAULTSIZE 0x0008")]
    public const int DI_DEFAULTSIZE = 0x0008;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_NOMIRROR"]/*' />
    [NativeTypeName("#define DI_NOMIRROR 0x0010")]
    public const int DI_NOMIRROR = 0x0010;
}
