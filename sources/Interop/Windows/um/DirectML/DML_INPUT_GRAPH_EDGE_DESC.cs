// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DML_INPUT_GRAPH_EDGE_DESC
    {
        [NativeTypeName("UINT")]
        public uint GraphInputIndex;

        [NativeTypeName("UINT")]
        public uint ToNodeIndex;

        [NativeTypeName("UINT")]
        public uint ToNodeInputIndex;

        [NativeTypeName("const char *")]
        public sbyte* Name;
    }
}
