// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define WTS_E_FAILEDEXTRACTION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB200)")]
        public const int WTS_E_FAILEDEXTRACTION = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB200))));

        [NativeTypeName("#define WTS_E_EXTRACTIONTIMEDOUT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB201)")]
        public const int WTS_E_EXTRACTIONTIMEDOUT = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB201))));

        [NativeTypeName("#define WTS_E_SURROGATEUNAVAILABLE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB202)")]
        public const int WTS_E_SURROGATEUNAVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB202))));

        [NativeTypeName("#define WTS_E_FASTEXTRACTIONNOTSUPPORTED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB203)")]
        public const int WTS_E_FASTEXTRACTIONNOTSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB203))));

        [NativeTypeName("#define WTS_E_DATAFILEUNAVAILABLE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB204)")]
        public const int WTS_E_DATAFILEUNAVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB204))));

        [NativeTypeName("#define WTS_E_EXTRACTIONPENDING MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB205)")]
        public const int WTS_E_EXTRACTIONPENDING = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB205))));

        [NativeTypeName("#define WTS_E_EXTRACTIONBLOCKED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB206)")]
        public const int WTS_E_EXTRACTIONBLOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB206))));

        [NativeTypeName("#define WTS_E_NOSTORAGEPROVIDERTHUMBNAILHANDLER MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB207)")]
        public const int WTS_E_NOSTORAGEPROVIDERTHUMBNAILHANDLER = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB207))));

        public static readonly Guid IID_ISharedBitmap = new Guid(0x091162A4, 0xBC96, 0x411F, 0xAA, 0xE8, 0xC5, 0x12, 0x2C, 0xD0, 0x33, 0x63);

        public static readonly Guid IID_IThumbnailCache = new Guid(0xF676C15D, 0x596A, 0x4CE2, 0x82, 0x34, 0x33, 0x99, 0x6F, 0x44, 0x5D, 0xB1);

        public static readonly Guid IID_IThumbnailProvider = new Guid(0xE357FCCD, 0xA995, 0x4576, 0xB0, 0x1F, 0x23, 0x46, 0x30, 0x15, 0x4E, 0x96);

        public static readonly Guid IID_IThumbnailSettings = new Guid(0xF4376F00, 0xBEF5, 0x4D45, 0x80, 0xF3, 0x1E, 0x02, 0x3B, 0xBF, 0x12, 0x09);

        public static readonly Guid IID_IThumbnailCachePrimer = new Guid(0x0F03F8FE, 0x2B26, 0x46F0, 0x96, 0x5A, 0x21, 0x2A, 0xA8, 0xD6, 0x6B, 0x76);

        public static readonly Guid IID_LocalThumbnailCache = new Guid(0x50EF4544, 0xAC9F, 0x4A8E, 0xB2, 0x1B, 0x8A, 0x26, 0x18, 0x0D, 0xB1, 0x3F);

        public static readonly Guid IID_SharedBitmap = new Guid(0x4DB26476, 0x6787, 0x4046, 0xB8, 0x36, 0xE8, 0x41, 0x2A, 0x9E, 0x8A, 0x27);
    }
}
