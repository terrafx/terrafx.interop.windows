// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum STORAGE_BUS_TYPE
    {
        BusTypeUnknown = 0x00,
        BusTypeScsi,
        BusTypeAtapi,
        BusTypeAta,
        BusType1394,
        BusTypeSsa,
        BusTypeFibre,
        BusTypeUsb,
        BusTypeRAID,
        BusTypeiScsi,
        BusTypeSas,
        BusTypeSata,
        BusTypeSd,
        BusTypeMmc,
        BusTypeVirtual,
        BusTypeFileBackedVirtual,
        BusTypeSpaces,
        BusTypeNvme,
        BusTypeSCM,
        BusTypeUfs,
        BusTypeMax,
        BusTypeMaxReserved = 0x7F,
    }
}
