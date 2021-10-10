// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct POINTER_TYPE_INFO
    {
        [NativeTypeName("POINTER_INPUT_TYPE")]
        public uint type;

        [NativeTypeName("tagPOINTER_TYPE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinUser.h:6475:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref POINTER_TOUCH_INFO touchInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.touchInfo, 1));
            }
        }

        public ref POINTER_PEN_INFO penInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.penInfo, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public POINTER_TOUCH_INFO touchInfo;

            [FieldOffset(0)]
            public POINTER_PEN_INFO penInfo;
        }
    }
}
