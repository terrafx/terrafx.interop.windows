// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class IMAGE
{
    public static int IMAGE_NT_OPTIONAL_HDR_MAGIC
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return IMAGE_NT_OPTIONAL_HDR32_MAGIC;
            }
            else
            {
                return IMAGE_NT_OPTIONAL_HDR64_MAGIC;
            }
        }
    }

    public static nuint IMAGE_ORDINAL_FLAG
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return IMAGE_ORDINAL_FLAG32;
            }
            else
            {
                return unchecked((nuint)(IMAGE_ORDINAL_FLAG64));
            }
        }
    }

    [return: NativeTypeName("#define IMAGE_ORDINAL32(Ordinal) (Ordinal & 0xffff)")]
    public static uint IMAGE_ORDINAL32(uint Ordinal) => Ordinal & 0xFFFF;

    [return: NativeTypeName("#define IMAGE_ORDINAL64(Ordinal) (Ordinal & 0xffff)")]
    public static ulong IMAGE_ORDINAL64(ulong Ordinal) => Ordinal & 0xFFFF;

    public static nuint IMAGE_ORDINAL(nuint Ordinal) => Ordinal & 0xFFFF;

    [return: NativeTypeName("#define IMAGE_SNAP_BY_ORDINAL32(Ordinal) ((Ordinal & IMAGE_ORDINAL_FLAG32) != 0)")]
    public static bool IMAGE_SNAP_BY_ORDINAL32(uint Ordinal) => (Ordinal & IMAGE_ORDINAL_FLAG32) != 0;

    [return: NativeTypeName("#define IMAGE_SNAP_BY_ORDINAL64(Ordinal) ((Ordinal & IMAGE_ORDINAL_FLAG64) != 0)")]
    public static bool IMAGE_SNAP_BY_ORDINAL64(ulong Ordinal) => (Ordinal & IMAGE_ORDINAL_FLAG64) != 0;

    public static bool IMAGE_SNAP_BY_ORDINAL(nuint Ordinal) => (Ordinal & IMAGE_ORDINAL_FLAG) != 0;

    [return: NativeTypeName("PIMAGE_SECTION_HEADER")]
    public static IMAGE_SECTION_HEADER* IMAGE_FIRST_SECTION(IMAGE_NT_HEADERS32* ntheader)
        => (IMAGE_SECTION_HEADER*)((byte*)ntheader + Marshal.OffsetOf<IMAGE_NT_HEADERS32>(nameof(IMAGE_NT_HEADERS32.OptionalHeader)).ToInt32() + ntheader->FileHeader.SizeOfOptionalHeader);

    [return: NativeTypeName("PIMAGE_SECTION_HEADER")]
    public static IMAGE_SECTION_HEADER* IMAGE_FIRST_SECTION(IMAGE_NT_HEADERS64* ntheader)
        => (IMAGE_SECTION_HEADER*)((byte*)ntheader + Marshal.OffsetOf<IMAGE_NT_HEADERS64>(nameof(IMAGE_NT_HEADERS64.OptionalHeader)).ToInt32() + ntheader->FileHeader.SizeOfOptionalHeader);
}
