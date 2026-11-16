// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DTEXOPCAPS
{
    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_DISABLE"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_DISABLE 0x00000001L")]
    public const int D3DTEXOPCAPS_DISABLE = 0x00000001;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_SELECTARG1"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_SELECTARG1 0x00000002L")]
    public const int D3DTEXOPCAPS_SELECTARG1 = 0x00000002;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_SELECTARG2"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_SELECTARG2 0x00000004L")]
    public const int D3DTEXOPCAPS_SELECTARG2 = 0x00000004;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_MODULATE"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_MODULATE 0x00000008L")]
    public const int D3DTEXOPCAPS_MODULATE = 0x00000008;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_MODULATE2X"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_MODULATE2X 0x00000010L")]
    public const int D3DTEXOPCAPS_MODULATE2X = 0x00000010;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_MODULATE4X"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_MODULATE4X 0x00000020L")]
    public const int D3DTEXOPCAPS_MODULATE4X = 0x00000020;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_ADD"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_ADD 0x00000040L")]
    public const int D3DTEXOPCAPS_ADD = 0x00000040;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_ADDSIGNED"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_ADDSIGNED 0x00000080L")]
    public const int D3DTEXOPCAPS_ADDSIGNED = 0x00000080;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_ADDSIGNED2X"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_ADDSIGNED2X 0x00000100L")]
    public const int D3DTEXOPCAPS_ADDSIGNED2X = 0x00000100;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_SUBTRACT"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_SUBTRACT 0x00000200L")]
    public const int D3DTEXOPCAPS_SUBTRACT = 0x00000200;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_ADDSMOOTH"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_ADDSMOOTH 0x00000400L")]
    public const int D3DTEXOPCAPS_ADDSMOOTH = 0x00000400;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_BLENDDIFFUSEALPHA"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_BLENDDIFFUSEALPHA 0x00000800L")]
    public const int D3DTEXOPCAPS_BLENDDIFFUSEALPHA = 0x00000800;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_BLENDTEXTUREALPHA"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_BLENDTEXTUREALPHA 0x00001000L")]
    public const int D3DTEXOPCAPS_BLENDTEXTUREALPHA = 0x00001000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_BLENDFACTORALPHA"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_BLENDFACTORALPHA 0x00002000L")]
    public const int D3DTEXOPCAPS_BLENDFACTORALPHA = 0x00002000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_BLENDTEXTUREALPHAPM"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_BLENDTEXTUREALPHAPM 0x00004000L")]
    public const int D3DTEXOPCAPS_BLENDTEXTUREALPHAPM = 0x00004000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_BLENDCURRENTALPHA"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_BLENDCURRENTALPHA 0x00008000L")]
    public const int D3DTEXOPCAPS_BLENDCURRENTALPHA = 0x00008000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_PREMODULATE"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_PREMODULATE 0x00010000L")]
    public const int D3DTEXOPCAPS_PREMODULATE = 0x00010000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_MODULATEALPHA_ADDCOLOR"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_MODULATEALPHA_ADDCOLOR 0x00020000L")]
    public const int D3DTEXOPCAPS_MODULATEALPHA_ADDCOLOR = 0x00020000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_MODULATECOLOR_ADDALPHA"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_MODULATECOLOR_ADDALPHA 0x00040000L")]
    public const int D3DTEXOPCAPS_MODULATECOLOR_ADDALPHA = 0x00040000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_MODULATEINVALPHA_ADDCOLOR"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_MODULATEINVALPHA_ADDCOLOR 0x00080000L")]
    public const int D3DTEXOPCAPS_MODULATEINVALPHA_ADDCOLOR = 0x00080000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_MODULATEINVCOLOR_ADDALPHA"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_MODULATEINVCOLOR_ADDALPHA 0x00100000L")]
    public const int D3DTEXOPCAPS_MODULATEINVCOLOR_ADDALPHA = 0x00100000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_BUMPENVMAP"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_BUMPENVMAP 0x00200000L")]
    public const int D3DTEXOPCAPS_BUMPENVMAP = 0x00200000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_BUMPENVMAPLUMINANCE"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_BUMPENVMAPLUMINANCE 0x00400000L")]
    public const int D3DTEXOPCAPS_BUMPENVMAPLUMINANCE = 0x00400000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_DOTPRODUCT3"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_DOTPRODUCT3 0x00800000L")]
    public const int D3DTEXOPCAPS_DOTPRODUCT3 = 0x00800000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_MULTIPLYADD"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_MULTIPLYADD 0x01000000L")]
    public const int D3DTEXOPCAPS_MULTIPLYADD = 0x01000000;

    /// <include file='D3DTEXOPCAPS.xml' path='doc/member[@name="D3DTEXOPCAPS.D3DTEXOPCAPS_LERP"]/*' />
    [NativeTypeName("#define D3DTEXOPCAPS_LERP 0x02000000L")]
    public const int D3DTEXOPCAPS_LERP = 0x02000000;
}
