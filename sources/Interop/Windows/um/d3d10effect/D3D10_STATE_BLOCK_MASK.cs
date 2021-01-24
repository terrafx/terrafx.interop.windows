// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D10_STATE_BLOCK_MASK
    {
        [NativeTypeName("BYTE")]
        public byte VS;

        [NativeTypeName("BYTE [2]")]
        public fixed byte VSSamplers[2];

        [NativeTypeName("BYTE [16]")]
        public fixed byte VSShaderResources[16];

        [NativeTypeName("BYTE [2]")]
        public fixed byte VSConstantBuffers[2];

        [NativeTypeName("BYTE")]
        public byte GS;

        [NativeTypeName("BYTE [2]")]
        public fixed byte GSSamplers[2];

        [NativeTypeName("BYTE [16]")]
        public fixed byte GSShaderResources[16];

        [NativeTypeName("BYTE [2]")]
        public fixed byte GSConstantBuffers[2];

        [NativeTypeName("BYTE")]
        public byte PS;

        [NativeTypeName("BYTE [2]")]
        public fixed byte PSSamplers[2];

        [NativeTypeName("BYTE [16]")]
        public fixed byte PSShaderResources[16];

        [NativeTypeName("BYTE [2]")]
        public fixed byte PSConstantBuffers[2];

        [NativeTypeName("BYTE [2]")]
        public fixed byte IAVertexBuffers[2];

        [NativeTypeName("BYTE")]
        public byte IAIndexBuffer;

        [NativeTypeName("BYTE")]
        public byte IAInputLayout;

        [NativeTypeName("BYTE")]
        public byte IAPrimitiveTopology;

        [NativeTypeName("BYTE")]
        public byte OMRenderTargets;

        [NativeTypeName("BYTE")]
        public byte OMDepthStencilState;

        [NativeTypeName("BYTE")]
        public byte OMBlendState;

        [NativeTypeName("BYTE")]
        public byte RSViewports;

        [NativeTypeName("BYTE")]
        public byte RSScissorRects;

        [NativeTypeName("BYTE")]
        public byte RSRasterizerState;

        [NativeTypeName("BYTE")]
        public byte SOBuffers;

        [NativeTypeName("BYTE")]
        public byte Predication;
    }
}
