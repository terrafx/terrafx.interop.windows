// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3D
{
    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_RETURN_PARAMETER_INDEX"]/*' />
    [NativeTypeName("#define D3D_RETURN_PARAMETER_INDEX (-1)")]
    public const int D3D_RETURN_PARAMETER_INDEX = (-1);

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SHADER_REQUIRES_DOUBLES"]/*' />
    [NativeTypeName("#define D3D_SHADER_REQUIRES_DOUBLES 0x00000001")]
    public const int D3D_SHADER_REQUIRES_DOUBLES = 0x00000001;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SHADER_REQUIRES_EARLY_DEPTH_STENCIL"]/*' />
    [NativeTypeName("#define D3D_SHADER_REQUIRES_EARLY_DEPTH_STENCIL 0x00000002")]
    public const int D3D_SHADER_REQUIRES_EARLY_DEPTH_STENCIL = 0x00000002;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SHADER_REQUIRES_UAVS_AT_EVERY_STAGE"]/*' />
    [NativeTypeName("#define D3D_SHADER_REQUIRES_UAVS_AT_EVERY_STAGE 0x00000004")]
    public const int D3D_SHADER_REQUIRES_UAVS_AT_EVERY_STAGE = 0x00000004;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SHADER_REQUIRES_64_UAVS"]/*' />
    [NativeTypeName("#define D3D_SHADER_REQUIRES_64_UAVS 0x00000008")]
    public const int D3D_SHADER_REQUIRES_64_UAVS = 0x00000008;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SHADER_REQUIRES_MINIMUM_PRECISION"]/*' />
    [NativeTypeName("#define D3D_SHADER_REQUIRES_MINIMUM_PRECISION 0x00000010")]
    public const int D3D_SHADER_REQUIRES_MINIMUM_PRECISION = 0x00000010;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SHADER_REQUIRES_11_1_DOUBLE_EXTENSIONS"]/*' />
    [NativeTypeName("#define D3D_SHADER_REQUIRES_11_1_DOUBLE_EXTENSIONS 0x00000020")]
    public const int D3D_SHADER_REQUIRES_11_1_DOUBLE_EXTENSIONS = 0x00000020;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SHADER_REQUIRES_11_1_SHADER_EXTENSIONS"]/*' />
    [NativeTypeName("#define D3D_SHADER_REQUIRES_11_1_SHADER_EXTENSIONS 0x00000040")]
    public const int D3D_SHADER_REQUIRES_11_1_SHADER_EXTENSIONS = 0x00000040;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SHADER_REQUIRES_LEVEL_9_COMPARISON_FILTERING"]/*' />
    [NativeTypeName("#define D3D_SHADER_REQUIRES_LEVEL_9_COMPARISON_FILTERING 0x00000080")]
    public const int D3D_SHADER_REQUIRES_LEVEL_9_COMPARISON_FILTERING = 0x00000080;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SHADER_REQUIRES_TILED_RESOURCES"]/*' />
    [NativeTypeName("#define D3D_SHADER_REQUIRES_TILED_RESOURCES 0x00000100")]
    public const int D3D_SHADER_REQUIRES_TILED_RESOURCES = 0x00000100;
}
