// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS"]/*' />
public enum D3DTEXTURETRANSFORMFLAGS
{
    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_DISABLE"]/*' />
    D3DTTFF_DISABLE = 0,

    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_COUNT1"]/*' />
    D3DTTFF_COUNT1 = 1,

    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_COUNT2"]/*' />
    D3DTTFF_COUNT2 = 2,

    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_COUNT3"]/*' />
    D3DTTFF_COUNT3 = 3,

    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_COUNT4"]/*' />
    D3DTTFF_COUNT4 = 4,

    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_PROJECTED"]/*' />
    D3DTTFF_PROJECTED = 256,

    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_FORCE_DWORD"]/*' />
    D3DTTFF_FORCE_DWORD = 0x7fffffff,
}
