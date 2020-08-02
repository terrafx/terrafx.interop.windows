// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct RPCOLEMESSAGE
    {
        [NativeTypeName("void *")]
        public void* reserved1;

        [NativeTypeName("RPCOLEDATAREP")]
        public uint dataRepresentation;

        [NativeTypeName("void *")]
        public void* Buffer;

        [NativeTypeName("ULONG")]
        public uint cbBuffer;

        [NativeTypeName("ULONG")]
        public uint iMethod;

        [NativeTypeName("void *[5]")]
        public _reserved2_e__FixedBuffer reserved2;

        [NativeTypeName("ULONG")]
        public uint rpcFlags;

        public unsafe partial struct _reserved2_e__FixedBuffer
        {
            public void* e0;
            public void* e1;
            public void* e2;
            public void* e3;
            public void* e4;

            public ref void* this[int index]
            {
                get
                {
                    fixed (void** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
