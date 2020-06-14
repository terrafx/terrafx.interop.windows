// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SPEVENTLPARAMTYPE
    {
        SPET_LPARAM_IS_UNDEFINED = 0,
        SPET_LPARAM_IS_TOKEN = (SPET_LPARAM_IS_UNDEFINED + 1),
        SPET_LPARAM_IS_OBJECT = (SPET_LPARAM_IS_TOKEN + 1),
        SPET_LPARAM_IS_POINTER = (SPET_LPARAM_IS_OBJECT + 1),
        SPET_LPARAM_IS_STRING = (SPET_LPARAM_IS_POINTER + 1),
    }
}
