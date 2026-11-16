// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DPCMPCAPS
{
    /// <include file='D3DPCMPCAPS.xml' path='doc/member[@name="D3DPCMPCAPS.D3DPCMPCAPS_NEVER"]/*' />
    [NativeTypeName("#define D3DPCMPCAPS_NEVER 0x00000001L")]
    public const int D3DPCMPCAPS_NEVER = 0x00000001;

    /// <include file='D3DPCMPCAPS.xml' path='doc/member[@name="D3DPCMPCAPS.D3DPCMPCAPS_LESS"]/*' />
    [NativeTypeName("#define D3DPCMPCAPS_LESS 0x00000002L")]
    public const int D3DPCMPCAPS_LESS = 0x00000002;

    /// <include file='D3DPCMPCAPS.xml' path='doc/member[@name="D3DPCMPCAPS.D3DPCMPCAPS_EQUAL"]/*' />
    [NativeTypeName("#define D3DPCMPCAPS_EQUAL 0x00000004L")]
    public const int D3DPCMPCAPS_EQUAL = 0x00000004;

    /// <include file='D3DPCMPCAPS.xml' path='doc/member[@name="D3DPCMPCAPS.D3DPCMPCAPS_LESSEQUAL"]/*' />
    [NativeTypeName("#define D3DPCMPCAPS_LESSEQUAL 0x00000008L")]
    public const int D3DPCMPCAPS_LESSEQUAL = 0x00000008;

    /// <include file='D3DPCMPCAPS.xml' path='doc/member[@name="D3DPCMPCAPS.D3DPCMPCAPS_GREATER"]/*' />
    [NativeTypeName("#define D3DPCMPCAPS_GREATER 0x00000010L")]
    public const int D3DPCMPCAPS_GREATER = 0x00000010;

    /// <include file='D3DPCMPCAPS.xml' path='doc/member[@name="D3DPCMPCAPS.D3DPCMPCAPS_NOTEQUAL"]/*' />
    [NativeTypeName("#define D3DPCMPCAPS_NOTEQUAL 0x00000020L")]
    public const int D3DPCMPCAPS_NOTEQUAL = 0x00000020;

    /// <include file='D3DPCMPCAPS.xml' path='doc/member[@name="D3DPCMPCAPS.D3DPCMPCAPS_GREATEREQUAL"]/*' />
    [NativeTypeName("#define D3DPCMPCAPS_GREATEREQUAL 0x00000040L")]
    public const int D3DPCMPCAPS_GREATEREQUAL = 0x00000040;

    /// <include file='D3DPCMPCAPS.xml' path='doc/member[@name="D3DPCMPCAPS.D3DPCMPCAPS_ALWAYS"]/*' />
    [NativeTypeName("#define D3DPCMPCAPS_ALWAYS 0x00000080L")]
    public const int D3DPCMPCAPS_ALWAYS = 0x00000080;
}
