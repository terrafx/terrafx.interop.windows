// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid LIBID_QuartzTypeLib
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IAMCollection
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB9, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IMediaControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB1, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IMediaEvent
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB6, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IMediaEventEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IMediaPosition
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB2, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IBasicAudio
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB3, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IVideoWindow
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB4, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IBasicVideo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB5, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IBasicVideo2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xB3, 0x9B, 0x32,
                    0xEA, 0xF6,
                    0xD1, 0x11,
                    0x90,
                    0x38,
                    0x00,
                    0xA0,
                    0xC9,
                    0x69,
                    0x72,
                    0x98
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDeferredCommand
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB8, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IQueueCommand
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB7, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FilgraphManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB3, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IFilterInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBA, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IRegFilterInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBB, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IMediaTypeInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBC, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IPinInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBD, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IAMStats
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xCF, 0x9B, 0xBC,
                    0xD2, 0xDC,
                    0xD2, 0x11,
                    0xAB,
                    0xF6,
                    0x00,
                    0xA0,
                    0xC9,
                    0x05,
                    0xF3,
                    0x75
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_FilgraphManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB3, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
