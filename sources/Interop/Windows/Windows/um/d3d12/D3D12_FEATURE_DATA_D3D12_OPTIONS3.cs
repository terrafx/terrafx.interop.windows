// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS3
    {
        public BOOL CopyQueueTimestampQueriesSupported;

        public BOOL CastingFullyTypedFormatSupported;

        public D3D12_COMMAND_LIST_SUPPORT_FLAGS WriteBufferImmediateSupportFlags;

        public D3D12_VIEW_INSTANCING_TIER ViewInstancingTier;

        public BOOL BarycentricsSupported;
    }
}
