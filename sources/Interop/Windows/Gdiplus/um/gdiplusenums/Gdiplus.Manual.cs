// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;
using static TerraFX.Interop.Gdiplus.ObjectType;

namespace TerraFX.Interop.Gdiplus;

public static partial class Gdiplus
{
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ObjectTypeIsValid"]/*' />
    public static BOOL ObjectTypeIsValid([NativeTypeName("Gdiplus::ObjectType")] ObjectType type)
    {
        return (type >= ObjectTypeMin) && (type <= ObjectTypeMax);
    }
}
