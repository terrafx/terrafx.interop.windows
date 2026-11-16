// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Gdiplus.MetafileType;

namespace TerraFX.Interop.Gdiplus;

public unsafe partial struct MetafileHeader
{
    public readonly METAHEADER* GetWmfHeader()
    {
        return (IsWmf() != 0) ? (METAHEADER*)Unsafe.AsPointer(ref Unsafe.AsRef(in Anonymous.WmfHeader)) : null;
    }

    public readonly ENHMETAHEADER3* GetEmfHeader()
    {
        return (IsEmfOrEmfPlus() != 0) ? (ENHMETAHEADER3*)Unsafe.AsPointer(ref Unsafe.AsRef(in Anonymous.EmfHeader)) : null;
    }

    public readonly BOOL IsEmfOrEmfPlus()
    {
        return Type >= MetafileTypeEmf;
    }

    public readonly BOOL IsEmfPlus()
    {
        return Type >= MetafileTypeEmfPlusOnly;
    }
}
