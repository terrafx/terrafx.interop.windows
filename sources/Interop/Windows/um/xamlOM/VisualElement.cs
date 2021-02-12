// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct VisualElement
    {
        [NativeTypeName("InstanceHandle")]
        public ulong Handle;

        public SourceInfo SrcInfo;

        [NativeTypeName("BSTR")]
        public ushort* Type;

        [NativeTypeName("BSTR")]
        public ushort* Name;

        [NativeTypeName("unsigned int")]
        public uint NumChildren;
    }
}
