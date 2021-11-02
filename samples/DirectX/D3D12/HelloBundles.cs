// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12HelloBundles in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using TerraFX.Interop;
using static TerraFX.Interop.D3D_PRIMITIVE_TOPOLOGY;
using static TerraFX.Interop.D3D12_COMMAND_LIST_TYPE;
using static TerraFX.Interop.Windows;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.DirectX.D3D12
{
    public unsafe class HelloBundles12 : HelloTriangle12
    {
        // Pipeline objects
        private ID3D12CommandAllocator* _bundleAllocator;
        private ID3D12GraphicsCommandList* _bundle;

        public HelloBundles12(string name) : base(name)
        {
        }

        protected override void CreateAssets()
        {
            base.CreateAssets();

            _bundleAllocator = CreateBundleAllocator();
            _bundle = CreateBundle();

            ID3D12GraphicsCommandList* CreateBundle()
            {
                ID3D12GraphicsCommandList* bundle;

                var iid = IID_ID3D12GraphicsCommandList;
                ThrowIfFailed(D3DDevice->CreateCommandList(nodeMask: 0, D3D12_COMMAND_LIST_TYPE_BUNDLE, _bundleAllocator, PipelineState, &iid, (void**)&bundle));

                bundle->SetGraphicsRootSignature(RootSignature);
                bundle->IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST);

                fixed (D3D12_VERTEX_BUFFER_VIEW* pVertexBufferView = &VertexBufferView)
                {
                    bundle->IASetVertexBuffers(StartSlot: 0, 1, pVertexBufferView);
                }

                bundle->DrawInstanced(3, 1, 0, 0);
                ThrowIfFailed(bundle->Close());

                return bundle;
            }

            ID3D12CommandAllocator* CreateBundleAllocator()
            {
                ID3D12CommandAllocator* bundleAllocator;

                var iid = IID_ID3D12CommandAllocator;
                ThrowIfFailed(D3DDevice->CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE_BUNDLE, &iid, (void**)&bundleAllocator));

                return bundleAllocator;
            }
        }

        protected override void DestroyAssets()
        {
            DestroyBundle();
            DestroyBundleAllocator();
            base.DestroyAssets();

            void DestroyBundle()
            {
                var bundle = _bundle;

                if (bundle != null)
                {
                    _bundle = null;
                    _ = bundle->Release();
                }
            }

            void DestroyBundleAllocator()
            {
                var bundleAllocator = _bundleAllocator;

                if (bundleAllocator != null)
                {
                    _bundleAllocator = null;
                    _ = bundleAllocator->Release();
                }
            }
        }

        protected override void Draw()
        {
            // Execute the commands stored in the bundle.
            GraphicsCommandList->ExecuteBundle(_bundle);
        }
    }
}
