// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct MLOperatorSchemaEdgeDescription
    {
        public MLOperatorParameterOptions options;

        public MLOperatorSchemaEdgeTypeFormat typeFormat;

        [NativeTypeName("MLOperatorSchemaEdgeDescription::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/MLOperatorAuthor.h:426:5)")]
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

        public ref sbyte* typeLabel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->typeLabel;
                }
            }
        }

        public ref MLOperatorEdgeDescription edgeDescription
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.edgeDescription, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("const void *")]
            public void* reserved;

            [FieldOffset(0)]
            [NativeTypeName("const char *")]
            public sbyte* typeLabel;

            [FieldOffset(0)]
            public MLOperatorEdgeDescription edgeDescription;
        }
    }
}
