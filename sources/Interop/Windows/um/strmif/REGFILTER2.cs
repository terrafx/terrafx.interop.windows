// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct REGFILTER2
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("DWORD")]
        public uint dwMerit;

        [NativeTypeName("REGFILTER2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/strmif.h:5070:36)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint cPins
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous1.cPins, 1));
            }
        }

        public ref REGFILTERPINS* rgPins
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous1_e__Struct* pField = &Anonymous.Anonymous1)
                {
                    return ref pField->rgPins;
                }
            }
        }

        public ref uint cPins2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous2.cPins2, 1));
            }
        }

        public ref REGFILTERPINS2* rgPins2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous2_e__Struct* pField = &Anonymous.Anonymous2)
                {
                    return ref pField->rgPins2;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("REGFILTER2::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/strmif.h:5072:24)")]
            public _Anonymous1_e__Struct Anonymous1;

            [FieldOffset(0)]
            [NativeTypeName("REGFILTER2::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/strmif.h:5077:24)")]
            public _Anonymous2_e__Struct Anonymous2;

            public unsafe partial struct _Anonymous1_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint cPins;

                [NativeTypeName("const REGFILTERPINS *")]
                public REGFILTERPINS* rgPins;
            }

            public unsafe partial struct _Anonymous2_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint cPins2;

                [NativeTypeName("const REGFILTERPINS2 *")]
                public REGFILTERPINS2* rgPins2;
            }
        }
    }
}
