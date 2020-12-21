// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Numerics;
using TerraFX.Interop;
using static TerraFX.Interop.D3D_DRIVER_TYPE;
using static TerraFX.Interop.D3D_FEATURE_LEVEL;
using static TerraFX.Interop.D3D_PRIMITIVE_TOPOLOGY;
using static TerraFX.Interop.D3D11_BIND_FLAG;
using static TerraFX.Interop.D3D11_INPUT_CLASSIFICATION;
using static TerraFX.Interop.D3D11_USAGE;
using static TerraFX.Interop.DXGI_FORMAT;
using static TerraFX.Interop.DXGI_SWAP_EFFECT;
using static TerraFX.Interop.Windows;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.DirectX.D3D11
{
    public unsafe class HelloTriangle11 : HelloWindow11
    {
        private ID3D11VertexShader* _vertexShader;
        private ID3D11InputLayout* _inputLayout;
        private ID3D11PixelShader* _pixelShader;
        private ID3D11Buffer* _vertexBuffer;

        public HelloTriangle11(string name) : base(name)
        {
        }

        protected override void CreateAssets()
        {
            _inputLayout = CreateInputLayout();
            CreateBuffers();
            base.CreateAssets();

            ID3D11InputLayout* CreateInputLayout()
            {
                using ComPtr<ID3DBlob> vertexShaderBlob = null;
                using ComPtr<ID3DBlob> pixelShaderBlob = null;

                fixed (char* fileName = GetAssetFullPath(@"D3D11\Assets\Shaders\HelloTriangle.hlsl"))
                fixed (ID3D11VertexShader** vertexShader = &_vertexShader)
                fixed (ID3D11PixelShader** pixelShader = &_pixelShader)
                {
                    var entryPoint = 0x00006E69614D5356;    // VSMain
                    var target = 0x0000305F345F7376;        // vs_4_0
                    ThrowIfFailed(nameof(D3DCompileFromFile), D3DCompileFromFile((ushort*)fileName, null, null, (sbyte*)&entryPoint, (sbyte*)&target, 0, 0, vertexShaderBlob.GetAddressOf(), null));

                    ThrowIfFailed(nameof(ID3D11Device.CreateVertexShader), D3DDevice->CreateVertexShader(vertexShaderBlob.Get()->GetBufferPointer(), vertexShaderBlob.Get()->GetBufferSize(), pClassLinkage: null, vertexShader));

                    entryPoint = 0x00006E69614D5350;        // PSMain
                    target = 0x0000305F345F7370;            // ps_4_0
                    ThrowIfFailed(nameof(D3DCompileFromFile), D3DCompileFromFile((ushort*)fileName, null, null, (sbyte*)&entryPoint, (sbyte*)&target, 0, 0, pixelShaderBlob.GetAddressOf(), null));

                    ThrowIfFailed(nameof(ID3D11Device.CreatePixelShader), D3DDevice->CreatePixelShader(pixelShaderBlob.Get()->GetBufferPointer(), pixelShaderBlob.Get()->GetBufferSize(), pClassLinkage: null, pixelShader));
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

                ID3D11InputLayout* inputLayout;
                ThrowIfFailed(nameof(ID3D11Device.CreateInputLayout), D3DDevice->CreateInputLayout(inputElementDescs, NumElements: 2, vertexShaderBlob.Get()->GetBufferPointer(), vertexShaderBlob.Get()->GetBufferSize(), &inputLayout));
                return inputLayout;
            }
        }

        protected virtual void CreateBuffers()
        {
            _vertexBuffer = CreateVertexBuffer();       
        }

        protected virtual ID3D11Buffer* CreateVertexBuffer()
        {
            var triangleVertices = stackalloc Vertex[3];
            {
                triangleVertices[0] = new Vertex {
                    Position = new Vector3(0.0f, 0.25f * AspectRatio, 0.0f),
                    Color = new Vector4(1.0f, 0.0f, 0.0f, 1.0f)
                };
                triangleVertices[1] = new Vertex {
                    Position = new Vector3(0.25f, -0.25f * AspectRatio, 0.0f),
                    Color = new Vector4(0.0f, 1.0f, 0.0f, 1.0f)
                };
                triangleVertices[2] = new Vertex {
                    Position = new Vector3(-0.25f, -0.25f * AspectRatio, 0.0f),
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

            ID3D11Buffer* vertexBuffer;
            ThrowIfFailed(nameof(ID3D11Device.CreateBuffer), D3DDevice->CreateBuffer(&vertexBufferDesc, &vertexBufferData, &vertexBuffer));
            return vertexBuffer;
        }

        protected override void DestroyAssets()
        {
            DestroyBuffers();
            DestroyInputLayout();

            void DestroyInputLayout()
            {
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
            }
        }

        protected virtual void DestroyBuffers()
        {
            DestroyVertexBuffer();

            void DestroyVertexBuffer()
            {
                var vertexBuffer = _vertexBuffer;

                if (vertexBuffer != null)
                {
                    _vertexBuffer = null;
                    _ = vertexBuffer->Release();
                }
            }
        }

        protected override void Draw()
        {
            ImmediateContext->IASetInputLayout(_inputLayout);

            var stride = (uint)sizeof(Vertex);
            var offset = 0u;

            var vertexBuffer = _vertexBuffer;
            ImmediateContext->IASetVertexBuffers(0, 1, &vertexBuffer, &stride, &offset);

            ImmediateContext->IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST);

            ImmediateContext->VSSetShader(_vertexShader, null, 0);
            ImmediateContext->PSSetShader(_pixelShader, null, 0);

            ImmediateContext->Draw(3, 0);
        }

        private struct Vertex
        {
            public Vector3 Position;

            public Vector4 Color;
        }
    }
}
