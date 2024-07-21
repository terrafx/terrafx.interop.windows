// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DRECT.xml' path='doc/member[@name="D3DRECT"]/*' />
public partial struct D3DRECT
{
    /// <include file='D3DRECT.xml' path='doc/member[@name="D3DRECT.x1"]/*' />
    [NativeTypeName("LONG")]
    public int x1;

    /// <include file='D3DRECT.xml' path='doc/member[@name="D3DRECT.y1"]/*' />
    [NativeTypeName("LONG")]
    public int y1;

    /// <include file='D3DRECT.xml' path='doc/member[@name="D3DRECT.x2"]/*' />
    [NativeTypeName("LONG")]
    public int x2;

    /// <include file='D3DRECT.xml' path='doc/member[@name="D3DRECT.y2"]/*' />
    [NativeTypeName("LONG")]
    public int y2;
}
