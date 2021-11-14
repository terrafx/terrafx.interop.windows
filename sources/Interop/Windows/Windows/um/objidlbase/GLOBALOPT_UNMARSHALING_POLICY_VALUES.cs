// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    public enum GLOBALOPT_UNMARSHALING_POLICY_VALUES
    {
        COMGLB_UNMARSHALING_POLICY_NORMAL = 0,
        COMGLB_UNMARSHALING_POLICY_STRONG = 1,
        COMGLB_UNMARSHALING_POLICY_HYBRID = 2,
    }
}
