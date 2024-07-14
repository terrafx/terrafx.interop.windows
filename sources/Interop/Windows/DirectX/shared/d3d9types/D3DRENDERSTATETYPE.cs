// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE"]/*' />
public enum D3DRENDERSTATETYPE
{
    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ZENABLE"]/*' />
    D3DRS_ZENABLE = 7,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FILLMODE"]/*' />
    D3DRS_FILLMODE = 8,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SHADEMODE"]/*' />
    D3DRS_SHADEMODE = 9,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ZWRITEENABLE"]/*' />
    D3DRS_ZWRITEENABLE = 14,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ALPHATESTENABLE"]/*' />
    D3DRS_ALPHATESTENABLE = 15,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_LASTPIXEL"]/*' />
    D3DRS_LASTPIXEL = 16,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SRCBLEND"]/*' />
    D3DRS_SRCBLEND = 19,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_DESTBLEND"]/*' />
    D3DRS_DESTBLEND = 20,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CULLMODE"]/*' />
    D3DRS_CULLMODE = 22,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ZFUNC"]/*' />
    D3DRS_ZFUNC = 23,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ALPHAREF"]/*' />
    D3DRS_ALPHAREF = 24,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ALPHAFUNC"]/*' />
    D3DRS_ALPHAFUNC = 25,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_DITHERENABLE"]/*' />
    D3DRS_DITHERENABLE = 26,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ALPHABLENDENABLE"]/*' />
    D3DRS_ALPHABLENDENABLE = 27,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGENABLE"]/*' />
    D3DRS_FOGENABLE = 28,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SPECULARENABLE"]/*' />
    D3DRS_SPECULARENABLE = 29,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGCOLOR"]/*' />
    D3DRS_FOGCOLOR = 34,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGTABLEMODE"]/*' />
    D3DRS_FOGTABLEMODE = 35,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGSTART"]/*' />
    D3DRS_FOGSTART = 36,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGEND"]/*' />
    D3DRS_FOGEND = 37,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGDENSITY"]/*' />
    D3DRS_FOGDENSITY = 38,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_RANGEFOGENABLE"]/*' />
    D3DRS_RANGEFOGENABLE = 48,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILENABLE"]/*' />
    D3DRS_STENCILENABLE = 52,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILFAIL"]/*' />
    D3DRS_STENCILFAIL = 53,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILZFAIL"]/*' />
    D3DRS_STENCILZFAIL = 54,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILPASS"]/*' />
    D3DRS_STENCILPASS = 55,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILFUNC"]/*' />
    D3DRS_STENCILFUNC = 56,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILREF"]/*' />
    D3DRS_STENCILREF = 57,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILMASK"]/*' />
    D3DRS_STENCILMASK = 58,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILWRITEMASK"]/*' />
    D3DRS_STENCILWRITEMASK = 59,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_TEXTUREFACTOR"]/*' />
    D3DRS_TEXTUREFACTOR = 60,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP0"]/*' />
    D3DRS_WRAP0 = 128,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP1"]/*' />
    D3DRS_WRAP1 = 129,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP2"]/*' />
    D3DRS_WRAP2 = 130,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP3"]/*' />
    D3DRS_WRAP3 = 131,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP4"]/*' />
    D3DRS_WRAP4 = 132,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP5"]/*' />
    D3DRS_WRAP5 = 133,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP6"]/*' />
    D3DRS_WRAP6 = 134,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP7"]/*' />
    D3DRS_WRAP7 = 135,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CLIPPING"]/*' />
    D3DRS_CLIPPING = 136,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_LIGHTING"]/*' />
    D3DRS_LIGHTING = 137,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_AMBIENT"]/*' />
    D3DRS_AMBIENT = 139,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGVERTEXMODE"]/*' />
    D3DRS_FOGVERTEXMODE = 140,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_COLORVERTEX"]/*' />
    D3DRS_COLORVERTEX = 141,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_LOCALVIEWER"]/*' />
    D3DRS_LOCALVIEWER = 142,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_NORMALIZENORMALS"]/*' />
    D3DRS_NORMALIZENORMALS = 143,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_DIFFUSEMATERIALSOURCE"]/*' />
    D3DRS_DIFFUSEMATERIALSOURCE = 145,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SPECULARMATERIALSOURCE"]/*' />
    D3DRS_SPECULARMATERIALSOURCE = 146,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_AMBIENTMATERIALSOURCE"]/*' />
    D3DRS_AMBIENTMATERIALSOURCE = 147,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_EMISSIVEMATERIALSOURCE"]/*' />
    D3DRS_EMISSIVEMATERIALSOURCE = 148,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_VERTEXBLEND"]/*' />
    D3DRS_VERTEXBLEND = 151,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CLIPPLANEENABLE"]/*' />
    D3DRS_CLIPPLANEENABLE = 152,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSIZE"]/*' />
    D3DRS_POINTSIZE = 154,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSIZE_MIN"]/*' />
    D3DRS_POINTSIZE_MIN = 155,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSPRITEENABLE"]/*' />
    D3DRS_POINTSPRITEENABLE = 156,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSCALEENABLE"]/*' />
    D3DRS_POINTSCALEENABLE = 157,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSCALE_A"]/*' />
    D3DRS_POINTSCALE_A = 158,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSCALE_B"]/*' />
    D3DRS_POINTSCALE_B = 159,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSCALE_C"]/*' />
    D3DRS_POINTSCALE_C = 160,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_MULTISAMPLEANTIALIAS"]/*' />
    D3DRS_MULTISAMPLEANTIALIAS = 161,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_MULTISAMPLEMASK"]/*' />
    D3DRS_MULTISAMPLEMASK = 162,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_PATCHEDGESTYLE"]/*' />
    D3DRS_PATCHEDGESTYLE = 163,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_DEBUGMONITORTOKEN"]/*' />
    D3DRS_DEBUGMONITORTOKEN = 165,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSIZE_MAX"]/*' />
    D3DRS_POINTSIZE_MAX = 166,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_INDEXEDVERTEXBLENDENABLE"]/*' />
    D3DRS_INDEXEDVERTEXBLENDENABLE = 167,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_COLORWRITEENABLE"]/*' />
    D3DRS_COLORWRITEENABLE = 168,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_TWEENFACTOR"]/*' />
    D3DRS_TWEENFACTOR = 170,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_BLENDOP"]/*' />
    D3DRS_BLENDOP = 171,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POSITIONDEGREE"]/*' />
    D3DRS_POSITIONDEGREE = 172,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_NORMALDEGREE"]/*' />
    D3DRS_NORMALDEGREE = 173,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SCISSORTESTENABLE"]/*' />
    D3DRS_SCISSORTESTENABLE = 174,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SLOPESCALEDEPTHBIAS"]/*' />
    D3DRS_SLOPESCALEDEPTHBIAS = 175,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ANTIALIASEDLINEENABLE"]/*' />
    D3DRS_ANTIALIASEDLINEENABLE = 176,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_MINTESSELLATIONLEVEL"]/*' />
    D3DRS_MINTESSELLATIONLEVEL = 178,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_MAXTESSELLATIONLEVEL"]/*' />
    D3DRS_MAXTESSELLATIONLEVEL = 179,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ADAPTIVETESS_X"]/*' />
    D3DRS_ADAPTIVETESS_X = 180,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ADAPTIVETESS_Y"]/*' />
    D3DRS_ADAPTIVETESS_Y = 181,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ADAPTIVETESS_Z"]/*' />
    D3DRS_ADAPTIVETESS_Z = 182,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ADAPTIVETESS_W"]/*' />
    D3DRS_ADAPTIVETESS_W = 183,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ENABLEADAPTIVETESSELLATION"]/*' />
    D3DRS_ENABLEADAPTIVETESSELLATION = 184,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_TWOSIDEDSTENCILMODE"]/*' />
    D3DRS_TWOSIDEDSTENCILMODE = 185,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CCW_STENCILFAIL"]/*' />
    D3DRS_CCW_STENCILFAIL = 186,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CCW_STENCILZFAIL"]/*' />
    D3DRS_CCW_STENCILZFAIL = 187,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CCW_STENCILPASS"]/*' />
    D3DRS_CCW_STENCILPASS = 188,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CCW_STENCILFUNC"]/*' />
    D3DRS_CCW_STENCILFUNC = 189,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_COLORWRITEENABLE1"]/*' />
    D3DRS_COLORWRITEENABLE1 = 190,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_COLORWRITEENABLE2"]/*' />
    D3DRS_COLORWRITEENABLE2 = 191,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_COLORWRITEENABLE3"]/*' />
    D3DRS_COLORWRITEENABLE3 = 192,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_BLENDFACTOR"]/*' />
    D3DRS_BLENDFACTOR = 193,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SRGBWRITEENABLE"]/*' />
    D3DRS_SRGBWRITEENABLE = 194,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_DEPTHBIAS"]/*' />
    D3DRS_DEPTHBIAS = 195,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP8"]/*' />
    D3DRS_WRAP8 = 198,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP9"]/*' />
    D3DRS_WRAP9 = 199,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP10"]/*' />
    D3DRS_WRAP10 = 200,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP11"]/*' />
    D3DRS_WRAP11 = 201,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP12"]/*' />
    D3DRS_WRAP12 = 202,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP13"]/*' />
    D3DRS_WRAP13 = 203,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP14"]/*' />
    D3DRS_WRAP14 = 204,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP15"]/*' />
    D3DRS_WRAP15 = 205,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SEPARATEALPHABLENDENABLE"]/*' />
    D3DRS_SEPARATEALPHABLENDENABLE = 206,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SRCBLENDALPHA"]/*' />
    D3DRS_SRCBLENDALPHA = 207,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_DESTBLENDALPHA"]/*' />
    D3DRS_DESTBLENDALPHA = 208,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_BLENDOPALPHA"]/*' />
    D3DRS_BLENDOPALPHA = 209,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FORCE_DWORD"]/*' />
    D3DRS_FORCE_DWORD = 0x7fffffff,
}
