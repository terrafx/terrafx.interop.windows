// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE"]/*' />
public enum D3DSHADER_PARAM_REGISTER_TYPE
{
    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_TEMP"]/*' />
    D3DSPR_TEMP = 0,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_INPUT"]/*' />
    D3DSPR_INPUT = 1,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONST"]/*' />
    D3DSPR_CONST = 2,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_ADDR"]/*' />
    D3DSPR_ADDR = 3,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_TEXTURE"]/*' />
    D3DSPR_TEXTURE = 3,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_RASTOUT"]/*' />
    D3DSPR_RASTOUT = 4,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_ATTROUT"]/*' />
    D3DSPR_ATTROUT = 5,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_TEXCRDOUT"]/*' />
    D3DSPR_TEXCRDOUT = 6,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_OUTPUT"]/*' />
    D3DSPR_OUTPUT = 6,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONSTINT"]/*' />
    D3DSPR_CONSTINT = 7,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_COLOROUT"]/*' />
    D3DSPR_COLOROUT = 8,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_DEPTHOUT"]/*' />
    D3DSPR_DEPTHOUT = 9,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_SAMPLER"]/*' />
    D3DSPR_SAMPLER = 10,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONST2"]/*' />
    D3DSPR_CONST2 = 11,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONST3"]/*' />
    D3DSPR_CONST3 = 12,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONST4"]/*' />
    D3DSPR_CONST4 = 13,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONSTBOOL"]/*' />
    D3DSPR_CONSTBOOL = 14,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_LOOP"]/*' />
    D3DSPR_LOOP = 15,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_TEMPFLOAT16"]/*' />
    D3DSPR_TEMPFLOAT16 = 16,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_MISCTYPE"]/*' />
    D3DSPR_MISCTYPE = 17,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_LABEL"]/*' />
    D3DSPR_LABEL = 18,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_PREDICATE"]/*' />
    D3DSPR_PREDICATE = 19,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_FORCE_DWORD"]/*' />
    D3DSPR_FORCE_DWORD = 0x7fffffff,
}
