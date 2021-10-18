// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MSIMODIFY
    {
        MSIMODIFY_SEEK = -1,
        MSIMODIFY_REFRESH = 0,
        MSIMODIFY_INSERT = 1,
        MSIMODIFY_UPDATE = 2,
        MSIMODIFY_ASSIGN = 3,
        MSIMODIFY_REPLACE = 4,
        MSIMODIFY_MERGE = 5,
        MSIMODIFY_DELETE = 6,
        MSIMODIFY_INSERT_TEMPORARY = 7,
        MSIMODIFY_VALIDATE = 8,
        MSIMODIFY_VALIDATE_NEW = 9,
        MSIMODIFY_VALIDATE_FIELD = 10,
        MSIMODIFY_VALIDATE_DELETE = 11,
    }
}
