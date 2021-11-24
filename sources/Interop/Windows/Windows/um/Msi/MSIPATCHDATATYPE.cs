// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum MSIPATCHDATATYPE
{
    MSIPATCH_DATATYPE_PATCHFILE = 0,
    MSIPATCH_DATATYPE_XMLPATH = 1,
    MSIPATCH_DATATYPE_XMLBLOB = 2,
}
