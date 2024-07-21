// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC"]/*' />
public enum D3DCMPFUNC
{
    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_NEVER"]/*' />
    D3DCMP_NEVER = 1,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_LESS"]/*' />
    D3DCMP_LESS = 2,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_EQUAL"]/*' />
    D3DCMP_EQUAL = 3,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_LESSEQUAL"]/*' />
    D3DCMP_LESSEQUAL = 4,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_GREATER"]/*' />
    D3DCMP_GREATER = 5,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_NOTEQUAL"]/*' />
    D3DCMP_NOTEQUAL = 6,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_GREATEREQUAL"]/*' />
    D3DCMP_GREATEREQUAL = 7,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_ALWAYS"]/*' />
    D3DCMP_ALWAYS = 8,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_FORCE_DWORD"]/*' />
    D3DCMP_FORCE_DWORD = 0x7fffffff,
}
