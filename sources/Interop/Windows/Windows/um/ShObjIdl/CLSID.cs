// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_QueryCancelAutoPlay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x68, 0x17, 0x1F, 0x33,
                0xA9, 0x05,
                0xDD, 0x4D,
                0xB8,
                0x6E,
                0xDA,
                0xE3,
                0x4D,
                0xDC,
                0x99,
                0x8A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_TimeCategorizer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8F, 0x11, 0xB4, 0x3B,
                0xFD, 0xDD,
                0x30, 0x4D,
                0xA3,
                0x48,
                0x9F,
                0xB5,
                0xD6,
                0xBF,
                0x1A,
                0xFE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_AlphabeticalCategorizer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC6, 0x54, 0x26, 0x3C,
                0x72, 0x73,
                0x6B, 0x4F,
                0xB3,
                0x10,
                0x55,
                0xD6,
                0x12,
                0x8F,
                0x49,
                0xD2
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MergedCategorizer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x11, 0x7C, 0x82, 0x8E,
                0xE7, 0x33,
                0xC1, 0x4B,
                0xB2,
                0x42,
                0x8C,
                0xD9,
                0xA1,
                0xC2,
                0xB3,
                0x04
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ImageProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC7, 0x70, 0xB7, 0x7A,
                0x23, 0x0E,
                0x7A, 0x4D,
                0x8A,
                0xA2,
                0x19,
                0xBF,
                0xAD,
                0x47,
                0x98,
                0x29
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CDBurn
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x05, 0x8A, 0xEB, 0xFB,
                0xEE, 0xBE,
                0x42, 0x44,
                0x80,
                0x4E,
                0x40,
                0x9D,
                0x6C,
                0x45,
                0x15,
                0xE9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_StartMenuPin
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5D, 0x54, 0xA9, 0xA2,
                0xC2, 0xA0,
                0xB4, 0x42,
                0x97,
                0x08,
                0xA0,
                0xB2,
                0xBA,
                0xDD,
                0x77,
                0xC8
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_WebWizardHost
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x49, 0xF1, 0x27, 0xC8,
                0xC1, 0x55,
                0x28, 0x4D,
                0x93,
                0x5E,
                0x57,
                0xE4,
                0x7C,
                0xAE,
                0xD9,
                0x73
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_PublishDropTarget
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFB, 0xEF, 0x6E, 0xCC,
                0xF6, 0x43,
                0xC5, 0x46,
                0x96,
                0x19,
                0x51,
                0xD5,
                0x71,
                0x96,
                0x7F,
                0x7D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_PublishingWizard
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3C, 0x16, 0x33, 0x6B,
                0xA5, 0x76,
                0x6C, 0x4B,
                0xBF,
                0x21,
                0x45,
                0xDE,
                0x9C,
                0xD5,
                0x03,
                0xA1
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_InternetPrintOrdering
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA8, 0x6A, 0xD3, 0xAD,
                0x1A, 0x75,
                0x79, 0x45,
                0xA2,
                0x66,
                0xD6,
                0x6F,
                0x52,
                0x02,
                0xCC,
                0xBB
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FolderViewHost
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x23, 0xCB, 0xB1, 0x20,
                0x68, 0x69,
                0xB9, 0x4E,
                0xB7,
                0xD4,
                0xA6,
                0x6D,
                0x00,
                0xD0,
                0x7C,
                0xEE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ExplorerBrowser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x85, 0x63, 0xF9, 0x71,
                0xD6, 0xDD,
                0xD3, 0x48,
                0xA0,
                0xC1,
                0xAE,
                0x06,
                0xE8,
                0xB0,
                0x55,
                0xFB
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ImageRecompress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1C, 0x09, 0x33, 0x6E,
                0xF8, 0xD2,
                0x40, 0x47,
                0xB5,
                0x5E,
                0x2E,
                0x11,
                0xD1,
                0x47,
                0x7A,
                0x2C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_TrayBandSiteService
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA0, 0xD0, 0x0A, 0xF6,
                0xE1, 0xE5,
                0xCB, 0x45,
                0xB5,
                0x1A,
                0xE1,
                0x5B,
                0x9F,
                0x8B,
                0x29,
                0x34
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_TrayDeskBand
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x37, 0x24, 0x44, 0xE6,
                0x68, 0x6C,
                0x52, 0x4F,
                0x94,
                0xDD,
                0x2C,
                0xFE,
                0xD2,
                0x67,
                0xEF,
                0xB9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_AttachmentServices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x96, 0xDD, 0x25, 0x41,
                0x3A, 0xE0,
                0x03, 0x41,
                0x8F,
                0x70,
                0xE0,
                0x59,
                0x7D,
                0x80,
                0x3B,
                0x9C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DocPropShellExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC3, 0x73, 0x33, 0x88,
                0x89, 0xBF,
                0xD1, 0x11,
                0xBE,
                0x35,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FSCopyHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0A, 0x38, 0x97, 0xD1,
                0x79, 0x0A,
                0xC8, 0x4D,
                0xA0,
                0x33,
                0xED,
                0x88,
                0x2C,
                0x2F,
                0xA1,
                0x4B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_PreviousVersions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x62, 0xB0, 0x6A, 0x59,
                0xD2, 0xB4,
                0x15, 0x42,
                0x9F,
                0x74,
                0xE9,
                0x10,
                0x9B,
                0x0A,
                0x81,
                0x53
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_NamespaceTreeControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x12, 0x42, 0x05, 0xAE,
                0x35, 0x35,
                0x30, 0x44,
                0x83,
                0xED,
                0xD5,
                0x01,
                0xAA,
                0x66,
                0x80,
                0xE6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_IENamespaceTreeControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x03, 0x2D, 0xE5, 0xAC,
                0xCD, 0xE5,
                0x20, 0x4B,
                0x82,
                0xFF,
                0xE7,
                0x1B,
                0x11,
                0xBE,
                0xAE,
                0x1D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ApplicationAssociationRegistrationUI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6D, 0x10, 0x68, 0x19,
                0xB5, 0xF3,
                0xCF, 0x44,
                0x89,
                0x0E,
                0x11,
                0x6F,
                0xCB,
                0x9E,
                0xCE,
                0xF1
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DesktopGadget
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1B, 0xCC, 0x4C, 0x92,
                0x62, 0x65,
                0x85, 0x4C,
                0x86,
                0x57,
                0xD1,
                0x77,
                0x92,
                0x52,
                0x22,
                0xB6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_AccessibilityDockingService
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x46, 0x1D, 0xCE, 0x29,
                0x81, 0xB4,
                0xA0, 0x4A,
                0xA0,
                0x8A,
                0xD3,
                0xEB,
                0xC8,
                0xAC,
                0xA4,
                0x02
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ExecuteFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7C, 0xB4, 0xDB, 0x11,
                0x25, 0xA5,
                0x0B, 0x40,
                0x9E,
                0x80,
                0xA5,
                0x46,
                0x15,
                0xA0,
                0x90,
                0xC0
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_VirtualDesktopManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x86, 0x90, 0x50, 0xAA,
                0xA9, 0x5C,
                0x25, 0x4C,
                0x8F,
                0x95,
                0x58,
                0x9D,
                0x3C,
                0x07,
                0xB4,
                0x8A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_StorageProviderBanners
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF4, 0xF9, 0xCD, 0x7C,
                0x76, 0xE5,
                0x5A, 0x45,
                0x8B,
                0xC7,
                0xF6,
                0xEC,
                0x68,
                0xD6,
                0xF0,
                0x63
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
