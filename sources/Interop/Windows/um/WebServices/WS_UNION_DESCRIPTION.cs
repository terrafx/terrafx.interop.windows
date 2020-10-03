// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_UNION_DESCRIPTION
    {
        [NativeTypeName("ULONG")]
        public uint size;

        [NativeTypeName("ULONG")]
        public uint alignment;

        [NativeTypeName("WS_UNION_FIELD_DESCRIPTION **")]
        public WS_UNION_FIELD_DESCRIPTION** fields;

        [NativeTypeName("ULONG")]
        public uint fieldCount;

        [NativeTypeName("ULONG")]
        public uint enumOffset;

        public int noneEnumValue;

        [NativeTypeName("ULONG *")]
        public uint* valueIndices;
    }
}
