// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum ASSOCIATIONTYPE
    {
        AT_FILEEXTENSION = 0,
        AT_URLPROTOCOL = (AT_FILEEXTENSION + 1),
        AT_STARTMENUCLIENT = (AT_URLPROTOCOL + 1),
        AT_MIMETYPE = (AT_STARTMENUCLIENT + 1),
    }
}
