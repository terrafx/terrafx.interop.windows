// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE"]/*' />
public enum D3DSHADER_PARAM_SRCMOD_TYPE
{
    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_NONE"]/*' />
    D3DSPSM_NONE = 0 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_NEG"]/*' />
    D3DSPSM_NEG = 1 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_BIAS"]/*' />
    D3DSPSM_BIAS = 2 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_BIASNEG"]/*' />
    D3DSPSM_BIASNEG = 3 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_SIGN"]/*' />
    D3DSPSM_SIGN = 4 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_SIGNNEG"]/*' />
    D3DSPSM_SIGNNEG = 5 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_COMP"]/*' />
    D3DSPSM_COMP = 6 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_X2"]/*' />
    D3DSPSM_X2 = 7 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_X2NEG"]/*' />
    D3DSPSM_X2NEG = 8 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_DZ"]/*' />
    D3DSPSM_DZ = 9 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_DW"]/*' />
    D3DSPSM_DW = 10 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_ABS"]/*' />
    D3DSPSM_ABS = 11 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_ABSNEG"]/*' />
    D3DSPSM_ABSNEG = 12 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_NOT"]/*' />
    D3DSPSM_NOT = 13 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_FORCE_DWORD"]/*' />
    D3DSPSM_FORCE_DWORD = 0x7fffffff,
}
