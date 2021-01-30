// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE
    {
        IMAPI_FORMAT2_RAW_CD_SUBCODE_PQ_ONLY = 0x1,
        IMAPI_FORMAT2_RAW_CD_SUBCODE_IS_COOKED = 0x2,
        IMAPI_FORMAT2_RAW_CD_SUBCODE_IS_RAW = 0x3,
    }
}
