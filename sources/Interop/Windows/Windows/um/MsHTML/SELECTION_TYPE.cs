// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum SELECTION_TYPE
    {
        SELECTION_TYPE_None = 0,
        SELECTION_TYPE_Caret = 1,
        SELECTION_TYPE_Text = 2,
        SELECTION_TYPE_Control = 3,
        SELECTION_TYPE_Max = 2147483647,
    }
}
