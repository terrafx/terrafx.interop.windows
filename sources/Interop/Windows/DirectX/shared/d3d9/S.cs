// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;

public static partial class S
{
    /// <include file='S.xml' path='doc/member[@name="S.S_NOT_RESIDENT"]/*' />
    [NativeTypeName("#define S_NOT_RESIDENT MAKE_D3DSTATUS(2165)")]
    public const int S_NOT_RESIDENT = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2165))));

    /// <include file='S.xml' path='doc/member[@name="S.S_RESIDENT_IN_SHARED_MEMORY"]/*' />
    [NativeTypeName("#define S_RESIDENT_IN_SHARED_MEMORY MAKE_D3DSTATUS(2166)")]
    public const int S_RESIDENT_IN_SHARED_MEMORY = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2166))));

    /// <include file='S.xml' path='doc/member[@name="S.S_PRESENT_MODE_CHANGED"]/*' />
    [NativeTypeName("#define S_PRESENT_MODE_CHANGED MAKE_D3DSTATUS(2167)")]
    public const int S_PRESENT_MODE_CHANGED = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2167))));

    /// <include file='S.xml' path='doc/member[@name="S.S_PRESENT_OCCLUDED"]/*' />
    [NativeTypeName("#define S_PRESENT_OCCLUDED MAKE_D3DSTATUS(2168)")]
    public const int S_PRESENT_OCCLUDED = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2168))));
}
