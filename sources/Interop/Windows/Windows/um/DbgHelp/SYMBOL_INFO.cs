// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SYMBOL_INFO
{
    [NativeTypeName("ULONG")]
    public uint SizeOfStruct;

    [NativeTypeName("ULONG")]
    public uint TypeIndex;

    [NativeTypeName("ULONG64 [2]")]
    public fixed ulong Reserved[2];

    [NativeTypeName("ULONG")]
    public uint Index;

    [NativeTypeName("ULONG")]
    public uint Size;

    [NativeTypeName("ULONG64")]
    public ulong ModBase;

    [NativeTypeName("ULONG")]
    public uint Flags;

    [NativeTypeName("ULONG64")]
    public ulong Value;

    [NativeTypeName("ULONG64")]
    public ulong Address;

    [NativeTypeName("ULONG")]
    public uint Register;

    [NativeTypeName("ULONG")]
    public uint Scope;

    [NativeTypeName("ULONG")]
    public uint Tag;

    [NativeTypeName("ULONG")]
    public uint NameLen;

    [NativeTypeName("ULONG")]
    public uint MaxNameLen;

    [NativeTypeName("CHAR [1]")]
    public fixed sbyte Name[1];
}
