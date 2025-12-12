// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreWorkload.xml' path='doc/member[@name="DXCoreWorkload"]/*' />
[NativeTypeName("uint32_t")]
public enum DXCoreWorkload : uint
{
    /// <include file='DXCoreWorkload.xml' path='doc/member[@name="DXCoreWorkload.Graphics"]/*' />
    Graphics = 0,

    /// <include file='DXCoreWorkload.xml' path='doc/member[@name="DXCoreWorkload.Compute"]/*' />
    Compute = 1,

    /// <include file='DXCoreWorkload.xml' path='doc/member[@name="DXCoreWorkload.Media"]/*' />
    Media = 2,

    /// <include file='DXCoreWorkload.xml' path='doc/member[@name="DXCoreWorkload.MachineLearning"]/*' />
    MachineLearning = 3,
}
