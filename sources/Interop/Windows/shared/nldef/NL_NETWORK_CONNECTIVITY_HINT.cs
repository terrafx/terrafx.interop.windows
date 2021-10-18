// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct NL_NETWORK_CONNECTIVITY_HINT
    {
        public NL_NETWORK_CONNECTIVITY_LEVEL_HINT ConnectivityLevel;

        public NL_NETWORK_CONNECTIVITY_COST_HINT ConnectivityCost;

        [NativeTypeName("BOOLEAN")]
        public byte ApproachingDataLimit;

        [NativeTypeName("BOOLEAN")]
        public byte OverDataLimit;

        [NativeTypeName("BOOLEAN")]
        public byte Roaming;
    }
}
