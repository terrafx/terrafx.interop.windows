// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct RAWMOUSE
    {
        public ushort usFlags;

        [NativeTypeName("tagRAWMOUSE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinUser.h:14915:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ULONG")]
        public uint ulRawButtons;

        [NativeTypeName("LONG")]
        public int lLastX;

        [NativeTypeName("LONG")]
        public int lLastY;

        [NativeTypeName("ULONG")]
        public uint ulExtraInformation;

        public ref uint ulButtons
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ulButtons, 1));
            }
        }

        public ref ushort usButtonFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.usButtonFlags, 1));
            }
        }

        public ref ushort usButtonData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.usButtonData, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint ulButtons;

            [FieldOffset(0)]
            [NativeTypeName("tagRAWMOUSE::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinUser.h:14917:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ushort usButtonFlags;

                public ushort usButtonData;
            }
        }
    }
}
