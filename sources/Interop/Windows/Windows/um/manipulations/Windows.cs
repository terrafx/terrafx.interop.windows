// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.POSITIVE_INFINITY"]/*' />
    [NativeTypeName("const float")]
    public const float POSITIVE_INFINITY = ((float)(1e308 * 10));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NEGATIVE_INFINITY"]/*' />
    [NativeTypeName("const float")]
    public const float NEGATIVE_INFINITY = ((float)(-1e308 * 10));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NaN"]/*' />
    [NativeTypeName("const float")]
    public const float NaN = ((float)((1e308 * 10) * 0.0));
}
