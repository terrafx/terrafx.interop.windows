// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum PMTUD_STATE
    {
        IP_PMTUDISC_NOT_SET,
        IP_PMTUDISC_DO,
        IP_PMTUDISC_DONT,
        IP_PMTUDISC_PROBE,
        IP_PMTUDISC_MAX,
    }
}
