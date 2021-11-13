// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct TP_POOL_STACK_INFORMATION
    {
        [NativeTypeName("SIZE_T")]
        public nuint StackReserve;

        [NativeTypeName("SIZE_T")]
        public nuint StackCommit;
    }
}
