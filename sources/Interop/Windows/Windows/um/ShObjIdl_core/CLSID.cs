// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_DesktopWallpaper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x10, 0x31, 0xCF, 0xC2,
                0x0E, 0x46,
                0xC1, 0x4F,
                0xB9,
                0xD0,
                0x8A,
                0x1C,
                0x0C,
                0x9C,
                0xC4,
                0xBD
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ShellDesktop
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0x14, 0x02, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ShellFSFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA0, 0x4B, 0x36, 0xF3,
                0xB9, 0x65,
                0xCE, 0x11,
                0xA9,
                0xBA,
                0x00,
                0xAA,
                0x00,
                0x4A,
                0xE8,
                0x37
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_NetworkPlaces
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x60, 0x2C, 0x8D, 0x20,
                0xEA, 0x3A,
                0x69, 0x10,
                0xA2,
                0xD7,
                0x08,
                0x00,
                0x2B,
                0x30,
                0x30,
                0x9D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ShellLink
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x01, 0x14, 0x02, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DriveSizeCategorizer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x53, 0x7B, 0x35, 0x94,
                0x29, 0xCA,
                0x78, 0x4B,
                0x83,
                0xAE,
                0xE8,
                0xFE,
                0x74,
                0x09,
                0x13,
                0x4F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DriveTypeCategorizer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCF, 0xF3, 0xA8, 0xB0,
                0x33, 0x43,
                0xAB, 0x4B,
                0x88,
                0x73,
                0x1C,
                0xCB,
                0x1C,
                0xAD,
                0xA4,
                0x8B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FreeSpaceCategorizer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x93, 0x77, 0x60, 0xB5,
                0xAC, 0x24,
                0xC7, 0x44,
                0x82,
                0xE2,
                0x83,
                0x17,
                0x26,
                0xAA,
                0x6C,
                0xB7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SizeCategorizer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x52, 0xB8, 0xD7, 0x55,
                0xD1, 0xF6,
                0xF2, 0x42,
                0xAA,
                0x75,
                0x87,
                0x28,
                0xA1,
                0xB2,
                0xD2,
                0x64
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_PropertiesUI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCF, 0xF8, 0x12, 0xD9,
                0x96, 0x03,
                0x15, 0x49,
                0x88,
                0x4E,
                0xFB,
                0x42,
                0x5D,
                0x32,
                0x94,
                0x3B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_UserNotification
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0E, 0x89, 0x10, 0x00,
                0x89, 0x87,
                0x3C, 0x41,
                0xAD,
                0xBC,
                0x48,
                0xF5,
                0xB5,
                0x11,
                0xB3,
                0xAF
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_TaskbarList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x44, 0xF3, 0xFD, 0x56,
                0x6D, 0xFD,
                0xD0, 0x11,
                0x95,
                0x8A,
                0x00,
                0x60,
                0x97,
                0xC9,
                0xA0,
                0x90
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ShellItem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE1, 0xFB, 0xC9, 0x9A,
                0xA2, 0xE0,
                0xD6, 0x4A,
                0xB4,
                0xEE,
                0xE2,
                0x12,
                0x01,
                0x3E,
                0xA9,
                0x17
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_NamespaceWalker
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0x61, 0xEB, 0x72,
                0x72, 0x86,
                0x03, 0x43,
                0x91,
                0x75,
                0xF2,
                0xE4,
                0xC6,
                0x8B,
                0x2E,
                0x7C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FileOperation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x75, 0x55, 0xD0, 0x3A,
                0x57, 0x88,
                0x50, 0x48,
                0x92,
                0x77,
                0x11,
                0xB8,
                0x5B,
                0xDB,
                0x8E,
                0x09
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FileOpenDialog
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9C, 0x5A, 0x1C, 0xDC,
                0x8A, 0xE8,
                0xDE, 0x4D,
                0xA5,
                0xA1,
                0x60,
                0xF8,
                0x2A,
                0x20,
                0xAE,
                0xF7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FileSaveDialog
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF3, 0xE2, 0xB4, 0xC0,
                0x21, 0xBA,
                0x73, 0x47,
                0x8D,
                0xBA,
                0x33,
                0x5E,
                0xC9,
                0x46,
                0xEB,
                0x8B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_KnownFolderManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x30, 0xC7, 0xF0, 0x4D,
                0x9D, 0xDF,
                0xE3, 0x4A,
                0x91,
                0x53,
                0xAA,
                0x6B,
                0x82,
                0xE9,
                0x79,
                0x5A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SharingConfigurationManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE1, 0x71, 0xF3, 0x49,
                0x5C, 0x8C,
                0x9C, 0x4D,
                0x9A,
                0x3B,
                0x54,
                0xA6,
                0x82,
                0x7F,
                0x51,
                0x3C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_NetworkConnections
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC7, 0xAC, 0x07, 0x70,
                0x02, 0x32,
                0xD1, 0x11,
                0xAA,
                0xD2,
                0x00,
                0x80,
                0x5F,
                0xC1,
                0x27,
                0x0E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ScheduledTasks
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x90, 0x79, 0x27, 0xD6,
                0x6A, 0x4C,
                0xCF, 0x11,
                0x8D,
                0x87,
                0x00,
                0xAA,
                0x00,
                0x60,
                0xF5,
                0xBF
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ApplicationAssociationRegistration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC7, 0x09, 0x12, 0x59,
                0x7B, 0x76,
                0xB2, 0x42,
                0x9F,
                0xBA,
                0x44,
                0xEE,
                0x46,
                0x15,
                0xF2,
                0xC7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SearchFolderItemFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x02, 0x0E, 0x01, 0x14,
                0xBD, 0xBB,
                0xF0, 0x41,
                0x88,
                0xE3,
                0xED,
                0xA3,
                0x71,
                0x21,
                0x65,
                0x84
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_OpenControlPanel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x85, 0x2D, 0x62, 0x06,
                0x56, 0x68,
                0x60, 0x44,
                0x8D,
                0xE1,
                0xA8,
                0x19,
                0x21,
                0xB4,
                0x1C,
                0x4B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MailRecipient
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x60, 0xBE, 0x56, 0x9E,
                0x0F, 0xC5,
                0xCF, 0x11,
                0x9A,
                0x2C,
                0x00,
                0xA0,
                0xC9,
                0x0A,
                0x90,
                0xCE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_NetworkExplorerFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0D, 0x1A, 0x2C, 0xF0,
                0x21, 0xBE,
                0x50, 0x43,
                0x88,
                0xB0,
                0x73,
                0x67,
                0xFC,
                0x96,
                0xEF,
                0x3C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DestinationList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF0, 0x0C, 0xF1, 0x77,
                0xB5, 0x3D,
                0x66, 0x49,
                0xB5,
                0x20,
                0xB7,
                0xC5,
                0x4F,
                0xD3,
                0x5E,
                0xD6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ApplicationDestinations
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x03, 0x40, 0xC1, 0x86,
                0x6B, 0x4D,
                0xF3, 0x4E,
                0xA7,
                0xB4,
                0x05,
                0x06,
                0x66,
                0x3B,
                0x2E,
                0x68
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ApplicationDocumentLists
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x22, 0xC2, 0xBE, 0x86,
                0xF2, 0x30,
                0xE0, 0x47,
                0x9F,
                0x25,
                0x60,
                0xD1,
                0x1C,
                0xD7,
                0x5C,
                0x28
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HomeGroup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x04, 0xBA, 0x77, 0xDE,
                0x92, 0x3C,
                0x11, 0x4D,
                0xA1,
                0xA5,
                0x42,
                0x35,
                0x2A,
                0x53,
                0xE0,
                0xE3
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ShellLibrary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1D, 0x21, 0xB3, 0xD9,
                0x7F, 0xE5,
                0x26, 0x44,
                0xAA,
                0xEF,
                0x30,
                0xA8,
                0x06,
                0xAD,
                0xD3,
                0x97
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_AppStartupLink
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE7, 0xB5, 0x3E, 0x27,
                0xB0, 0x88,
                0x43, 0x48,
                0xBF,
                0xEF,
                0xE2,
                0xC8,
                0x1D,
                0x43,
                0xAA,
                0xE5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_EnumerableObjectCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC1, 0x68, 0x34, 0x2D,
                0xA7, 0x36,
                0xB6, 0x43,
                0xAC,
                0x24,
                0xD3,
                0xF0,
                0x2F,
                0xD9,
                0x60,
                0x7A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FrameworkInputPane
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA3, 0x0A, 0x12, 0xD5,
                0xBA, 0x46,
                0xC5, 0x44,
                0x82,
                0x2D,
                0xCA,
                0x80,
                0x92,
                0xC1,
                0xFC,
                0x72
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DefFolderMenu
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBE, 0x82, 0x33, 0xC6,
                0x33, 0x79,
                0xD0, 0x48,
                0x9A,
                0xC8,
                0x85,
                0xFB,
                0x46,
                0xBE,
                0x2F,
                0xDD
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_AppVisibility
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD9, 0xE3, 0x5F, 0x7E,
                0x5F, 0x98,
                0x08, 0x49,
                0x91,
                0xF9,
                0xEE,
                0x19,
                0xF9,
                0xFD,
                0x15,
                0x14
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_AppShellVerbHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x19, 0xA7, 0xD3, 0x4E,
                0xA8, 0xCE,
                0xD9, 0x4B,
                0x91,
                0x0D,
                0xE2,
                0x52,
                0xF9,
                0x97,
                0xAF,
                0xC2
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ExecuteUnknown
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x28, 0x94, 0x4E, 0xE4,
                0xBC, 0xBD,
                0x87, 0x49,
                0xA0,
                0x99,
                0x40,
                0xDC,
                0x8F,
                0xD2,
                0x55,
                0xE7
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_PackageDebugSettings
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6F, 0xC1, 0xAE, 0xB1,
                0x83, 0x23,
                0x52, 0x48,
                0xB0,
                0xE9,
                0x8F,
                0x0B,
                0x1D,
                0xC6,
                0x6B,
                0x4D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SuspensionDependencyManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC5, 0x3F, 0x27, 0x6B,
                0xFD, 0x61,
                0x18, 0x49,
                0x95,
                0xA2,
                0xC3,
                0xB5,
                0xE9,
                0xD7,
                0xF5,
                0x81
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ApplicationActivationManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7D, 0x12, 0xBA, 0x45,
                0xA8, 0x10,
                0xEA, 0x46,
                0x8A,
                0xB7,
                0x56,
                0xEA,
                0x90,
                0x78,
                0x94,
                0x3C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ApplicationDesignModeSettings
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB5, 0x6F, 0x8A, 0x95,
                0xB2, 0xDC,
                0xAF, 0x4F,
                0xAA,
                0xFD,
                0x7F,
                0xB0,
                0x54,
                0xAD,
                0x1A,
                0x3B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
