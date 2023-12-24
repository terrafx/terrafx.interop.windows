// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [return: NativeTypeName("PIMAGE_NT_HEADERS")]
    public static IMAGE_NT_HEADERS32* ImageNtHeader32([NativeTypeName("PVOID")] void* Base)
    {
        return (IMAGE_NT_HEADERS32*)ImageNtHeader(Base);
    }

    [return: NativeTypeName("PIMAGE_NT_HEADERS")]
    public static IMAGE_NT_HEADERS64* ImageNtHeader64([NativeTypeName("PVOID")] void* Base)
    {
        return (IMAGE_NT_HEADERS64*)ImageNtHeader(Base);
    }

    [return: NativeTypeName("PIMAGE_SECTION_HEADER")]
    public static IMAGE_SECTION_HEADER* ImageRvaToSection32([NativeTypeName("PIMAGE_NT_HEADERS")] IMAGE_NT_HEADERS32* NtHeaders, [NativeTypeName("PVOID")] void* Base, [NativeTypeName("ULONG")] uint Rva)
    {
        return ImageRvaToSection(NtHeaders, Base, Rva);
    }

    [return: NativeTypeName("PIMAGE_SECTION_HEADER")]
    public static IMAGE_SECTION_HEADER* ImageRvaToSection64([NativeTypeName("PIMAGE_NT_HEADERS")] IMAGE_NT_HEADERS64* NtHeaders, [NativeTypeName("PVOID")] void* Base, [NativeTypeName("ULONG")] uint Rva)
    {
        return ImageRvaToSection(NtHeaders, Base, Rva);
    }

    [return: NativeTypeName("PVOID")]
    public static void* ImageRvaToVa32([NativeTypeName("PIMAGE_NT_HEADERS")] IMAGE_NT_HEADERS32* NtHeaders, [NativeTypeName("PVOID")] void* Base, [NativeTypeName("ULONG")] uint Rva, [NativeTypeName("PIMAGE_SECTION_HEADER *")] IMAGE_SECTION_HEADER** LastRvaSection)
    {
        return ImageRvaToVa(NtHeaders, Base, Rva, LastRvaSection);
    }

    [return: NativeTypeName("PVOID")]
    public static void* ImageRvaToVa64([NativeTypeName("PIMAGE_NT_HEADERS")] IMAGE_NT_HEADERS64* NtHeaders, [NativeTypeName("PVOID")] void* Base, [NativeTypeName("ULONG")] uint Rva, [NativeTypeName("PIMAGE_SECTION_HEADER *")] IMAGE_SECTION_HEADER** LastRvaSection)
    {
        return ImageRvaToVa(NtHeaders, Base, Rva, LastRvaSection);
    }

    [NativeTypeName("#define NONGAMESPARTITIONS WINAPI_PARTITION_DESKTOP | WINAPI_PARTITION_PKG_WER")]
    public const int NONGAMESPARTITIONS = 1;

    /// <summary>RESERVED.</summary>
    public const int UNDNAME_RESERVED1 = 0x0020;

    /// <summary>RESERVED.</summary>
    public const int UNDNAME_RESERVED2 = 0x0040;

    /// <summary>Input is just a type encoding; composes an abstract declarator.</summary>
    public const int UNDNAME_TYPE_ONLY = 0x2000;

    /// <summary>The real template parameters are available.</summary>
    public const int UNDNAME_HAVE_PARAMETERS = 0x4000;

    /// <summary>Suppresses enum/class/struct/union.</summary>
    public const int UNDNAME_NO_ECSU = 0x8000;

    /// <summary>Suppresses check for valid identifier characters.</summary>
    public const int UNDNAME_NO_IDENT_CHAR_CHECK = 0x10000;

    /// <summary>Does not include ptr64 in output.</summary>
    public const int UNDNAME_NO_PTR64 = 0x20000;
}
