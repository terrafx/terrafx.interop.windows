// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class BPPF
{
    /// <include file='BPPF.xml' path='doc/member[@name="BPPF.BPPF_ERASE"]/*' />
    [NativeTypeName("#define BPPF_ERASE 0x0001")]
    public const int BPPF_ERASE = 0x0001;

    /// <include file='BPPF.xml' path='doc/member[@name="BPPF.BPPF_NOCLIP"]/*' />
    [NativeTypeName("#define BPPF_NOCLIP 0x0002")]
    public const int BPPF_NOCLIP = 0x0002;

    /// <include file='BPPF.xml' path='doc/member[@name="BPPF.BPPF_NONCLIENT"]/*' />
    [NativeTypeName("#define BPPF_NONCLIENT 0x0004")]
    public const int BPPF_NONCLIENT = 0x0004;
}
