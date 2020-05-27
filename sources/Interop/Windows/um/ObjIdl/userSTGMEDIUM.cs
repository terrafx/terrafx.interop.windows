// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct userSTGMEDIUM
    {
        [NativeTypeName("IUnknown *")]
        public IUnknown* pUnkForRelease;

        public partial struct _STGMEDIUM_UNION
        {
            [NativeTypeName("DWORD")]
            public uint tymed;

            [NativeTypeName("union __MIDL_IAdviseSink_0003")]
            public _u_e__Struct u;

            [StructLayout(LayoutKind.Explicit)]
            public unsafe partial struct _u_e__Struct
            {
                [FieldOffset(0)]
                [NativeTypeName("wireHMETAFILEPICT")]
                public userHMETAFILEPICT* hMetaFilePict;

                [FieldOffset(0)]
                [NativeTypeName("wireHENHMETAFILE")]
                public userHENHMETAFILE* hHEnhMetaFile;

                [FieldOffset(0)]
                [NativeTypeName("GDI_OBJECT *")]
                public GDI_OBJECT* hGdiHandle;

                [FieldOffset(0)]
                [NativeTypeName("wireHGLOBAL")]
                public userHGLOBAL* hGlobal;

                [FieldOffset(0)]
                [NativeTypeName("LPOLESTR")]
                public ushort* lpszFileName;

                [FieldOffset(0)]
                [NativeTypeName("BYTE_BLOB *")]
                public BYTE_BLOB* pstm;

                [FieldOffset(0)]
                [NativeTypeName("BYTE_BLOB *")]
                public BYTE_BLOB* pstg;
            }
        }
    }
}
