// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct CY
    {
        [FieldOffset(0)]
        [NativeTypeName("tagCY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared/wtypes.h:671:5)")]
        public _Anonymous_e__Struct Anonymous;

        public ref uint Lo => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Lo, 1));

        public ref int Hi => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Hi, 1));

        [FieldOffset(0)]
        [NativeTypeName("LONGLONG")]
        public long int64;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("ULONG")]
            public uint Lo;

            [NativeTypeName("LONG")]
            public int Hi;
        }
    }
}
