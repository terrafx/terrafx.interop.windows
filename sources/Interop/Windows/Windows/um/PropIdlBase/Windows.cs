// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define PROPSETFLAG_DEFAULT ( 0 )")]
        public const int PROPSETFLAG_DEFAULT = (0);

        [NativeTypeName("#define PROPSETFLAG_NONSIMPLE ( 1 )")]
        public const int PROPSETFLAG_NONSIMPLE = (1);

        [NativeTypeName("#define PROPSETFLAG_ANSI ( 2 )")]
        public const int PROPSETFLAG_ANSI = (2);

        [NativeTypeName("#define PROPSETFLAG_UNBUFFERED ( 4 )")]
        public const int PROPSETFLAG_UNBUFFERED = (4);

        [NativeTypeName("#define PROPSETFLAG_CASE_SENSITIVE ( 8 )")]
        public const int PROPSETFLAG_CASE_SENSITIVE = (8);

        [NativeTypeName("#define PROPSET_BEHAVIOR_CASE_SENSITIVE ( 1 )")]
        public const int PROPSET_BEHAVIOR_CASE_SENSITIVE = (1);

        [NativeTypeName("#define PID_DICTIONARY ( 0 )")]
        public const int PID_DICTIONARY = (0);

        [NativeTypeName("#define PID_CODEPAGE ( 0x1 )")]
        public const int PID_CODEPAGE = (0x1);

        [NativeTypeName("#define PID_FIRST_USABLE ( 0x2 )")]
        public const int PID_FIRST_USABLE = (0x2);

        [NativeTypeName("#define PID_FIRST_NAME_DEFAULT ( 0xfff )")]
        public const int PID_FIRST_NAME_DEFAULT = (0xfff);

        [NativeTypeName("#define PID_LOCALE ( 0x80000000 )")]
        public const uint PID_LOCALE = (0x80000000);

        [NativeTypeName("#define PID_MODIFY_TIME ( 0x80000001 )")]
        public const uint PID_MODIFY_TIME = (0x80000001);

        [NativeTypeName("#define PID_SECURITY ( 0x80000002 )")]
        public const uint PID_SECURITY = (0x80000002);

        [NativeTypeName("#define PID_BEHAVIOR ( 0x80000003 )")]
        public const uint PID_BEHAVIOR = (0x80000003);

        [NativeTypeName("#define PID_ILLEGAL ( 0xffffffff )")]
        public const uint PID_ILLEGAL = (0xffffffff);

        [NativeTypeName("#define PID_MIN_READONLY ( 0x80000000 )")]
        public const uint PID_MIN_READONLY = (0x80000000);

        [NativeTypeName("#define PID_MAX_READONLY ( 0xbfffffff )")]
        public const uint PID_MAX_READONLY = (0xbfffffff);

        [NativeTypeName("#define PRSPEC_INVALID ( 0xffffffff )")]
        public const uint PRSPEC_INVALID = (0xffffffff);

        [NativeTypeName("#define PRSPEC_LPWSTR ( 0 )")]
        public const int PRSPEC_LPWSTR = (0);

        [NativeTypeName("#define PRSPEC_PROPID ( 1 )")]
        public const int PRSPEC_PROPID = (1);

        [NativeTypeName("#define PROPSETHDR_OSVERSION_UNKNOWN 0xFFFFFFFF")]
        public const uint PROPSETHDR_OSVERSION_UNKNOWN = 0xFFFFFFFF;

        public static ref readonly Guid IID_IPropertyStorage
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x38, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPropertySetStorage
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumSTATPROPSTG
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumSTATPROPSETSTG
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
