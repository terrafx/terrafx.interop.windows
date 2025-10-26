// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreEngineNamePropertyInput.xml' path='doc/member[@name="DXCoreEngineNamePropertyInput"]/*' />
public unsafe partial struct DXCoreEngineNamePropertyInput
{
    /// <include file='DXCoreEngineNamePropertyInput.xml' path='doc/member[@name="DXCoreEngineNamePropertyInput.adapterEngineIndex"]/*' />
    public DXCoreAdapterEngineIndex adapterEngineIndex;

    /// <include file='DXCoreEngineNamePropertyInput.xml' path='doc/member[@name="DXCoreEngineNamePropertyInput.engineNameLength"]/*' />
    [NativeTypeName("uint32_t")]
    public uint engineNameLength;

    /// <include file='DXCoreEngineNamePropertyInput.xml' path='doc/member[@name="DXCoreEngineNamePropertyInput.engineName"]/*' />
    [NativeTypeName("wchar_t *")]
    public char* engineName;
}
