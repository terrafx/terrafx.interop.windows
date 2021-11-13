// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define IMAPI2FS_BOOT_ENTRY_COUNT_MAX 32")]
        public const int IMAPI2FS_BOOT_ENTRY_COUNT_MAX = 32;

        [NativeTypeName("#define IMAPI2FS_MajorVersion 1")]
        public const int IMAPI2FS_MajorVersion = 1;

        [NativeTypeName("#define IMAPI2FS_MinorVersion 0")]
        public const int IMAPI2FS_MinorVersion = 0;

        [NativeTypeName("#define IMAPI2FS_FullVersion_STR \"1.0\"")]
        public static ReadOnlySpan<byte> IMAPI2FS_FullVersion_STR => new byte[] { 0x31, 0x2E, 0x30, 0x00 };

        [NativeTypeName("#define IMAPI2FS_FullVersion_WSTR L\"1.0\"")]
        public const string IMAPI2FS_FullVersion_WSTR = "1.0";

        public static ref readonly Guid IID_IBootOptions
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD4, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IProgressItem
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD5, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumProgressItems
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD6, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IProgressItems
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD7, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFileSystemImageResult
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFileSystemImageResult2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x29, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFsiItem
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD9, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumFsiItems
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDA, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFsiFileItem
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDB, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFsiFileItem2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0x0C, 0x9D, 0x19,
                    0xE1, 0x11,
                    0xEB, 0x40,
                    0x8E,
                    0xC2,
                    0xC8,
                    0xC8,
                    0x22,
                    0xA0,
                    0x77,
                    0x92
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFsiNamedStreams
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x56, 0xBA, 0x79, 0xED,
                    0x94, 0x52,
                    0x50, 0x42,
                    0x8D,
                    0x46,
                    0xF9,
                    0xAE,
                    0xCE,
                    0xE2,
                    0x34,
                    0x59
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFsiDirectoryItem
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDC, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFsiDirectoryItem2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9B, 0x4B, 0xFB, 0xF7,
                    0x96, 0x6D,
                    0x7B, 0x4D,
                    0x91,
                    0x15,
                    0x20,
                    0x1B,
                    0x14,
                    0x48,
                    0x11,
                    0xEF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFileSystemImage
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFileSystemImage2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0x4B, 0x64, 0xD7,
                    0x37, 0x15,
                    0x67, 0x47,
                    0xB6,
                    0x2F,
                    0xF1,
                    0x38,
                    0x7B,
                    0x02,
                    0xDD,
                    0xFD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFileSystemImage3
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0x84, 0xFF, 0x7C,
                    0x97, 0x7E,
                    0x07, 0x48,
                    0x83,
                    0x04,
                    0x91,
                    0x0D,
                    0xD8,
                    0xF7,
                    0xC0,
                    0x51
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DFileSystemImageEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DFileSystemImageImportEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0x30, 0x5C, 0xD2,
                    0x87, 0x40,
                    0x66, 0x43,
                    0x9E,
                    0x24,
                    0xE5,
                    0x5B,
                    0xE2,
                    0x86,
                    0x42,
                    0x4B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IIsoImageManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE5, 0x8B, 0xA3, 0x6C,
                    0xBB, 0xFB,
                    0x00, 0x48,
                    0x95,
                    0xA1,
                    0xA4,
                    0x38,
                    0x86,
                    0x5E,
                    0xB0,
                    0xD4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_BootOptions
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCE, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_FsiStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCD, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_FileSystemImageResult
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCC, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_ProgressItem
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_EnumProgressItems
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_ProgressItems
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC9, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_FsiDirectoryItem
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC8, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_FsiFileItem
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC7, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_EnumFsiItems
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC6, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_FsiNamedStreams
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xED, 0xF8, 0xB6, 0xC6,
                    0x19, 0x6D,
                    0xB4, 0x44,
                    0xB5,
                    0x39,
                    0xB1,
                    0x59,
                    0xB7,
                    0x93,
                    0xA3,
                    0x2D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftFileSystemImage
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC5, 0x1F, 0x94, 0x2C,
                    0x5B, 0x97,
                    0xBE, 0x59,
                    0xA9,
                    0x60,
                    0x9A,
                    0x2A,
                    0x26,
                    0x28,
                    0x53,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftIsoImageManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0x3B, 0xEE, 0xCE,
                    0x56, 0x8F,
                    0x56, 0x40,
                    0x86,
                    0x9B,
                    0xEF,
                    0x16,
                    0x91,
                    0x7E,
                    0x3E,
                    0xFC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_BlockRange
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_BlockRangeList
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
