// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DMEMORYPRESSURE.xml' path='doc/member[@name="D3DMEMORYPRESSURE"]/*' />
public partial struct D3DMEMORYPRESSURE
{
    /// <include file='D3DMEMORYPRESSURE.xml' path='doc/member[@name="D3DMEMORYPRESSURE.BytesEvictedFromProcess"]/*' />
    [NativeTypeName("UINT64")]
    public ulong BytesEvictedFromProcess;

    /// <include file='D3DMEMORYPRESSURE.xml' path='doc/member[@name="D3DMEMORYPRESSURE.SizeOfInefficientAllocation"]/*' />
    [NativeTypeName("UINT64")]
    public ulong SizeOfInefficientAllocation;

    /// <include file='D3DMEMORYPRESSURE.xml' path='doc/member[@name="D3DMEMORYPRESSURE.LevelOfEfficiency"]/*' />
    [NativeTypeName("DWORD")]
    public uint LevelOfEfficiency;
}
