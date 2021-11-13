// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum PROPDESC_AGGREGATION_TYPE
    {
        PDAT_DEFAULT = 0,
        PDAT_FIRST = 1,
        PDAT_SUM = 2,
        PDAT_AVERAGE = 3,
        PDAT_DATERANGE = 4,
        PDAT_UNION = 5,
        PDAT_MAX = 6,
        PDAT_MIN = 7,
    }
}
