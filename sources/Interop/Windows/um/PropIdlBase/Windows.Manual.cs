// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int PROPSETFLAG_DEFAULT = 0;

        public const int PROPSETFLAG_NONSIMPLE = 1;

        public const int PROPSETFLAG_ANSI = 2;

        public const int PROPSETFLAG_UNBUFFERED = 4;

        public const int PROPSETFLAG_CASE_SENSITIVE = 8;

        public const int PROPSET_BEHAVIOR_CASE_SENSITIVE = 1;

        public const uint PID_DICTIONARY = 0;

        public const uint PID_CODEPAGE = 0x1;

        public const uint PID_FIRST_USABLE = 0x2;

        public const uint PID_FIRST_NAME_DEFAULT = 0xFFF;

        public const uint PID_LOCALE = 0x80000000;

        public const uint PID_MODIFY_TIME = 0x80000001;

        public const uint PID_SECURITY = 0x80000002;

        public const uint PID_BEHAVIOR = 0x80000003;

        public const uint PID_ILLEGAL = 0xFFFFFFFF;

        public const uint PID_MIN_READONLY = 0x80000000;

        public const uint PID_MAX_READONLY = 0xBFFFFFFF;

        public const uint PRSPEC_INVALID = 0xFFFFFFFF;

        public const uint PRSPEC_LPWSTR = 0;

        public const uint PRSPEC_PROPID = 1;

        public static ushort PROPSETHDR_OSVER_KIND(nuint dwOSVer) => HIWORD(dwOSVer);

        public static byte PROPSETHDR_OSVER_MAJOR(nuint dwOSVer) => LOBYTE(LOWORD(dwOSVer));

        public static byte PROPSETHDR_OSVER_MINOR(nuint dwOSVer) => HIBYTE(LOWORD(dwOSVer));

        public static nuint PROPSETHDR_OSVERSION_UNKNOWN = 0xFFFFFFFF;

        public static readonly Guid IID_IEnumSTATPROPSETSTG = new Guid(0x0000013B, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IEnumSTATPROPSTG = new Guid(0x00000139, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IPropertySetStorage = new Guid(0x0000013A, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IPropertyStorage = new Guid(0x00000138, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);
    }
}
