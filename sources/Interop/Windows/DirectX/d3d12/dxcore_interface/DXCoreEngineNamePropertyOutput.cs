// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreEngineNamePropertyOutput.xml' path='doc/member[@name="DXCoreEngineNamePropertyOutput"]/*' />
public partial struct DXCoreEngineNamePropertyOutput
{
    /// <include file='DXCoreEngineNamePropertyOutput.xml' path='doc/member[@name="DXCoreEngineNamePropertyOutput.engineNameLength"]/*' />
    [NativeTypeName("uint32_t")]
    public uint engineNameLength;
}
