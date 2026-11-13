// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;
using static TerraFX.Interop.Gdiplus.ObjectType;

namespace TerraFX.Interop.Gdiplus;

public static partial class Gdiplus
{
    public static EmfPlusRecordType GDIP_WMF_RECORD_TO_EMFPLUS(int n)
        => (EmfPlusRecordType)(n | GDIP_WMF_RECORD_BASE);

    public static int GDIP_EMFPLUS_RECORD_TO_WMF(EmfPlusRecordType n)
        => ((int)n) & ~GDIP_WMF_RECORD_BASE;

    public static BOOL GDIP_IS_WMF_RECORDTYPE(EmfPlusRecordType n)
        => (((int)n & GDIP_WMF_RECORD_BASE) != 0);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ObjectTypeIsValid"]/*' />
    public static BOOL ObjectTypeIsValid([NativeTypeName("Gdiplus::ObjectType")] ObjectType type)
    {
        return (type >= ObjectTypeMin) && (type <= ObjectTypeMax);
    }
}
