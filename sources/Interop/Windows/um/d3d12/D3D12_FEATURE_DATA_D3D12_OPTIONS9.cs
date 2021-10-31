// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS9
    {
        public BOOL MeshShaderPipelineStatsSupported;

        public BOOL MeshShaderSupportsFullRangeRenderTargetArrayIndex;

        public BOOL AtomicInt64OnTypedResourceSupported;

        public BOOL AtomicInt64OnGroupSharedSupported;

        public BOOL DerivativesInMeshAndAmplificationShadersSupported;

        public D3D12_WAVE_MMA_TIER WaveMMATier;
    }
}
