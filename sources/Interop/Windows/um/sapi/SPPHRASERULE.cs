// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SPPHRASERULE
    {
        [NativeTypeName("LPCWSTR")]
        public ushort* pszName;

        [NativeTypeName("ULONG")]
        public uint ulId;

        [NativeTypeName("ULONG")]
        public uint ulFirstElement;

        [NativeTypeName("ULONG")]
        public uint ulCountOfElements;

        [NativeTypeName("const SPPHRASERULE *")]
        public SPPHRASERULE* pNextSibling;

        [NativeTypeName("const SPPHRASERULE *")]
        public SPPHRASERULE* pFirstChild;

        public float SREngineConfidence;

        [NativeTypeName("signed char")]
        public sbyte Confidence;
    }
}
