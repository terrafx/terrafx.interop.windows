// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreEngineQueryOutput.xml' path='doc/member[@name="DXCoreEngineQueryOutput"]/*' />
public partial struct DXCoreEngineQueryOutput
{
    /// <include file='DXCoreEngineQueryOutput.xml' path='doc/member[@name="DXCoreEngineQueryOutput.runningTime"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong runningTime;

    /// <include file='DXCoreEngineQueryOutput.xml' path='doc/member[@name="DXCoreEngineQueryOutput.processQuerySucceeded"]/*' />
    public bool processQuerySucceeded;
}
