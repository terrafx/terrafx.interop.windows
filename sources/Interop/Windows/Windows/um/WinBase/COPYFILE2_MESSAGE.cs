// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    public partial struct COPYFILE2_MESSAGE
    {
        public COPYFILE2_MESSAGE_TYPE Type;

        [NativeTypeName("DWORD")]
        public uint dwPadding;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:5716:5)")]
        public _Info_e__Union Info;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Info_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:5718:9)")]
            public _ChunkStarted_e__Struct ChunkStarted;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:5729:9)")]
            public _ChunkFinished_e__Struct ChunkFinished;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:5742:9)")]
            public _StreamStarted_e__Struct StreamStarted;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:5751:9)")]
            public _StreamFinished_e__Struct StreamFinished;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:5762:9)")]
            public _PollContinue_e__Struct PollContinue;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:5766:9)")]
            public _Error_e__Struct Error;

            public partial struct _ChunkStarted_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint dwStreamNumber;

                [NativeTypeName("DWORD")]
                public uint dwReserved;

                public HANDLE hSourceFile;

                public HANDLE hDestinationFile;

                public ULARGE_INTEGER uliChunkNumber;

                public ULARGE_INTEGER uliChunkSize;

                public ULARGE_INTEGER uliStreamSize;

                public ULARGE_INTEGER uliTotalFileSize;
            }

            public partial struct _ChunkFinished_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint dwStreamNumber;

                [NativeTypeName("DWORD")]
                public uint dwFlags;

                public HANDLE hSourceFile;

                public HANDLE hDestinationFile;

                public ULARGE_INTEGER uliChunkNumber;

                public ULARGE_INTEGER uliChunkSize;

                public ULARGE_INTEGER uliStreamSize;

                public ULARGE_INTEGER uliStreamBytesTransferred;

                public ULARGE_INTEGER uliTotalFileSize;

                public ULARGE_INTEGER uliTotalBytesTransferred;
            }

            public partial struct _StreamStarted_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint dwStreamNumber;

                [NativeTypeName("DWORD")]
                public uint dwReserved;

                public HANDLE hSourceFile;

                public HANDLE hDestinationFile;

                public ULARGE_INTEGER uliStreamSize;

                public ULARGE_INTEGER uliTotalFileSize;
            }

            public partial struct _StreamFinished_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint dwStreamNumber;

                [NativeTypeName("DWORD")]
                public uint dwReserved;

                public HANDLE hSourceFile;

                public HANDLE hDestinationFile;

                public ULARGE_INTEGER uliStreamSize;

                public ULARGE_INTEGER uliStreamBytesTransferred;

                public ULARGE_INTEGER uliTotalFileSize;

                public ULARGE_INTEGER uliTotalBytesTransferred;
            }

            public partial struct _PollContinue_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint dwReserved;
            }

            public partial struct _Error_e__Struct
            {
                public COPYFILE2_COPY_PHASE CopyPhase;

                [NativeTypeName("DWORD")]
                public uint dwStreamNumber;

                public HRESULT hrFailure;

                [NativeTypeName("DWORD")]
                public uint dwReserved;

                public ULARGE_INTEGER uliChunkNumber;

                public ULARGE_INTEGER uliStreamSize;

                public ULARGE_INTEGER uliStreamBytesTransferred;

                public ULARGE_INTEGER uliTotalFileSize;

                public ULARGE_INTEGER uliTotalBytesTransferred;
            }
        }
    }
}
