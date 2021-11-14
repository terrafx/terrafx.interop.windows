// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.FILE;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [return: NativeTypeName("DWORD")]
        public static uint DeviceDsmNumberOfDataSetRanges([NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input)
        {
            return Input->DataSetRangesLength / unchecked((uint)(sizeof(DEVICE_DATA_SET_RANGE)));
        }

        [return: NativeTypeName("DWORD")]
        public static uint DeviceDsmGetInputLength([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("DWORD")] uint ParameterBlockLength, [NativeTypeName("DWORD")] uint NumberOfDataSetRanges)
        {
            uint Bytes = 28;

            if (ParameterBlockLength != 0)
            {
                unchecked(Bytes) = unchecked(((Bytes) + ((Definition->ParameterBlockAlignment) - 1)) / (Definition->ParameterBlockAlignment) * (Definition->ParameterBlockAlignment));
                unchecked(Bytes) += ParameterBlockLength;
            }

            if (NumberOfDataSetRanges != 0)
            {
                unchecked(Bytes) = unchecked(((Bytes) + ((8) - 1)) / (8) * (8));
                unchecked(Bytes) += unchecked((uint)(sizeof(DEVICE_DATA_SET_RANGE)) * NumberOfDataSetRanges);
            }

            return Bytes;
        }

        [return: NativeTypeName("DWORD")]
        public static uint DeviceDsmGetNumberOfDataSetRanges([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("DWORD")] uint InputLength, [NativeTypeName("DWORD")] uint ParameterBlockLength)
        {
            uint Bytes = 28;

            if (ParameterBlockLength != 0)
            {
                unchecked(Bytes) = unchecked(((Bytes) + ((Definition->ParameterBlockAlignment) - 1)) / (Definition->ParameterBlockAlignment) * (Definition->ParameterBlockAlignment));
                unchecked(Bytes) += ParameterBlockLength;
            }

            unchecked(Bytes) = unchecked(((Bytes) + ((8) - 1)) / (8) * (8));
            unchecked(Bytes) = unchecked(InputLength - Bytes);
            return unchecked(Bytes) / unchecked((uint)(sizeof(DEVICE_DATA_SET_RANGE)));
        }

        [return: NativeTypeName("BOOLEAN")]
        public static byte DeviceDsmAddDataSetRange([NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input, [NativeTypeName("DWORD")] uint InputLength, [NativeTypeName("LONGLONG")] long Offset, [NativeTypeName("DWORDLONG")] ulong Length)
        {
            uint Bytes = 0;
            uint Index = 0;
            DEVICE_DATA_SET_RANGE* Ranges = null;
            byte Return = 0;

            if ((Input->Flags & 0x00000001) != 0)
            {
                goto Cleanup;
            }

            if (Input->DataSetRangesLength == 0)
            {
                if (Input->ParameterBlockLength == 0)
                {
                    Bytes = unchecked((uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES)));
                }
                else
                {
                    Bytes = Input->ParameterBlockOffset + Input->ParameterBlockLength;
                }

                Bytes = (((Bytes) + ((8) - 1)) / (8) * (8));
            }
            else
            {
                Bytes = Input->DataSetRangesOffset + Input->DataSetRangesLength;
            }

            if ((InputLength - Bytes) < sizeof(DEVICE_DATA_SET_RANGE))
            {
                goto Cleanup;
            }

            if (Input->DataSetRangesOffset == 0)
            {
                Input->DataSetRangesOffset = Bytes;
            }

            Ranges = DeviceDsmDataSetRanges(Input);
            Index = DeviceDsmNumberOfDataSetRanges(Input);
            Ranges[Index].StartingOffset = Offset;
            Ranges[Index].LengthInBytes = Length;
            Input->DataSetRangesLength += unchecked((uint)(sizeof(DEVICE_DATA_SET_RANGE)));
            Return = 1;
        Cleanup:
            return Return;
        }

        [NativeTypeName("#define FSCTL_ENABLE_PER_IO_FLAGS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 267, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public static int FSCTL_ENABLE_PER_IO_FLAGS
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return 0;
                }
                else
                {
                    return (((0x00000009) << 16) | ((0) << 14) | ((267) << 2) | (0));
                }
            }
        }

        [NativeTypeName("#define FILE_REGION_USAGE_HUGE_PAGE_ALIGNMENT 0x00000010")]
        public static int FILE_REGION_USAGE_HUGE_PAGE_ALIGNMENT
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return 0;
                }
                else
                {
                    return 0x00000010;
                }
            }
        }

        [NativeTypeName("#define FILE_REGION_USAGE_QUERY_ALIGNMENT (FILE_REGION_USAGE_LARGE_PAGE_ALIGNMENT   |\\\r\n                                                 FILE_REGION_USAGE_HUGE_PAGE_ALIGNMENT)")]
        public static int FILE_REGION_USAGE_QUERY_ALIGNMENT = FILE_REGION_USAGE_LARGE_PAGE_ALIGNMENT | FILE_REGION_USAGE_HUGE_PAGE_ALIGNMENT;

        public static ref readonly Guid GUID_DEVINTERFACE_DISK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0x63, 0xF5, 0x53,
                    0xBF, 0xB6,
                    0xD0, 0x11,
                    0x94,
                    0xF2,
                    0x00,
                    0xA0,
                    0xC9,
                    0x1E,
                    0xFB,
                    0x8B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_CDROM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x08, 0x63, 0xF5, 0x53,
                    0xBF, 0xB6,
                    0xD0, 0x11,
                    0x94,
                    0xF2,
                    0x00,
                    0xA0,
                    0xC9,
                    0x1E,
                    0xFB,
                    0x8B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_PARTITION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0x63, 0xF5, 0x53,
                    0xBF, 0xB6,
                    0xD0, 0x11,
                    0x94,
                    0xF2,
                    0x00,
                    0xA0,
                    0xC9,
                    0x1E,
                    0xFB,
                    0x8B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_TAPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0B, 0x63, 0xF5, 0x53,
                    0xBF, 0xB6,
                    0xD0, 0x11,
                    0x94,
                    0xF2,
                    0x00,
                    0xA0,
                    0xC9,
                    0x1E,
                    0xFB,
                    0x8B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_WRITEONCEDISK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0C, 0x63, 0xF5, 0x53,
                    0xBF, 0xB6,
                    0xD0, 0x11,
                    0x94,
                    0xF2,
                    0x00,
                    0xA0,
                    0xC9,
                    0x1E,
                    0xFB,
                    0x8B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_VOLUME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0D, 0x63, 0xF5, 0x53,
                    0xBF, 0xB6,
                    0xD0, 0x11,
                    0x94,
                    0xF2,
                    0x00,
                    0xA0,
                    0xC9,
                    0x1E,
                    0xFB,
                    0x8B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_MEDIUMCHANGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x63, 0xF5, 0x53,
                    0xBF, 0xB6,
                    0xD0, 0x11,
                    0x94,
                    0xF2,
                    0x00,
                    0xA0,
                    0xC9,
                    0x1E,
                    0xFB,
                    0x8B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_FLOPPY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0x63, 0xF5, 0x53,
                    0xBF, 0xB6,
                    0xD0, 0x11,
                    0x94,
                    0xF2,
                    0x00,
                    0xA0,
                    0xC9,
                    0x1E,
                    0xFB,
                    0x8B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_CDCHANGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x12, 0x63, 0xF5, 0x53,
                    0xBF, 0xB6,
                    0xD0, 0x11,
                    0x94,
                    0xF2,
                    0x00,
                    0xA0,
                    0xC9,
                    0x1E,
                    0xFB,
                    0x8B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_STORAGEPORT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xFE, 0xCC, 0x2A,
                    0x30, 0xC1,
                    0xD2, 0x11,
                    0xB0,
                    0x82,
                    0x00,
                    0xA0,
                    0xC9,
                    0x1E,
                    0xFB,
                    0x8B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_VMLUN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0x66, 0x41, 0x6F,
                    0x29, 0x9F,
                    0xA5, 0x42,
                    0xB2,
                    0x0B,
                    0x37,
                    0xE2,
                    0x19,
                    0xCA,
                    0x02,
                    0xB0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_SES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEC, 0xC9, 0x90, 0x17,
                    0xD5, 0x47,
                    0xF3, 0x4D,
                    0xB5,
                    0xAF,
                    0x9A,
                    0xDF,
                    0x3C,
                    0xF2,
                    0x3E,
                    0x48
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_SERVICE_VOLUME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0x3D, 0xAD, 0x6E,
                    0xEC, 0x25,
                    0xBC, 0x46,
                    0xB7,
                    0xFD,
                    0xC1,
                    0xF0,
                    0xDF,
                    0x8F,
                    0x50,
                    0x37
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_HIDDEN_VOLUME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0x8A, 0x10, 0x7F,
                    0x33, 0x98,
                    0x3B, 0x4B,
                    0xB7,
                    0x80,
                    0x2C,
                    0x6B,
                    0x5F,
                    0xA5,
                    0xC0,
                    0x62
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_UNIFIED_ACCESS_RPMB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0x7C, 0x44, 0x27,
                    0xC3, 0xBC,
                    0x07, 0x4D,
                    0xA0,
                    0x5B,
                    0xA3,
                    0x39,
                    0x5B,
                    0xB4,
                    0xEE,
                    0xE7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_SCM_PHYSICAL_DEVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9D, 0x60, 0x83, 0x42,
                    0xC2, 0x4D,
                    0xBE, 0x43,
                    0xBB,
                    0xB4,
                    0x4F,
                    0x15,
                    0xDF,
                    0xCE,
                    0x2C,
                    0x61
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_SCM_PD_HEALTH_NOTIFICATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0xD3, 0xA2, 0x9D,
                    0xF5, 0x72,
                    0xE3, 0x4E,
                    0x81,
                    0x55,
                    0xEC,
                    0xA0,
                    0x67,
                    0x8E,
                    0x3B,
                    0x06
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_SCM_PD_PASSTHROUGH_INVDIMM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0xAC, 0x09, 0x43,
                    0x11, 0x0D,
                    0xE4, 0x11,
                    0x91,
                    0x91,
                    0x08,
                    0x00,
                    0x20,
                    0x0C,
                    0x9A,
                    0x66
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_COMPORT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xD1, 0xE0, 0x86,
                    0x89, 0x80,
                    0xD0, 0x11,
                    0x9C,
                    0xE4,
                    0x08,
                    0x00,
                    0x3E,
                    0x30,
                    0x1F,
                    0x73
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x78, 0xE9, 0x36, 0x4D,
                    0x25, 0xE3,
                    0xCE, 0x11,
                    0xBF,
                    0xC1,
                    0x08,
                    0x00,
                    0x2B,
                    0xE1,
                    0x03,
                    0x18
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid FILE_TYPE_NOTIFICATION_GUID_PAGE_FILE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x64, 0x0A, 0x0D,
                    0xFC, 0x38,
                    0xB8, 0x4D,
                    0x9F,
                    0xE7,
                    0x3F,
                    0x43,
                    0x52,
                    0xCD,
                    0x7C,
                    0x5C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid FILE_TYPE_NOTIFICATION_GUID_HIBERNATION_FILE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x4D, 0x62, 0xB7,
                    0xA3, 0xB9,
                    0xF8, 0x4C,
                    0x80,
                    0x11,
                    0x5B,
                    0x86,
                    0xC9,
                    0x40,
                    0xE7,
                    0xB7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid FILE_TYPE_NOTIFICATION_GUID_CRASHDUMP_FILE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB7, 0x3E, 0x45, 0x9D,
                    0xA6, 0xD2,
                    0xBD, 0x4D,
                    0xA2,
                    0xE3,
                    0xFB,
                    0xD0,
                    0xED,
                    0x91,
                    0x09,
                    0xA9
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CTL_CODE(int DeviceType, int Function, int Method, int Access) => (DeviceType << 16) | (Access << 14) | (Function << 2) | Method;
    }
}
