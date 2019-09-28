// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct NCCALCSIZE_PARAMS
    {
        [NativeTypeName("RECT [3]")]
        public _rgrc_e__FixedBuffer rgrc;

        [NativeTypeName("PWINDOWPOS")]
        public WINDOWPOS* lppos;

        public partial struct _rgrc_e__FixedBuffer
        {
            internal RECT e0;
            internal RECT e1;
            internal RECT e2;

            public unsafe ref RECT this[int index]
            {
                get
                {
                    fixed (RECT* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
