// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_VIDEO_PROCESSOR_STREAM
    {
        [NativeTypeName("BOOL")]
        public int Enable;

        [NativeTypeName("UINT")]
        public uint OutputIndex;

        [NativeTypeName("UINT")]
        public uint InputFrameOrField;

        [NativeTypeName("UINT")]
        public uint PastFrames;

        [NativeTypeName("UINT")]
        public uint FutureFrames;

        [NativeTypeName("ID3D11VideoProcessorInputView **")]
        public ID3D11VideoProcessorInputView** ppPastSurfaces;

        [NativeTypeName("ID3D11VideoProcessorInputView *")]
        public ID3D11VideoProcessorInputView* pInputSurface;

        [NativeTypeName("ID3D11VideoProcessorInputView **")]
        public ID3D11VideoProcessorInputView** ppFutureSurfaces;

        [NativeTypeName("ID3D11VideoProcessorInputView **")]
        public ID3D11VideoProcessorInputView** ppPastSurfacesRight;

        [NativeTypeName("ID3D11VideoProcessorInputView *")]
        public ID3D11VideoProcessorInputView* pInputSurfaceRight;

        [NativeTypeName("ID3D11VideoProcessorInputView **")]
        public ID3D11VideoProcessorInputView** ppFutureSurfacesRight;
    }
}
