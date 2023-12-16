// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDEVINFO_RESOURCEMANAGER.xml' path='doc/member[@name="D3DDEVINFO_RESOURCEMANAGER"]/*' />
public partial struct D3DDEVINFO_RESOURCEMANAGER
{
    /// <include file='D3DDEVINFO_RESOURCEMANAGER.xml' path='doc/member[@name="D3DDEVINFO_RESOURCEMANAGER.stats"]/*' />
    [NativeTypeName("D3DRESOURCESTATS[8]")]
    public _stats_e__FixedBuffer stats;

    /// <include file='_stats_e__FixedBuffer.xml' path='doc/member[@name="_stats_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _stats_e__FixedBuffer
    {
        public D3DRESOURCESTATS e0;
    }
}
