// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum PERSIST_SPROPSTORE_FLAGS
    {
        FPSPS_DEFAULT = 0,
        FPSPS_READONLY = 0x1,
        FPSPS_TREAT_NEW_VALUES_AS_DIRTY = 0x2,
    }
}
