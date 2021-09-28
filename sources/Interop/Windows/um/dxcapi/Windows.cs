// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("dxcompiler", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DxcCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("dxcompiler", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DxcCreateInstance2(IMalloc* pMalloc, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [NativeTypeName("const UINT32")]
        public const uint DxcValidatorFlags_Default = 0;

        [NativeTypeName("const UINT32")]
        public const uint DxcValidatorFlags_InPlaceEdit = 1;

        [NativeTypeName("const UINT32")]
        public const uint DxcValidatorFlags_RootSignatureOnly = 2;

        [NativeTypeName("const UINT32")]
        public const uint DxcValidatorFlags_ModuleOnly = 4;

        [NativeTypeName("const UINT32")]
        public const uint DxcValidatorFlags_ValidMask = 0x7;

        [NativeTypeName("const UINT32")]
        public const uint DxcVersionInfoFlags_None = 0;

        [NativeTypeName("const UINT32")]
        public const uint DxcVersionInfoFlags_Debug = 1;

        [NativeTypeName("const UINT32")]
        public const uint DxcVersionInfoFlags_Internal = 2;

        [NativeTypeName("const CLSID")]
        public static ref readonly Guid CLSID_DxcCompiler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0x2D, 0xE2, 0x73,
                    0xCE, 0xE6,
                    0xF3, 0x47,
                    0xB5,
                    0xBF,
                    0xF0,
                    0x66,
                    0x4F,
                    0x39,
                    0xC1,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DxcLinker
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x87, 0x80, 0x6A, 0xEF,
                    0xEA, 0xB0,
                    0x56, 0x4D,
                    0x9E,
                    0x45,
                    0xD0,
                    0x7E,
                    0x1A,
                    0x8B,
                    0x78,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const CLSID")]
        public static ref readonly Guid CLSID_DxcDiaDataSource
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x73, 0x6B, 0x1F, 0xCD,
                    0xB0, 0x2A,
                    0x4D, 0x48,
                    0x8E,
                    0xDC,
                    0xEB,
                    0xE7,
                    0xA4,
                    0x3C,
                    0xA0,
                    0x9F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const CLSID")]
        public static ref readonly Guid CLSID_DxcCompilerArgs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0xAE, 0x56, 0x3E,
                    0x4D, 0x22,
                    0x0F, 0x47,
                    0xA1,
                    0xA1,
                    0xFE,
                    0x30,
                    0x16,
                    0xEE,
                    0x9F,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DxcLibrary
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0xD6, 0x45, 0x62,
                    0xE0, 0x66,
                    0xFD, 0x48,
                    0x80,
                    0xB4,
                    0x4D,
                    0x27,
                    0x17,
                    0x96,
                    0x74,
                    0x8C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DxcUtils => ref CLSID_DxcLibrary;

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DxcValidator
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0xE2, 0xA3, 0x8C,
                    0x28, 0xF7,
                    0xF3, 0x4C,
                    0x8C,
                    0xDD,
                    0x88,
                    0xAF,
                    0x91,
                    0x75,
                    0x87,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DxcAssembler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x68, 0xDB, 0x28, 0xD7,
                    0x03, 0xF9,
                    0x80, 0x4F,
                    0x94,
                    0xCD,
                    0xDC,
                    0xCF,
                    0x76,
                    0xEC,
                    0x71,
                    0x51
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DxcContainerReflection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x89, 0x44, 0xF5, 0xB9,
                    0xB8, 0x55,
                    0x0C, 0x40,
                    0xBA,
                    0x3A,
                    0x16,
                    0x75,
                    0xE4,
                    0x72,
                    0x8B,
                    0x91
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DxcOptimizer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9F, 0xD7, 0x2C, 0xAE,
                    0x22, 0xCC,
                    0x3F, 0x45,
                    0x9B,
                    0x6B,
                    0xB1,
                    0x24,
                    0xE7,
                    0xA5,
                    0x20,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DxcContainerBuilder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x94, 0x42, 0x13, 0x94,
                    0x1F, 0x41,
                    0x74, 0x45,
                    0xB4,
                    0xD0,
                    0x87,
                    0x41,
                    0xE2,
                    0x52,
                    0x40,
                    0xD2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define DXC_CP_UTF8 65001")]
        public const int DXC_CP_UTF8 = 65001;

        [NativeTypeName("#define DXC_CP_UTF16 1200")]
        public const int DXC_CP_UTF16 = 1200;

        [NativeTypeName("#define DXC_CP_ACP 0")]
        public const int DXC_CP_ACP = 0;

        [NativeTypeName("#define DXC_HASHFLAG_INCLUDES_SOURCE 1")]
        public const int DXC_HASHFLAG_INCLUDES_SOURCE = 1;

        [NativeTypeName("#define DXC_PART_PDB DXC_FOURCC('I', 'L', 'D', 'B')")]
        public const uint DXC_PART_PDB = ((uint)((byte)('I')) | (uint)((byte)('L')) << 8 | (uint)((byte)('D')) << 16 | (uint)((byte)('B')) << 24);

        [NativeTypeName("#define DXC_PART_PDB_NAME DXC_FOURCC('I', 'L', 'D', 'N')")]
        public const uint DXC_PART_PDB_NAME = ((uint)((byte)('I')) | (uint)((byte)('L')) << 8 | (uint)((byte)('D')) << 16 | (uint)((byte)('N')) << 24);

        [NativeTypeName("#define DXC_PART_PRIVATE_DATA DXC_FOURCC('P', 'R', 'I', 'V')")]
        public const uint DXC_PART_PRIVATE_DATA = ((uint)((byte)('P')) | (uint)((byte)('R')) << 8 | (uint)((byte)('I')) << 16 | (uint)((byte)('V')) << 24);

        [NativeTypeName("#define DXC_PART_ROOT_SIGNATURE DXC_FOURCC('R', 'T', 'S', '0')")]
        public const uint DXC_PART_ROOT_SIGNATURE = ((uint)((byte)('R')) | (uint)((byte)('T')) << 8 | (uint)((byte)('S')) << 16 | (uint)((byte)('0')) << 24);

        [NativeTypeName("#define DXC_PART_DXIL DXC_FOURCC('D', 'X', 'I', 'L')")]
        public const uint DXC_PART_DXIL = ((uint)((byte)('D')) | (uint)((byte)('X')) << 8 | (uint)((byte)('I')) << 16 | (uint)((byte)('L')) << 24);

        [NativeTypeName("#define DXC_PART_REFLECTION_DATA DXC_FOURCC('S', 'T', 'A', 'T')")]
        public const uint DXC_PART_REFLECTION_DATA = ((uint)((byte)('S')) | (uint)((byte)('T')) << 8 | (uint)((byte)('A')) << 16 | (uint)((byte)('T')) << 24);

        [NativeTypeName("#define DXC_PART_SHADER_HASH DXC_FOURCC('H', 'A', 'S', 'H')")]
        public const uint DXC_PART_SHADER_HASH = ((uint)((byte)('H')) | (uint)((byte)('A')) << 8 | (uint)((byte)('S')) << 16 | (uint)((byte)('H')) << 24);

        [NativeTypeName("#define DXC_PART_INPUT_SIGNATURE DXC_FOURCC('I', 'S', 'G', '1')")]
        public const uint DXC_PART_INPUT_SIGNATURE = ((uint)((byte)('I')) | (uint)((byte)('S')) << 8 | (uint)((byte)('G')) << 16 | (uint)((byte)('1')) << 24);

        [NativeTypeName("#define DXC_PART_OUTPUT_SIGNATURE DXC_FOURCC('O', 'S', 'G', '1')")]
        public const uint DXC_PART_OUTPUT_SIGNATURE = ((uint)((byte)('O')) | (uint)((byte)('S')) << 8 | (uint)((byte)('G')) << 16 | (uint)((byte)('1')) << 24);

        [NativeTypeName("#define DXC_PART_PATCH_CONSTANT_SIGNATURE DXC_FOURCC('P', 'S', 'G', '1')")]
        public const uint DXC_PART_PATCH_CONSTANT_SIGNATURE = ((uint)((byte)('P')) | (uint)((byte)('S')) << 8 | (uint)((byte)('G')) << 16 | (uint)((byte)('1')) << 24);

        [NativeTypeName("#define DXC_ARG_DEBUG L\"-Zi\"")]
        public const string DXC_ARG_DEBUG = "-Zi";

        [NativeTypeName("#define DXC_ARG_SKIP_VALIDATION L\"-Vd\"")]
        public const string DXC_ARG_SKIP_VALIDATION = "-Vd";

        [NativeTypeName("#define DXC_ARG_SKIP_OPTIMIZATIONS L\"-Od\"")]
        public const string DXC_ARG_SKIP_OPTIMIZATIONS = "-Od";

        [NativeTypeName("#define DXC_ARG_PACK_MATRIX_ROW_MAJOR L\"-Zpr\"")]
        public const string DXC_ARG_PACK_MATRIX_ROW_MAJOR = "-Zpr";

        [NativeTypeName("#define DXC_ARG_PACK_MATRIX_COLUMN_MAJOR L\"-Zpc\"")]
        public const string DXC_ARG_PACK_MATRIX_COLUMN_MAJOR = "-Zpc";

        [NativeTypeName("#define DXC_ARG_AVOID_FLOW_CONTROL L\"-Gfa\"")]
        public const string DXC_ARG_AVOID_FLOW_CONTROL = "-Gfa";

        [NativeTypeName("#define DXC_ARG_PREFER_FLOW_CONTROL L\"-Gfp\"")]
        public const string DXC_ARG_PREFER_FLOW_CONTROL = "-Gfp";

        [NativeTypeName("#define DXC_ARG_ENABLE_STRICTNESS L\"-Ges\"")]
        public const string DXC_ARG_ENABLE_STRICTNESS = "-Ges";

        [NativeTypeName("#define DXC_ARG_ENABLE_BACKWARDS_COMPATIBILITY L\"-Gec\"")]
        public const string DXC_ARG_ENABLE_BACKWARDS_COMPATIBILITY = "-Gec";

        [NativeTypeName("#define DXC_ARG_IEEE_STRICTNESS L\"-Gis\"")]
        public const string DXC_ARG_IEEE_STRICTNESS = "-Gis";

        [NativeTypeName("#define DXC_ARG_OPTIMIZATION_LEVEL0 L\"-O0\"")]
        public const string DXC_ARG_OPTIMIZATION_LEVEL0 = "-O0";

        [NativeTypeName("#define DXC_ARG_OPTIMIZATION_LEVEL1 L\"-O1\"")]
        public const string DXC_ARG_OPTIMIZATION_LEVEL1 = "-O1";

        [NativeTypeName("#define DXC_ARG_OPTIMIZATION_LEVEL2 L\"-O2\"")]
        public const string DXC_ARG_OPTIMIZATION_LEVEL2 = "-O2";

        [NativeTypeName("#define DXC_ARG_OPTIMIZATION_LEVEL3 L\"-O3\"")]
        public const string DXC_ARG_OPTIMIZATION_LEVEL3 = "-O3";

        [NativeTypeName("#define DXC_ARG_WARNINGS_ARE_ERRORS L\"-WX\"")]
        public const string DXC_ARG_WARNINGS_ARE_ERRORS = "-WX";

        [NativeTypeName("#define DXC_ARG_RESOURCES_MAY_ALIAS L\"-res_may_alias\"")]
        public const string DXC_ARG_RESOURCES_MAY_ALIAS = "-res_may_alias";

        [NativeTypeName("#define DXC_ARG_ALL_RESOURCES_BOUND L\"-all_resources_bound\"")]
        public const string DXC_ARG_ALL_RESOURCES_BOUND = "-all_resources_bound";

        [NativeTypeName("#define DXC_ARG_DEBUG_NAME_FOR_SOURCE L\"-Zss\"")]
        public const string DXC_ARG_DEBUG_NAME_FOR_SOURCE = "-Zss";

        [NativeTypeName("#define DXC_ARG_DEBUG_NAME_FOR_BINARY L\"-Zsb\"")]
        public const string DXC_ARG_DEBUG_NAME_FOR_BINARY = "-Zsb";

        public static ref readonly Guid IID_IDxcBlob
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x08, 0xFB, 0xA5, 0x8B,
                    0x95, 0x51,
                    0xE2, 0x40,
                    0xAC,
                    0x58,
                    0x0D,
                    0x98,
                    0x9C,
                    0x3A,
                    0x01,
                    0x02
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcBlobEncoding
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xD4, 0x41, 0x72,
                    0x46, 0x26,
                    0x91, 0x41,
                    0x97,
                    0xC0,
                    0x98,
                    0xE9,
                    0x6E,
                    0x42,
                    0xFC,
                    0x68
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcBlobUtf16
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAB, 0x4E, 0xF8, 0xA3,
                    0xAA, 0x0F,
                    0x7E, 0x49,
                    0xA3,
                    0x9C,
                    0xEE,
                    0x6E,
                    0xD6,
                    0x0B,
                    0x2D,
                    0x84
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcBlobUtf8
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC9, 0x36, 0xA6, 0x3D,
                    0x71, 0xBA,
                    0x24, 0x40,
                    0xA3,
                    0x01,
                    0x30,
                    0xCB,
                    0xF1,
                    0x25,
                    0x30,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcIncludeHandler
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7D, 0xFC, 0x61, 0x7F,
                    0x0D, 0x95,
                    0x7F, 0x46,
                    0xB3,
                    0xE3,
                    0x3C,
                    0x02,
                    0xFB,
                    0x49,
                    0x18,
                    0x7C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcCompilerArgs
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2A, 0xFE, 0xEF, 0x73,
                    0xDC, 0x70,
                    0xF8, 0x45,
                    0x96,
                    0x90,
                    0xEF,
                    0xF6,
                    0x4C,
                    0x02,
                    0x42,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcLibrary
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC7, 0x4D, 0x20, 0xE5,
                    0x8C, 0xD1,
                    0x3C, 0x4C,
                    0xBD,
                    0xFB,
                    0x85,
                    0x16,
                    0x73,
                    0x98,
                    0x0F,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcOperationResult
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4A, 0x48, 0xDB, 0xCE,
                    0xE9, 0xD4,
                    0x5A, 0x44,
                    0xB9,
                    0x91,
                    0xCA,
                    0x21,
                    0xCA,
                    0x15,
                    0x7D,
                    0xC2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcCompiler
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF3, 0x0B, 0x21, 0x8C,
                    0x1F, 0x01,
                    0x22, 0x44,
                    0x8D,
                    0x70,
                    0x6F,
                    0x9A,
                    0xCB,
                    0x8D,
                    0xB6,
                    0x17
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcCompiler2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD9, 0xA9, 0x05, 0xA0,
                    0xBB, 0xB8,
                    0x94, 0x45,
                    0xB5,
                    0xC9,
                    0x0E,
                    0x63,
                    0x3B,
                    0xEC,
                    0x4D,
                    0x37
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcLinker
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2A, 0xBE, 0xB5, 0xF1,
                    0xDD, 0x62,
                    0x27, 0x43,
                    0xA1,
                    0xC2,
                    0x42,
                    0xAC,
                    0x1E,
                    0x1E,
                    0x78,
                    0xE6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcUtils
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0xC4, 0x05, 0x46,
                    0x19, 0x20,
                    0x2A, 0x49,
                    0xAD,
                    0xA4,
                    0x65,
                    0xF2,
                    0x0B,
                    0xB7,
                    0xD6,
                    0x7F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcResult
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDA, 0x6C, 0x34, 0x58,
                    0xE7, 0xDD,
                    0x97, 0x44,
                    0x94,
                    0x61,
                    0x6F,
                    0x87,
                    0xAF,
                    0x5E,
                    0x06,
                    0x59
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcCompiler3
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x87, 0x46, 0x8B, 0x22,
                    0x6A, 0x5A,
                    0x30, 0x47,
                    0x90,
                    0x0C,
                    0x97,
                    0x02,
                    0xB2,
                    0x20,
                    0x3F,
                    0x54
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcValidator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD2, 0x2B, 0xE8, 0xA6,
                    0xD7, 0x1F,
                    0x26, 0x48,
                    0x98,
                    0x11,
                    0x28,
                    0x57,
                    0xE7,
                    0x97,
                    0xF4,
                    0x9A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcContainerBuilder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x1F, 0x4B, 0x33,
                    0x92, 0x22,
                    0x35, 0x4B,
                    0x99,
                    0xA1,
                    0x25,
                    0x58,
                    0x8D,
                    0x8C,
                    0x17,
                    0xFE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcAssembler
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x7A, 0x1F, 0x09,
                    0x1F, 0x1C,
                    0x48, 0x49,
                    0x90,
                    0x4B,
                    0xE6,
                    0xE3,
                    0xA8,
                    0xA7,
                    0x71,
                    0xD5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcContainerReflection
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x1B, 0xC2, 0xD2,
                    0x50, 0x83,
                    0xDC, 0x4B,
                    0x97,
                    0x6A,
                    0x33,
                    0x1C,
                    0xE6,
                    0xF4,
                    0xC5,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcOptimizerPass
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9F, 0xD7, 0x2C, 0xAE,
                    0x22, 0xCC,
                    0x3F, 0x45,
                    0x9B,
                    0x6B,
                    0xB1,
                    0x24,
                    0xE7,
                    0xA5,
                    0x20,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcOptimizer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2E, 0x0E, 0x74, 0x25,
                    0xBA, 0x9C,
                    0x1B, 0x40,
                    0x91,
                    0x19,
                    0x4F,
                    0xB4,
                    0x2F,
                    0x39,
                    0xF2,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcVersionInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x5B, 0x4F, 0xB0,
                    0x59, 0x20,
                    0x12, 0x4F,
                    0xA8,
                    0xFF,
                    0xA1,
                    0xE0,
                    0xCD,
                    0xE1,
                    0xCC,
                    0x7E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDxcVersionInfo2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC4, 0x04, 0x69, 0xFB,
                    0xF0, 0x42,
                    0x62, 0x4B,
                    0x9C,
                    0x46,
                    0x98,
                    0x3A,
                    0xF7,
                    0xDA,
                    0x7C,
                    0x83
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
