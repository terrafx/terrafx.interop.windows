// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct TP_POOL_STACK_INFORMATION
    {
        [NativeTypeName("SIZE_T")]
        public UIntPtr StackReserve;

        [NativeTypeName("SIZE_T")]
        public UIntPtr StackCommit;
    }
}
