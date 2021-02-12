// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct MLOperatorAttributeNameValue
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        public MLOperatorAttributeType type;

        [NativeTypeName("uint32_t")]
        public uint valueCount;

        [NativeTypeName("MLOperatorAttributeNameValue::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/MLOperatorAuthor.h:602:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref void* reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->reserved;
                }
            }
        }

        public ref long* ints
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->ints;
                }
            }
        }

        public ref sbyte** strings
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->strings;
                }
            }
        }

        public ref float* floats
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->floats;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("const void *")]
            public void* reserved;

            [FieldOffset(0)]
            [NativeTypeName("const int64_t *")]
            public long* ints;

            [FieldOffset(0)]
            [NativeTypeName("const char *const *")]
            public sbyte** strings;

            [FieldOffset(0)]
            [NativeTypeName("const float *")]
            public float* floats;
        }
    }
}
