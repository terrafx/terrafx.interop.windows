// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12SerializeRootSignature([NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")] D3D12_ROOT_SIGNATURE_DESC* pRootSignature, D3D_ROOT_SIGNATURE_VERSION Version, ID3DBlob** ppBlob, ID3DBlob** ppErrorBlob);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12CreateRootSignatureDeserializer([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSizeInBytes, [NativeTypeName("const IID &")] Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pRootSignature, ID3DBlob** ppBlob, ID3DBlob** ppErrorBlob);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12CreateVersionedRootSignatureDeserializer([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSizeInBytes, [NativeTypeName("const IID &")] Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_PROTECTED_RESOURCES_SESSION_HARDWARE_PROTECTED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4E, 0x08, 0xB0, 0x62,
                    0x0E, 0xC7,
                    0xAA, 0x4D,
                    0xA1,
                    0x09,
                    0x30,
                    0xFF,
                    0x8D,
                    0x5A,
                    0x04,
                    0x82
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12CreateDevice(IUnknown* pAdapter, D3D_FEATURE_LEVEL MinimumFeatureLevel, [NativeTypeName("const IID &")] Guid* riid, void** ppDevice);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12GetDebugInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvDebug);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12EnableExperimentalFeatures(uint NumFeatures, [NativeTypeName("const IID *")] Guid* pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes);

        [NativeTypeName("const UUID")]
        public static ref readonly Guid D3D12ExperimentalShaderModels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3E, 0x57, 0xF5, 0x76,
                    0x3A, 0xF1,
                    0xF5, 0x40,
                    0xB2,
                    0x97,
                    0x81,
                    0xCE,
                    0x9E,
                    0x18,
                    0x93,
                    0x3F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const UUID")]
        public static ref readonly Guid D3D12TiledResourceTier4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5F, 0x72, 0xC4, 0xC9,
                    0x1A, 0xA8,
                    0x56, 0x4F,
                    0x8C,
                    0x5B,
                    0xC5,
                    0x10,
                    0x39,
                    0xD6,
                    0x94,
                    0xFB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const UUID")]
        public static ref readonly Guid D3D12MetaCommand
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7E, 0xC9, 0x34, 0xC7,
                    0x77, 0x80,
                    0xC8, 0x48,
                    0x9F,
                    0xDC,
                    0xD9,
                    0xD1,
                    0xDD,
                    0x31,
                    0xDD,
                    0x77
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_D3D12Debug
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEB, 0x2A, 0x35, 0xF2,
                    0x84, 0xDD,
                    0xFE, 0x49,
                    0xB9,
                    0x7B,
                    0xA9,
                    0xDC,
                    0xFD,
                    0xCC,
                    0x1B,
                    0x4F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_D3D12Tools
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB1, 0x16, 0x82, 0xE3,
                    0x8C, 0x3C,
                    0x33, 0x48,
                    0xAA,
                    0x09,
                    0x0A,
                    0x06,
                    0xB6,
                    0x5D,
                    0x96,
                    0xC8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_D3D12DeviceRemovedExtendedData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC4, 0xBB, 0x75, 0x4A,
                    0xF4, 0x9F,
                    0xD8, 0x4A,
                    0x9F,
                    0x18,
                    0xAB,
                    0xAE,
                    0x84,
                    0xDC,
                    0x5F,
                    0xF2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_D3D12SDKConfiguration
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0x6A, 0xDA, 0x7C,
                    0x3E, 0xA0,
                    0xC8, 0x49,
                    0x94,
                    0x58,
                    0x03,
                    0x34,
                    0xD2,
                    0x0E,
                    0x07,
                    0xCE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12GetInterface([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, void** ppvDebug);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Object
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0xC2, 0xFE, 0xC4,
                    0x66, 0x79,
                    0x95, 0x4E,
                    0x9F,
                    0x94,
                    0xF4,
                    0x31,
                    0xCB,
                    0x56,
                    0xC3,
                    0xB8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12DeviceChild
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4B, 0xB9, 0x5D, 0x90,
                    0x0C, 0xA0,
                    0x40, 0x41,
                    0x9D,
                    0xF5,
                    0x2B,
                    0x64,
                    0xCA,
                    0x9E,
                    0xA3,
                    0x57
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12RootSignature
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0x6B, 0x4A, 0xC5,
                    0xDF, 0x72,
                    0xE8, 0x4E,
                    0x8B,
                    0xE5,
                    0xA9,
                    0x46,
                    0xA1,
                    0x42,
                    0x92,
                    0x14
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12RootSignatureDeserializer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7B, 0x64, 0xAB, 0x34,
                    0xC8, 0x3C,
                    0xAC, 0x46,
                    0x84,
                    0x1B,
                    0xC0,
                    0x96,
                    0x56,
                    0x45,
                    0xC0,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VersionedRootSignatureDeserializer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x67, 0xCE, 0x91, 0x7F,
                    0x0C, 0x09,
                    0xB7, 0x4B,
                    0xB7,
                    0x8E,
                    0xED,
                    0x8F,
                    0xF2,
                    0xE3,
                    0x1D,
                    0xA0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Pageable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFB, 0x58, 0xEE, 0x63,
                    0x68, 0x12,
                    0x35, 0x48,
                    0x86,
                    0xDA,
                    0xF0,
                    0x08,
                    0xCE,
                    0x62,
                    0xF0,
                    0xD6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Heap
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0x25, 0x3B, 0x6B,
                    0x51, 0x6E,
                    0xB3, 0x45,
                    0x90,
                    0xEE,
                    0x98,
                    0x84,
                    0x26,
                    0x5E,
                    0x8D,
                    0xF3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Resource
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0x42, 0x64, 0x69,
                    0x2E, 0xA7,
                    0x59, 0x40,
                    0xBC,
                    0x79,
                    0x5B,
                    0x5C,
                    0x98,
                    0x04,
                    0x0F,
                    0xAD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12CommandAllocator
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE4, 0xDE, 0x02, 0x61,
                    0x59, 0xAF,
                    0x09, 0x4B,
                    0xB9,
                    0x99,
                    0xB4,
                    0x4D,
                    0x73,
                    0xF0,
                    0x9B,
                    0x24
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Fence
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0x3D, 0x75, 0x0A,
                    0xD8, 0xC4,
                    0x91, 0x4B,
                    0xAD,
                    0xF6,
                    0xBE,
                    0x5A,
                    0x60,
                    0xD9,
                    0x5A,
                    0x76
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Fence1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFE, 0x85, 0x36, 0x43,
                    0x2B, 0xE2,
                    0xA0, 0x4C,
                    0xA8,
                    0xDB,
                    0xB5,
                    0xB4,
                    0xF4,
                    0xDD,
                    0x0E,
                    0x4A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12PipelineState
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF3, 0x30, 0x5A, 0x76,
                    0x24, 0xF6,
                    0x6F, 0x4C,
                    0xA8,
                    0x28,
                    0xAC,
                    0xE9,
                    0x48,
                    0x62,
                    0x24,
                    0x45
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12DescriptorHeap
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1D, 0x47, 0xFB, 0x8E,
                    0x6C, 0x61,
                    0x49, 0x4F,
                    0x90,
                    0xF7,
                    0x12,
                    0x7B,
                    0xB7,
                    0x63,
                    0xFA,
                    0x51
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12QueryHeap
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAE, 0x58, 0x96, 0x0D,
                    0x45, 0xED,
                    0x9E, 0x46,
                    0xA6,
                    0x1D,
                    0x97,
                    0x0E,
                    0xC5,
                    0x83,
                    0xCA,
                    0xB4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12CommandSignature
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0x79, 0x6A, 0xC3,
                    0x80, 0xEC,
                    0x0A, 0x4F,
                    0x89,
                    0x85,
                    0xA7,
                    0xB2,
                    0x47,
                    0x50,
                    0x82,
                    0xD1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12CommandList
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1C, 0xD9, 0x16, 0x71,
                    0xE4, 0xE7,
                    0xCE, 0x47,
                    0xB8,
                    0xC6,
                    0xEC,
                    0x81,
                    0x68,
                    0xF4,
                    0x37,
                    0xE5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12GraphicsCommandList
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0F, 0x0D, 0x16, 0x5B,
                    0x1B, 0xAC,
                    0x85, 0x41,
                    0x8B,
                    0xA8,
                    0xB3,
                    0xAE,
                    0x42,
                    0xA5,
                    0xA4,
                    0x55
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12GraphicsCommandList1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFB, 0x03, 0x31, 0x55,
                    0xE7, 0x1F,
                    0x57, 0x45,
                    0xBB,
                    0x38,
                    0x94,
                    0x6D,
                    0x7D,
                    0x0E,
                    0x7C,
                    0xA7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12GraphicsCommandList2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0xE5, 0xC3, 0x38,
                    0x17, 0xFF,
                    0x2C, 0x41,
                    0x91,
                    0x50,
                    0x4F,
                    0xC6,
                    0xF9,
                    0xD7,
                    0x2A,
                    0x28
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12CommandQueue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0x70, 0xC8, 0x0E,
                    0x7E, 0x5D,
                    0x22, 0x4C,
                    0x8C,
                    0xFC,
                    0x5B,
                    0xAA,
                    0xE0,
                    0x76,
                    0x16,
                    0xED
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Device
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0x19, 0x98, 0x18,
                    0xB6, 0x1D,
                    0x57, 0x4B,
                    0xBE,
                    0x54,
                    0x18,
                    0x21,
                    0x33,
                    0x9B,
                    0x85,
                    0xF7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12PipelineLibrary
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA8, 0x26, 0x42, 0xC6,
                    0x01, 0x92,
                    0xAF, 0x46,
                    0xB4,
                    0xCC,
                    0x53,
                    0xFB,
                    0x9F,
                    0xF7,
                    0x41,
                    0x4F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12PipelineLibrary1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x42, 0xBF, 0xEA, 0x80,
                    0x68, 0x25,
                    0x5E, 0x4E,
                    0xBD,
                    0x82,
                    0xC3,
                    0x7F,
                    0x86,
                    0x96,
                    0x1D,
                    0xC3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Device1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xCE, 0xAC, 0x77,
                    0x8E, 0x63,
                    0x65, 0x4E,
                    0x88,
                    0x95,
                    0xC1,
                    0xF2,
                    0x33,
                    0x86,
                    0x86,
                    0x3E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Device2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1E, 0xA4, 0xBA, 0x30,
                    0x5B, 0xB1,
                    0x5C, 0x47,
                    0xA0,
                    0xBB,
                    0x1A,
                    0xF5,
                    0xC5,
                    0xB6,
                    0x43,
                    0x28
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Device3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0xDC, 0xDA, 0x81,
                    0xAD, 0x2B,
                    0x92, 0x43,
                    0x93,
                    0xC5,
                    0x10,
                    0x13,
                    0x45,
                    0xC4,
                    0xAA,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12ProtectedSession
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x18, 0x3D, 0x53, 0xA1,
                    0xC1, 0x0A,
                    0x84, 0x40,
                    0x85,
                    0xB9,
                    0x89,
                    0xA9,
                    0x61,
                    0x16,
                    0x80,
                    0x6B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12ProtectedResourceSession
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF4, 0x96, 0xD6, 0x6C,
                    0x89, 0xF2,
                    0xCC, 0x40,
                    0x80,
                    0x91,
                    0x5A,
                    0x6C,
                    0x0A,
                    0x09,
                    0x9C,
                    0x3D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Device4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x17, 0xDF, 0x65, 0xE8,
                    0xEE, 0xA9,
                    0xF9, 0x46,
                    0xA4,
                    0x63,
                    0x30,
                    0x98,
                    0x31,
                    0x5A,
                    0xA2,
                    0xE5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12LifetimeOwner
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9F, 0xAF, 0x67, 0xE6,
                    0x56, 0xCD,
                    0x46, 0x4F,
                    0x83,
                    0xCE,
                    0x03,
                    0x2E,
                    0x59,
                    0x5D,
                    0x70,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12SwapChainAssistant
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB6, 0x64, 0xDF, 0xF1,
                    0xFD, 0x57,
                    0xCD, 0x49,
                    0x88,
                    0x07,
                    0xC0,
                    0xEB,
                    0x88,
                    0xB4,
                    0x5C,
                    0x8F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12LifetimeTracker
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0x3D, 0xD0, 0x3F,
                    0xB1, 0x4E,
                    0x4A, 0x42,
                    0xA5,
                    0x82,
                    0x49,
                    0x4E,
                    0xCB,
                    0x8B,
                    0xA8,
                    0x13
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12StateObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x43, 0x69, 0x01, 0x47,
                    0xA8, 0xFC,
                    0x94, 0x45,
                    0x93,
                    0xEA,
                    0xAF,
                    0x25,
                    0x8B,
                    0x55,
                    0x34,
                    0x6D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12StateObjectProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0xA8, 0x5F, 0xDE,
                    0xF9, 0x9B,
                    0x26, 0x4F,
                    0x89,
                    0xFF,
                    0xD7,
                    0xF5,
                    0x6F,
                    0xDE,
                    0x38,
                    0x60
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Device5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0x17, 0x4F, 0x8B,
                    0xEA, 0x2F,
                    0x80, 0x4B,
                    0x8F,
                    0x58,
                    0x43,
                    0x07,
                    0x19,
                    0x1A,
                    0xB9,
                    0x5D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedDataSettings
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1C, 0x48, 0xBC, 0x82,
                    0x9B, 0x6B,
                    0x30, 0x40,
                    0xAE,
                    0xDB,
                    0x7E,
                    0xE3,
                    0xD1,
                    0xDF,
                    0x1E,
                    0x63
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedDataSettings1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x51, 0xAE, 0xD5, 0xDB,
                    0x17, 0x33,
                    0x0A, 0x4F,
                    0xAD,
                    0xF9,
                    0x1D,
                    0x7C,
                    0xED,
                    0xCA,
                    0xAE,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0x1D, 0x93, 0x98,
                    0xE8, 0x5A,
                    0x91, 0x47,
                    0xAA,
                    0x3C,
                    0x1A,
                    0x73,
                    0xA2,
                    0x93,
                    0x4E,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedData1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0xA0, 0x27, 0x97,
                    0x1D, 0xCF,
                    0xDA, 0x4D,
                    0x9E,
                    0xBA,
                    0xEF,
                    0xFA,
                    0x65,
                    0x3F,
                    0xC5,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedData2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x58, 0xFC, 0x67,
                    0xCA, 0xE4,
                    0x15, 0x49,
                    0xBF,
                    0x18,
                    0x42,
                    0x54,
                    0x12,
                    0x72,
                    0xDA,
                    0x54
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Device6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0x22, 0x0B, 0xC7,
                    0xE4, 0x40,
                    0x17, 0x4A,
                    0x89,
                    0xAF,
                    0x02,
                    0x5A,
                    0x07,
                    0x27,
                    0xA6,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12ProtectedResourceSession1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD6, 0x2D, 0xF1, 0xD6,
                    0xFB, 0x76,
                    0x6E, 0x40,
                    0x89,
                    0x61,
                    0x42,
                    0x96,
                    0xEE,
                    0xFC,
                    0x04,
                    0x09
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Device7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x53, 0x4B, 0x01, 0x5C,
                    0xA1, 0x68,
                    0x9B, 0x4B,
                    0x8B,
                    0xD1,
                    0xDD,
                    0x60,
                    0x46,
                    0xB9,
                    0x35,
                    0x8B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Device8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBB, 0xE6, 0x18, 0x92,
                    0x44, 0xF9,
                    0x7E, 0x4F,
                    0xA7,
                    0x5C,
                    0xB1,
                    0xB2,
                    0xC7,
                    0xB7,
                    0x01,
                    0xF3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Resource1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0x22, 0x5E, 0x9D,
                    0x30, 0x44,
                    0x61, 0x41,
                    0x88,
                    0xB3,
                    0x3E,
                    0xCA,
                    0x6B,
                    0xB1,
                    0x6E,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Resource2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0xEC, 0x36, 0xBE,
                    0x85, 0xEA,
                    0xEB, 0x4A,
                    0xA4,
                    0x5A,
                    0xE9,
                    0xD7,
                    0x64,
                    0x04,
                    0xA4,
                    0x95
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Heap1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x89, 0x73, 0x2F, 0x57,
                    0x68, 0x21,
                    0xE3, 0x49,
                    0x96,
                    0x93,
                    0xD6,
                    0xDF,
                    0x58,
                    0x71,
                    0xBF,
                    0x6D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12GraphicsCommandList3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA7, 0x83, 0xDA, 0x6F,
                    0x4C, 0xB8,
                    0x38, 0x4E,
                    0x9A,
                    0xC8,
                    0xC7,
                    0xBD,
                    0x22,
                    0x01,
                    0x6B,
                    0x3D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12MetaCommand
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0x4C, 0xB8, 0xDB,
                    0xCE, 0x36,
                    0xC9, 0x4F,
                    0xB8,
                    0x01,
                    0xF0,
                    0x48,
                    0xC4,
                    0x6A,
                    0xC5,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12GraphicsCommandList4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8E, 0x31, 0x54, 0x87,
                    0xA9, 0xD3,
                    0x41, 0x45,
                    0x98,
                    0xCF,
                    0x64,
                    0x5B,
                    0x50,
                    0xDC,
                    0x48,
                    0x74
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12ShaderCacheSession
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0x49, 0xE2, 0x28,
                    0x64, 0x0F,
                    0xE4, 0x4A,
                    0xA6,
                    0xEC,
                    0x12,
                    0x92,
                    0x55,
                    0xDC,
                    0x49,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Device9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0xE9, 0x80, 0x4C,
                    0x32, 0xF0,
                    0x60, 0x4F,
                    0xBC,
                    0x9E,
                    0xEB,
                    0xC2,
                    0xCF,
                    0xA1,
                    0xD8,
                    0x3C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12Tools
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0xE1, 0x71, 0x70,
                    0x4B, 0xE8,
                    0x33, 0x4B,
                    0x97,
                    0x4F,
                    0x12,
                    0xFA,
                    0x49,
                    0xDE,
                    0x65,
                    0xC5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12SDKConfiguration
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x14, 0x53, 0xEB, 0xE9,
                    0xAA, 0x33,
                    0xB2, 0x42,
                    0xA7,
                    0x18,
                    0xD7,
                    0x7F,
                    0x58,
                    0xB1,
                    0xF1,
                    0xC7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12GraphicsCommandList5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x08, 0x05, 0x55,
                    0x24, 0x40,
                    0x4C, 0x47,
                    0x87,
                    0xF5,
                    0x64,
                    0x72,
                    0xEA,
                    0xEE,
                    0x44,
                    0xEA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12GraphicsCommandList6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0x78, 0x82, 0xC3,
                    0x48, 0xE5,
                    0xFA, 0x4C,
                    0x96,
                    0xCF,
                    0x56,
                    0x89,
                    0xA9,
                    0x37,
                    0x0F,
                    0x80
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define D3D12_16BIT_INDEX_STRIP_CUT_VALUE ( 0xffff )")]
        public const int D3D12_16BIT_INDEX_STRIP_CUT_VALUE = (0xffff);

        [NativeTypeName("#define D3D12_32BIT_INDEX_STRIP_CUT_VALUE ( 0xffffffff )")]
        public const uint D3D12_32BIT_INDEX_STRIP_CUT_VALUE = (0xffffffff);

        [NativeTypeName("#define D3D12_8BIT_INDEX_STRIP_CUT_VALUE ( 0xff )")]
        public const int D3D12_8BIT_INDEX_STRIP_CUT_VALUE = (0xff);

        [NativeTypeName("#define D3D12_APPEND_ALIGNED_ELEMENT ( 0xffffffff )")]
        public const uint D3D12_APPEND_ALIGNED_ELEMENT = (0xffffffff);

        [NativeTypeName("#define D3D12_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT ( 9 )")]
        public const int D3D12_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT = (9);

        [NativeTypeName("#define D3D12_CLIP_OR_CULL_DISTANCE_COUNT ( 8 )")]
        public const int D3D12_CLIP_OR_CULL_DISTANCE_COUNT = (8);

        [NativeTypeName("#define D3D12_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT ( 2 )")]
        public const int D3D12_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT = (2);

        [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT ( 14 )")]
        public const int D3D12_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT = (14);

        [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS ( 4 )")]
        public const int D3D12_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT ( 15 )")]
        public const int D3D12_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT = (15);

        [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT ( 16 )")]
        public const int D3D12_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT = (16);

        [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT ( 15 )")]
        public const int D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT = (15);

        [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT ( 64 )")]
        public const int D3D12_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT = (64);

        [NativeTypeName("#define D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT ( 1 )")]
        public const int D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT ( 128 )")]
        public const int D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT = (128);

        [NativeTypeName("#define D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT ( 128 )")]
        public const int D3D12_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT = (128);

        [NativeTypeName("#define D3D12_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_COMMONSHADER_SAMPLER_REGISTER_COUNT ( 16 )")]
        public const int D3D12_COMMONSHADER_SAMPLER_REGISTER_COUNT = (16);

        [NativeTypeName("#define D3D12_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D12_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D12_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_COMMONSHADER_SAMPLER_SLOT_COUNT ( 16 )")]
        public const int D3D12_COMMONSHADER_SAMPLER_SLOT_COUNT = (16);

        [NativeTypeName("#define D3D12_COMMONSHADER_SUBROUTINE_NESTING_LIMIT ( 32 )")]
        public const int D3D12_COMMONSHADER_SUBROUTINE_NESTING_LIMIT = (32);

        [NativeTypeName("#define D3D12_COMMONSHADER_TEMP_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_COMMONSHADER_TEMP_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_COMMONSHADER_TEMP_REGISTER_COUNT ( 4096 )")]
        public const int D3D12_COMMONSHADER_TEMP_REGISTER_COUNT = (4096);

        [NativeTypeName("#define D3D12_COMMONSHADER_TEMP_REGISTER_READS_PER_INST ( 3 )")]
        public const int D3D12_COMMONSHADER_TEMP_REGISTER_READS_PER_INST = (3);

        [NativeTypeName("#define D3D12_COMMONSHADER_TEMP_REGISTER_READ_PORTS ( 3 )")]
        public const int D3D12_COMMONSHADER_TEMP_REGISTER_READ_PORTS = (3);

        [NativeTypeName("#define D3D12_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX ( 10 )")]
        public const int D3D12_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX = (10);

        [NativeTypeName("#define D3D12_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN ( -10 )")]
        public const int D3D12_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN = (-10);

        [NativeTypeName("#define D3D12_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE ( -8 )")]
        public const int D3D12_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE = (-8);

        [NativeTypeName("#define D3D12_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE ( 7 )")]
        public const int D3D12_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE = (7);

        [NativeTypeName("#define D3D12_CONSTANT_BUFFER_DATA_PLACEMENT_ALIGNMENT ( 256 )")]
        public const int D3D12_CONSTANT_BUFFER_DATA_PLACEMENT_ALIGNMENT = (256);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 256 )")]
        public const int D3D12_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (256);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP ( 64 )")]
        public const int D3D12_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP = (64);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 240 )")]
        public const int D3D12_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (240);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP ( 68 )")]
        public const int D3D12_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP = (68);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 224 )")]
        public const int D3D12_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (224);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP ( 72 )")]
        public const int D3D12_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP = (72);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 208 )")]
        public const int D3D12_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (208);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP ( 76 )")]
        public const int D3D12_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP = (76);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 192 )")]
        public const int D3D12_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (192);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP ( 84 )")]
        public const int D3D12_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP = (84);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 176 )")]
        public const int D3D12_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (176);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP ( 92 )")]
        public const int D3D12_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP = (92);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 160 )")]
        public const int D3D12_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (160);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP ( 100 )")]
        public const int D3D12_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP = (100);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 144 )")]
        public const int D3D12_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (144);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP ( 112 )")]
        public const int D3D12_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP = (112);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 128 )")]
        public const int D3D12_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (128);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP ( 128 )")]
        public const int D3D12_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP = (128);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 112 )")]
        public const int D3D12_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (112);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP ( 144 )")]
        public const int D3D12_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP = (144);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 96 )")]
        public const int D3D12_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (96);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP ( 168 )")]
        public const int D3D12_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP = (168);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 80 )")]
        public const int D3D12_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (80);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP ( 204 )")]
        public const int D3D12_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP = (204);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 64 )")]
        public const int D3D12_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (64);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP ( 256 )")]
        public const int D3D12_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP = (256);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 48 )")]
        public const int D3D12_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (48);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP ( 340 )")]
        public const int D3D12_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP = (340);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 32 )")]
        public const int D3D12_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (32);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP ( 512 )")]
        public const int D3D12_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP = (512);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 16 )")]
        public const int D3D12_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (16);

        [NativeTypeName("#define D3D12_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP ( 768 )")]
        public const int D3D12_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP = (768);

        [NativeTypeName("#define D3D12_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION ( 1 )")]
        public const int D3D12_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION = (1);

        [NativeTypeName("#define D3D12_CS_4_X_RAW_UAV_BYTE_ALIGNMENT ( 256 )")]
        public const int D3D12_CS_4_X_RAW_UAV_BYTE_ALIGNMENT = (256);

        [NativeTypeName("#define D3D12_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP ( 768 )")]
        public const int D3D12_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP = (768);

        [NativeTypeName("#define D3D12_CS_4_X_THREAD_GROUP_MAX_X ( 768 )")]
        public const int D3D12_CS_4_X_THREAD_GROUP_MAX_X = (768);

        [NativeTypeName("#define D3D12_CS_4_X_THREAD_GROUP_MAX_Y ( 768 )")]
        public const int D3D12_CS_4_X_THREAD_GROUP_MAX_Y = (768);

        [NativeTypeName("#define D3D12_CS_4_X_UAV_REGISTER_COUNT ( 1 )")]
        public const int D3D12_CS_4_X_UAV_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION ( 65535 )")]
        public const int D3D12_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION = (65535);

        [NativeTypeName("#define D3D12_CS_TGSM_REGISTER_COUNT ( 8192 )")]
        public const int D3D12_CS_TGSM_REGISTER_COUNT = (8192);

        [NativeTypeName("#define D3D12_CS_TGSM_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D12_CS_TGSM_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D12_CS_TGSM_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_CS_TGSM_RESOURCE_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_CS_TGSM_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_CS_TGSM_RESOURCE_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_CS_THREADGROUPID_REGISTER_COMPONENTS ( 3 )")]
        public const int D3D12_CS_THREADGROUPID_REGISTER_COMPONENTS = (3);

        [NativeTypeName("#define D3D12_CS_THREADGROUPID_REGISTER_COUNT ( 1 )")]
        public const int D3D12_CS_THREADGROUPID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT ( 1 )")]
        public const int D3D12_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_CS_THREADIDINGROUP_REGISTER_COMPONENTS ( 3 )")]
        public const int D3D12_CS_THREADIDINGROUP_REGISTER_COMPONENTS = (3);

        [NativeTypeName("#define D3D12_CS_THREADIDINGROUP_REGISTER_COUNT ( 1 )")]
        public const int D3D12_CS_THREADIDINGROUP_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_CS_THREADID_REGISTER_COMPONENTS ( 3 )")]
        public const int D3D12_CS_THREADID_REGISTER_COMPONENTS = (3);

        [NativeTypeName("#define D3D12_CS_THREADID_REGISTER_COUNT ( 1 )")]
        public const int D3D12_CS_THREADID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP ( 1024 )")]
        public const int D3D12_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP = (1024);

        [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MAX_X ( 1024 )")]
        public const int D3D12_CS_THREAD_GROUP_MAX_X = (1024);

        [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MAX_Y ( 1024 )")]
        public const int D3D12_CS_THREAD_GROUP_MAX_Y = (1024);

        [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MAX_Z ( 64 )")]
        public const int D3D12_CS_THREAD_GROUP_MAX_Z = (64);

        [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MIN_X ( 1 )")]
        public const int D3D12_CS_THREAD_GROUP_MIN_X = (1);

        [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MIN_Y ( 1 )")]
        public const int D3D12_CS_THREAD_GROUP_MIN_Y = (1);

        [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MIN_Z ( 1 )")]
        public const int D3D12_CS_THREAD_GROUP_MIN_Z = (1);

        [NativeTypeName("#define D3D12_CS_THREAD_LOCAL_TEMP_REGISTER_POOL ( 16384 )")]
        public const int D3D12_CS_THREAD_LOCAL_TEMP_REGISTER_POOL = (16384);

        [NativeTypeName("#define D3D12_DEFAULT_BLEND_FACTOR_ALPHA ( 1.0f )")]
        public const float D3D12_DEFAULT_BLEND_FACTOR_ALPHA = (1.0f);

        [NativeTypeName("#define D3D12_DEFAULT_BLEND_FACTOR_BLUE ( 1.0f )")]
        public const float D3D12_DEFAULT_BLEND_FACTOR_BLUE = (1.0f);

        [NativeTypeName("#define D3D12_DEFAULT_BLEND_FACTOR_GREEN ( 1.0f )")]
        public const float D3D12_DEFAULT_BLEND_FACTOR_GREEN = (1.0f);

        [NativeTypeName("#define D3D12_DEFAULT_BLEND_FACTOR_RED ( 1.0f )")]
        public const float D3D12_DEFAULT_BLEND_FACTOR_RED = (1.0f);

        [NativeTypeName("#define D3D12_DEFAULT_BORDER_COLOR_COMPONENT ( 0.0f )")]
        public const float D3D12_DEFAULT_BORDER_COLOR_COMPONENT = (0.0f);

        [NativeTypeName("#define D3D12_DEFAULT_DEPTH_BIAS ( 0 )")]
        public const int D3D12_DEFAULT_DEPTH_BIAS = (0);

        [NativeTypeName("#define D3D12_DEFAULT_DEPTH_BIAS_CLAMP ( 0.0f )")]
        public const float D3D12_DEFAULT_DEPTH_BIAS_CLAMP = (0.0f);

        [NativeTypeName("#define D3D12_DEFAULT_MAX_ANISOTROPY ( 16 )")]
        public const int D3D12_DEFAULT_MAX_ANISOTROPY = (16);

        [NativeTypeName("#define D3D12_DEFAULT_MIP_LOD_BIAS ( 0.0f )")]
        public const float D3D12_DEFAULT_MIP_LOD_BIAS = (0.0f);

        [NativeTypeName("#define D3D12_DEFAULT_MSAA_RESOURCE_PLACEMENT_ALIGNMENT ( 4194304 )")]
        public const int D3D12_DEFAULT_MSAA_RESOURCE_PLACEMENT_ALIGNMENT = (4194304);

        [NativeTypeName("#define D3D12_DEFAULT_RENDER_TARGET_ARRAY_INDEX ( 0 )")]
        public const int D3D12_DEFAULT_RENDER_TARGET_ARRAY_INDEX = (0);

        [NativeTypeName("#define D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT ( 65536 )")]
        public const int D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT = (65536);

        [NativeTypeName("#define D3D12_DEFAULT_SAMPLE_MASK ( 0xffffffff )")]
        public const uint D3D12_DEFAULT_SAMPLE_MASK = (0xffffffff);

        [NativeTypeName("#define D3D12_DEFAULT_SCISSOR_ENDX ( 0 )")]
        public const int D3D12_DEFAULT_SCISSOR_ENDX = (0);

        [NativeTypeName("#define D3D12_DEFAULT_SCISSOR_ENDY ( 0 )")]
        public const int D3D12_DEFAULT_SCISSOR_ENDY = (0);

        [NativeTypeName("#define D3D12_DEFAULT_SCISSOR_STARTX ( 0 )")]
        public const int D3D12_DEFAULT_SCISSOR_STARTX = (0);

        [NativeTypeName("#define D3D12_DEFAULT_SCISSOR_STARTY ( 0 )")]
        public const int D3D12_DEFAULT_SCISSOR_STARTY = (0);

        [NativeTypeName("#define D3D12_DEFAULT_SLOPE_SCALED_DEPTH_BIAS ( 0.0f )")]
        public const float D3D12_DEFAULT_SLOPE_SCALED_DEPTH_BIAS = (0.0f);

        [NativeTypeName("#define D3D12_DEFAULT_STENCIL_READ_MASK ( 0xff )")]
        public const int D3D12_DEFAULT_STENCIL_READ_MASK = (0xff);

        [NativeTypeName("#define D3D12_DEFAULT_STENCIL_REFERENCE ( 0 )")]
        public const int D3D12_DEFAULT_STENCIL_REFERENCE = (0);

        [NativeTypeName("#define D3D12_DEFAULT_STENCIL_WRITE_MASK ( 0xff )")]
        public const int D3D12_DEFAULT_STENCIL_WRITE_MASK = (0xff);

        [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX ( 0 )")]
        public const int D3D12_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX = (0);

        [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_HEIGHT ( 0 )")]
        public const int D3D12_DEFAULT_VIEWPORT_HEIGHT = (0);

        [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_MAX_DEPTH ( 0.0f )")]
        public const float D3D12_DEFAULT_VIEWPORT_MAX_DEPTH = (0.0f);

        [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_MIN_DEPTH ( 0.0f )")]
        public const float D3D12_DEFAULT_VIEWPORT_MIN_DEPTH = (0.0f);

        [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_TOPLEFTX ( 0 )")]
        public const int D3D12_DEFAULT_VIEWPORT_TOPLEFTX = (0);

        [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_TOPLEFTY ( 0 )")]
        public const int D3D12_DEFAULT_VIEWPORT_TOPLEFTY = (0);

        [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_WIDTH ( 0 )")]
        public const int D3D12_DEFAULT_VIEWPORT_WIDTH = (0);

        [NativeTypeName("#define D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND ( 0xffffffff )")]
        public const uint D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND = (0xffffffff);

        [NativeTypeName("#define D3D12_DRIVER_RESERVED_REGISTER_SPACE_VALUES_END ( 0xfffffff7 )")]
        public const uint D3D12_DRIVER_RESERVED_REGISTER_SPACE_VALUES_END = (0xfffffff7);

        [NativeTypeName("#define D3D12_DRIVER_RESERVED_REGISTER_SPACE_VALUES_START ( 0xfffffff0 )")]
        public const uint D3D12_DRIVER_RESERVED_REGISTER_SPACE_VALUES_START = (0xfffffff0);

        [NativeTypeName("#define D3D12_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS ( 3968 )")]
        public const int D3D12_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = (3968);

        [NativeTypeName("#define D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COUNT ( 32 )")]
        public const int D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D12_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS ( 3 )")]
        public const int D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS = (3);

        [NativeTypeName("#define D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT ( 1 )")]
        public const int D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT ( 32 )")]
        public const int D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_DS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_DS_OUTPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_DS_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D12_DS_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D12_FLOAT16_FUSED_TOLERANCE_IN_ULP ( 0.6 )")]
        public const double D3D12_FLOAT16_FUSED_TOLERANCE_IN_ULP = (0.6);

        [NativeTypeName("#define D3D12_FLOAT32_MAX ( 3.402823466e+38f )")]
        public const float D3D12_FLOAT32_MAX = (3.402823466e+38f);

        [NativeTypeName("#define D3D12_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP ( 0.6f )")]
        public const float D3D12_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP = (0.6f);

        [NativeTypeName("#define D3D12_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR ( 2.4f )")]
        public const float D3D12_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR = (2.4f);

        [NativeTypeName("#define D3D12_FLOAT_TO_SRGB_EXPONENT_NUMERATOR ( 1.0f )")]
        public const float D3D12_FLOAT_TO_SRGB_EXPONENT_NUMERATOR = (1.0f);

        [NativeTypeName("#define D3D12_FLOAT_TO_SRGB_OFFSET ( 0.055f )")]
        public const float D3D12_FLOAT_TO_SRGB_OFFSET = (0.055f);

        [NativeTypeName("#define D3D12_FLOAT_TO_SRGB_SCALE_1 ( 12.92f )")]
        public const float D3D12_FLOAT_TO_SRGB_SCALE_1 = (12.92f);

        [NativeTypeName("#define D3D12_FLOAT_TO_SRGB_SCALE_2 ( 1.055f )")]
        public const float D3D12_FLOAT_TO_SRGB_SCALE_2 = (1.055f);

        [NativeTypeName("#define D3D12_FLOAT_TO_SRGB_THRESHOLD ( 0.0031308f )")]
        public const float D3D12_FLOAT_TO_SRGB_THRESHOLD = (0.0031308f);

        [NativeTypeName("#define D3D12_FTOI_INSTRUCTION_MAX_INPUT ( 2147483647.999f )")]
        public const float D3D12_FTOI_INSTRUCTION_MAX_INPUT = (2147483647.999f);

        [NativeTypeName("#define D3D12_FTOI_INSTRUCTION_MIN_INPUT ( -2147483648.999f )")]
        public const float D3D12_FTOI_INSTRUCTION_MIN_INPUT = (-2147483648.999f);

        [NativeTypeName("#define D3D12_FTOU_INSTRUCTION_MAX_INPUT ( 4294967295.999f )")]
        public const float D3D12_FTOU_INSTRUCTION_MAX_INPUT = (4294967295.999f);

        [NativeTypeName("#define D3D12_FTOU_INSTRUCTION_MIN_INPUT ( 0.0f )")]
        public const float D3D12_FTOU_INSTRUCTION_MIN_INPUT = (0.0f);

        [NativeTypeName("#define D3D12_GS_INPUT_INSTANCE_ID_READS_PER_INST ( 2 )")]
        public const int D3D12_GS_INPUT_INSTANCE_ID_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_GS_INPUT_INSTANCE_ID_READ_PORTS ( 1 )")]
        public const int D3D12_GS_INPUT_INSTANCE_ID_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_GS_INPUT_PRIM_CONST_REGISTER_COUNT ( 1 )")]
        public const int D3D12_GS_INPUT_PRIM_CONST_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_GS_INPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_GS_INPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_GS_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D12_GS_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D12_GS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_GS_INPUT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_GS_INPUT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_GS_INPUT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_GS_INPUT_REGISTER_VERTICES ( 32 )")]
        public const int D3D12_GS_INPUT_REGISTER_VERTICES = (32);

        [NativeTypeName("#define D3D12_GS_MAX_INSTANCE_COUNT ( 32 )")]
        public const int D3D12_GS_MAX_INSTANCE_COUNT = (32);

        [NativeTypeName("#define D3D12_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES ( 1024 )")]
        public const int D3D12_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES = (1024);

        [NativeTypeName("#define D3D12_GS_OUTPUT_ELEMENTS ( 32 )")]
        public const int D3D12_GS_OUTPUT_ELEMENTS = (32);

        [NativeTypeName("#define D3D12_GS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_GS_OUTPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_GS_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D12_GS_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D12_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D12_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D12_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D12_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D12_HS_CONTROL_POINT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_HS_CONTROL_POINT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_HS_CONTROL_POINT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_HS_CONTROL_POINT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_HS_CONTROL_POINT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_HS_CONTROL_POINT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND ( 0xffffffff )")]
        public const uint D3D12_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND = (0xffffffff);

        [NativeTypeName("#define D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND ( 0xffffffff )")]
        public const uint D3D12_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND = (0xffffffff);

        [NativeTypeName("#define D3D12_HS_MAXTESSFACTOR_LOWER_BOUND ( 1.0f )")]
        public const float D3D12_HS_MAXTESSFACTOR_LOWER_BOUND = (1.0f);

        [NativeTypeName("#define D3D12_HS_MAXTESSFACTOR_UPPER_BOUND ( 64.0f )")]
        public const float D3D12_HS_MAXTESSFACTOR_UPPER_BOUND = (64.0f);

        [NativeTypeName("#define D3D12_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS ( 3968 )")]
        public const int D3D12_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = (3968);

        [NativeTypeName("#define D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT ( 32 )")]
        public const int D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS ( 128 )")]
        public const int D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS = (128);

        [NativeTypeName("#define D3D12_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
        public const int D3D12_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES = (0);

        [NativeTypeName("#define D3D12_IA_DEFAULT_PRIMITIVE_TOPOLOGY ( 0 )")]
        public const int D3D12_IA_DEFAULT_PRIMITIVE_TOPOLOGY = (0);

        [NativeTypeName("#define D3D12_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
        public const int D3D12_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES = (0);

        [NativeTypeName("#define D3D12_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT ( 1 )")]
        public const int D3D12_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT = (1);

        [NativeTypeName("#define D3D12_IA_INSTANCE_ID_BIT_COUNT ( 32 )")]
        public const int D3D12_IA_INSTANCE_ID_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_IA_INTEGER_ARITHMETIC_BIT_COUNT ( 32 )")]
        public const int D3D12_IA_INTEGER_ARITHMETIC_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_IA_PATCH_MAX_CONTROL_POINT_COUNT ( 32 )")]
        public const int D3D12_IA_PATCH_MAX_CONTROL_POINT_COUNT = (32);

        [NativeTypeName("#define D3D12_IA_PRIMITIVE_ID_BIT_COUNT ( 32 )")]
        public const int D3D12_IA_PRIMITIVE_ID_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_IA_VERTEX_ID_BIT_COUNT ( 32 )")]
        public const int D3D12_IA_VERTEX_ID_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT ( 32 )")]
        public const int D3D12_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT = (32);

        [NativeTypeName("#define D3D12_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS ( 128 )")]
        public const int D3D12_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS = (128);

        [NativeTypeName("#define D3D12_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ( 32 )")]
        public const int D3D12_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT = (32);

        [NativeTypeName("#define D3D12_INTEGER_DIVIDE_BY_ZERO_QUOTIENT ( 0xffffffff )")]
        public const uint D3D12_INTEGER_DIVIDE_BY_ZERO_QUOTIENT = (0xffffffff);

        [NativeTypeName("#define D3D12_INTEGER_DIVIDE_BY_ZERO_REMAINDER ( 0xffffffff )")]
        public const uint D3D12_INTEGER_DIVIDE_BY_ZERO_REMAINDER = (0xffffffff);

        [NativeTypeName("#define D3D12_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL ( 0xffffffff )")]
        public const uint D3D12_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL = (0xffffffff);

        [NativeTypeName("#define D3D12_KEEP_UNORDERED_ACCESS_VIEWS ( 0xffffffff )")]
        public const uint D3D12_KEEP_UNORDERED_ACCESS_VIEWS = (0xffffffff);

        [NativeTypeName("#define D3D12_LINEAR_GAMMA ( 1.0f )")]
        public const float D3D12_LINEAR_GAMMA = (1.0f);

        [NativeTypeName("#define D3D12_MAJOR_VERSION ( 12 )")]
        public const int D3D12_MAJOR_VERSION = (12);

        [NativeTypeName("#define D3D12_MAX_BORDER_COLOR_COMPONENT ( 1.0f )")]
        public const float D3D12_MAX_BORDER_COLOR_COMPONENT = (1.0f);

        [NativeTypeName("#define D3D12_MAX_DEPTH ( 1.0f )")]
        public const float D3D12_MAX_DEPTH = (1.0f);

        [NativeTypeName("#define D3D12_MAX_LIVE_STATIC_SAMPLERS ( 2032 )")]
        public const int D3D12_MAX_LIVE_STATIC_SAMPLERS = (2032);

        [NativeTypeName("#define D3D12_MAX_MAXANISOTROPY ( 16 )")]
        public const int D3D12_MAX_MAXANISOTROPY = (16);

        [NativeTypeName("#define D3D12_MAX_MULTISAMPLE_SAMPLE_COUNT ( 32 )")]
        public const int D3D12_MAX_MULTISAMPLE_SAMPLE_COUNT = (32);

        [NativeTypeName("#define D3D12_MAX_POSITION_VALUE ( 3.402823466e+34f )")]
        public const float D3D12_MAX_POSITION_VALUE = (3.402823466e+34f);

        [NativeTypeName("#define D3D12_MAX_ROOT_COST ( 64 )")]
        public const int D3D12_MAX_ROOT_COST = (64);

        [NativeTypeName("#define D3D12_MAX_SHADER_VISIBLE_DESCRIPTOR_HEAP_SIZE_TIER_1 ( 1000000 )")]
        public const int D3D12_MAX_SHADER_VISIBLE_DESCRIPTOR_HEAP_SIZE_TIER_1 = (1000000);

        [NativeTypeName("#define D3D12_MAX_SHADER_VISIBLE_DESCRIPTOR_HEAP_SIZE_TIER_2 ( 1000000 )")]
        public const int D3D12_MAX_SHADER_VISIBLE_DESCRIPTOR_HEAP_SIZE_TIER_2 = (1000000);

        [NativeTypeName("#define D3D12_MAX_SHADER_VISIBLE_SAMPLER_HEAP_SIZE ( 2048 )")]
        public const int D3D12_MAX_SHADER_VISIBLE_SAMPLER_HEAP_SIZE = (2048);

        [NativeTypeName("#define D3D12_MAX_TEXTURE_DIMENSION_2_TO_EXP ( 17 )")]
        public const int D3D12_MAX_TEXTURE_DIMENSION_2_TO_EXP = (17);

        [NativeTypeName("#define D3D12_MAX_VIEW_INSTANCE_COUNT ( 4 )")]
        public const int D3D12_MAX_VIEW_INSTANCE_COUNT = (4);

        [NativeTypeName("#define D3D12_MINOR_VERSION ( 0 )")]
        public const int D3D12_MINOR_VERSION = (0);

        [NativeTypeName("#define D3D12_MIN_BORDER_COLOR_COMPONENT ( 0.0f )")]
        public const float D3D12_MIN_BORDER_COLOR_COMPONENT = (0.0f);

        [NativeTypeName("#define D3D12_MIN_DEPTH ( 0.0f )")]
        public const float D3D12_MIN_DEPTH = (0.0f);

        [NativeTypeName("#define D3D12_MIN_MAXANISOTROPY ( 0 )")]
        public const int D3D12_MIN_MAXANISOTROPY = (0);

        [NativeTypeName("#define D3D12_MIP_LOD_BIAS_MAX ( 15.99f )")]
        public const float D3D12_MIP_LOD_BIAS_MAX = (15.99f);

        [NativeTypeName("#define D3D12_MIP_LOD_BIAS_MIN ( -16.0f )")]
        public const float D3D12_MIP_LOD_BIAS_MIN = (-16.0f);

        [NativeTypeName("#define D3D12_MIP_LOD_FRACTIONAL_BIT_COUNT ( 8 )")]
        public const int D3D12_MIP_LOD_FRACTIONAL_BIT_COUNT = (8);

        [NativeTypeName("#define D3D12_MIP_LOD_RANGE_BIT_COUNT ( 8 )")]
        public const int D3D12_MIP_LOD_RANGE_BIT_COUNT = (8);

        [NativeTypeName("#define D3D12_MULTISAMPLE_ANTIALIAS_LINE_WIDTH ( 1.4f )")]
        public const float D3D12_MULTISAMPLE_ANTIALIAS_LINE_WIDTH = (1.4f);

        [NativeTypeName("#define D3D12_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT ( 0 )")]
        public const int D3D12_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT = (0);

        [NativeTypeName("#define D3D12_OS_RESERVED_REGISTER_SPACE_VALUES_END ( 0xffffffff )")]
        public const uint D3D12_OS_RESERVED_REGISTER_SPACE_VALUES_END = (0xffffffff);

        [NativeTypeName("#define D3D12_OS_RESERVED_REGISTER_SPACE_VALUES_START ( 0xfffffff8 )")]
        public const uint D3D12_OS_RESERVED_REGISTER_SPACE_VALUES_START = (0xfffffff8);

        [NativeTypeName("#define D3D12_PACKED_TILE ( 0xffffffff )")]
        public const uint D3D12_PACKED_TILE = (0xffffffff);

        [NativeTypeName("#define D3D12_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 15 )")]
        public const int D3D12_PIXEL_ADDRESS_RANGE_BIT_COUNT = (15);

        [NativeTypeName("#define D3D12_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 16 )")]
        public const int D3D12_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT = (16);

        [NativeTypeName("#define D3D12_PS_CS_UAV_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_PS_CS_UAV_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_PS_CS_UAV_REGISTER_COUNT ( 8 )")]
        public const int D3D12_PS_CS_UAV_REGISTER_COUNT = (8);

        [NativeTypeName("#define D3D12_PS_CS_UAV_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D12_PS_CS_UAV_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D12_PS_CS_UAV_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_PS_CS_UAV_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_PS_FRONTFACING_DEFAULT_VALUE ( 0xffffffff )")]
        public const uint D3D12_PS_FRONTFACING_DEFAULT_VALUE = (0xffffffff);

        [NativeTypeName("#define D3D12_PS_FRONTFACING_FALSE_VALUE ( 0 )")]
        public const int D3D12_PS_FRONTFACING_FALSE_VALUE = (0);

        [NativeTypeName("#define D3D12_PS_FRONTFACING_TRUE_VALUE ( 0xffffffff )")]
        public const uint D3D12_PS_FRONTFACING_TRUE_VALUE = (0xffffffff);

        [NativeTypeName("#define D3D12_PS_INPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_PS_INPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_PS_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D12_PS_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D12_PS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_PS_INPUT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_PS_INPUT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_PS_INPUT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.0f )")]
        public const float D3D12_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.0f);

        [NativeTypeName("#define D3D12_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_PS_OUTPUT_DEPTH_REGISTER_COUNT ( 1 )")]
        public const int D3D12_PS_OUTPUT_DEPTH_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_PS_OUTPUT_MASK_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D12_PS_OUTPUT_MASK_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D12_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_PS_OUTPUT_MASK_REGISTER_COUNT ( 1 )")]
        public const int D3D12_PS_OUTPUT_MASK_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D12_PS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_PS_OUTPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_PS_OUTPUT_REGISTER_COUNT ( 8 )")]
        public const int D3D12_PS_OUTPUT_REGISTER_COUNT = (8);

        [NativeTypeName("#define D3D12_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.5f )")]
        public const float D3D12_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.5f);

        [NativeTypeName("#define D3D12_RAW_UAV_SRV_BYTE_ALIGNMENT ( 16 )")]
        public const int D3D12_RAW_UAV_SRV_BYTE_ALIGNMENT = (16);

        [NativeTypeName("#define D3D12_RAYTRACING_AABB_BYTE_ALIGNMENT ( 8 )")]
        public const int D3D12_RAYTRACING_AABB_BYTE_ALIGNMENT = (8);

        [NativeTypeName("#define D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BYTE_ALIGNMENT ( 256 )")]
        public const int D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BYTE_ALIGNMENT = (256);

        [NativeTypeName("#define D3D12_RAYTRACING_INSTANCE_DESCS_BYTE_ALIGNMENT ( 16 )")]
        public const int D3D12_RAYTRACING_INSTANCE_DESCS_BYTE_ALIGNMENT = (16);

        [NativeTypeName("#define D3D12_RAYTRACING_MAX_ATTRIBUTE_SIZE_IN_BYTES ( 32 )")]
        public const int D3D12_RAYTRACING_MAX_ATTRIBUTE_SIZE_IN_BYTES = (32);

        [NativeTypeName("#define D3D12_RAYTRACING_MAX_DECLARABLE_TRACE_RECURSION_DEPTH ( 31 )")]
        public const int D3D12_RAYTRACING_MAX_DECLARABLE_TRACE_RECURSION_DEPTH = (31);

        [NativeTypeName("#define D3D12_RAYTRACING_MAX_GEOMETRIES_PER_BOTTOM_LEVEL_ACCELERATION_STRUCTURE ( 16777216 )")]
        public const int D3D12_RAYTRACING_MAX_GEOMETRIES_PER_BOTTOM_LEVEL_ACCELERATION_STRUCTURE = (16777216);

        [NativeTypeName("#define D3D12_RAYTRACING_MAX_INSTANCES_PER_TOP_LEVEL_ACCELERATION_STRUCTURE ( 16777216 )")]
        public const int D3D12_RAYTRACING_MAX_INSTANCES_PER_TOP_LEVEL_ACCELERATION_STRUCTURE = (16777216);

        [NativeTypeName("#define D3D12_RAYTRACING_MAX_PRIMITIVES_PER_BOTTOM_LEVEL_ACCELERATION_STRUCTURE ( 536870912 )")]
        public const int D3D12_RAYTRACING_MAX_PRIMITIVES_PER_BOTTOM_LEVEL_ACCELERATION_STRUCTURE = (536870912);

        [NativeTypeName("#define D3D12_RAYTRACING_MAX_RAY_GENERATION_SHADER_THREADS ( 1073741824 )")]
        public const int D3D12_RAYTRACING_MAX_RAY_GENERATION_SHADER_THREADS = (1073741824);

        [NativeTypeName("#define D3D12_RAYTRACING_MAX_SHADER_RECORD_STRIDE ( 4096 )")]
        public const int D3D12_RAYTRACING_MAX_SHADER_RECORD_STRIDE = (4096);

        [NativeTypeName("#define D3D12_RAYTRACING_SHADER_RECORD_BYTE_ALIGNMENT ( 32 )")]
        public const int D3D12_RAYTRACING_SHADER_RECORD_BYTE_ALIGNMENT = (32);

        [NativeTypeName("#define D3D12_RAYTRACING_SHADER_TABLE_BYTE_ALIGNMENT ( 64 )")]
        public const int D3D12_RAYTRACING_SHADER_TABLE_BYTE_ALIGNMENT = (64);

        [NativeTypeName("#define D3D12_RAYTRACING_TRANSFORM3X4_BYTE_ALIGNMENT ( 16 )")]
        public const int D3D12_RAYTRACING_TRANSFORM3X4_BYTE_ALIGNMENT = (16);

        [NativeTypeName("#define D3D12_REQ_BLEND_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
        public const int D3D12_REQ_BLEND_OBJECT_COUNT_PER_DEVICE = (4096);

        [NativeTypeName("#define D3D12_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP ( 27 )")]
        public const int D3D12_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP = (27);

        [NativeTypeName("#define D3D12_REQ_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
        public const int D3D12_REQ_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

        [NativeTypeName("#define D3D12_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
        public const int D3D12_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE = (4096);

        [NativeTypeName("#define D3D12_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 32 )")]
        public const int D3D12_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (32);

        [NativeTypeName("#define D3D12_REQ_DRAW_VERTEX_COUNT_2_TO_EXP ( 32 )")]
        public const int D3D12_REQ_DRAW_VERTEX_COUNT_2_TO_EXP = (32);

        [NativeTypeName("#define D3D12_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION ( 16384 )")]
        public const int D3D12_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION = (16384);

        [NativeTypeName("#define D3D12_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT ( 1024 )")]
        public const int D3D12_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT = (1024);

        [NativeTypeName("#define D3D12_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
        public const int D3D12_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

        [NativeTypeName("#define D3D12_REQ_MAXANISOTROPY ( 16 )")]
        public const int D3D12_REQ_MAXANISOTROPY = (16);

        [NativeTypeName("#define D3D12_REQ_MIP_LEVELS ( 15 )")]
        public const int D3D12_REQ_MIP_LEVELS = (15);

        [NativeTypeName("#define D3D12_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES ( 2048 )")]
        public const int D3D12_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES = (2048);

        [NativeTypeName("#define D3D12_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
        public const int D3D12_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE = (4096);

        [NativeTypeName("#define D3D12_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH ( 16384 )")]
        public const int D3D12_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH = (16384);

        [NativeTypeName("#define D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM ( 128 )")]
        public const int D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM = (128);

        [NativeTypeName("#define D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM ( 0.25f )")]
        public const float D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM = (0.25f);

        [NativeTypeName("#define D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM ( 2048 )")]
        public const int D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM = (2048);

        [NativeTypeName("#define D3D12_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP ( 20 )")]
        public const int D3D12_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP = (20);

        [NativeTypeName("#define D3D12_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
        public const int D3D12_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE = (4096);

        [NativeTypeName("#define D3D12_REQ_SUBRESOURCES ( 30720 )")]
        public const int D3D12_REQ_SUBRESOURCES = (30720);

        [NativeTypeName("#define D3D12_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION ( 2048 )")]
        public const int D3D12_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION = (2048);

        [NativeTypeName("#define D3D12_REQ_TEXTURE1D_U_DIMENSION ( 16384 )")]
        public const int D3D12_REQ_TEXTURE1D_U_DIMENSION = (16384);

        [NativeTypeName("#define D3D12_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION ( 2048 )")]
        public const int D3D12_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION = (2048);

        [NativeTypeName("#define D3D12_REQ_TEXTURE2D_U_OR_V_DIMENSION ( 16384 )")]
        public const int D3D12_REQ_TEXTURE2D_U_OR_V_DIMENSION = (16384);

        [NativeTypeName("#define D3D12_REQ_TEXTURE3D_U_V_OR_W_DIMENSION ( 2048 )")]
        public const int D3D12_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = (2048);

        [NativeTypeName("#define D3D12_REQ_TEXTURECUBE_DIMENSION ( 16384 )")]
        public const int D3D12_REQ_TEXTURECUBE_DIMENSION = (16384);

        [NativeTypeName("#define D3D12_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL ( 0 )")]
        public const int D3D12_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL = (0);

        [NativeTypeName("#define D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES ( 0xffffffff )")]
        public const uint D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES = (0xffffffff);

        [NativeTypeName("#define D3D12_RS_SET_SHADING_RATE_COMBINER_COUNT ( 2 )")]
        public const int D3D12_RS_SET_SHADING_RATE_COMBINER_COUNT = (2);

        [NativeTypeName("#define D3D12_SDK_VERSION ( 3 )")]
        public const int D3D12_SDK_VERSION = (3);

        [NativeTypeName("#define D3D12_SHADER_IDENTIFIER_SIZE_IN_BYTES ( 32 )")]
        public const int D3D12_SHADER_IDENTIFIER_SIZE_IN_BYTES = (32);

        [NativeTypeName("#define D3D12_SHADER_MAJOR_VERSION ( 5 )")]
        public const int D3D12_SHADER_MAJOR_VERSION = (5);

        [NativeTypeName("#define D3D12_SHADER_MAX_INSTANCES ( 65535 )")]
        public const int D3D12_SHADER_MAX_INSTANCES = (65535);

        [NativeTypeName("#define D3D12_SHADER_MAX_INTERFACES ( 253 )")]
        public const int D3D12_SHADER_MAX_INTERFACES = (253);

        [NativeTypeName("#define D3D12_SHADER_MAX_INTERFACE_CALL_SITES ( 4096 )")]
        public const int D3D12_SHADER_MAX_INTERFACE_CALL_SITES = (4096);

        [NativeTypeName("#define D3D12_SHADER_MAX_TYPES ( 65535 )")]
        public const int D3D12_SHADER_MAX_TYPES = (65535);

        [NativeTypeName("#define D3D12_SHADER_MINOR_VERSION ( 1 )")]
        public const int D3D12_SHADER_MINOR_VERSION = (1);

        [NativeTypeName("#define D3D12_SHIFT_INSTRUCTION_PAD_VALUE ( 0 )")]
        public const int D3D12_SHIFT_INSTRUCTION_PAD_VALUE = (0);

        [NativeTypeName("#define D3D12_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT ( 5 )")]
        public const int D3D12_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT = (5);

        [NativeTypeName("#define D3D12_SIMULTANEOUS_RENDER_TARGET_COUNT ( 8 )")]
        public const int D3D12_SIMULTANEOUS_RENDER_TARGET_COUNT = (8);

        [NativeTypeName("#define D3D12_SMALL_MSAA_RESOURCE_PLACEMENT_ALIGNMENT ( 65536 )")]
        public const int D3D12_SMALL_MSAA_RESOURCE_PLACEMENT_ALIGNMENT = (65536);

        [NativeTypeName("#define D3D12_SMALL_RESOURCE_PLACEMENT_ALIGNMENT ( 4096 )")]
        public const int D3D12_SMALL_RESOURCE_PLACEMENT_ALIGNMENT = (4096);

        [NativeTypeName("#define D3D12_SO_BUFFER_MAX_STRIDE_IN_BYTES ( 2048 )")]
        public const int D3D12_SO_BUFFER_MAX_STRIDE_IN_BYTES = (2048);

        [NativeTypeName("#define D3D12_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES ( 512 )")]
        public const int D3D12_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES = (512);

        [NativeTypeName("#define D3D12_SO_BUFFER_SLOT_COUNT ( 4 )")]
        public const int D3D12_SO_BUFFER_SLOT_COUNT = (4);

        [NativeTypeName("#define D3D12_SO_DDI_REGISTER_INDEX_DENOTING_GAP ( 0xffffffff )")]
        public const uint D3D12_SO_DDI_REGISTER_INDEX_DENOTING_GAP = (0xffffffff);

        [NativeTypeName("#define D3D12_SO_NO_RASTERIZED_STREAM ( 0xffffffff )")]
        public const uint D3D12_SO_NO_RASTERIZED_STREAM = (0xffffffff);

        [NativeTypeName("#define D3D12_SO_OUTPUT_COMPONENT_COUNT ( 128 )")]
        public const int D3D12_SO_OUTPUT_COMPONENT_COUNT = (128);

        [NativeTypeName("#define D3D12_SO_STREAM_COUNT ( 4 )")]
        public const int D3D12_SO_STREAM_COUNT = (4);

        [NativeTypeName("#define D3D12_SPEC_DATE_DAY ( 14 )")]
        public const int D3D12_SPEC_DATE_DAY = (14);

        [NativeTypeName("#define D3D12_SPEC_DATE_MONTH ( 11 )")]
        public const int D3D12_SPEC_DATE_MONTH = (11);

        [NativeTypeName("#define D3D12_SPEC_DATE_YEAR ( 2014 )")]
        public const int D3D12_SPEC_DATE_YEAR = (2014);

        [NativeTypeName("#define D3D12_SPEC_VERSION ( 1.16 )")]
        public const double D3D12_SPEC_VERSION = (1.16);

        [NativeTypeName("#define D3D12_SRGB_GAMMA ( 2.2f )")]
        public const float D3D12_SRGB_GAMMA = (2.2f);

        [NativeTypeName("#define D3D12_SRGB_TO_FLOAT_DENOMINATOR_1 ( 12.92f )")]
        public const float D3D12_SRGB_TO_FLOAT_DENOMINATOR_1 = (12.92f);

        [NativeTypeName("#define D3D12_SRGB_TO_FLOAT_DENOMINATOR_2 ( 1.055f )")]
        public const float D3D12_SRGB_TO_FLOAT_DENOMINATOR_2 = (1.055f);

        [NativeTypeName("#define D3D12_SRGB_TO_FLOAT_EXPONENT ( 2.4f )")]
        public const float D3D12_SRGB_TO_FLOAT_EXPONENT = (2.4f);

        [NativeTypeName("#define D3D12_SRGB_TO_FLOAT_OFFSET ( 0.055f )")]
        public const float D3D12_SRGB_TO_FLOAT_OFFSET = (0.055f);

        [NativeTypeName("#define D3D12_SRGB_TO_FLOAT_THRESHOLD ( 0.04045f )")]
        public const float D3D12_SRGB_TO_FLOAT_THRESHOLD = (0.04045f);

        [NativeTypeName("#define D3D12_SRGB_TO_FLOAT_TOLERANCE_IN_ULP ( 0.5f )")]
        public const float D3D12_SRGB_TO_FLOAT_TOLERANCE_IN_ULP = (0.5f);

        [NativeTypeName("#define D3D12_STANDARD_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_STANDARD_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_STANDARD_COMPONENT_BIT_COUNT_DOUBLED ( 64 )")]
        public const int D3D12_STANDARD_COMPONENT_BIT_COUNT_DOUBLED = (64);

        [NativeTypeName("#define D3D12_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE ( 4 )")]
        public const int D3D12_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE = (4);

        [NativeTypeName("#define D3D12_STANDARD_PIXEL_COMPONENT_COUNT ( 128 )")]
        public const int D3D12_STANDARD_PIXEL_COMPONENT_COUNT = (128);

        [NativeTypeName("#define D3D12_STANDARD_PIXEL_ELEMENT_COUNT ( 32 )")]
        public const int D3D12_STANDARD_PIXEL_ELEMENT_COUNT = (32);

        [NativeTypeName("#define D3D12_STANDARD_VECTOR_SIZE ( 4 )")]
        public const int D3D12_STANDARD_VECTOR_SIZE = (4);

        [NativeTypeName("#define D3D12_STANDARD_VERTEX_ELEMENT_COUNT ( 32 )")]
        public const int D3D12_STANDARD_VERTEX_ELEMENT_COUNT = (32);

        [NativeTypeName("#define D3D12_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT ( 64 )")]
        public const int D3D12_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT = (64);

        [NativeTypeName("#define D3D12_SUBPIXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
        public const int D3D12_SUBPIXEL_FRACTIONAL_BIT_COUNT = (8);

        [NativeTypeName("#define D3D12_SUBTEXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
        public const int D3D12_SUBTEXEL_FRACTIONAL_BIT_COUNT = (8);

        [NativeTypeName("#define D3D12_SYSTEM_RESERVED_REGISTER_SPACE_VALUES_END ( 0xffffffff )")]
        public const uint D3D12_SYSTEM_RESERVED_REGISTER_SPACE_VALUES_END = (0xffffffff);

        [NativeTypeName("#define D3D12_SYSTEM_RESERVED_REGISTER_SPACE_VALUES_START ( 0xfffffff0 )")]
        public const uint D3D12_SYSTEM_RESERVED_REGISTER_SPACE_VALUES_START = (0xfffffff0);

        [NativeTypeName("#define D3D12_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR ( 64 )")]
        public const int D3D12_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR = (64);

        [NativeTypeName("#define D3D12_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR ( 64 )")]
        public const int D3D12_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR = (64);

        [NativeTypeName("#define D3D12_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR ( 63 )")]
        public const int D3D12_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR = (63);

        [NativeTypeName("#define D3D12_TESSELLATOR_MAX_TESSELLATION_FACTOR ( 64 )")]
        public const int D3D12_TESSELLATOR_MAX_TESSELLATION_FACTOR = (64);

        [NativeTypeName("#define D3D12_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR ( 2 )")]
        public const int D3D12_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR = (2);

        [NativeTypeName("#define D3D12_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR ( 1 )")]
        public const int D3D12_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR = (1);

        [NativeTypeName("#define D3D12_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR ( 1 )")]
        public const int D3D12_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR = (1);

        [NativeTypeName("#define D3D12_TEXEL_ADDRESS_RANGE_BIT_COUNT ( 16 )")]
        public const int D3D12_TEXEL_ADDRESS_RANGE_BIT_COUNT = (16);

        [NativeTypeName("#define D3D12_TEXTURE_DATA_PITCH_ALIGNMENT ( 256 )")]
        public const int D3D12_TEXTURE_DATA_PITCH_ALIGNMENT = (256);

        [NativeTypeName("#define D3D12_TEXTURE_DATA_PLACEMENT_ALIGNMENT ( 512 )")]
        public const int D3D12_TEXTURE_DATA_PLACEMENT_ALIGNMENT = (512);

        [NativeTypeName("#define D3D12_TILED_RESOURCE_TILE_SIZE_IN_BYTES ( 65536 )")]
        public const int D3D12_TILED_RESOURCE_TILE_SIZE_IN_BYTES = (65536);

        [NativeTypeName("#define D3D12_TRACKED_WORKLOAD_MAX_INSTANCES ( 32 )")]
        public const int D3D12_TRACKED_WORKLOAD_MAX_INSTANCES = (32);

        [NativeTypeName("#define D3D12_UAV_COUNTER_PLACEMENT_ALIGNMENT ( 4096 )")]
        public const int D3D12_UAV_COUNTER_PLACEMENT_ALIGNMENT = (4096);

        [NativeTypeName("#define D3D12_UAV_SLOT_COUNT ( 64 )")]
        public const int D3D12_UAV_SLOT_COUNT = (64);

        [NativeTypeName("#define D3D12_UNBOUND_MEMORY_ACCESS_RESULT ( 0 )")]
        public const int D3D12_UNBOUND_MEMORY_ACCESS_RESULT = (0);

        [NativeTypeName("#define D3D12_VIDEO_DECODE_MAX_ARGUMENTS ( 10 )")]
        public const int D3D12_VIDEO_DECODE_MAX_ARGUMENTS = (10);

        [NativeTypeName("#define D3D12_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS ( 4 )")]
        public const int D3D12_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_VIDEO_DECODE_MIN_BITSTREAM_OFFSET_ALIGNMENT ( 256 )")]
        public const int D3D12_VIDEO_DECODE_MIN_BITSTREAM_OFFSET_ALIGNMENT = (256);

        [NativeTypeName("#define D3D12_VIDEO_DECODE_MIN_HISTOGRAM_OFFSET_ALIGNMENT ( 256 )")]
        public const int D3D12_VIDEO_DECODE_MIN_HISTOGRAM_OFFSET_ALIGNMENT = (256);

        [NativeTypeName("#define D3D12_VIDEO_DECODE_STATUS_MACROBLOCKS_AFFECTED_UNKNOWN ( 0xffffffff )")]
        public const uint D3D12_VIDEO_DECODE_STATUS_MACROBLOCKS_AFFECTED_UNKNOWN = (0xffffffff);

        [NativeTypeName("#define D3D12_VIDEO_PROCESS_MAX_FILTERS ( 32 )")]
        public const int D3D12_VIDEO_PROCESS_MAX_FILTERS = (32);

        [NativeTypeName("#define D3D12_VIDEO_PROCESS_STEREO_VIEWS ( 2 )")]
        public const int D3D12_VIDEO_PROCESS_STEREO_VIEWS = (2);

        [NativeTypeName("#define D3D12_VIEWPORT_AND_SCISSORRECT_MAX_INDEX ( 15 )")]
        public const int D3D12_VIEWPORT_AND_SCISSORRECT_MAX_INDEX = (15);

        [NativeTypeName("#define D3D12_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ( 16 )")]
        public const int D3D12_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE = (16);

        [NativeTypeName("#define D3D12_VIEWPORT_BOUNDS_MAX ( 32767 )")]
        public const int D3D12_VIEWPORT_BOUNDS_MAX = (32767);

        [NativeTypeName("#define D3D12_VIEWPORT_BOUNDS_MIN ( -32768 )")]
        public const int D3D12_VIEWPORT_BOUNDS_MIN = (-32768);

        [NativeTypeName("#define D3D12_VS_INPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_VS_INPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_VS_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D12_VS_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D12_VS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D12_VS_INPUT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D12_VS_INPUT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D12_VS_INPUT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D12_VS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D12_VS_OUTPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D12_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D12_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D12_VS_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D12_VS_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D12_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT ( 10 )")]
        public const int D3D12_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT = (10);

        [NativeTypeName("#define D3D12_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 25 )")]
        public const int D3D12_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (25);

        [NativeTypeName("#define D3D12_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP ( 25 )")]
        public const int D3D12_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP = (25);

        [NativeTypeName("#define D3D12_SHADER_COMPONENT_MAPPING_MASK 0x7")]
        public const int D3D12_SHADER_COMPONENT_MAPPING_MASK = 0x7;

        [NativeTypeName("#define D3D12_SHADER_COMPONENT_MAPPING_SHIFT 3")]
        public const int D3D12_SHADER_COMPONENT_MAPPING_SHIFT = 3;

        [NativeTypeName("#define D3D12_SHADER_COMPONENT_MAPPING_ALWAYS_SET_BIT_AVOIDING_ZEROMEM_MISTAKES (1<<(D3D12_SHADER_COMPONENT_MAPPING_SHIFT*4))")]
        public const int D3D12_SHADER_COMPONENT_MAPPING_ALWAYS_SET_BIT_AVOIDING_ZEROMEM_MISTAKES = (1 << (3 * 4));

        [NativeTypeName("#define D3D12_DEFAULT_SHADER_4_COMPONENT_MAPPING D3D12_ENCODE_SHADER_4_COMPONENT_MAPPING(0,1,2,3)")]
        public const int D3D12_DEFAULT_SHADER_4_COMPONENT_MAPPING = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4))));

        [NativeTypeName("#define D3D12_FILTER_REDUCTION_TYPE_MASK ( 0x3 )")]
        public const int D3D12_FILTER_REDUCTION_TYPE_MASK = (0x3);

        [NativeTypeName("#define D3D12_FILTER_REDUCTION_TYPE_SHIFT ( 7 )")]
        public const int D3D12_FILTER_REDUCTION_TYPE_SHIFT = (7);

        [NativeTypeName("#define D3D12_FILTER_TYPE_MASK ( 0x3 )")]
        public const int D3D12_FILTER_TYPE_MASK = (0x3);

        [NativeTypeName("#define D3D12_MIN_FILTER_SHIFT ( 4 )")]
        public const int D3D12_MIN_FILTER_SHIFT = (4);

        [NativeTypeName("#define D3D12_MAG_FILTER_SHIFT ( 2 )")]
        public const int D3D12_MAG_FILTER_SHIFT = (2);

        [NativeTypeName("#define D3D12_MIP_FILTER_SHIFT ( 0 )")]
        public const int D3D12_MIP_FILTER_SHIFT = (0);

        [NativeTypeName("#define D3D12_ANISOTROPIC_FILTERING_BIT ( 0x40 )")]
        public const int D3D12_ANISOTROPIC_FILTERING_BIT = (0x40);

        [NativeTypeName("#define D3D12_SHADING_RATE_X_AXIS_SHIFT 2")]
        public const int D3D12_SHADING_RATE_X_AXIS_SHIFT = 2;

        [NativeTypeName("#define D3D12_SHADING_RATE_VALID_MASK 3")]
        public const int D3D12_SHADING_RATE_VALID_MASK = 3;
    }
}
