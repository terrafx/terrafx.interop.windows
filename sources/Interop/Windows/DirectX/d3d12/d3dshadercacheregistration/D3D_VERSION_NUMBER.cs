// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_VERSION_NUMBER.xml' path='doc/member[@name="D3D_VERSION_NUMBER"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct D3D_VERSION_NUMBER
{
    /// <include file='D3D_VERSION_NUMBER.xml' path='doc/member[@name="D3D_VERSION_NUMBER.Version"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("UINT64")]
    public ulong Version;

    /// <include file='D3D_VERSION_NUMBER.xml' path='doc/member[@name="D3D_VERSION_NUMBER.VersionParts"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("UINT16[4]")]
    public _VersionParts_e__FixedBuffer VersionParts;

    /// <include file='_VersionParts_e__FixedBuffer.xml' path='doc/member[@name="_VersionParts_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _VersionParts_e__FixedBuffer
    {
        public ushort e0;
    }
}
