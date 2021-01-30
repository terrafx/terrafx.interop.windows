// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum ObjectType
    {
        ObjectTypeInvalid,
        ObjectTypeBrush,
        ObjectTypePen,
        ObjectTypePath,
        ObjectTypeRegion,
        ObjectTypeImage,
        ObjectTypeFont,
        ObjectTypeStringFormat,
        ObjectTypeImageAttributes,
        ObjectTypeCustomLineCap,
        ObjectTypeMax = ObjectTypeCustomLineCap,
        ObjectTypeMin = ObjectTypeBrush,
    }
}
