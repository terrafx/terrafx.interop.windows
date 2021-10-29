// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop
{
    public enum __MIDL___MIDL_itf_dia2_0000_0033_0001
    {
        E_DIA_INPROLOG = unchecked((int)(((((uint)(1) << 31) | ((uint)((int)(0x6d)) << 16)) | (uint)(100)))),
        E_DIA_SYNTAX = (E_DIA_INPROLOG + 1),
        E_DIA_FRAME_ACCESS = (E_DIA_SYNTAX + 1),
        E_DIA_VALUE = (E_DIA_FRAME_ACCESS + 1),
    }
}
