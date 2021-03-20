// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [32]")]
        public const string InterfaceName_Windows_Storage_Streams_IBuffer = "Windows.Storage.Streams.IBuffer";

        [NativeTypeName("const WCHAR [39]")]
        public const string InterfaceName_Windows_Storage_Streams_IBufferFactory = "Windows.Storage.Streams.IBufferFactory";

        [NativeTypeName("const WCHAR [39]")]
        public const string InterfaceName_Windows_Storage_Streams_IBufferStatics = "Windows.Storage.Streams.IBufferStatics";

        [NativeTypeName("const WCHAR [45]")]
        public const string InterfaceName_Windows_Storage_Streams_IContentTypeProvider = "Windows.Storage.Streams.IContentTypeProvider";

        [NativeTypeName("const WCHAR [36]")]
        public const string InterfaceName_Windows_Storage_Streams_IDataReader = "Windows.Storage.Streams.IDataReader";

        [NativeTypeName("const WCHAR [43]")]
        public const string InterfaceName_Windows_Storage_Streams_IDataReaderFactory = "Windows.Storage.Streams.IDataReaderFactory";

        [NativeTypeName("const WCHAR [43]")]
        public const string InterfaceName_Windows_Storage_Streams_IDataReaderStatics = "Windows.Storage.Streams.IDataReaderStatics";

        [NativeTypeName("const WCHAR [36]")]
        public const string InterfaceName_Windows_Storage_Streams_IDataWriter = "Windows.Storage.Streams.IDataWriter";

        [NativeTypeName("const WCHAR [43]")]
        public const string InterfaceName_Windows_Storage_Streams_IDataWriterFactory = "Windows.Storage.Streams.IDataWriterFactory";

        [NativeTypeName("const WCHAR [55]")]
        public const string InterfaceName_Windows_Storage_Streams_IFileRandomAccessStreamStatics = "Windows.Storage.Streams.IFileRandomAccessStreamStatics";

        [NativeTypeName("const WCHAR [37]")]
        public const string InterfaceName_Windows_Storage_Streams_IInputStream = "Windows.Storage.Streams.IInputStream";

        [NativeTypeName("const WCHAR [46]")]
        public const string InterfaceName_Windows_Storage_Streams_IInputStreamReference = "Windows.Storage.Streams.IInputStreamReference";

        [NativeTypeName("const WCHAR [38]")]
        public const string InterfaceName_Windows_Storage_Streams_IOutputStream = "Windows.Storage.Streams.IOutputStream";

        [NativeTypeName("const WCHAR [44]")]
        public const string InterfaceName_Windows_Storage_Streams_IRandomAccessStream = "Windows.Storage.Streams.IRandomAccessStream";

        [NativeTypeName("const WCHAR [53]")]
        public const string InterfaceName_Windows_Storage_Streams_IRandomAccessStreamReference = "Windows.Storage.Streams.IRandomAccessStreamReference";

        [NativeTypeName("const WCHAR [60]")]
        public const string InterfaceName_Windows_Storage_Streams_IRandomAccessStreamReferenceStatics = "Windows.Storage.Streams.IRandomAccessStreamReferenceStatics";

        [NativeTypeName("const WCHAR [51]")]
        public const string InterfaceName_Windows_Storage_Streams_IRandomAccessStreamStatics = "Windows.Storage.Streams.IRandomAccessStreamStatics";

        [NativeTypeName("const WCHAR [59]")]
        public const string InterfaceName_Windows_Storage_Streams_IRandomAccessStreamWithContentType = "Windows.Storage.Streams.IRandomAccessStreamWithContentType";

        [NativeTypeName("const WCHAR [31]")]
        public const string RuntimeClass_Windows_Storage_Streams_Buffer = "Windows.Storage.Streams.Buffer";

        [NativeTypeName("const WCHAR [35]")]
        public const string RuntimeClass_Windows_Storage_Streams_DataReader = "Windows.Storage.Streams.DataReader";

        [NativeTypeName("const WCHAR [48]")]
        public const string RuntimeClass_Windows_Storage_Streams_DataReaderLoadOperation = "Windows.Storage.Streams.DataReaderLoadOperation";

        [NativeTypeName("const WCHAR [35]")]
        public const string RuntimeClass_Windows_Storage_Streams_DataWriter = "Windows.Storage.Streams.DataWriter";

        [NativeTypeName("const WCHAR [49]")]
        public const string RuntimeClass_Windows_Storage_Streams_DataWriterStoreOperation = "Windows.Storage.Streams.DataWriterStoreOperation";

        [NativeTypeName("const WCHAR [40]")]
        public const string RuntimeClass_Windows_Storage_Streams_FileInputStream = "Windows.Storage.Streams.FileInputStream";

        [NativeTypeName("const WCHAR [41]")]
        public const string RuntimeClass_Windows_Storage_Streams_FileOutputStream = "Windows.Storage.Streams.FileOutputStream";

        [NativeTypeName("const WCHAR [47]")]
        public const string RuntimeClass_Windows_Storage_Streams_FileRandomAccessStream = "Windows.Storage.Streams.FileRandomAccessStream";

        [NativeTypeName("const WCHAR [51]")]
        public const string RuntimeClass_Windows_Storage_Streams_InMemoryRandomAccessStream = "Windows.Storage.Streams.InMemoryRandomAccessStream";

        [NativeTypeName("const WCHAR [46]")]
        public const string RuntimeClass_Windows_Storage_Streams_InputStreamOverStream = "Windows.Storage.Streams.InputStreamOverStream";

        [NativeTypeName("const WCHAR [47]")]
        public const string RuntimeClass_Windows_Storage_Streams_OutputStreamOverStream = "Windows.Storage.Streams.OutputStreamOverStream";

        [NativeTypeName("const WCHAR [43]")]
        public const string RuntimeClass_Windows_Storage_Streams_RandomAccessStream = "Windows.Storage.Streams.RandomAccessStream";

        [NativeTypeName("const WCHAR [53]")]
        public const string RuntimeClass_Windows_Storage_Streams_RandomAccessStreamOverStream = "Windows.Storage.Streams.RandomAccessStreamOverStream";

        [NativeTypeName("const WCHAR [52]")]
        public const string RuntimeClass_Windows_Storage_Streams_RandomAccessStreamReference = "Windows.Storage.Streams.RandomAccessStreamReference";

        public static readonly Guid IID_IBuffer = new Guid(0x905A0FE0, 0xBC53, 0x11DF, 0x8C, 0x49, 0x00, 0x1E, 0x4F, 0xC6, 0x86, 0xDA);

        public static readonly Guid IID_IBufferFactory = new Guid(0x71AF914D, 0xC10F, 0x484B, 0xBC, 0x50, 0x14, 0xBC, 0x62, 0x3B, 0x3A, 0x27);

        public static readonly Guid IID_IBufferStatics = new Guid(0xE901E65B, 0xD716, 0x475A, 0xA9, 0x0A, 0xAF, 0x72, 0x29, 0xB1, 0xE7, 0x41);

        public static readonly Guid IID_IContentTypeProvider = new Guid(0x97D098A5, 0x3B99, 0x4DE9, 0x88, 0xA5, 0xE1, 0x1D, 0x2F, 0x50, 0xC7, 0x95);

        public static readonly Guid IID_IDataReader = new Guid(0xE2B50029, 0xB4C1, 0x4314, 0xA4, 0xB8, 0xFB, 0x81, 0x3A, 0x2F, 0x27, 0x5E);

        public static readonly Guid IID_IDataReaderFactory = new Guid(0xD7527847, 0x57DA, 0x4E15, 0x91, 0x4C, 0x06, 0x80, 0x66, 0x99, 0xA0, 0x98);

        public static readonly Guid IID_IDataReaderStatics = new Guid(0x11FCBFC8, 0xF93A, 0x471B, 0xB1, 0x21, 0xF3, 0x79, 0xE3, 0x49, 0x31, 0x3C);

        public static readonly Guid IID_IDataWriter = new Guid(0x64B89265, 0xD341, 0x4922, 0xB3, 0x8A, 0xDD, 0x4A, 0xF8, 0x80, 0x8C, 0x4E);

        public static readonly Guid IID_IDataWriterFactory = new Guid(0x338C67C2, 0x8B84, 0x4C2B, 0x9C, 0x50, 0x7B, 0x87, 0x67, 0x84, 0x7A, 0x1F);

        public static readonly Guid IID_IFileRandomAccessStreamStatics = new Guid(0x73550107, 0x3B57, 0x4B5D, 0x83, 0x45, 0x55, 0x4D, 0x2F, 0xC6, 0x21, 0xF0);

        public static readonly Guid IID_IInputStream = new Guid(0x905A0FE2, 0xBC53, 0x11DF, 0x8C, 0x49, 0x00, 0x1E, 0x4F, 0xC6, 0x86, 0xDA);

        public static readonly Guid IID_IInputStreamReference = new Guid(0x43929D18, 0x5EC9, 0x4B5A, 0x91, 0x9C, 0x42, 0x05, 0xB0, 0xC8, 0x04, 0xB6);

        public static readonly Guid IID_IOutputStream = new Guid(0x905A0FE6, 0xBC53, 0x11DF, 0x8C, 0x49, 0x00, 0x1E, 0x4F, 0xC6, 0x86, 0xDA);

        public static readonly Guid IID_IRandomAccessStream = new Guid(0x905A0FE1, 0xBC53, 0x11DF, 0x8C, 0x49, 0x00, 0x1E, 0x4F, 0xC6, 0x86, 0xDA);

        public static readonly Guid IID_IRandomAccessStreamReference = new Guid(0x33EE3134, 0x1DD6, 0x4E3A, 0x80, 0x67, 0xD1, 0xC1, 0x62, 0xE8, 0x64, 0x2B);

        public static readonly Guid IID_IRandomAccessStreamReferenceStatics = new Guid(0x857309DC, 0x3FBF, 0x4E7D, 0x98, 0x6F, 0xEF, 0x3B, 0x1A, 0x07, 0xA9, 0x64);

        public static readonly Guid IID_IRandomAccessStreamStatics = new Guid(0x524CEDCF, 0x6E29, 0x4CE5, 0x95, 0x73, 0x6B, 0x75, 0x3D, 0xB6, 0x6C, 0x3A);

        public static readonly Guid IID_IRandomAccessStreamWithContentType = new Guid(0xCC254827, 0x4B3D, 0x438F, 0x92, 0x32, 0x10, 0xC7, 0x6B, 0xC7, 0xE0, 0x38);
    }
}
