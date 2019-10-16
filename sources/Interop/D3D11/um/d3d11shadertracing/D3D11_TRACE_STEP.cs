// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_TRACE_STEP
    {
        [NativeTypeName("UINT")]
        public uint ID;

        [NativeTypeName("BOOL")]
        public int InstructionActive;

        [NativeTypeName("UINT8")]
        public byte NumRegistersWritten;

        [NativeTypeName("UINT8")]
        public byte NumRegistersRead;

        [NativeTypeName("D3D11_TRACE_MISC_OPERATIONS_MASK")]
        public ushort MiscOperations;

        [NativeTypeName("UINT")]
        public uint OpcodeType;

        [NativeTypeName("UINT64")]
        public ulong CurrentGlobalCycle;
    }
}
