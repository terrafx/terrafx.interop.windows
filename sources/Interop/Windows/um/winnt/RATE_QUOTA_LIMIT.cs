// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct RATE_QUOTA_LIMIT
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint RateData;

        [FieldOffset(0)]
        [NativeTypeName("_RATE_QUOTA_LIMIT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11552:5)")]
        public _Anonymous_e__Union Anonymous;

        public partial struct _Anonymous_e__Union
        {
            internal uint _bitfield;

            [NativeTypeName("DWORD : 7")]
            public uint RatePercent
            {
                get
                {
                    return _bitfield & 0x7Fu;
                }

                set
                {
                    _bitfield = (_bitfield & ~0x7Fu) | (value & 0x7Fu);
                }
            }

            [NativeTypeName("DWORD : 25")]
            public uint Reserved0
            {
                get
                {
                    return (_bitfield >> 7) & 0x1FFFFFFu;
                }

                set
                {
                    _bitfield = (_bitfield & ~(0x1FFFFFFu << 7)) | ((value & 0x1FFFFFFu) << 7);
                }
            }
        }
    }
}
