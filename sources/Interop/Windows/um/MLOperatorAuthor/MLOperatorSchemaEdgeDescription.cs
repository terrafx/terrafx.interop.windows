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

        public unsafe ref void* reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->reserved;
            }
        }

        public unsafe ref sbyte* typeLabel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->typeLabel;
            }
        }

        public unsafe ref MLOperatorEdgeDescription edgeDescription
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.edgeDescription, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->edgeDescription;
#endif
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
