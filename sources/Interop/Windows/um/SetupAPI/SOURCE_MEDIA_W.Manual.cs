// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SOURCE_MEDIA_W
    {
        public static uint Size
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(SOURCE_MEDIA32_W));
                }
                else
                {
                    return (uint)(sizeof(SOURCE_MEDIA64_W));
                }
            }
        }

        [FieldOffset(0)]
        public SOURCE_MEDIA32_W _value32;

        [FieldOffset(0)]
        public SOURCE_MEDIA64_W _value64;

        [NativeTypeName("PCWSTR")]
        public ref ushort* Reserved
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).Reserved;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).Reserved;
                }
            }
        }

        [NativeTypeName("PCWSTR")]
        public ref ushort* Tagfile
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).Tagfile;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).Tagfile;
                }
            }
        }

        [NativeTypeName("PCWSTR")]
        public ref ushort* Description
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).Description;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).Description;
                }
            }
        }

        [NativeTypeName("PCWSTR")]
        public ref ushort* SourcePath
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).SourcePath;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).SourcePath;
                }
            }
        }

        [NativeTypeName("PCWSTR")]
        public ref ushort* SourceFile
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).SourceFile;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).SourceFile;
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint Flags
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Flags, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Flags, 1));
                }
            }
        }
    }
}
