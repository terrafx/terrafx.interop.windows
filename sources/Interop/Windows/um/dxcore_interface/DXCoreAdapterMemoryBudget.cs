// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DXCoreAdapterMemoryBudget
    {
        [NativeTypeName("uint64_t")]
        public ulong budget;

        [NativeTypeName("uint64_t")]
        public ulong currentUsage;

        [NativeTypeName("uint64_t")]
        public ulong availableForReservation;

        [NativeTypeName("uint64_t")]
        public ulong currentReservation;
    }
}
