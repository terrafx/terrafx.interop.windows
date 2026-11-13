// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_WICImagingFactory => ref CLSID_WICImagingFactory2;

    public static ref readonly Guid CLSID_WICPngDecoder => ref CLSID_WICPngDecoder2;
}
