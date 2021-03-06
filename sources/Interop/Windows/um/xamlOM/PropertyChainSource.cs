// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PropertyChainSource
    {
        [NativeTypeName("InstanceHandle")]
        public ulong Handle;

        [NativeTypeName("BSTR")]
        public ushort* TargetType;

        [NativeTypeName("BSTR")]
        public ushort* Name;

        public BaseValueSource Source;

        public SourceInfo SrcInfo;
    }
}
