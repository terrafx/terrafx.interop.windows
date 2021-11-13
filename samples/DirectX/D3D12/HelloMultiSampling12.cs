// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12HelloWindow.h in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;
using static TerraFX.Interop.DirectX.D3D12_DSV_DIMENSION;
using static TerraFX.Interop.DirectX.D3D12_FEATURE;
using static TerraFX.Interop.DirectX.D3D12_HEAP_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_HEAP_TYPE;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_STATES;
using static TerraFX.Interop.DirectX.DirectX;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.DirectX.D3D12
{
    [SupportedOSPlatform("windows10.0")]
    public unsafe class HelloMultiSampling12 : HelloTriangle12
    {
        private ID3D12Resource*[] _msaaRenderTargets;
        private DXGI_SAMPLE_DESC _msaaDesc;

        public HelloMultiSampling12(string name) : base(name)
        {
            _msaaRenderTargets = new ID3D12Resource*[2];
            _msaaDesc = new DXGI_SAMPLE_DESC(2, DXGI_STANDARD_MULTISAMPLE_QUALITY_PATTERN);
        }

        public ID3D12Resource* MSAARenderTarget => _msaaRenderTargets[FrameIndex];

        public uint MSAACount
        {
            get
            {
                return _msaaDesc.Count;
            }

            set
            {
                var msaa = new D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS {
                    Format = BackBufferFormat,
                    SampleCount = value,
                };
                ThrowIfFailed(D3DDevice->CheckFeatureSupport(D3D12_FEATURE_MULTISAMPLE_QUALITY_LEVELS, &msaa, (uint)sizeof(D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS)));

                if (msaa.NumQualityLevels == 0)
                {
                    throw new NotSupportedException($"{value}x MSAA is not supported on your system");
                }

                // CheckFeatureSupport returns the number of quality levels
                // The max level is one less than the number of levels
                // It is common to have 1 quality level, so _msaaQuality is 0. This can be confusing, but just means the lowest quality setting,
                // rather than meaning not supported

                // There are 2 special values for quality levels
                // * -1 means all samples should be evenly distributed among the pixel
                // * -2 means all samples should be in the centre of the pixel
                _msaaDesc = new DXGI_SAMPLE_DESC(value, msaa.NumQualityLevels - 1);
            }
        }

        protected override ID3D12Resource* CreateDepthStencil()
        {
            ID3D12Resource* depthStencil;

            var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_DEFAULT);

            var resourceDesc = D3D12_RESOURCE_DESC.Tex2D(DepthBufferFormat, (uint)Size.Width, (uint)Size.Height, 1, 1, _msaaDesc.Count, _msaaDesc.Quality);
            resourceDesc.Flags |= D3D12_RESOURCE_FLAG_ALLOW_DEPTH_STENCIL;

            var clearValue = new D3D12_CLEAR_VALUE(DepthBufferFormat, 1.0f, 0);

            var iid = IID_ID3D12Resource;
            ThrowIfFailed(D3DDevice->CreateCommittedResource(&heapProperties, D3D12_HEAP_FLAG_NONE, &resourceDesc, D3D12_RESOURCE_STATE_DEPTH_WRITE, &clearValue, &iid, (void**)&depthStencil));

            var dsvDesc = new D3D12_DEPTH_STENCIL_VIEW_DESC {
                Format = DepthBufferFormat,
                ViewDimension = D3D12_DSV_DIMENSION_TEXTURE2DMS
            };
            D3DDevice->CreateDepthStencilView(depthStencil, &dsvDesc, DSVHeap->GetCPUDescriptorHandleForHeapStart());

            return depthStencil;
        }

        protected override void CreateRenderTargetViews()
        {
            var rtvHandle = RTVHeap->GetCPUDescriptorHandleForHeapStart();

            for (var i = 0u; i < FrameCount; i++)
            {
                D3DDevice->CreateRenderTargetView(_msaaRenderTargets[i], pDesc: null, rtvHandle);
                _ = rtvHandle.Offset(1, RTVDescriptorSize);
            }
        }

        protected override void CreateWindowSizeDependentResources()
        {
            _msaaRenderTargets = CreateMSAARenderTargets();
            base.CreateWindowSizeDependentResources();

            ID3D12Resource*[] CreateMSAARenderTargets()
            {
                var msaaRenderTargets = new ID3D12Resource*[FrameCount];

                var desc = new D3D12_RESOURCE_DESC {
                    Height = (uint)Size.Height,
                    Width = (uint)Size.Width,
                    DepthOrArraySize = 1,
                    SampleDesc = _msaaDesc,
                    Dimension = D3D12_RESOURCE_DIMENSION_TEXTURE2D,
                    Flags = D3D12_RESOURCE_FLAG_ALLOW_RENDER_TARGET,
                    Format = BackBufferFormat,
                    MipLevels = 1
                };

                var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_DEFAULT);

                var clearColor = BackgroundColor;
                var clearValue = new D3D12_CLEAR_VALUE(BackBufferFormat, (float*)&clearColor);

                var iid = IID_ID3D12Resource;

                for (var i = 0u; i < FrameCount; i++)
                {
                    ID3D12Resource* msaaRenderTarget;
                    ThrowIfFailed(D3DDevice->CreateCommittedResource(&heapProperties, D3D12_HEAP_FLAG_NONE, &desc, D3D12_RESOURCE_STATE_RENDER_TARGET, &clearValue, &iid, (void**)&msaaRenderTarget));
                    msaaRenderTargets[i] = msaaRenderTarget;
                }

                return msaaRenderTargets;
            }
        }

        protected override void TransitionForRender()
        {
        }

        protected override void TransitionForPresent()
        {
            if (MSAACount > 1)
            {
                var barriers = stackalloc D3D12_RESOURCE_BARRIER[2];

                barriers[0] = D3D12_RESOURCE_BARRIER.InitTransition(MSAARenderTarget, D3D12_RESOURCE_STATE_RENDER_TARGET, D3D12_RESOURCE_STATE_RESOLVE_SOURCE);
                barriers[1] = D3D12_RESOURCE_BARRIER.InitTransition(RenderTarget, D3D12_RESOURCE_STATE_PRESENT, D3D12_RESOURCE_STATE_RESOLVE_DEST);

                GraphicsCommandList->ResourceBarrier(2, barriers);
                GraphicsCommandList->ResolveSubresource(RenderTarget, 0, MSAARenderTarget, 0, BackBufferFormat);

                barriers[0] = D3D12_RESOURCE_BARRIER.InitTransition(MSAARenderTarget, D3D12_RESOURCE_STATE_RESOLVE_SOURCE, D3D12_RESOURCE_STATE_RENDER_TARGET);
                barriers[1] = D3D12_RESOURCE_BARRIER.InitTransition(RenderTarget, D3D12_RESOURCE_STATE_RESOLVE_DEST, D3D12_RESOURCE_STATE_PRESENT);
                GraphicsCommandList->ResourceBarrier(2, barriers);
            }
            else
            {
                var barriers = stackalloc D3D12_RESOURCE_BARRIER[2];

                barriers[0] = D3D12_RESOURCE_BARRIER.InitTransition(MSAARenderTarget, D3D12_RESOURCE_STATE_RENDER_TARGET, D3D12_RESOURCE_STATE_COPY_SOURCE);
                barriers[1] = D3D12_RESOURCE_BARRIER.InitTransition(RenderTarget, D3D12_RESOURCE_STATE_PRESENT, D3D12_RESOURCE_STATE_COPY_DEST);

                GraphicsCommandList->ResourceBarrier(2, barriers);
                GraphicsCommandList->CopyResource(RenderTarget, MSAARenderTarget);

                barriers[0] = D3D12_RESOURCE_BARRIER.InitTransition(MSAARenderTarget, D3D12_RESOURCE_STATE_COPY_SOURCE, D3D12_RESOURCE_STATE_RENDER_TARGET);
                barriers[1] = D3D12_RESOURCE_BARRIER.InitTransition(RenderTarget, D3D12_RESOURCE_STATE_COPY_DEST, D3D12_RESOURCE_STATE_PRESENT);
                GraphicsCommandList->ResourceBarrier(2, barriers);
            }
        }
    }
}
