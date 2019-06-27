// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>This defines the input layout of vertices and the vertex shader which processes them.</summary>
    public unsafe struct D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES
    {
        #region Fields
        [NativeTypeName("BYTE[]")]
        public byte* shaderBufferWithInputSignature;

        [NativeTypeName("UINT32")]
        public uint shaderBufferSize;

        [NativeTypeName("D2D1_INPUT_ELEMENT_DESC[]")]
        public D2D1_INPUT_ELEMENT_DESC* inputElements;

        [NativeTypeName("UINT32")]
        public uint elementCount;

        [NativeTypeName("UINT32")]
        public uint stride;
        #endregion
    }
}
