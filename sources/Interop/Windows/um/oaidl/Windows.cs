// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define FADF_AUTO ( 0x1 )")]
        public const int FADF_AUTO = (0x1);

        [NativeTypeName("#define FADF_STATIC ( 0x2 )")]
        public const int FADF_STATIC = (0x2);

        [NativeTypeName("#define FADF_EMBEDDED ( 0x4 )")]
        public const int FADF_EMBEDDED = (0x4);

        [NativeTypeName("#define FADF_FIXEDSIZE ( 0x10 )")]
        public const int FADF_FIXEDSIZE = (0x10);

        [NativeTypeName("#define FADF_RECORD ( 0x20 )")]
        public const int FADF_RECORD = (0x20);

        [NativeTypeName("#define FADF_HAVEIID ( 0x40 )")]
        public const int FADF_HAVEIID = (0x40);

        [NativeTypeName("#define FADF_HAVEVARTYPE ( 0x80 )")]
        public const int FADF_HAVEVARTYPE = (0x80);

        [NativeTypeName("#define FADF_BSTR ( 0x100 )")]
        public const int FADF_BSTR = (0x100);

        [NativeTypeName("#define FADF_UNKNOWN ( 0x200 )")]
        public const int FADF_UNKNOWN = (0x200);

        [NativeTypeName("#define FADF_DISPATCH ( 0x400 )")]
        public const int FADF_DISPATCH = (0x400);

        [NativeTypeName("#define FADF_VARIANT ( 0x800 )")]
        public const int FADF_VARIANT = (0x800);

        [NativeTypeName("#define FADF_RESERVED ( 0xf008 )")]
        public const int FADF_RESERVED = (0xf008);

        [NativeTypeName("#define PARAMFLAG_NONE ( 0 )")]
        public const int PARAMFLAG_NONE = (0);

        [NativeTypeName("#define PARAMFLAG_FIN ( 0x1 )")]
        public const int PARAMFLAG_FIN = (0x1);

        [NativeTypeName("#define PARAMFLAG_FOUT ( 0x2 )")]
        public const int PARAMFLAG_FOUT = (0x2);

        [NativeTypeName("#define PARAMFLAG_FLCID ( 0x4 )")]
        public const int PARAMFLAG_FLCID = (0x4);

        [NativeTypeName("#define PARAMFLAG_FRETVAL ( 0x8 )")]
        public const int PARAMFLAG_FRETVAL = (0x8);

        [NativeTypeName("#define PARAMFLAG_FOPT ( 0x10 )")]
        public const int PARAMFLAG_FOPT = (0x10);

        [NativeTypeName("#define PARAMFLAG_FHASDEFAULT ( 0x20 )")]
        public const int PARAMFLAG_FHASDEFAULT = (0x20);

        [NativeTypeName("#define PARAMFLAG_FHASCUSTDATA ( 0x40 )")]
        public const int PARAMFLAG_FHASCUSTDATA = (0x40);

        [NativeTypeName("#define IDLFLAG_NONE ( PARAMFLAG_NONE )")]
        public const int IDLFLAG_NONE = ((0));

        [NativeTypeName("#define IDLFLAG_FIN ( PARAMFLAG_FIN )")]
        public const int IDLFLAG_FIN = ((0x1));

        [NativeTypeName("#define IDLFLAG_FOUT ( PARAMFLAG_FOUT )")]
        public const int IDLFLAG_FOUT = ((0x2));

        [NativeTypeName("#define IDLFLAG_FLCID ( PARAMFLAG_FLCID )")]
        public const int IDLFLAG_FLCID = ((0x4));

        [NativeTypeName("#define IDLFLAG_FRETVAL ( PARAMFLAG_FRETVAL )")]
        public const int IDLFLAG_FRETVAL = ((0x8));

        [NativeTypeName("#define IMPLTYPEFLAG_FDEFAULT ( 0x1 )")]
        public const int IMPLTYPEFLAG_FDEFAULT = (0x1);

        [NativeTypeName("#define IMPLTYPEFLAG_FSOURCE ( 0x2 )")]
        public const int IMPLTYPEFLAG_FSOURCE = (0x2);

        [NativeTypeName("#define IMPLTYPEFLAG_FRESTRICTED ( 0x4 )")]
        public const int IMPLTYPEFLAG_FRESTRICTED = (0x4);

        [NativeTypeName("#define IMPLTYPEFLAG_FDEFAULTVTABLE ( 0x8 )")]
        public const int IMPLTYPEFLAG_FDEFAULTVTABLE = (0x8);

        [NativeTypeName("#define DISPID_UNKNOWN ( -1 )")]
        public const int DISPID_UNKNOWN = (-1);

        [NativeTypeName("#define DISPID_VALUE ( 0 )")]
        public const int DISPID_VALUE = (0);

        [NativeTypeName("#define DISPID_PROPERTYPUT ( -3 )")]
        public const int DISPID_PROPERTYPUT = (-3);

        [NativeTypeName("#define DISPID_NEWENUM ( -4 )")]
        public const int DISPID_NEWENUM = (-4);

        [NativeTypeName("#define DISPID_EVALUATE ( -5 )")]
        public const int DISPID_EVALUATE = (-5);

        [NativeTypeName("#define DISPID_CONSTRUCTOR ( -6 )")]
        public const int DISPID_CONSTRUCTOR = (-6);

        [NativeTypeName("#define DISPID_DESTRUCTOR ( -7 )")]
        public const int DISPID_DESTRUCTOR = (-7);

        [NativeTypeName("#define DISPID_COLLECT ( -8 )")]
        public const int DISPID_COLLECT = (-8);

        public static ref readonly Guid IID_ICreateTypeInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x05, 0x04, 0x02, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICreateTypeInfo2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0x04, 0x02, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICreateTypeLib
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x06, 0x04, 0x02, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICreateTypeLib2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0F, 0x04, 0x02, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDispatch
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x04, 0x02, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumVARIANT
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x04, 0x04, 0x02, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITypeComp
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0x04, 0x02, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITypeInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x04, 0x02, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITypeInfo2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x12, 0x04, 0x02, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITypeLib
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0x04, 0x02, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITypeLib2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0x04, 0x02, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITypeChangeEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x04, 0x02, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IErrorInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0xB1, 0xF2, 0x1C,
                    0x7D, 0x54,
                    0x1B, 0x10,
                    0x8E,
                    0x65,
                    0x08,
                    0x00,
                    0x2B,
                    0x2B,
                    0xD1,
                    0x19
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICreateErrorInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x33, 0xF0, 0x22,
                    0x7D, 0x54,
                    0x1B, 0x10,
                    0x8E,
                    0x65,
                    0x08,
                    0x00,
                    0x2B,
                    0x2B,
                    0xD1,
                    0x19
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISupportErrorInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0x3D, 0x0B, 0xDF,
                    0x8F, 0x54,
                    0x1B, 0x10,
                    0x8E,
                    0x65,
                    0x08,
                    0x00,
                    0x2B,
                    0x2B,
                    0xD1,
                    0x19
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITypeFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2E, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITypeMarshal
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2D, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IRecordInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2F, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IErrorLog
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xCA, 0x27, 0x31,
                    0x6E, 0x44,
                    0xCE, 0x11,
                    0x81,
                    0x35,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xB8,
                    0x51
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPropertyBag
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x2A, 0x27, 0x55,
                    0xCB, 0x42,
                    0xCE, 0x11,
                    0x81,
                    0x35,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xB8,
                    0x51
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITypeLibRegistrationReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2A, 0x8A, 0x6A, 0xED,
                    0x60, 0xB1,
                    0x77, 0x4E,
                    0x8F,
                    0x73,
                    0xAA,
                    0x74,
                    0x35,
                    0xCD,
                    0x5C,
                    0x27
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITypeLibRegistration
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x35, 0xE7, 0xA3, 0x76,
                    0xDF, 0x02,
                    0x12, 0x4A,
                    0x98,
                    0xEB,
                    0x04,
                    0x3A,
                    0xD3,
                    0x60,
                    0x0A,
                    0xF3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
