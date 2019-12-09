// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Numerics;
using TerraFX.Interop;
using static TerraFX.Interop.D3D_DRIVER_TYPE;
using static TerraFX.Interop.D3D_FEATURE_LEVEL;
using static TerraFX.Interop.D3D_PRIMITIVE_TOPOLOGY;
using static TerraFX.Interop.D3D11;
using static TerraFX.Interop.D3D11_BIND_FLAG;
using static TerraFX.Interop.D3D11_INPUT_CLASSIFICATION;
using static TerraFX.Interop.D3D11_USAGE;
using static TerraFX.Interop.D3DCompiler;
using static TerraFX.Interop.DXGI;
using static TerraFX.Interop.DXGI_FORMAT;
using static TerraFX.Interop.DXGI_SWAP_EFFECT;
using static TerraFX.Interop.Windows;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.DirectX.D3D11
{
    public unsafe class HelloTriangle11 : DX11Sample
    {
        private const uint FrameCount = 2;

        private IDXGISwapChain* _swapChain;
        private ID3D11Device* _device;
        private ID3D11DeviceContext* _immediateContext;
        private ID3D11RenderTargetView* _renderTarget;
        private ID3D11VertexShader* _vertexShader;
        private ID3D11InputLayout* _inputLayout;
        private ID3D11PixelShader* _pixelShader;
        private ID3D11Buffer* _vertexBuffer;

        public HelloTriangle11(uint width, uint height, string name)
            : base(width, height, name)
        {
        }

        public override void OnInit()
        {
            Guid iid;
            IDXGIFactory1* factory = null;
            IDXGIAdapter* adapter = null;
            ID3D11Texture2D* backBuffer = null;
            ID3DBlob* vertexShaderBlob = null;
            ID3DBlob* pixelShaderBlob = null;

            try
            {
                iid = IID_IDXGIFactory1;
                ThrowIfFailed(nameof(CreateDXGIFactory1), CreateDXGIFactory1(&iid, (void**)&factory));

                if (_useWarpDevice)
                {
                    throw new NotImplementedException("WARP Device not supported for D3D11.");
                }
                else
                {
                    adapter = GetHardwareAdapter(factory);
                }

                fixed (ID3D11Device** device = &_device)
                fixed (ID3D11DeviceContext** immediateContext = &_immediateContext)
                {
                    var featureLevel = D3D_FEATURE_LEVEL_11_0;
                    ThrowIfFailed(nameof(D3D11CreateDevice), D3D11CreateDevice(adapter, D3D_DRIVER_TYPE_HARDWARE, Software: IntPtr.Zero, Flags: 0, &featureLevel, FeatureLevels: 1, D3D11_SDK_VERSION, device, pFeatureLevel: null, immediateContext));
                }

                // Describe and create the swap chain.
                var swapChainDesc = new DXGI_SWAP_CHAIN_DESC {
                    BufferDesc = new DXGI_MODE_DESC {
                        Width = _width,
                        Height = _height,
                        Format = DXGI_FORMAT_R8G8B8A8_UNORM,
                    },
                    SampleDesc = new DXGI_SAMPLE_DESC {
                        Count = 1
                    },
                    BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT,
                    BufferCount = FrameCount,
                    OutputWindow = Win32Application.Hwnd,
                    Windowed = TRUE,
                    SwapEffect = DXGI_SWAP_EFFECT_DISCARD,
                };

                fixed (IDXGISwapChain** swapChain = &_swapChain)
                {
                    ThrowIfFailed(nameof(IDXGIFactory1.CreateSwapChain), factory->CreateSwapChain(
                        (IUnknown*)_device,
                        &swapChainDesc,
                        swapChain
                    ));
                }

                // This sample does not support fullscreen transitions.
                ThrowIfFailed(nameof(IDXGIFactory.MakeWindowAssociation), factory->MakeWindowAssociation(Win32Application.Hwnd, DXGI_MWA_NO_ALT_ENTER));

                fixed (ID3D11RenderTargetView** renderTarget = &_renderTarget)
                {
                    iid = IID_ID3D11Texture2D;

                    ThrowIfFailed(nameof(IDXGISwapChain.GetBuffer), _swapChain->GetBuffer(0, &iid, (void**)&backBuffer));
                    ThrowIfFailed(nameof(ID3D11Device.CreateRenderTargetView), _device->CreateRenderTargetView((ID3D11Resource*)backBuffer, null, renderTarget));

                    _immediateContext->OMSetRenderTargets(1, renderTarget, pDepthStencilView: null);
                }

                var vp = new D3D11_VIEWPORT {
                    Width = _width,
                    Height = _height,
                    MinDepth = 0.0f,
                    MaxDepth = 1.0f,
                    TopLeftX = 0,
                    TopLeftY = 0,
                };
                _immediateContext->RSSetViewports(1, &vp);

                var compileFlags = 0u;

                fixed (char* fileName = GetAssetFullPath(@"D3D11\Assets\Shaders\HelloTriangle.hlsl"))
                fixed (ID3D11VertexShader** vertexShader = &_vertexShader)
                fixed (ID3D11PixelShader** pixelShader = &_pixelShader)
                {
                    var entryPoint = 0x00006E69614D5356;    // VSMain
                    var target = 0x0000305F345F7376;        // vs_4_0
                    ThrowIfFailed(nameof(D3DCompileFromFile), D3DCompileFromFile((ushort*)fileName, null, null, (sbyte*)&entryPoint, (sbyte*)&target, compileFlags, 0, &vertexShaderBlob, null));

                    ThrowIfFailed(nameof(ID3D11Device.CreateVertexShader), _device->CreateVertexShader(vertexShaderBlob->GetBufferPointer(), vertexShaderBlob->GetBufferSize(), pClassLinkage: null, vertexShader));

                    entryPoint = 0x00006E69614D5350;        // PSMain
                    target = 0x0000305F345F7370;            // ps_4_0
                    ThrowIfFailed(nameof(D3DCompileFromFile), D3DCompileFromFile((ushort*)fileName, null, null, (sbyte*)&entryPoint, (sbyte*)&target, compileFlags, 0, &pixelShaderBlob, null));

                    ThrowIfFailed(nameof(ID3D11Device.CreatePixelShader), _device->CreatePixelShader(pixelShaderBlob->GetBufferPointer(), pixelShaderBlob->GetBufferSize(), pClassLinkage: null, pixelShader));
                }

                var inputElementDescs = stackalloc D3D11_INPUT_ELEMENT_DESC[2];
                {
                    var semanticName0 = stackalloc sbyte[9];
                    {
                        ((ulong*)semanticName0)[0] = 0x4E4F495449534F50;      // POSITION
                    }
                    inputElementDescs[0] = new D3D11_INPUT_ELEMENT_DESC {
                        SemanticName = semanticName0,
                        SemanticIndex = 0,
                        Format = DXGI_FORMAT_R32G32B32_FLOAT,
                        InputSlot = 0,
                        AlignedByteOffset = 0,
                        InputSlotClass = D3D11_INPUT_PER_VERTEX_DATA,
                        InstanceDataStepRate = 0
                    };

                    var semanticName1 = 0x000000524F4C4F43;                     // COLOR
                    inputElementDescs[1] = new D3D11_INPUT_ELEMENT_DESC {
                        SemanticName = (sbyte*)&semanticName1,
                        SemanticIndex = 0,
                        Format = DXGI_FORMAT_R32G32B32A32_FLOAT,
                        InputSlot = 0,
                        AlignedByteOffset = 12,
                        InputSlotClass = D3D11_INPUT_PER_VERTEX_DATA,
                        InstanceDataStepRate = 0
                    };
                }

                fixed (ID3D11InputLayout** inputLayout = &_inputLayout)
                {
                    ThrowIfFailed(nameof(ID3D11Device.CreateInputLayout), _device->CreateInputLayout(inputElementDescs, NumElements: 2, vertexShaderBlob->GetBufferPointer(), vertexShaderBlob->GetBufferSize(), inputLayout));
                }

                _immediateContext->IASetInputLayout(_inputLayout);

                var triangleVertices = stackalloc Vertex[3];
                {
                    triangleVertices[0] = new Vertex {
                        Position = new Vector3(0.0f, 0.25f * _aspectRatio, 0.0f),
                        Color = new Vector4(1.0f, 0.0f, 0.0f, 1.0f)
                    };
                    triangleVertices[1] = new Vertex {
                        Position = new Vector3(0.25f, -0.25f * _aspectRatio, 0.0f),
                        Color = new Vector4(0.0f, 1.0f, 0.0f, 1.0f)
                    };
                    triangleVertices[2] = new Vertex {
                        Position = new Vector3(-0.25f, -0.25f * _aspectRatio, 0.0f),
                        Color = new Vector4(0.0f, 0.0f, 1.0f, 1.0f)
                    };
                }

                var vertexBufferSize = (uint)sizeof(Vertex) * 3;

                var vertexBufferDesc = new D3D11_BUFFER_DESC {
                    ByteWidth = vertexBufferSize,
                    Usage = D3D11_USAGE_DEFAULT,
                    BindFlags = (uint)D3D11_BIND_VERTEX_BUFFER
                };

                var vertexBufferData = new D3D11_SUBRESOURCE_DATA {
                    pSysMem = triangleVertices
                };

                fixed (ID3D11Buffer** vertexBuffer = &_vertexBuffer)
                {
                    ThrowIfFailed(nameof(ID3D11Device.CreateBuffer), _device->CreateBuffer(&vertexBufferDesc, &vertexBufferData, vertexBuffer));

                    var stride = (uint)sizeof(Vertex);
                    var offset = 0u;

                    _immediateContext->IASetVertexBuffers(0, 1, vertexBuffer, &stride, &offset);
                }

                _immediateContext->IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST);
            }
            finally
            {
                if (pixelShaderBlob != null)
                {
                    _ = pixelShaderBlob->Release();
                }

                if (vertexShaderBlob != null)
                {
                    _ = vertexShaderBlob->Release();
                }

                if (backBuffer != null)
                {
                    _ = backBuffer->Release();
                }

                if (adapter != null)
                {
                    _ = adapter->Release();
                }

                if (factory != null)
                {
                    _ = factory->Release();
                }
            }
        }

        // Update frame-based values.
        public override void OnUpdate()
        {
        }

        // Render the scene.
        public override void OnRender()
        {
            // Clear the back buffer
            var clearColor = stackalloc float[4];
            {
                clearColor[0] = 0.0f;
                clearColor[1] = 0.2f;
                clearColor[2] = 0.4f;
                clearColor[3] = 1.0f;
            }
            _immediateContext->ClearRenderTargetView(_renderTarget, clearColor);

            // Render a triangle
            _immediateContext->VSSetShader(_vertexShader, null, 0);
            _immediateContext->PSSetShader(_pixelShader, null, 0);
            _immediateContext->Draw(3, 0);

            // Present the frame
            ThrowIfFailed(nameof(IDXGISwapChain.Present), _swapChain->Present(0, 0));
        }

        public override void OnDestroy()
        {
            _immediateContext->ClearState();
        }

        protected override void Dispose(bool isDisposing)
        {
            var vertexBuffer = _vertexBuffer;

            if (vertexBuffer != null)
            {
                _vertexBuffer = null;
                _ = vertexBuffer->Release();
            }

            var inputLayout = _inputLayout;

            if (inputLayout != null)
            {
                _inputLayout = null;
                _ = inputLayout->Release();
            }

            var pixelShader = _pixelShader;

            if (pixelShader != null)
            {
                _pixelShader = null;
                _ = pixelShader->Release();
            }

            var vertexShader = _vertexShader;

            if (vertexShader != null)
            {
                _vertexShader = null;
                _ = vertexShader->Release();
            }

            var swapChain = _swapChain;

            if (swapChain != null)
            {
                _swapChain = null;
                _ = swapChain->Release();
            }

            var immediateContext = _immediateContext;

            if (immediateContext != null)
            {
                _immediateContext = null;
                _ = immediateContext->Release();
            }

            var device = _device;

            if (device != null)
            {
                _device = null;
                _ = device->Release();
            }

            var renderTarget = _renderTarget;

            if (renderTarget != null)
            {
                _renderTarget = null;
                _ = renderTarget->Release();
            }

            base.Dispose(isDisposing);
        }

        private struct Vertex
        {
            public Vector3 Position;

            public Vector4 Color;
        }
    }
}
