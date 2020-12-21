// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcapi.h in the microsoft/DirectXCompiler commit 747ee519eb9b65f893bb891bc6d229dfe9687e6a
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const CLSID")]
        public static readonly Guid CLSID_DxcCompilerArgs = new Guid(0x3e56ae82, 0x224d, 0x470f, 0xa1, 0xa1, 0xfe, 0x30, 0x16, 0xee, 0x9f, 0x9d);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcUtils = CLSID_DxcLibrary;

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxcPdbUtils = new Guid(0x54621dfb, 0xf2ce, 0x457e, 0xae, 0x8c, 0xec, 0x35, 0x5f, 0xae, 0xec, 0x7c);

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

        [NativeTypeName("#define DXC_EXTRA_OUTPUT_NAME_STDOUT L\"*stdout*\"")]
        public const string DXC_EXTRA_OUTPUT_NAME_STDOUT = "*stdout*";

        [NativeTypeName("#define DXC_EXTRA_OUTPUT_NAME_STDERR L\"*stderr*\"")]
        public const string DXC_EXTRA_OUTPUT_NAME_STDERR = "*stderr*";

        public static readonly Guid IID_IDxcBlobUtf16 = new Guid(0xA3F84EAB, 0x0FAA, 0x497E, 0xA3, 0x9C, 0xEE, 0x6E, 0xD6, 0x0B, 0x2D, 0x84);

        public static readonly Guid IID_IDxcBlobUtf8 = new Guid(0x3DA636C9, 0xBA71, 0x4024, 0xA3, 0x01, 0x30, 0xCB, 0xF1, 0x25, 0x30, 0x5B);

        public static readonly Guid IID_IDxcCompilerArgs = new Guid(0x73EFFE2A, 0x70DC, 0x45F8, 0x96, 0x90, 0xEF, 0xF6, 0x4C, 0x02, 0x42, 0x9D);

        public static readonly Guid IID_IDxcUtils = new Guid(0x4605C4CB, 0x2019, 0x492A, 0xAD, 0xA4, 0x65, 0xF2, 0x0B, 0xB7, 0xD6, 0x7F);

        public static readonly Guid IID_IDxcResult = new Guid(0x58346CDA, 0xDDE7, 0x4497, 0x94, 0x61, 0x6F, 0x87, 0xAF, 0x5E, 0x06, 0x59);

        public static readonly Guid IID_IDxcExtraOutputs = new Guid(0x319B37A2, 0xA5C2, 0x494A, 0xA5, 0xDE, 0x48, 0x01, 0xB2, 0xFA, 0xF9, 0x89);

        public static readonly Guid IID_IDxcCompiler3 = new Guid(0x228B4687, 0x5A6A, 0x4730, 0x90, 0x0C, 0x97, 0x02, 0xB2, 0x20, 0x3F, 0x54);

        public static readonly Guid IID_IDxcPdbUtils = new Guid(0xE6C9647E, 0x9D6A, 0x4C3B, 0xB9, 0x4C, 0x52, 0x4B, 0x5A, 0x6C, 0x34, 0x3D);
    }
}
