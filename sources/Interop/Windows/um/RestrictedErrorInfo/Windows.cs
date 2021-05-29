// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestrictedErrorInfo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IRestrictedErrorInfo = new Guid(0x82BA7092, 0x4C88, 0x427D, 0xA7, 0xBC, 0x16, 0xDD, 0x93, 0xFE, 0xB6, 0x7E);

        public static readonly Guid IID_ILanguageExceptionErrorInfo = new Guid(0x04A2DBF3, 0xDF83, 0x116C, 0x09, 0x46, 0x08, 0x12, 0xAB, 0xF6, 0xE0, 0x7D);

        public static readonly Guid IID_ILanguageExceptionTransform = new Guid(0xFEB5A271, 0xA6CD, 0x45CE, 0x88, 0x0A, 0x69, 0x67, 0x06, 0xBA, 0xDC, 0x65);

        public static readonly Guid IID_ILanguageExceptionStackBackTrace = new Guid(0xCBE53FB5, 0xF967, 0x4258, 0x8D, 0x34, 0x42, 0xF5, 0xE2, 0x58, 0x33, 0xDE);

        public static readonly Guid IID_ILanguageExceptionErrorInfo2 = new Guid(0x5746E5C4, 0x5B97, 0x424C, 0xB6, 0x20, 0x28, 0x22, 0x91, 0x57, 0x34, 0xDD);
    }
}
