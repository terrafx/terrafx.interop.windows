// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PrintPreview.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

public static partial class ID
{
    [NativeTypeName("#define ID_PREVIEWPACKAGETARGET_DXGI __uuidof(IPrintPreviewDxgiPackageTarget)")]
    public static ref readonly Guid ID_PREVIEWPACKAGETARGET_DXGI => ref IID_IPrintPreviewDxgiPackageTarget;
}
