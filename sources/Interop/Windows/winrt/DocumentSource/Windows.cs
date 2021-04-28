// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/DocumentSource.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define JOB_PAGE_APPLICATION_DEFINED ( ( UINT32  )-1 )")]
        public const uint JOB_PAGE_APPLICATION_DEFINED = unchecked((uint)(-1));

        public static readonly Guid IID_IPrintPreviewPageCollection = new Guid(0x0B31CC62, 0xD7EC, 0x4747, 0x9D, 0x6E, 0xF2, 0x53, 0x7D, 0x87, 0x0F, 0x2B);

        public static readonly Guid IID_IPrintDocumentPageSource = new Guid(0xA96BB1DB, 0x172E, 0x4667, 0x82, 0xB5, 0xAD, 0x97, 0xA2, 0x52, 0x31, 0x8F);
    }
}
