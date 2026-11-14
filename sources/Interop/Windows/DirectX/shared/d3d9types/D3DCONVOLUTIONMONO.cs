// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DCONVOLUTIONMONO
{
    /// <include file='D3DCONVOLUTIONMONO.xml' path='doc/member[@name="D3DCONVOLUTIONMONO.D3DCONVOLUTIONMONO_MAXWIDTH"]/*' />
    [NativeTypeName("#define D3DCONVOLUTIONMONO_MAXWIDTH 7")]
    public const int D3DCONVOLUTIONMONO_MAXWIDTH = 7;

    /// <include file='D3DCONVOLUTIONMONO.xml' path='doc/member[@name="D3DCONVOLUTIONMONO.D3DCONVOLUTIONMONO_MAXHEIGHT"]/*' />
    [NativeTypeName("#define D3DCONVOLUTIONMONO_MAXHEIGHT D3DCONVOLUTIONMONO_MAXWIDTH")]
    public const int D3DCONVOLUTIONMONO_MAXHEIGHT = 7;
}
