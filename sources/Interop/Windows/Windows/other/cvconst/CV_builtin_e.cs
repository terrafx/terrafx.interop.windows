// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e"]/*' />
public enum CV_builtin_e
{
    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_INVALID"]/*' />
    CV_BI_INVALID = 0x0000,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_INTERFACE_POINTER"]/*' />
    CV_BI_HLSL_INTERFACE_POINTER = 0x0200,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_TEXTURE1D"]/*' />
    CV_BI_HLSL_TEXTURE1D = 0x0201,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_TEXTURE1D_ARRAY"]/*' />
    CV_BI_HLSL_TEXTURE1D_ARRAY = 0x0202,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_TEXTURE2D"]/*' />
    CV_BI_HLSL_TEXTURE2D = 0x0203,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_TEXTURE2D_ARRAY"]/*' />
    CV_BI_HLSL_TEXTURE2D_ARRAY = 0x0204,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_TEXTURE3D"]/*' />
    CV_BI_HLSL_TEXTURE3D = 0x0205,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_TEXTURECUBE"]/*' />
    CV_BI_HLSL_TEXTURECUBE = 0x0206,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_TEXTURECUBE_ARRAY"]/*' />
    CV_BI_HLSL_TEXTURECUBE_ARRAY = 0x0207,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_TEXTURE2DMS"]/*' />
    CV_BI_HLSL_TEXTURE2DMS = 0x0208,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_TEXTURE2DMS_ARRAY"]/*' />
    CV_BI_HLSL_TEXTURE2DMS_ARRAY = 0x0209,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_SAMPLER"]/*' />
    CV_BI_HLSL_SAMPLER = 0x020a,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_SAMPLERCOMPARISON"]/*' />
    CV_BI_HLSL_SAMPLERCOMPARISON = 0x020b,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_BUFFER"]/*' />
    CV_BI_HLSL_BUFFER = 0x020c,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_POINTSTREAM"]/*' />
    CV_BI_HLSL_POINTSTREAM = 0x020d,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_LINESTREAM"]/*' />
    CV_BI_HLSL_LINESTREAM = 0x020e,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_TRIANGLESTREAM"]/*' />
    CV_BI_HLSL_TRIANGLESTREAM = 0x020f,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_INPUTPATCH"]/*' />
    CV_BI_HLSL_INPUTPATCH = 0x0210,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_OUTPUTPATCH"]/*' />
    CV_BI_HLSL_OUTPUTPATCH = 0x0211,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_RWTEXTURE1D"]/*' />
    CV_BI_HLSL_RWTEXTURE1D = 0x0212,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_RWTEXTURE1D_ARRAY"]/*' />
    CV_BI_HLSL_RWTEXTURE1D_ARRAY = 0x0213,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_RWTEXTURE2D"]/*' />
    CV_BI_HLSL_RWTEXTURE2D = 0x0214,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_RWTEXTURE2D_ARRAY"]/*' />
    CV_BI_HLSL_RWTEXTURE2D_ARRAY = 0x0215,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_RWTEXTURE3D"]/*' />
    CV_BI_HLSL_RWTEXTURE3D = 0x0216,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_RWBUFFER"]/*' />
    CV_BI_HLSL_RWBUFFER = 0x0217,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_BYTEADDRESS_BUFFER"]/*' />
    CV_BI_HLSL_BYTEADDRESS_BUFFER = 0x0218,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_RWBYTEADDRESS_BUFFER"]/*' />
    CV_BI_HLSL_RWBYTEADDRESS_BUFFER = 0x0219,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_STRUCTURED_BUFFER"]/*' />
    CV_BI_HLSL_STRUCTURED_BUFFER = 0x021a,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_RWSTRUCTURED_BUFFER"]/*' />
    CV_BI_HLSL_RWSTRUCTURED_BUFFER = 0x021b,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_APPEND_STRUCTURED_BUFFER"]/*' />
    CV_BI_HLSL_APPEND_STRUCTURED_BUFFER = 0x021c,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_CONSUME_STRUCTURED_BUFFER"]/*' />
    CV_BI_HLSL_CONSUME_STRUCTURED_BUFFER = 0x021d,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_MIN8FLOAT"]/*' />
    CV_BI_HLSL_MIN8FLOAT = 0x021e,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_MIN10FLOAT"]/*' />
    CV_BI_HLSL_MIN10FLOAT = 0x021f,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_MIN16FLOAT"]/*' />
    CV_BI_HLSL_MIN16FLOAT = 0x0220,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_MIN12INT"]/*' />
    CV_BI_HLSL_MIN12INT = 0x0221,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_MIN16INT"]/*' />
    CV_BI_HLSL_MIN16INT = 0x0222,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_MIN16UINT"]/*' />
    CV_BI_HLSL_MIN16UINT = 0x0223,

    /// <include file='CV_builtin_e.xml' path='doc/member[@name="CV_builtin_e.CV_BI_HLSL_CONSTANT_BUFFER"]/*' />
    CV_BI_HLSL_CONSTANT_BUFFER = 0x0224,
}
