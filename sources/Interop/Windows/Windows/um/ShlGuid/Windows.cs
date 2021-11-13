// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_NetworkDomain
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x66, 0xE0, 0x46,
                    0xF0, 0x4B,
                    0xD1, 0x11,
                    0x83,
                    0xEE,
                    0x00,
                    0xA0,
                    0xC9,
                    0x0D,
                    0xC8,
                    0x49
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_NetworkServer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0x2A, 0x54, 0xC0,
                    0xF0, 0x4B,
                    0xD1, 0x11,
                    0x83,
                    0xEE,
                    0x00,
                    0xA0,
                    0xC9,
                    0x0D,
                    0xC8,
                    0x49
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_NetworkShare
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x54, 0xA7, 0x54,
                    0xF0, 0x4B,
                    0xD1, 0x11,
                    0x83,
                    0xEE,
                    0x00,
                    0xA0,
                    0xC9,
                    0x0D,
                    0xC8,
                    0x49
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MyComputer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x4F, 0xD0, 0x20,
                    0xEA, 0x3A,
                    0x69, 0x10,
                    0xA2,
                    0xD8,
                    0x08,
                    0x00,
                    0x2B,
                    0x30,
                    0x30,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_Internet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x53, 0x1C, 0x87,
                    0xA0, 0x42,
                    0x69, 0x10,
                    0xA2,
                    0xEA,
                    0x08,
                    0x00,
                    0x2B,
                    0x30,
                    0x30,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_RecycleBin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xF0, 0x5F, 0x64,
                    0x81, 0x50,
                    0x1B, 0x10,
                    0x9F,
                    0x08,
                    0x00,
                    0xAA,
                    0x00,
                    0x2F,
                    0x95,
                    0x4E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ControlPanel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x20, 0xEC, 0x21,
                    0xEA, 0x3A,
                    0x69, 0x10,
                    0xA2,
                    0xDD,
                    0x08,
                    0x00,
                    0x2B,
                    0x30,
                    0x30,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_Printers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xA2, 0x27, 0x22,
                    0xEA, 0x3A,
                    0x69, 0x10,
                    0xA2,
                    0xDE,
                    0x08,
                    0x00,
                    0x2B,
                    0x30,
                    0x30,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MyDocuments
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBA, 0x8F, 0x0D, 0x45,
                    0x25, 0xAD,
                    0xD0, 0x11,
                    0x98,
                    0xA8,
                    0x08,
                    0x00,
                    0x36,
                    0x1B,
                    0x11,
                    0x03
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_BrowsableShellExt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_BrowseInPlace
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x91, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_DeskBand
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_InfoBand
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_CommBand
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x94, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_Intshcut
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_InternetSite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CGID_Explorer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CGID_ShellDocView
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CGID_ShellServiceObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD2, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CGID_ExplorerBarDoc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD3, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_INewShortcutHookA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellBrowser
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE2, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellView
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IContextMenu
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE4, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellIcon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE5, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellFolder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE6, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellExtInit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellPropSheetExt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IPersistFolder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEA, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IExtractIconA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEB, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellDetails
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEC, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellLinkA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ICopyHookA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEF, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IFileViewerA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ICommDlgBrowser
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IEnumIDList
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF2, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IFileViewerSite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF3, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IContextMenu2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF4, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellExecuteHookA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF5, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IPropSheetPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF6, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_INewShortcutHookW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF7, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IFileViewerW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF8, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellLinkW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IExtractIconW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFA, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellExecuteHookW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFB, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ICopyHookW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFC, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IRemoteComputer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFE, 0x14, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IQueryInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x15, 0x02, 0x00,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IBriefcaseStg
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x1F, 0xCE, 0x8B,
                    0x21, 0x09,
                    0x1B, 0x10,
                    0xB1,
                    0xFF,
                    0x00,
                    0xDD,
                    0x01,
                    0x0C,
                    0xCC,
                    0x48
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellView2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x9E, 0xE3, 0x88,
                    0x78, 0x35,
                    0xCF, 0x11,
                    0xAE,
                    0x69,
                    0x08,
                    0x00,
                    0x2B,
                    0x2E,
                    0x12,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IURLSearchHook
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0xF6, 0x60, 0xAC,
                    0xD9, 0x0F,
                    0xD0, 0x11,
                    0x99,
                    0xCB,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD6,
                    0x44,
                    0x97
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ISearchContext
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x56, 0xF6, 0x09,
                    0xAF, 0x41,
                    0x0C, 0x48,
                    0x88,
                    0xF7,
                    0x16,
                    0xCC,
                    0x0D,
                    0x16,
                    0x46,
                    0x15
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IURLSearchHook2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0x4D, 0xE4, 0x5E,
                    0x32, 0x6D,
                    0xE3, 0x46,
                    0x86,
                    0xBC,
                    0x07,
                    0x54,
                    0x0D,
                    0xED,
                    0xD0,
                    0xE0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDefViewID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0x64, 0x5F, 0x98,
                    0x10, 0xD4,
                    0x02, 0x4E,
                    0xBE,
                    0x22,
                    0xDA,
                    0x07,
                    0xF2,
                    0xB5,
                    0xC5,
                    0xE1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FolderShortcut
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0xCE, 0xFA, 0x0A,
                    0x28, 0xE8,
                    0xD1, 0x11,
                    0x91,
                    0x87,
                    0xB5,
                    0x32,
                    0xF1,
                    0xE9,
                    0x57,
                    0x5D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDockingWindowSite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC2, 0x2F, 0x34, 0x2A,
                    0x26, 0x7B,
                    0xD0, 0x11,
                    0x8C,
                    0xA9,
                    0x00,
                    0xA0,
                    0xC9,
                    0x2D,
                    0xBF,
                    0xE8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDockingWindowFrame
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0x65, 0xD2, 0x47,
                    0x27, 0x7B,
                    0xD0, 0x11,
                    0x8C,
                    0xA9,
                    0x00,
                    0xA0,
                    0xC9,
                    0x2D,
                    0xBF,
                    0xE8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellIconOverlay
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x70, 0x8A, 0x68, 0x7D,
                    0x13, 0xC6,
                    0xD0, 0x11,
                    0x99,
                    0x9B,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD6,
                    0x55,
                    0xE1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellIconOverlayIdentifier
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x42, 0x6C, 0x0C,
                    0x89, 0xC5,
                    0xD0, 0x11,
                    0x99,
                    0x9A,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD6,
                    0x55,
                    0xE1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ICommDlgBrowser2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x95, 0x33, 0x10,
                    0x94, 0x28,
                    0xD2, 0x11,
                    0x90,
                    0x39,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xEB,
                    0x3E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellFolderViewCB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0xE3, 0x47, 0x20,
                    0xA9, 0xF2,
                    0xCE, 0x11,
                    0xAE,
                    0x65,
                    0x08,
                    0x00,
                    0x2B,
                    0x2E,
                    0x12,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CFSIconOverlayManager
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0x1F, 0xB5, 0x63,
                    0x68, 0xC8,
                    0xD0, 0x11,
                    0x99,
                    0x9C,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD6,
                    0x55,
                    0xE1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellIconOverlayManager
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x34, 0x5E, 0x0B, 0xF1,
                    0x3B, 0xDD,
                    0xA7, 0x42,
                    0xAA,
                    0x7D,
                    0x2F,
                    0x4E,
                    0xC5,
                    0x4B,
                    0xB0,
                    0x9B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IThumbnailCapture
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0x92, 0xA3, 0x4E,
                    0x11, 0x72,
                    0x9F, 0x40,
                    0xB6,
                    0x22,
                    0xF6,
                    0x3D,
                    0xBD,
                    0x16,
                    0xC5,
                    0x33
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellImageStore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0x11, 0xC8, 0x48,
                    0x24, 0xB9,
                    0xD1, 0x11,
                    0x98,
                    0xD5,
                    0x00,
                    0xC0,
                    0x4F,
                    0xB6,
                    0x87,
                    0xDA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IContextMenu3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0xE0, 0xFC, 0xBC,
                    0x17, 0xEC,
                    0xD0, 0x11,
                    0x8D,
                    0x10,
                    0x00,
                    0xA0,
                    0xC9,
                    0x0F,
                    0x27,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_DefView
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xFE, 0x12, 0x6D,
                    0x11, 0x79,
                    0xCF, 0x11,
                    0x95,
                    0x34,
                    0x00,
                    0x00,
                    0xC0,
                    0x5B,
                    0xAE,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CGID_DefView
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x7F, 0xF0, 0x4A,
                    0x31, 0xD2,
                    0xD0, 0x11,
                    0xB9,
                    0x42,
                    0x00,
                    0xA0,
                    0xC9,
                    0x03,
                    0x12,
                    0xE1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MenuBand
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0xAE, 0x4D, 0x5B,
                    0x07, 0xB8,
                    0xD0, 0x11,
                    0x98,
                    0x15,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x19,
                    0x72
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellFolderBand
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC8, 0x0C, 0xE8, 0x7F,
                    0x47, 0xC2,
                    0xD0, 0x11,
                    0xB9,
                    0x3A,
                    0x00,
                    0xA0,
                    0xC9,
                    0x03,
                    0x12,
                    0xE1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDefViewFrame
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0xB7, 0x0E, 0x71,
                    0xED, 0x45,
                    0xD0, 0x11,
                    0x92,
                    0x4A,
                    0x00,
                    0x20,
                    0xAF,
                    0xC7,
                    0xAC,
                    0x4D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid VID_LargeIcons
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xD0, 0x57, 0x00,
                    0x73, 0x35,
                    0xCF, 0x11,
                    0xAE,
                    0x69,
                    0x08,
                    0x00,
                    0x2B,
                    0x2E,
                    0x12,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid VID_SmallIcons
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x00, 0x90, 0x08,
                    0x73, 0x35,
                    0xCF, 0x11,
                    0xAE,
                    0x69,
                    0x08,
                    0x00,
                    0x2B,
                    0x2E,
                    0x12,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid VID_List
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xA5, 0x1F, 0x0E,
                    0x73, 0x35,
                    0xCF, 0x11,
                    0xAE,
                    0x69,
                    0x08,
                    0x00,
                    0x2B,
                    0x2E,
                    0x12,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid VID_Details
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x77, 0x7E, 0x13,
                    0x73, 0x35,
                    0xCF, 0x11,
                    0xAE,
                    0x69,
                    0x08,
                    0x00,
                    0x2B,
                    0x2E,
                    0x12,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid VID_Tile
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE5, 0x25, 0xF1, 0x65,
                    0xE1, 0x7B,
                    0x10, 0x48,
                    0xBA,
                    0x9D,
                    0xD2,
                    0x71,
                    0xC8,
                    0x43,
                    0x2C,
                    0xE3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid VID_Content
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x34, 0xC4, 0xC2, 0x30,
                    0x89, 0x08,
                    0x8D, 0x4C,
                    0x98,
                    0x5D,
                    0xA9,
                    0xF7,
                    0x18,
                    0x30,
                    0xB0,
                    0xA9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid VID_Thumbnails
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0xB2, 0xEB, 0x8B,
                    0xD0, 0x52,
                    0xD0, 0x11,
                    0xB7,
                    0xF4,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0x06,
                    0xEC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid VID_ThumbStrip
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xA6, 0xEF, 0x8E,
                    0xE9, 0xD1,
                    0x5B, 0x44,
                    0x94,
                    0xB7,
                    0x74,
                    0xFB,
                    0xCE,
                    0x2E,
                    0xA1,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SInPlaceBrowser
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0xE0, 0x2A, 0x1D,
                    0x55, 0x36,
                    0xCC, 0x46,
                    0xB6,
                    0x3A,
                    0x28,
                    0x59,
                    0x88,
                    0x15,
                    0x3B,
                    0xCA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SSearchBoxInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0xAA, 0x2D, 0x14,
                    0x6B, 0x51,
                    0x13, 0x47,
                    0xB4,
                    0x9C,
                    0xFB,
                    0x98,
                    0x5E,
                    0xF8,
                    0x29,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_CommandsPropertyBag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x32, 0x04, 0x6E,
                    0x16, 0x44,
                    0x5C, 0x48,
                    0xB1,
                    0x43,
                    0xE6,
                    0x2A,
                    0x76,
                    0x0D,
                    0x9F,
                    0xE5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDiscardableBrowserProperty
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0xDE, 0xC3, 0x49,
                    0x29, 0xD3,
                    0xD0, 0x11,
                    0xAB,
                    0x73,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC3,
                    0x3E,
                    0x80
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellChangeNotify
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB1, 0xE2, 0x2B, 0xD8,
                    0x64, 0x57,
                    0xD0, 0x11,
                    0xA9,
                    0x6E,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0x05,
                    0xA2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CUrlHistory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x4A, 0x37, 0x3C,
                    0xE4, 0xBA,
                    0xCF, 0x11,
                    0xBF,
                    0x7D,
                    0x00,
                    0xAA,
                    0x00,
                    0x69,
                    0x46,
                    0xEE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CURLSearchHook
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0xAE, 0xBF, 0xCF,
                    0xA6, 0x17,
                    0xD0, 0x11,
                    0x99,
                    0xCB,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD6,
                    0x44,
                    0x97
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IObjMgr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x27, 0xBB, 0x00,
                    0x77, 0x6A,
                    0xD0, 0x11,
                    0xA5,
                    0x35,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xD0,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IACList
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x30, 0xA1, 0x77,
                    0xFD, 0x94,
                    0xD0, 0x11,
                    0xA5,
                    0x44,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xD0,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IACList2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x41, 0x01, 0x47,
                    0x86, 0x51,
                    0xD2, 0x11,
                    0xBB,
                    0xB6,
                    0x00,
                    0x60,
                    0x97,
                    0x7B,
                    0x46,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ICurrentWorkingDirectory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0x6D, 0x95, 0x91,
                    0x76, 0x92,
                    0xD1, 0x11,
                    0x92,
                    0x1A,
                    0x00,
                    0x60,
                    0x97,
                    0xDF,
                    0x5B,
                    0xD4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AutoComplete
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x63, 0x27, 0xBB, 0x00,
                    0x77, 0x6A,
                    0xD0, 0x11,
                    0xA5,
                    0x35,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xD0,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ACLHistory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x27, 0xBB, 0x00,
                    0x77, 0x6A,
                    0xD0, 0x11,
                    0xA5,
                    0x35,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xD0,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ACListISF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0x36, 0xC0, 0x03,
                    0x86, 0xA1,
                    0xD0, 0x11,
                    0x82,
                    0x4A,
                    0x00,
                    0xAA,
                    0x00,
                    0x5B,
                    0x43,
                    0x83
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ACLMRU
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0xA6, 0x56, 0x67,
                    0x71, 0xDE,
                    0xD0, 0x11,
                    0x83,
                    0x1B,
                    0x00,
                    0xAA,
                    0x00,
                    0x5B,
                    0x43,
                    0x83
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ACLMulti
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0x27, 0xBB, 0x00,
                    0x77, 0x6A,
                    0xD0, 0x11,
                    0xA5,
                    0x35,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xD0,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ACLCustomMRU
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0xDB, 0x35, 0x69,
                    0xE8, 0x21,
                    0xCC, 0x4C,
                    0xBE,
                    0xB9,
                    0x9F,
                    0xE3,
                    0xC7,
                    0x7A,
                    0x29,
                    0x7A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ProgressDialog
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0x38, 0x38, 0xF8,
                    0xD3, 0xFC,
                    0xD1, 0x11,
                    0xA6,
                    0xB9,
                    0x00,
                    0x60,
                    0x97,
                    0xDF,
                    0x5B,
                    0xD4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IProgressDialog
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x04, 0x7C, 0xBC, 0xEB,
                    0x5E, 0x31,
                    0xD2, 0x11,
                    0xB6,
                    0x2F,
                    0x00,
                    0x60,
                    0x97,
                    0xDF,
                    0x5B,
                    0xD4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_STopLevelBrowser
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xBE, 0x96, 0x4C,
                    0x5C, 0x91,
                    0xCF, 0x11,
                    0x99,
                    0xD3,
                    0x00,
                    0xAA,
                    0x00,
                    0x4A,
                    0xE8,
                    0x37
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FileTypes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xE5, 0x91, 0xB0,
                    0xE3, 0x83,
                    0xCF, 0x11,
                    0xA7,
                    0x13,
                    0x00,
                    0x20,
                    0xAF,
                    0xD7,
                    0x97,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ActiveDesktop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x87, 0x04, 0x75,
                    0x1F, 0xEF,
                    0xD0, 0x11,
                    0x98,
                    0x88,
                    0x00,
                    0x60,
                    0x97,
                    0xDE,
                    0xAC,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IActiveDesktop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0xEB, 0x90, 0xF4,
                    0x40, 0x12,
                    0xD1, 0x11,
                    0x98,
                    0x88,
                    0x00,
                    0x60,
                    0x97,
                    0xDE,
                    0xAC,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IActiveDesktopP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x2E, 0x50, 0x52,
                    0x80, 0xEC,
                    0xD0, 0x11,
                    0x89,
                    0xAB,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC2,
                    0x97,
                    0x2D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IADesktopP2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE2, 0x54, 0x27, 0xB2,
                    0x74, 0x45,
                    0xD1, 0x11,
                    0x98,
                    0x88,
                    0x00,
                    0x60,
                    0x97,
                    0xDE,
                    0xAC,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ISynchronizedCallBack
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x60, 0xC2, 0x74,
                    0xD1, 0x70,
                    0xD1, 0x11,
                    0xB7,
                    0x5A,
                    0x00,
                    0xA0,
                    0xC9,
                    0x05,
                    0x64,
                    0xFE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IQueryAssociations
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0xA5, 0x6C, 0xC4,
                    0x3F, 0x3C,
                    0xD2, 0x11,
                    0xBE,
                    0xE6,
                    0x00,
                    0x00,
                    0xF8,
                    0x05,
                    0xCA,
                    0x57
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_QueryAssociations
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFD, 0x34, 0x70, 0xA0,
                    0xAA, 0x6C,
                    0x54, 0x49,
                    0xAC,
                    0x3F,
                    0x97,
                    0xA2,
                    0x72,
                    0x16,
                    0xF9,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IColumnProvider
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x04, 0x50, 0x02, 0xE8,
                    0x42, 0x1C,
                    0xD2, 0x11,
                    0xBE,
                    0x2C,
                    0x00,
                    0xA0,
                    0xC9,
                    0xA8,
                    0x3D,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_LinkColumnProvider
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0x4F, 0xF1, 0x24,
                    0x1C, 0x7B,
                    0xD1, 0x11,
                    0x83,
                    0x8F,
                    0x00,
                    0x00,
                    0xF8,
                    0x04,
                    0x61,
                    0xCF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CGID_ShortCut
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x87, 0xA6, 0x93,
                    0x1A, 0x95,
                    0xD1, 0x11,
                    0x94,
                    0x6F,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_INamedPropertyBag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x04, 0x70, 0xFB,
                    0x2C, 0x95,
                    0xD1, 0x11,
                    0x94,
                    0x6F,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_InternetButtons
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x69, 0x79, 0x1E,
                    0xC5, 0x9C,
                    0xD1, 0x11,
                    0xA8,
                    0x3F,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC9,
                    0x9D,
                    0x61
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MSOButtons
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB8, 0x34, 0x8F, 0x17,
                    0x82, 0xA2,
                    0xD2, 0x11,
                    0x86,
                    0xC5,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xEA,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ToolbarExtButtons
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0xB5, 0xE4, 0x2C,
                    0x8F, 0xA2,
                    0xD2, 0x11,
                    0x86,
                    0xC5,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xEA,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DarwinAppPublisher
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0xC7, 0xCC, 0xCF,
                    0x82, 0xA2,
                    0xD1, 0x11,
                    0x90,
                    0x82,
                    0x00,
                    0x60,
                    0x08,
                    0x05,
                    0x93,
                    0x82
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DocHostUIHandler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0xE9, 0x57, 0x70,
                    0x1B, 0xBD,
                    0xD1, 0x11,
                    0x89,
                    0x19,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC2,
                    0xC8,
                    0x36
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IShellFolder2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0xF6, 0xF2, 0x93,
                    0x1B, 0x1D,
                    0xD3, 0x11,
                    0xA3,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x79,
                    0xAB,
                    0xD1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_ShellDetails
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0x6A, 0x63, 0x28,
                    0x3D, 0x95,
                    0xD2, 0x11,
                    0xB5,
                    0xD6,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x18,
                    0xD0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_Storage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0xF1, 0x25, 0xB7,
                    0xEF, 0x47,
                    0x1A, 0x10,
                    0xA5,
                    0xF1,
                    0x02,
                    0x60,
                    0x8C,
                    0x9E,
                    0xEB,
                    0xAC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_ImageProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x1D, 0xB8, 0x14,
                    0x35, 0x01,
                    0x31, 0x4D,
                    0x96,
                    0xD9,
                    0x6C,
                    0xBF,
                    0xC9,
                    0x67,
                    0x1A,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_CustomImageProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0x8B, 0xCD, 0x7E,
                    0x36, 0xC1,
                    0x9B, 0x4A,
                    0x94,
                    0x11,
                    0x4E,
                    0xBD,
                    0x66,
                    0x73,
                    0xCC,
                    0xC3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_LibraryProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0xB6, 0x76, 0x5D,
                    0x3D, 0x9B,
                    0xBB, 0x44,
                    0xB6,
                    0xAE,
                    0x25,
                    0xDA,
                    0x4F,
                    0x63,
                    0x8A,
                    0x67
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_Displaced
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0x4B, 0x17, 0x9B,
                    0xFF, 0x40,
                    0xD2, 0x11,
                    0xA2,
                    0x7E,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC3,
                    0x08,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_Briefcase
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0x8B, 0x8D, 0x32,
                    0x29, 0x77,
                    0xFC, 0x4B,
                    0x95,
                    0x4C,
                    0x90,
                    0x2B,
                    0x32,
                    0x9D,
                    0x56,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_Misc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x34, 0x4B, 0x17, 0x9B,
                    0xFF, 0x40,
                    0xD2, 0x11,
                    0xA2,
                    0x7E,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC3,
                    0x08,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_WebView
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x54, 0x27, 0xF2,
                    0x82, 0xF7,
                    0x91, 0x42,
                    0xBD,
                    0x94,
                    0xF1,
                    0x36,
                    0x93,
                    0x51,
                    0x3A,
                    0xEC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_MUSIC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2E, 0x37, 0xA3, 0x56,
                    0x9C, 0xCE,
                    0xD2, 0x11,
                    0x9F,
                    0x0E,
                    0x00,
                    0x60,
                    0x97,
                    0xC6,
                    0x86,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_DRM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE4, 0x19, 0xAC, 0xAE,
                    0xAE, 0x89,
                    0x08, 0x45,
                    0xB9,
                    0xB7,
                    0xBB,
                    0x86,
                    0x7A,
                    0xBE,
                    0xE2,
                    0xED
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_Volume
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x35, 0x4B, 0x17, 0x9B,
                    0xFF, 0x40,
                    0xD2, 0x11,
                    0xA2,
                    0x7E,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC3,
                    0x08,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FMTID_Query
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0x1C, 0x69, 0x49,
                    0x17, 0x7E,
                    0x1A, 0x10,
                    0xA9,
                    0x1C,
                    0x08,
                    0x00,
                    0x2B,
                    0x2E,
                    0xCD,
                    0xA9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IEnumExtraSearch
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0x0B, 0x70, 0x0E,
                    0xB6, 0x9D,
                    0xD1, 0x11,
                    0xA1,
                    0xCE,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0x5D,
                    0x13
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_HWShellExecute
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5F, 0x65, 0xB8, 0xFF,
                    0xB9, 0x81,
                    0xCE, 0x4F,
                    0xB8,
                    0x9C,
                    0x9A,
                    0x6B,
                    0xA7,
                    0x6D,
                    0x13,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DragDropHelper
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8A, 0x27, 0x57, 0x46,
                    0x1B, 0x41,
                    0xD2, 0x11,
                    0x83,
                    0x9A,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x18,
                    0xD0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CAnchorBrowsePropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBB, 0xF3, 0x50, 0x30,
                    0xB5, 0x98,
                    0xCF, 0x11,
                    0xBB,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0xBD,
                    0xCE,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CImageBrowsePropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB3, 0xF3, 0x50, 0x30,
                    0xB5, 0x98,
                    0xCF, 0x11,
                    0xBB,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0xBD,
                    0xCE,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CDocBrowsePropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB4, 0xF3, 0x50, 0x30,
                    0xB5, 0x98,
                    0xCF, 0x11,
                    0xBB,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0xBD,
                    0xCE,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IFileSystemBindData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x8D, 0xE1, 0x01,
                    0x8B, 0x4D,
                    0xD2, 0x11,
                    0x85,
                    0x5D,
                    0x00,
                    0x60,
                    0x08,
                    0x05,
                    0x93,
                    0x67
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_STopWindow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0xB5, 0xE1, 0x49,
                    0x36, 0x46,
                    0xD3, 0x11,
                    0x97,
                    0xF7,
                    0x00,
                    0xC0,
                    0x4F,
                    0x45,
                    0xD0,
                    0xB3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SGetViewFromViewDual
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0x93, 0x9A, 0x88,
                    0x1E, 0x97,
                    0x12, 0x4B,
                    0xB9,
                    0x0C,
                    0x24,
                    0xDF,
                    0xC9,
                    0xE1,
                    0xE5,
                    0xE8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FolderItem
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x0F, 0xF1, 0xFE,
                    0x5E, 0x35,
                    0x06, 0x4E,
                    0x93,
                    0x81,
                    0x9B,
                    0x24,
                    0xD7,
                    0xF7,
                    0xCC,
                    0x88
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FolderItemsMultiLevel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x48, 0xC7, 0x53,
                    0x99, 0xAB,
                    0x33, 0x4D,
                    0xAC,
                    0xA4,
                    0x31,
                    0x17,
                    0xF5,
                    0x1D,
                    0x37,
                    0x88
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_NewMenu
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0xA3, 0x69, 0xD9,
                    0xFF, 0xE7,
                    0xD0, 0x11,
                    0xA9,
                    0x3B,
                    0x00,
                    0xA0,
                    0xC9,
                    0x0F,
                    0x27,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_SFObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xE2, 0x81, 0x39,
                    0x59, 0xF5,
                    0xD3, 0x11,
                    0x8E,
                    0x3A,
                    0x00,
                    0xC0,
                    0x4F,
                    0x68,
                    0x37,
                    0xD5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_SFUIObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x25, 0xE2, 0x81, 0x39,
                    0x59, 0xF5,
                    0xD3, 0x11,
                    0x8E,
                    0x3A,
                    0x00,
                    0xC0,
                    0x4F,
                    0x68,
                    0x37,
                    0xD5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_SFViewObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0xE2, 0x81, 0x39,
                    0x59, 0xF5,
                    0xD3, 0x11,
                    0x8E,
                    0x3A,
                    0x00,
                    0xC0,
                    0x4F,
                    0x68,
                    0x37,
                    0xD5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_Storage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0xE2, 0x81, 0x39,
                    0x59, 0xF5,
                    0xD3, 0x11,
                    0x8E,
                    0x3A,
                    0x00,
                    0xC0,
                    0x4F,
                    0x68,
                    0x37,
                    0xD5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_Stream
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAB, 0xB3, 0xEB, 0x1C,
                    0x10, 0x7C,
                    0x9A, 0x49,
                    0xA4,
                    0x17,
                    0x92,
                    0xCA,
                    0x16,
                    0xC4,
                    0xCB,
                    0x83
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_RandomAccessStream
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0xC9, 0x6F, 0xF1,
                    0xAE, 0x77,
                    0xFE, 0x4C,
                    0xBD,
                    0xA7,
                    0xA8,
                    0x66,
                    0xEE,
                    0xA6,
                    0x87,
                    0x8D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_LinkTargetItem
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0xE2, 0x81, 0x39,
                    0x59, 0xF5,
                    0xD3, 0x11,
                    0x8E,
                    0x3A,
                    0x00,
                    0xC0,
                    0x4F,
                    0x68,
                    0x37,
                    0xD5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_StorageEnum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0xA4, 0x21, 0x46,
                    0xD6, 0xF0,
                    0x73, 0x47,
                    0x8A,
                    0x9C,
                    0x46,
                    0xE7,
                    0x7B,
                    0x17,
                    0x48,
                    0x40
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_Transfer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x46, 0xE3, 0xD5,
                    0x53, 0xF7,
                    0x32, 0x49,
                    0xB4,
                    0x03,
                    0x45,
                    0x74,
                    0x80,
                    0x0E,
                    0x24,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_PropertyStore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0xE1, 0x84, 0x03,
                    0x23, 0x15,
                    0x9C, 0x43,
                    0xA4,
                    0xC8,
                    0xAB,
                    0x91,
                    0x10,
                    0x52,
                    0xF5,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_ThumbnailHandler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0x65, 0x2E, 0x7B,
                    0x20, 0x8E,
                    0x4A, 0x4F,
                    0xB0,
                    0x9E,
                    0x65,
                    0x97,
                    0xAF,
                    0xC7,
                    0x2F,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_EnumItems
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0x05, 0xF6, 0x94,
                    0x50, 0x28,
                    0x24, 0x49,
                    0xAA,
                    0x5A,
                    0xD1,
                    0x5E,
                    0x84,
                    0x86,
                    0x80,
                    0x39
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_DataObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9F, 0xBD, 0xC0, 0xB8,
                    0x24, 0xED,
                    0x5C, 0x45,
                    0x83,
                    0xE6,
                    0xD5,
                    0x39,
                    0x0C,
                    0x4F,
                    0xE8,
                    0xC4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_AssociationArray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x17, 0xEF, 0xA9, 0xBE,
                    0xF1, 0x82,
                    0x60, 0x4F,
                    0x92,
                    0x84,
                    0x4F,
                    0x8D,
                    0xB7,
                    0x5C,
                    0x3B,
                    0xE9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_Filter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x78, 0x87, 0xD0, 0x38,
                    0x57, 0xF5,
                    0x90, 0x46,
                    0x9E,
                    0xBF,
                    0xBA,
                    0x54,
                    0x70,
                    0x6A,
                    0xD8,
                    0xF7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_EnumAssocHandlers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9C, 0x0B, 0xAB, 0xB8,
                    0xEC, 0xC2,
                    0x7A, 0x4F,
                    0x91,
                    0x8D,
                    0x31,
                    0x49,
                    0x00,
                    0xE6,
                    0x28,
                    0x0A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_StorageItem
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x09, 0x21, 0x4E, 0x40,
                    0xD2, 0x77,
                    0x99, 0x46,
                    0xA5,
                    0xA0,
                    0x4F,
                    0xDF,
                    0x10,
                    0xDB,
                    0x98,
                    0x37
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid BHID_FilePlaceholder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEB, 0xDC, 0x77, 0x86,
                    0xE0, 0xAA,
                    0x05, 0x40,
                    0x8D,
                    0x3D,
                    0x54,
                    0x7F,
                    0xA8,
                    0x52,
                    0xF8,
                    0x25
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_FilePlaceholderMergeHandler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x51, 0x9A, 0x9C, 0x3E,
                    0xAA, 0xD4,
                    0x70, 0x48,
                    0xB4,
                    0x7C,
                    0x74,
                    0x24,
                    0xB4,
                    0x91,
                    0xF1,
                    0xCC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_CtxQueryAssociations
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xFC, 0xAD, 0xFA,
                    0x77, 0xB7,
                    0x69, 0x4B,
                    0xAA,
                    0x81,
                    0x77,
                    0x03,
                    0x5E,
                    0xF0,
                    0xE6,
                    0xE8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDocViewSite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x05, 0xD6, 0x87,
                    0x11, 0xC5,
                    0xCF, 0x11,
                    0x89,
                    0xA9,
                    0x00,
                    0xA0,
                    0xC9,
                    0x05,
                    0x41,
                    0x29
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_QuickLinks
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0xBF, 0x5C, 0x0E,
                    0x5F, 0xD1,
                    0xD0, 0x11,
                    0x83,
                    0x01,
                    0x00,
                    0xAA,
                    0x00,
                    0x5B,
                    0x43,
                    0x83
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ISFBand
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0xE2, 0x2B, 0xD8,
                    0x64, 0x57,
                    0xD0, 0x11,
                    0xA9,
                    0x6E,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0x05,
                    0xA2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_CDefView
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xFF, 0x34, 0x44,
                    0x4C, 0xEF,
                    0xCE, 0x11,
                    0xAE,
                    0x65,
                    0x08,
                    0x00,
                    0x2B,
                    0x2E,
                    0x12,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ShellFldSetExt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x13, 0x53, 0x6D,
                    0x62, 0x8C,
                    0xD1, 0x11,
                    0xB2,
                    0xCD,
                    0x00,
                    0x60,
                    0x97,
                    0xDF,
                    0x8C,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SMenuBandChild
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0xC0, 0x9C, 0xED,
                    0xB9, 0x08,
                    0xD1, 0x11,
                    0x98,
                    0x23,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x19,
                    0x72
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SMenuBandParent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEC, 0x8E, 0x27, 0x8C,
                    0xAB, 0x3E,
                    0xD1, 0x11,
                    0x8C,
                    0xB0,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x18,
                    0xD0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SMenuPopup
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEB, 0xAF, 0xE7, 0xD1,
                    0x2E, 0x6A,
                    0xD0, 0x11,
                    0x8C,
                    0x78,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x18,
                    0xB4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SMenuBandBottomSelected
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF4, 0xBA, 0x5E, 0x16,
                    0x51, 0x6D,
                    0xD2, 0x11,
                    0x83,
                    0xAD,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x18,
                    0xD0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SMenuBandBottom
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0xA6, 0x3C, 0x74,
                    0xEB, 0x0D,
                    0xD1, 0x11,
                    0x98,
                    0x25,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x19,
                    0x72
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_MenuShellFolder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB4, 0x7E, 0xC1, 0xA6,
                    0x65, 0x2D,
                    0xD2, 0x11,
                    0x83,
                    0x8F,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x18,
                    0xD0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SMenuBandContextMenuModifier
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0x58, 0x54, 0x39,
                    0x62, 0x71,
                    0x5E, 0x46,
                    0xB7,
                    0x83,
                    0x2A,
                    0xA1,
                    0x87,
                    0x4F,
                    0xEF,
                    0x81
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SMenuBandBKContextMenu
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0xBD, 0x4B, 0x16,
                    0x0D, 0x1D,
                    0xE0, 0x4D,
                    0x9A,
                    0x3B,
                    0xD9,
                    0x72,
                    0x96,
                    0x47,
                    0xC2,
                    0xB8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CGID_MENUDESKBAR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x12, 0x0A, 0x9F, 0x5C,
                    0x9E, 0x95,
                    0xD0, 0x11,
                    0xA3,
                    0xA4,
                    0x00,
                    0xA0,
                    0xC9,
                    0x08,
                    0x26,
                    0x36
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SMenuBandTop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0xA8, 0x93, 0x94,
                    0x38, 0xEC,
                    0xD0, 0x11,
                    0xBC,
                    0x46,
                    0x00,
                    0xAA,
                    0x00,
                    0x6C,
                    0xE2,
                    0xF5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MenuToolbarBase
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x66, 0xB9, 0x40,
                    0x22, 0xB5,
                    0xD1, 0x11,
                    0xB3,
                    0xB4,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xFD,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IBanneredBar
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x94, 0x9A, 0x6A, 0x59,
                    0x3E, 0x01,
                    0xD1, 0x11,
                    0x8D,
                    0x34,
                    0x00,
                    0xA0,
                    0xC9,
                    0x0F,
                    0x27,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MenuBandSite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE4, 0xF4, 0x3E, 0xE1,
                    0xF2, 0xD2,
                    0xD0, 0x11,
                    0x98,
                    0x16,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x19,
                    0x72
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SCommDlgBrowser
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0x02, 0xF3, 0x80,
                    0xDF, 0xB7,
                    0xD2, 0x11,
                    0xA3,
                    0x3B,
                    0x00,
                    0x60,
                    0x97,
                    0xDF,
                    0x5B,
                    0xD4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CPFG_LOGON_USERNAME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0xBB, 0x15, 0xDA,
                    0x4D, 0x95,
                    0xD3, 0x4F,
                    0xB0,
                    0xF4,
                    0x1F,
                    0xB5,
                    0xB9,
                    0x0B,
                    0x17,
                    0x4B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CPFG_LOGON_PASSWORD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFA, 0x4C, 0x62, 0x60,
                    0x77, 0xA4,
                    0xB1, 0x47,
                    0x8A,
                    0x8E,
                    0x3A,
                    0x4A,
                    0x19,
                    0x98,
                    0x18,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CPFG_SMARTCARD_USERNAME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x69, 0xCF, 0x1E, 0x3E,
                    0x8C, 0x56,
                    0x96, 0x4D,
                    0x9D,
                    0x59,
                    0x46,
                    0x44,
                    0x41,
                    0x74,
                    0xE2,
                    0xD6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CPFG_SMARTCARD_PIN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0x26, 0xE5, 0x4F,
                    0x81, 0x91,
                    0xC1, 0x46,
                    0xB0,
                    0xA4,
                    0x9D,
                    0xED,
                    0xD4,
                    0xDB,
                    0x7D,
                    0xEA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CPFG_CREDENTIAL_PROVIDER_LOGO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x75, 0x77, 0x83, 0x2D,
                    0xCD, 0xF6,
                    0x4E, 0x46,
                    0xA7,
                    0x45,
                    0x48,
                    0x2F,
                    0xD0,
                    0xB4,
                    0x74,
                    0x93
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CPFG_CREDENTIAL_PROVIDER_LABEL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF3, 0xBF, 0x6B, 0x28,
                    0xD4, 0xBA,
                    0x8F, 0x43,
                    0xB0,
                    0x07,
                    0x79,
                    0xB7,
                    0x26,
                    0x7C,
                    0x3D,
                    0x48
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CPFG_STANDALONE_SUBMIT_BUTTON
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0x0A, 0x7B, 0x0B,
                    0x36, 0xCC,
                    0x59, 0x4D,
                    0x80,
                    0x2B,
                    0x82,
                    0xF7,
                    0x14,
                    0xFA,
                    0x70,
                    0x22
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CPFG_STYLE_LINK_AS_BUTTON
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x08, 0xA5, 0x8F, 0x08,
                    0xA6, 0x94,
                    0x30, 0x44,
                    0xA4,
                    0xCB,
                    0x6F,
                    0xC6,
                    0xE3,
                    0xC0,
                    0xB9,
                    0xE2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_Invalid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x98, 0x78, 0x80, 0x57,
                    0x4F, 0x8C,
                    0x62, 0x44,
                    0xBB,
                    0x63,
                    0x71,
                    0x04,
                    0x23,
                    0x80,
                    0xB1,
                    0x09
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_Generic
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB5, 0x28, 0x4F, 0x5C,
                    0x69, 0xF8,
                    0x84, 0x4E,
                    0x8E,
                    0x60,
                    0xF1,
                    0x1D,
                    0xB9,
                    0x7C,
                    0x5C,
                    0xC7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_GenericSearchResults
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1E, 0x1A, 0xDE, 0x7F,
                    0x31, 0x8B,
                    0xA5, 0x49,
                    0x93,
                    0xB8,
                    0x6B,
                    0xE1,
                    0x4C,
                    0xFA,
                    0x49,
                    0x43
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_GenericLibrary
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9A, 0xAB, 0x4E, 0x5F,
                    0x33, 0x68,
                    0x61, 0x4F,
                    0x89,
                    0x9D,
                    0x31,
                    0xCF,
                    0x46,
                    0x97,
                    0x9D,
                    0x49
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_Documents
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0xD7, 0x49, 0x7D,
                    0x21, 0x3C,
                    0x05, 0x4F,
                    0x99,
                    0xAA,
                    0xFD,
                    0xC2,
                    0xC9,
                    0x47,
                    0x46,
                    0x56
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_Pictures
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x58, 0x0E, 0x69, 0xB3,
                    0x61, 0xE9,
                    0x3B, 0x42,
                    0xB6,
                    0x87,
                    0x38,
                    0x6E,
                    0xBF,
                    0xD8,
                    0x32,
                    0x39
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_Music
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCC, 0xDD, 0xD6, 0x94,
                    0x68, 0x4A,
                    0x75, 0x41,
                    0xA3,
                    0x74,
                    0xBD,
                    0x58,
                    0x4A,
                    0x51,
                    0x0B,
                    0x78
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_Videos
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0x64, 0xA9, 0x5F,
                    0x77, 0x7E,
                    0x3C, 0x48,
                    0xAC,
                    0x93,
                    0x69,
                    0x1D,
                    0x05,
                    0x85,
                    0x0D,
                    0xE8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_Downloads
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6E, 0x18, 0x5A, 0x88,
                    0x40, 0xA4,
                    0xDA, 0x4A,
                    0x81,
                    0x2B,
                    0xDB,
                    0x87,
                    0x1B,
                    0x94,
                    0x22,
                    0x59
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_UserFiles
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9B, 0xC6, 0x0F, 0xCD,
                    0xE2, 0x71,
                    0xE5, 0x46,
                    0x96,
                    0x90,
                    0x5B,
                    0xCD,
                    0x9F,
                    0x57,
                    0xAA,
                    0xB3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_UsersLibraries
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x09, 0x8F, 0xD9, 0xC4,
                    0x24, 0x61,
                    0xE0, 0x4F,
                    0x99,
                    0x42,
                    0x82,
                    0x64,
                    0x16,
                    0x08,
                    0x2D,
                    0xA9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_OtherUsers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0xFD, 0x37, 0xB3,
                    0xD5, 0x9D,
                    0x35, 0x46,
                    0xA6,
                    0xD4,
                    0xDA,
                    0x33,
                    0xFD,
                    0x10,
                    0x2B,
                    0x7A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_PublishedItems
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x96, 0x5B, 0x2F, 0x7F,
                    0x74, 0xFF,
                    0xDA, 0x41,
                    0xAF,
                    0xD8,
                    0x1C,
                    0x78,
                    0xA5,
                    0xF3,
                    0xAE,
                    0xA2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_Communications
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE5, 0x5F, 0x47, 0x91,
                    0x6B, 0x58,
                    0xBA, 0x4E,
                    0x8D,
                    0x75,
                    0xD1,
                    0x74,
                    0x34,
                    0xB8,
                    0xCD,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_Contacts
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEC, 0x70, 0x2B, 0xDE,
                    0xF7, 0x9B,
                    0x93, 0x4A,
                    0xBD,
                    0x3D,
                    0x24,
                    0x3F,
                    0x78,
                    0x81,
                    0xD4,
                    0x92
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_StartMenu
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0xB4, 0x87, 0xEF,
                    0xCE, 0xF2,
                    0x85, 0x47,
                    0x86,
                    0x58,
                    0x4C,
                    0xA6,
                    0xC6,
                    0x3E,
                    0x38,
                    0xC6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_RecordedTV
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0xA2, 0x57, 0x55,
                    0xA6, 0x5D,
                    0x83, 0x4F,
                    0x88,
                    0x09,
                    0xC2,
                    0xC9,
                    0x8A,
                    0x11,
                    0xA6,
                    0xFA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_SavedGames
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0x33, 0x36, 0xD0,
                    0xCB, 0x28,
                    0x06, 0x41,
                    0x9F,
                    0x23,
                    0x29,
                    0x56,
                    0xE3,
                    0xE5,
                    0xE0,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_OpenSearch
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x29, 0x96, 0xAF, 0x8F,
                    0x80, 0x19,
                    0xFF, 0x46,
                    0x80,
                    0x23,
                    0x9D,
                    0xCE,
                    0xAB,
                    0x9C,
                    0x3E,
                    0xE3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_SearchConnector
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0x25, 0x27, 0x98,
                    0x47, 0x6F,
                    0x9E, 0x47,
                    0xB4,
                    0x47,
                    0x81,
                    0x2B,
                    0xFA,
                    0x7D,
                    0x2E,
                    0x8F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_AccountPictures
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0x5D, 0x2A, 0xDB,
                    0xE6, 0x06,
                    0x07, 0x40,
                    0xAB,
                    0xA6,
                    0xAF,
                    0x87,
                    0x7D,
                    0x52,
                    0x6E,
                    0xA6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_Games
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0xB0, 0x89, 0xB6,
                    0xD3, 0x76,
                    0xBB, 0x4C,
                    0x87,
                    0xF7,
                    0x58,
                    0x5D,
                    0x0E,
                    0x0C,
                    0xE0,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_ControlPanelCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0x06, 0x4F, 0xDE,
                    0x10, 0xFA,
                    0x8F, 0x4B,
                    0xA4,
                    0x94,
                    0x06,
                    0x8B,
                    0x20,
                    0xB2,
                    0x23,
                    0x07
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_ControlPanelClassic
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF3, 0x94, 0x37, 0x0C,
                    0x45, 0xB5,
                    0xAA, 0x43,
                    0xA3,
                    0x29,
                    0xC3,
                    0x74,
                    0x30,
                    0xC5,
                    0x8D,
                    0x2A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_Printers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC6, 0xBE, 0x7B, 0x2C,
                    0x44, 0xC8,
                    0x0A, 0x4A,
                    0x91,
                    0xFA,
                    0xCE,
                    0xF6,
                    0xF5,
                    0x9C,
                    0xFD,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_RecycleBin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x04, 0xE0, 0xD9, 0xD6,
                    0x87, 0xCD,
                    0x2B, 0x44,
                    0x9D,
                    0x57,
                    0x5E,
                    0x0A,
                    0xEB,
                    0x4F,
                    0x6F,
                    0x72
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_SoftwareExplorer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0x39, 0x74, 0xD6,
                    0xD9, 0x52,
                    0x07, 0x4E,
                    0x83,
                    0x4E,
                    0x67,
                    0xC9,
                    0x86,
                    0x10,
                    0xF3,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_CompressedFolder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0x3E, 0x21, 0x80,
                    0xFD, 0xBC,
                    0x4F, 0x4C,
                    0x88,
                    0x17,
                    0xBB,
                    0x27,
                    0x60,
                    0x12,
                    0x67,
                    0xA9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_NetworkExplorer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x24, 0xCC, 0x25,
                    0x7C, 0x9A,
                    0x51, 0x4F,
                    0x80,
                    0xE0,
                    0x7A,
                    0x29,
                    0x28,
                    0xFE,
                    0xBE,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_Searches
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0xA2, 0x0B, 0x0B,
                    0x5F, 0x40,
                    0x5E, 0x41,
                    0xA6,
                    0xEE,
                    0xCA,
                    0xD6,
                    0x25,
                    0x20,
                    0x78,
                    0x53
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_SearchHome
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0x8A, 0x4D, 0x83,
                    0x74, 0x09,
                    0xD6, 0x4E,
                    0x86,
                    0x6E,
                    0xF2,
                    0x03,
                    0xD8,
                    0x0B,
                    0x38,
                    0x10
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_StorageProviderGeneric
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC5, 0xEB, 0x01, 0x4F,
                    0x85, 0x23,
                    0xF2, 0x41,
                    0xA2,
                    0x8E,
                    0x2C,
                    0x5C,
                    0x91,
                    0xFB,
                    0x56,
                    0xE0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_StorageProviderDocuments
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0xBD, 0x61, 0xDD,
                    0xE8, 0x70,
                    0xDD, 0x48,
                    0x96,
                    0x55,
                    0x65,
                    0xC5,
                    0xE1,
                    0xAA,
                    0xC2,
                    0xD1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_StorageProviderPictures
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA9, 0x42, 0xD6, 0x71,
                    0xB1, 0xF2,
                    0xCD, 0x42,
                    0xAD,
                    0x92,
                    0xEB,
                    0x93,
                    0x00,
                    0xC7,
                    0xCC,
                    0x0A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_StorageProviderMusic
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7E, 0xCD, 0x2E, 0x67,
                    0x04, 0xAF,
                    0x99, 0x43,
                    0x87,
                    0x5C,
                    0x02,
                    0x90,
                    0x84,
                    0x5B,
                    0x62,
                    0x47
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FOLDERTYPEID_StorageProviderVideos
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x4D, 0x29, 0x51,
                    0xB1, 0xD7,
                    0x5B, 0x48,
                    0x9E,
                    0x9A,
                    0x17,
                    0xCF,
                    0xFE,
                    0x33,
                    0xE1,
                    0x87
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SYNCMGR_OBJECTID_Icon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC3, 0x85, 0xBC, 0x6D,
                    0x07, 0x5D,
                    0x72, 0x4C,
                    0xA7,
                    0x77,
                    0x7F,
                    0xEC,
                    0x78,
                    0x07,
                    0x2C,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SYNCMGR_OBJECTID_EventStore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB9, 0x34, 0xEF, 0x4B,
                    0x86, 0xA7,
                    0x75, 0x40,
                    0xBA,
                    0x88,
                    0x0C,
                    0x2B,
                    0x9D,
                    0x89,
                    0xA9,
                    0x8F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SYNCMGR_OBJECTID_ConflictStore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF4, 0x81, 0x81, 0xD7,
                    0x89, 0x23,
                    0xE4, 0x47,
                    0xA9,
                    0x60,
                    0x60,
                    0xBC,
                    0xC2,
                    0xED,
                    0x93,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SYNCMGR_OBJECTID_BrowseContent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0xB5, 0xCB, 0x57,
                    0xB4, 0xE9,
                    0xAE, 0x47,
                    0xA1,
                    0x20,
                    0xC4,
                    0xDF,
                    0x33,
                    0x35,
                    0xDE,
                    0xE2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SYNCMGR_OBJECTID_ShowSchedule
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0xF3, 0xC6, 0xED,
                    0x41, 0x84,
                    0x09, 0x41,
                    0xAD,
                    0xF3,
                    0x6C,
                    0x1C,
                    0xA0,
                    0xB7,
                    0xDE,
                    0x47
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SYNCMGR_OBJECTID_QueryBeforeActivate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0B, 0xD8, 0x82, 0xD8,
                    0xAA, 0xE7,
                    0xED, 0x49,
                    0x86,
                    0xB7,
                    0xE6,
                    0xE1,
                    0xF7,
                    0x14,
                    0xCD,
                    0xFE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SYNCMGR_OBJECTID_QueryBeforeDeactivate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0xC2, 0xEF, 0xA0,
                    0xE0, 0x60,
                    0x0E, 0x46,
                    0x93,
                    0x74,
                    0xEA,
                    0x88,
                    0x51,
                    0x3C,
                    0xFC,
                    0x80
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SYNCMGR_OBJECTID_QueryBeforeEnable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0xF7, 0xCB, 0x04,
                    0xEB, 0x5B,
                    0xE1, 0x4D,
                    0xBC,
                    0x90,
                    0x90,
                    0x83,
                    0x45,
                    0xC4,
                    0x80,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SYNCMGR_OBJECTID_QueryBeforeDisable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAA, 0x64, 0x5F, 0xBB,
                    0x04, 0xF0,
                    0xB5, 0x4E,
                    0x8E,
                    0x4D,
                    0x26,
                    0x75,
                    0x19,
                    0x66,
                    0x34,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SYNCMGR_OBJECTID_QueryBeforeDelete
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x97, 0x33, 0x6C, 0xF7,
                    0xB3, 0xAF,
                    0xD7, 0x45,
                    0xA5,
                    0x9F,
                    0x5A,
                    0x49,
                    0xE9,
                    0x05,
                    0x43,
                    0x7E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SYNCMGR_OBJECTID_EventLinkClick
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC1, 0xBD, 0x03, 0x22,
                    0xF1, 0x1A,
                    0x82, 0x40,
                    0x8C,
                    0x30,
                    0x28,
                    0x39,
                    0x9F,
                    0x41,
                    0x38,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EP_NavPane
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x6B, 0x31, 0xCB,
                    0xF7, 0x25,
                    0xB8, 0x42,
                    0x8A,
                    0x09,
                    0x54,
                    0x0D,
                    0x23,
                    0xA4,
                    0x3C,
                    0x2F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EP_Commands
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x68, 0x58, 0x74, 0xD9,
                    0x5F, 0xCA,
                    0x76, 0x4A,
                    0x91,
                    0xCD,
                    0xF5,
                    0xA1,
                    0x29,
                    0xFB,
                    0xB0,
                    0x76
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EP_Commands_Organize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x17, 0xE8, 0x72,
                    0xEC, 0xE3,
                    0x60, 0x46,
                    0xBF,
                    0x24,
                    0x3C,
                    0x3B,
                    0x7B,
                    0x64,
                    0x88,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EP_Commands_View
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2D, 0xC3, 0xF7, 0x21,
                    0xAA, 0xEE,
                    0x9B, 0x43,
                    0xBB,
                    0x51,
                    0x37,
                    0xB9,
                    0x6F,
                    0xD6,
                    0xA9,
                    0x43
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EP_DetailsPane
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8B, 0xF9, 0xAB, 0x43,
                    0xB8, 0x89,
                    0x2D, 0x47,
                    0xB9,
                    0xCE,
                    0xE6,
                    0x9B,
                    0x82,
                    0x29,
                    0xF0,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EP_PreviewPane
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0x63, 0x3C, 0x89,
                    0xC8, 0x45,
                    0x17, 0x4D,
                    0xBE,
                    0x19,
                    0x22,
                    0x3B,
                    0xE7,
                    0x1B,
                    0xE3,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EP_QueryPane
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4F, 0xDE, 0xBC, 0x65,
                    0x07, 0x4F,
                    0x27, 0x4F,
                    0x83,
                    0xA7,
                    0x1A,
                    0xFC,
                    0xA4,
                    0xDF,
                    0x7D,
                    0xDD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EP_AdvQueryPane
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8B, 0xDB, 0xE9, 0xB4,
                    0xBA, 0x34,
                    0x39, 0x4C,
                    0xB5,
                    0xCC,
                    0x16,
                    0xA1,
                    0xBD,
                    0x2C,
                    0x41,
                    0x1C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EP_StatusBar
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCE, 0x56, 0xFE, 0x65,
                    0xFE, 0x5C,
                    0xC4, 0x4B,
                    0xAD,
                    0x8A,
                    0x7A,
                    0xE3,
                    0xFE,
                    0x7E,
                    0x8F,
                    0x7C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EP_Ribbon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA8, 0x24, 0x75, 0xD2,
                    0xF2, 0xC9,
                    0x34, 0x48,
                    0xA1,
                    0x06,
                    0xDF,
                    0x88,
                    0x89,
                    0xFD,
                    0x4F,
                    0x37
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_LocationFactory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x51, 0x4D, 0x5C, 0x96,
                    0x76, 0x8B,
                    0x57, 0x4E,
                    0x80,
                    0xB7,
                    0x56,
                    0x4D,
                    0x2E,
                    0xA4,
                    0xB5,
                    0x5E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_LocationProvider
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0xA4, 0x3C, 0x1B,
                    0x14, 0x26,
                    0x4B, 0x41,
                    0xB8,
                    0x13,
                    0x1A,
                    0xCE,
                    0xCA,
                    0x3E,
                    0x3D,
                    0xD8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid ItemCount_Property_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x45, 0x5C, 0xBF, 0xAB,
                    0xCC, 0x5C,
                    0xB7, 0x47,
                    0xBB,
                    0x4E,
                    0x87,
                    0xCB,
                    0x87,
                    0xBB,
                    0xD1,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SelectedItemCount_Property_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD2, 0x16, 0xE3, 0x8F,
                    0x52, 0x0E,
                    0x0A, 0x46,
                    0x9C,
                    0x1E,
                    0x48,
                    0xF2,
                    0x73,
                    0xD4,
                    0x70,
                    0xA3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid ItemIndex_Property_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDA, 0x53, 0xA0, 0x92,
                    0x69, 0x29,
                    0x21, 0x40,
                    0xBF,
                    0x27,
                    0x51,
                    0x4C,
                    0xFC,
                    0x2E,
                    0x4A,
                    0x69
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_SearchableApplication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2A, 0x29, 0x6C, 0x36,
                    0xB3, 0xD9,
                    0xBF, 0x4D,
                    0xBB,
                    0x70,
                    0xE6,
                    0x2E,
                    0xC3,
                    0xD0,
                    0xBB,
                    0xBF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define STR_MYDOCS_CLSID \"{450D8FBA-AD25-11D0-98A8-0800361B1103}\"")]
        public static ReadOnlySpan<byte> STR_MYDOCS_CLSID => new byte[] { 0x7B, 0x34, 0x35, 0x30, 0x44, 0x38, 0x46, 0x42, 0x41, 0x2D, 0x41, 0x44, 0x32, 0x35, 0x2D, 0x31, 0x31, 0x44, 0x30, 0x2D, 0x39, 0x38, 0x41, 0x38, 0x2D, 0x30, 0x38, 0x30, 0x30, 0x33, 0x36, 0x31, 0x42, 0x31, 0x31, 0x30, 0x33, 0x7D, 0x00 };

        [NativeTypeName("#define IID_IShellCopyHookA IID_ICopyHookA")]
        public static ref readonly Guid IID_IShellCopyHookA => ref IID_ICopyHookA;

        [NativeTypeName("#define IID_IShellCopyHookW IID_ICopyHookW")]
        public static ref readonly Guid IID_IShellCopyHookW => ref IID_ICopyHookW;

        [NativeTypeName("#define SID_LinkSite IID_IShellLinkW")]
        public static ref readonly Guid SID_LinkSite => ref IID_IShellLinkW;

        [NativeTypeName("#define SID_ShellFolderViewCB IID_IShellFolderViewCB")]
        public static ref readonly Guid SID_ShellFolderViewCB => ref IID_IShellFolderViewCB;

        [NativeTypeName("#define SID_SShellBrowser IID_IShellBrowser")]
        public static ref readonly Guid SID_SShellBrowser => ref IID_IShellBrowser;

        [NativeTypeName("#define IID_IFileViewer IID_IFileViewerW")]
        public static ref readonly Guid IID_IFileViewer => ref IID_IFileViewerW;

        [NativeTypeName("#define IID_IShellLink IID_IShellLinkW")]
        public static ref readonly Guid IID_IShellLink => ref IID_IShellLinkW;

        [NativeTypeName("#define IID_IExtractIcon IID_IExtractIconW")]
        public static ref readonly Guid IID_IExtractIcon => ref IID_IExtractIconW;

        [NativeTypeName("#define IID_IShellCopyHook IID_IShellCopyHookW")]
        public static ref readonly Guid IID_IShellCopyHook => ref IID_ICopyHookW;

        [NativeTypeName("#define IID_IShellExecuteHook IID_IShellExecuteHookW")]
        public static ref readonly Guid IID_IShellExecuteHook => ref IID_IShellExecuteHookW;

        [NativeTypeName("#define IID_INewShortcutHook IID_INewShortcutHookW")]
        public static ref readonly Guid IID_INewShortcutHook => ref IID_INewShortcutHookW;

        [NativeTypeName("#define SID_SUrlHistory CLSID_CUrlHistory")]
        public static ref readonly Guid SID_SUrlHistory => ref CLSID_CUrlHistory;

        [NativeTypeName("#define SID_SInternetExplorer IID_IWebBrowserApp")]
        public static ref readonly Guid SID_SInternetExplorer => ref IID_IWebBrowserApp;

        [NativeTypeName("#define SID_SWebBrowserApp IID_IWebBrowserApp")]
        public static ref readonly Guid SID_SWebBrowserApp => ref IID_IWebBrowserApp;

        [NativeTypeName("#define SID_SProgressUI CLSID_ProgressDialog")]
        public static ref readonly Guid SID_SProgressUI => ref CLSID_ProgressDialog;

        [NativeTypeName("#define PID_FINDDATA 0")]
        public const int PID_FINDDATA = 0;

        [NativeTypeName("#define PID_NETRESOURCE 1")]
        public const int PID_NETRESOURCE = 1;

        [NativeTypeName("#define PID_DESCRIPTIONID 2")]
        public const int PID_DESCRIPTIONID = 2;

        [NativeTypeName("#define PID_WHICHFOLDER 3")]
        public const int PID_WHICHFOLDER = 3;

        [NativeTypeName("#define PID_NETWORKLOCATION 4")]
        public const int PID_NETWORKLOCATION = 4;

        [NativeTypeName("#define PID_COMPUTERNAME 5")]
        public const int PID_COMPUTERNAME = 5;

        [NativeTypeName("#define PID_DISPLACED_FROM 2")]
        public const int PID_DISPLACED_FROM = 2;

        [NativeTypeName("#define PID_DISPLACED_DATE 3")]
        public const int PID_DISPLACED_DATE = 3;

        [NativeTypeName("#define PID_SYNC_COPY_IN 2")]
        public const int PID_SYNC_COPY_IN = 2;

        [NativeTypeName("#define PID_MISC_STATUS 2")]
        public const int PID_MISC_STATUS = 2;

        [NativeTypeName("#define PID_MISC_ACCESSCOUNT 3")]
        public const int PID_MISC_ACCESSCOUNT = 3;

        [NativeTypeName("#define PID_MISC_OWNER 4")]
        public const int PID_MISC_OWNER = 4;

        [NativeTypeName("#define PID_HTMLINFOTIPFILE 5")]
        public const int PID_HTMLINFOTIPFILE = 5;

        [NativeTypeName("#define PID_MISC_PICS 6")]
        public const int PID_MISC_PICS = 6;

        [NativeTypeName("#define PID_DISPLAY_PROPERTIES 0")]
        public const int PID_DISPLAY_PROPERTIES = 0;

        [NativeTypeName("#define PID_INTROTEXT 1")]
        public const int PID_INTROTEXT = 1;

        [NativeTypeName("#define PIDSI_ARTIST 2")]
        public const int PIDSI_ARTIST = 2;

        [NativeTypeName("#define PIDSI_SONGTITLE 3")]
        public const int PIDSI_SONGTITLE = 3;

        [NativeTypeName("#define PIDSI_ALBUM 4")]
        public const int PIDSI_ALBUM = 4;

        [NativeTypeName("#define PIDSI_YEAR 5")]
        public const int PIDSI_YEAR = 5;

        [NativeTypeName("#define PIDSI_COMMENT 6")]
        public const int PIDSI_COMMENT = 6;

        [NativeTypeName("#define PIDSI_TRACK 7")]
        public const int PIDSI_TRACK = 7;

        [NativeTypeName("#define PIDSI_GENRE 11")]
        public const int PIDSI_GENRE = 11;

        [NativeTypeName("#define PIDSI_LYRICS 12")]
        public const int PIDSI_LYRICS = 12;

        [NativeTypeName("#define PIDDRSI_PROTECTED 2")]
        public const int PIDDRSI_PROTECTED = 2;

        [NativeTypeName("#define PIDDRSI_DESCRIPTION 3")]
        public const int PIDDRSI_DESCRIPTION = 3;

        [NativeTypeName("#define PIDDRSI_PLAYCOUNT 4")]
        public const int PIDDRSI_PLAYCOUNT = 4;

        [NativeTypeName("#define PIDDRSI_PLAYSTARTS 5")]
        public const int PIDDRSI_PLAYSTARTS = 5;

        [NativeTypeName("#define PIDDRSI_PLAYEXPIRES 6")]
        public const int PIDDRSI_PLAYEXPIRES = 6;

        [NativeTypeName("#define PIDVSI_STREAM_NAME 0x00000002")]
        public const int PIDVSI_STREAM_NAME = 0x00000002;

        [NativeTypeName("#define PIDVSI_FRAME_WIDTH 0x00000003")]
        public const int PIDVSI_FRAME_WIDTH = 0x00000003;

        [NativeTypeName("#define PIDVSI_FRAME_HEIGHT 0x00000004")]
        public const int PIDVSI_FRAME_HEIGHT = 0x00000004;

        [NativeTypeName("#define PIDVSI_TIMELENGTH 0x00000007")]
        public const int PIDVSI_TIMELENGTH = 0x00000007;

        [NativeTypeName("#define PIDVSI_FRAME_COUNT 0x00000005")]
        public const int PIDVSI_FRAME_COUNT = 0x00000005;

        [NativeTypeName("#define PIDVSI_FRAME_RATE 0x00000006")]
        public const int PIDVSI_FRAME_RATE = 0x00000006;

        [NativeTypeName("#define PIDVSI_DATA_RATE 0x00000008")]
        public const int PIDVSI_DATA_RATE = 0x00000008;

        [NativeTypeName("#define PIDVSI_SAMPLE_SIZE 0x00000009")]
        public const int PIDVSI_SAMPLE_SIZE = 0x00000009;

        [NativeTypeName("#define PIDVSI_COMPRESSION 0x0000000A")]
        public const int PIDVSI_COMPRESSION = 0x0000000A;

        [NativeTypeName("#define PIDVSI_STREAM_NUMBER 0x0000000B")]
        public const int PIDVSI_STREAM_NUMBER = 0x0000000B;

        [NativeTypeName("#define PIDASI_FORMAT 0x00000002")]
        public const int PIDASI_FORMAT = 0x00000002;

        [NativeTypeName("#define PIDASI_TIMELENGTH 0x00000003")]
        public const int PIDASI_TIMELENGTH = 0x00000003;

        [NativeTypeName("#define PIDASI_AVG_DATA_RATE 0x00000004")]
        public const int PIDASI_AVG_DATA_RATE = 0x00000004;

        [NativeTypeName("#define PIDASI_SAMPLE_RATE 0x00000005")]
        public const int PIDASI_SAMPLE_RATE = 0x00000005;

        [NativeTypeName("#define PIDASI_SAMPLE_SIZE 0x00000006")]
        public const int PIDASI_SAMPLE_SIZE = 0x00000006;

        [NativeTypeName("#define PIDASI_CHANNEL_COUNT 0x00000007")]
        public const int PIDASI_CHANNEL_COUNT = 0x00000007;

        [NativeTypeName("#define PIDASI_STREAM_NUMBER 0x00000008")]
        public const int PIDASI_STREAM_NUMBER = 0x00000008;

        [NativeTypeName("#define PIDASI_STREAM_NAME 0x00000009")]
        public const int PIDASI_STREAM_NAME = 0x00000009;

        [NativeTypeName("#define PIDASI_COMPRESSION 0x0000000A")]
        public const int PIDASI_COMPRESSION = 0x0000000A;

        [NativeTypeName("#define PID_CONTROLPANEL_CATEGORY 2")]
        public const int PID_CONTROLPANEL_CATEGORY = 2;

        [NativeTypeName("#define PID_VOLUME_FREE 2")]
        public const int PID_VOLUME_FREE = 2;

        [NativeTypeName("#define PID_VOLUME_CAPACITY 3")]
        public const int PID_VOLUME_CAPACITY = 3;

        [NativeTypeName("#define PID_VOLUME_FILESYSTEM 4")]
        public const int PID_VOLUME_FILESYSTEM = 4;

        [NativeTypeName("#define PID_SHARE_CSC_STATUS 2")]
        public const int PID_SHARE_CSC_STATUS = 2;

        [NativeTypeName("#define PID_LINK_TARGET 2")]
        public const int PID_LINK_TARGET = 2;

        [NativeTypeName("#define PID_LINK_TARGET_TYPE 3")]
        public const int PID_LINK_TARGET_TYPE = 3;

        [NativeTypeName("#define PID_QUERY_RANK 2")]
        public const int PID_QUERY_RANK = 2;
    }
}
