// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;
using static TerraFX.Interop.Gdiplus.MetafileType;

namespace TerraFX.Interop.Gdiplus;

public partial struct MetafileHeader
{
    public BOOL IsEmfOrEmfPlus()
    {
        return Type >= MetafileTypeEmf;
    }

    public BOOL IsEmfPlus()
    {
        return Type >= MetafileTypeEmfPlusOnly;
    }
}
