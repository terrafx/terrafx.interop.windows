// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DVERTEXELEMENT9.xml' path='doc/member[@name="D3DVERTEXELEMENT9"]/*' />
public partial struct D3DVERTEXELEMENT9
{
    /// <include file='D3DVERTEXELEMENT9.xml' path='doc/member[@name="D3DVERTEXELEMENT9.Stream"]/*' />
    [NativeTypeName("WORD")]
    public ushort Stream;

    /// <include file='D3DVERTEXELEMENT9.xml' path='doc/member[@name="D3DVERTEXELEMENT9.Offset"]/*' />
    [NativeTypeName("WORD")]
    public ushort Offset;

    /// <include file='D3DVERTEXELEMENT9.xml' path='doc/member[@name="D3DVERTEXELEMENT9.Type"]/*' />
    public byte Type;

    /// <include file='D3DVERTEXELEMENT9.xml' path='doc/member[@name="D3DVERTEXELEMENT9.Method"]/*' />
    public byte Method;

    /// <include file='D3DVERTEXELEMENT9.xml' path='doc/member[@name="D3DVERTEXELEMENT9.Usage"]/*' />
    public byte Usage;

    /// <include file='D3DVERTEXELEMENT9.xml' path='doc/member[@name="D3DVERTEXELEMENT9.UsageIndex"]/*' />
    public byte UsageIndex;
}
