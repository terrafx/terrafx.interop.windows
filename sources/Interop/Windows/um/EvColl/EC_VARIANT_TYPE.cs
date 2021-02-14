// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum EC_VARIANT_TYPE
    {
        EcVarTypeNull = 0,
        EcVarTypeBoolean,
        EcVarTypeUInt32,
        EcVarTypeDateTime,
        EcVarTypeString,
        EcVarObjectArrayPropertyHandle,
    }
}
