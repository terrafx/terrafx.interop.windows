// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct STORAGE_GET_BC_PROPERTIES_OUTPUT
    {
        [NativeTypeName("DWORD")]
        public uint MaximumRequestsPerPeriod;

        [NativeTypeName("DWORD")]
        public uint MinimumPeriod;

        [NativeTypeName("DWORDLONG")]
        public ulong MaximumRequestSize;

        [NativeTypeName("DWORD")]
        public uint EstimatedTimePerRequest;

        [NativeTypeName("DWORD")]
        public uint NumOutStandingRequests;

        [NativeTypeName("DWORDLONG")]
        public ulong RequestSize;
    }
}
