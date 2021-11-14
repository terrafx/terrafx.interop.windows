// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    public unsafe partial struct D3D10_STATE_BLOCK_MASK
    {
        public byte VS;

        [NativeTypeName("BYTE [2]")]
        public fixed byte VSSamplers[2];

        [NativeTypeName("BYTE [16]")]
        public fixed byte VSShaderResources[16];

        [NativeTypeName("BYTE [2]")]
        public fixed byte VSConstantBuffers[2];

        public byte GS;

        [NativeTypeName("BYTE [2]")]
        public fixed byte GSSamplers[2];

        [NativeTypeName("BYTE [16]")]
        public fixed byte GSShaderResources[16];

        [NativeTypeName("BYTE [2]")]
        public fixed byte GSConstantBuffers[2];

        public byte PS;

        [NativeTypeName("BYTE [2]")]
        public fixed byte PSSamplers[2];

        [NativeTypeName("BYTE [16]")]
        public fixed byte PSShaderResources[16];

        [NativeTypeName("BYTE [2]")]
        public fixed byte PSConstantBuffers[2];

        [NativeTypeName("BYTE [2]")]
        public fixed byte IAVertexBuffers[2];

        public byte IAIndexBuffer;

        public byte IAInputLayout;

        public byte IAPrimitiveTopology;

        public byte OMRenderTargets;

        public byte OMDepthStencilState;

        public byte OMBlendState;

        public byte RSViewports;

        public byte RSScissorRects;

        public byte RSRasterizerState;

        public byte SOBuffers;

        public byte Predication;
    }
}
