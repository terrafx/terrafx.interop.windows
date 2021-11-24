// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct IMAGEHLP_MODULEW
{
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    [NativeTypeName("DWORD")]
    public uint BaseOfImage;

    [NativeTypeName("DWORD")]
    public uint ImageSize;

    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    [NativeTypeName("DWORD")]
    public uint CheckSum;

    [NativeTypeName("DWORD")]
    public uint NumSyms;

    public SYM_TYPE SymType;

    [NativeTypeName("WCHAR [32]")]
    public fixed ushort ModuleName[32];

    [NativeTypeName("WCHAR [256]")]
    public fixed ushort ImageName[256];

    [NativeTypeName("WCHAR [256]")]
    public fixed ushort LoadedImageName[256];
}
