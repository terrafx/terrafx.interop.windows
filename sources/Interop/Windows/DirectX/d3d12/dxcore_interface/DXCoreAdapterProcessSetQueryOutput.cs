// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreAdapterProcessSetQueryOutput.xml' path='doc/member[@name="DXCoreAdapterProcessSetQueryOutput"]/*' />
public partial struct DXCoreAdapterProcessSetQueryOutput
{
    /// <include file='DXCoreAdapterProcessSetQueryOutput.xml' path='doc/member[@name="DXCoreAdapterProcessSetQueryOutput.processesWritten"]/*' />
    [NativeTypeName("uint32_t")]
    public uint processesWritten;

    /// <include file='DXCoreAdapterProcessSetQueryOutput.xml' path='doc/member[@name="DXCoreAdapterProcessSetQueryOutput.processesTotal"]/*' />
    [NativeTypeName("uint32_t")]
    public uint processesTotal;
}
