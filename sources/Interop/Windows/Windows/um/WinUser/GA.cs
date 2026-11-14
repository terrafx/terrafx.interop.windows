// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GA
{
    /// <include file='GA.xml' path='doc/member[@name="GA.GA_PARENT"]/*' />
    [NativeTypeName("#define GA_PARENT 1")]
    public const int GA_PARENT = 1;

    /// <include file='GA.xml' path='doc/member[@name="GA.GA_ROOT"]/*' />
    [NativeTypeName("#define GA_ROOT 2")]
    public const int GA_ROOT = 2;

    /// <include file='GA.xml' path='doc/member[@name="GA.GA_ROOTOWNER"]/*' />
    [NativeTypeName("#define GA_ROOTOWNER 3")]
    public const int GA_ROOTOWNER = 3;
}
