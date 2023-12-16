// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DRASTER_STATUS.xml' path='doc/member[@name="D3DRASTER_STATUS"]/*' />
public partial struct D3DRASTER_STATUS
{
    /// <include file='D3DRASTER_STATUS.xml' path='doc/member[@name="D3DRASTER_STATUS.InVBlank"]/*' />
    public BOOL InVBlank;

    /// <include file='D3DRASTER_STATUS.xml' path='doc/member[@name="D3DRASTER_STATUS.ScanLine"]/*' />
    public uint ScanLine;
}
