// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32"]/*' />
public partial struct IMAGE_OPTIONAL_HEADER32
{
    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.Magic"]/*' />
    [NativeTypeName("WORD")]
    public ushort Magic;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.MajorLinkerVersion"]/*' />
    public byte MajorLinkerVersion;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.MinorLinkerVersion"]/*' />
    public byte MinorLinkerVersion;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.SizeOfCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfCode;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.SizeOfInitializedData"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfInitializedData;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.SizeOfUninitializedData"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfUninitializedData;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.AddressOfEntryPoint"]/*' />
    [NativeTypeName("DWORD")]
    public uint AddressOfEntryPoint;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.BaseOfCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint BaseOfCode;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.BaseOfData"]/*' />
    [NativeTypeName("DWORD")]
    public uint BaseOfData;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.ImageBase"]/*' />
    [NativeTypeName("DWORD")]
    public uint ImageBase;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.SectionAlignment"]/*' />
    [NativeTypeName("DWORD")]
    public uint SectionAlignment;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.FileAlignment"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileAlignment;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.MajorOperatingSystemVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MajorOperatingSystemVersion;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.MinorOperatingSystemVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MinorOperatingSystemVersion;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.MajorImageVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MajorImageVersion;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.MinorImageVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MinorImageVersion;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.MajorSubsystemVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MajorSubsystemVersion;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.MinorSubsystemVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MinorSubsystemVersion;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.Win32VersionValue"]/*' />
    [NativeTypeName("DWORD")]
    public uint Win32VersionValue;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.SizeOfImage"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfImage;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.SizeOfHeaders"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfHeaders;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.CheckSum"]/*' />
    [NativeTypeName("DWORD")]
    public uint CheckSum;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.Subsystem"]/*' />
    [NativeTypeName("WORD")]
    public ushort Subsystem;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.DllCharacteristics"]/*' />
    [NativeTypeName("WORD")]
    public ushort DllCharacteristics;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.SizeOfStackReserve"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStackReserve;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.SizeOfStackCommit"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStackCommit;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.SizeOfHeapReserve"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfHeapReserve;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.SizeOfHeapCommit"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfHeapCommit;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.LoaderFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint LoaderFlags;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.NumberOfRvaAndSizes"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfRvaAndSizes;

    /// <include file='IMAGE_OPTIONAL_HEADER32.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER32.DataDirectory"]/*' />
    [NativeTypeName("IMAGE_DATA_DIRECTORY[16]")]
    public _DataDirectory_e__FixedBuffer DataDirectory;

    /// <include file='_DataDirectory_e__FixedBuffer.xml' path='doc/member[@name="_DataDirectory_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _DataDirectory_e__FixedBuffer
    {
        public IMAGE_DATA_DIRECTORY e0;
    }
}
