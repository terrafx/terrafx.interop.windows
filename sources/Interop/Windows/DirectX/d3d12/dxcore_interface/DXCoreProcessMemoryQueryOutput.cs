// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreProcessMemoryQueryOutput.xml' path='doc/member[@name="DXCoreProcessMemoryQueryOutput"]/*' />
public partial struct DXCoreProcessMemoryQueryOutput
{
    /// <include file='DXCoreProcessMemoryQueryOutput.xml' path='doc/member[@name="DXCoreProcessMemoryQueryOutput.memoryUsage"]/*' />
    public DXCoreMemoryUsage memoryUsage;

    /// <include file='DXCoreProcessMemoryQueryOutput.xml' path='doc/member[@name="DXCoreProcessMemoryQueryOutput.processQuerySucceeded"]/*' />
    public bool processQuerySucceeded;
}
