// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum FUNCKIND
    {
        FUNC_VIRTUAL = 0,
        FUNC_PUREVIRTUAL = (FUNC_VIRTUAL + 1),
        FUNC_NONVIRTUAL = (FUNC_PUREVIRTUAL + 1),
        FUNC_STATIC = (FUNC_NONVIRTUAL + 1),
        FUNC_DISPATCH = (FUNC_STATIC + 1),
    }
}
