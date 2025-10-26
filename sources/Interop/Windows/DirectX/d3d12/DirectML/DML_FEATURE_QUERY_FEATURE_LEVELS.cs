// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_FEATURE_QUERY_FEATURE_LEVELS.xml' path='doc/member[@name="DML_FEATURE_QUERY_FEATURE_LEVELS"]/*' />
public unsafe partial struct DML_FEATURE_QUERY_FEATURE_LEVELS
{
    /// <include file='DML_FEATURE_QUERY_FEATURE_LEVELS.xml' path='doc/member[@name="DML_FEATURE_QUERY_FEATURE_LEVELS.RequestedFeatureLevelCount"]/*' />
    public uint RequestedFeatureLevelCount;

    /// <include file='DML_FEATURE_QUERY_FEATURE_LEVELS.xml' path='doc/member[@name="DML_FEATURE_QUERY_FEATURE_LEVELS.RequestedFeatureLevels"]/*' />
    [NativeTypeName("const DML_FEATURE_LEVEL *")]
    public DML_FEATURE_LEVEL* RequestedFeatureLevels;
}
