// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_HTMLCSSStyleDeclaration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x41, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x85, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLRuleStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD0, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLCSSRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEF, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLCSSImportRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF0, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLCSSMediaRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF1, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLCSSMediaList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x32, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLCSSNamespaceRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF2, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLMSCSSKeyframeRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0E, 0x08, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLMSCSSKeyframesRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0F, 0x08, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLRenderStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAA, 0xF6, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLCurrentStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDC, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDOMAttribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB2, 0xF4, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDOMTextNode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBA, 0xF4, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDOMImplementation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0E, 0xF8, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLAttributeCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCC, 0xF4, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_StaticNodeList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x67, 0x04, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMChildrenCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAA, 0xF5, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDefaults
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC8, 0xF6, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTCDefaultDispatch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFC, 0xF4, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTCPropertyBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDE, 0xF5, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTCMethodBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x30, 0xF6, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTCEventBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFE, 0xF4, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTCAttachBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF5, 0xF5, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTCDescBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDD, 0xF5, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLUrnCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x80, 0xF5, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLGenericElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB8, 0xF4, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLStyleSheetRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCE, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLStyleSheetRulesCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCD, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLStyleSheetPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEF, 0xF7, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLStyleSheetPagesCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF1, 0xF7, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLStyleSheet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE4, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLStyleSheetsCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7F, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLLinkElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x77, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDOMRange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC3, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLFormElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x51, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLTextElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6A, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLImg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x41, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLImageElementFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8F, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLBody
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4A, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLFontElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7B, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLAnchorElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x48, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLLabelElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2B, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLListElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x72, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLUListElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x69, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLOListElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x70, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLLIElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x73, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLBlockElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x81, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDivElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7E, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDDElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7F, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDTElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7C, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLBRElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x80, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDListElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7D, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLHRElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x52, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLParaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6F, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLElementCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCB, 0xF4, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLHeaderElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7A, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLSelectElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x45, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLWndSelectElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCF, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLOptionElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLOptionElementFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8D, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLWndOptionElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD0, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLInputElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD8, 0xF5, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLTextAreaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAC, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLRichtextElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDF, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLButtonElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC6, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLMarqueeElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB9, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLHtmlElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x91, 0xF4, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLHeadElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x93, 0xF4, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLTitleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x84, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLMetaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x75, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLBaseElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x76, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLIsIndexElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x78, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLNextIdElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x79, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLBaseFontElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x82, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLUnknownElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x68, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLHistory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA3, 0xAA, 0xCE, 0xFE,
                0x05, 0x84,
                0xCF, 0x11,
                0x8B,
                0xA1,
                0x00,
                0xAA,
                0x00,
                0x47,
                0x6D,
                0xA6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_COpsProfile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x02, 0xF4, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLNavigator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA6, 0xAA, 0xCE, 0xFE,
                0x05, 0x84,
                0xCF, 0x11,
                0x8B,
                0xA1,
                0x00,
                0xAA,
                0x00,
                0x47,
                0x6D,
                0xA6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLLocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE1, 0xB1, 0x3B, 0x16,
                0x00, 0x6E,
                0xCF, 0x11,
                0x83,
                0x7A,
                0x48,
                0xDC,
                0x04,
                0xC1,
                0x00,
                0x00
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CMimeTypes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFE, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CPlugins
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFF, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CEventObj
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8A, 0xF4, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLStyleMedia
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4C, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FramesCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF6, 0xF7, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLScreen
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5D, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLWindow2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC6, 0x6E, 0x8A, 0xD4,
                0x4A, 0x6A,
                0xCF, 0x11,
                0x94,
                0xA7,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLWindowProxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x91, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDocumentCompatibleInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1B, 0x04, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDocumentCompatibleInfoCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x19, 0x04, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDocument
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0x69, 0x33, 0x25,
                0xF9, 0x03,
                0xCF, 0x11,
                0x8F,
                0xD0,
                0x00,
                0xAA,
                0x00,
                0x68,
                0x6F,
                0x13
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_Scriptlet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAE, 0xFD, 0x24, 0xAE,
                0xC6, 0x03,
                0xD1, 0x11,
                0x8B,
                0x76,
                0x00,
                0x80,
                0xC7,
                0x44,
                0xF3,
                0x89
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLEmbed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5D, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLAreasCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCA, 0xF4, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLMapElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x71, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLAreaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x83, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLTableCaption
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEC, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLCommentElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLPhraseElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6E, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLSpanElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF5, 0xF3, 0x50, 0x30,
                0xB4, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLTable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6B, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLTableCol
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6C, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLTableSection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE9, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLTableRow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6D, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLTableCell
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x46, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLScriptElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8C, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLNoShowElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8B, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLObjectElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4E, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLParamElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3E, 0xF8, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLFrameBase
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x12, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLFrameElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x14, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLIFrame
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x16, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDivPosition
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x49, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLFieldSetElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE8, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLLegendElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE9, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLSpanFlow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE6, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLFrameSetSite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1A, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLBGsound
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x70, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLStyleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7D, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLStyleFontFace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD4, 0xF3, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_XDomainRequest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x55, 0x04, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_XDomainRequestFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x57, 0x04, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLStorage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x75, 0x04, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBB, 0x04, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMUIEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCB, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMMouseEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCF, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMDragEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x62, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMMouseWheelEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD1, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMWheelEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD3, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMTextEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD5, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMKeyboardEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD7, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMCompositionEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD9, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMMutationEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDB, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMBeforeUnloadEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x64, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMFocusEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCD, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMCustomEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDF, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CanvasGradient
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x15, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CanvasPattern
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CanvasTextMetrics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x19, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CanvasImageData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1B, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CanvasRenderingContext2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLCanvasElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE5, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMProgressEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1F, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMMessageEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x21, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMSiteModeEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x66, 0x07, 0x51, 0x30,
                0xB6, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMStorageEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x23, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_XMLHttpRequestEventTarget
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x31, 0x08, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLXMLHttpRequest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0B, 0x04, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLXMLHttpRequestFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0D, 0x04, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAngle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x84, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAnimatedAngle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE4, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAnimatedTransformList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB1, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAnimatedBoolean
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8B, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAnimatedEnumeration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8E, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAnimatedInteger
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8F, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAnimatedLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x81, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAnimatedLengthList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x82, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAnimatedNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x88, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAnimatedNumberList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8A, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAnimatedRect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x86, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAnimatedString
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8C, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGClipPathElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE6, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x64, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7E, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGLengthList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x80, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGMatrix
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAE, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x87, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGNumberList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x89, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPatternElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD4, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSeg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB3, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegArcAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBB, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegArcRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBC, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegClosePath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBD, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegMovetoAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCC, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegMovetoRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCD, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegLinetoAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC6, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegLinetoRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC9, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegCurvetoCubicAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBE, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegCurvetoCubicRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBF, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegCurvetoCubicSmoothAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC0, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegCurvetoCubicSmoothRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC1, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegCurvetoQuadraticAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC2, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegCurvetoQuadraticRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC3, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegCurvetoQuadraticSmoothAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC4, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegCurvetoQuadraticSmoothRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC5, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegLinetoHorizontalAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC7, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegLinetoHorizontalRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC8, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegLinetoVerticalAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCA, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegLinetoVerticalRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCB, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathSegList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB4, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBA, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPointList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB9, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGRect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x83, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGStringList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8D, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGTransform
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAF, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGSVGElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x74, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGUseElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x90, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLStyleSheetRulesAppliedCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x45, 0xF8, 0x36, 0xEB,
                0x95, 0x23,
                0x19, 0x47,
                0xB8,
                0x5C,
                0xD0,
                0xD8,
                0x0E,
                0x18,
                0x4B,
                0xD9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_RulesApplied
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0x39, 0x80, 0x7C,
                0x53, 0x7A,
                0x26, 0x4D,
                0x98,
                0xAC,
                0xFD,
                0xD2,
                0x3E,
                0x6B,
                0x9E,
                0x01
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_RulesAppliedCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEE, 0x26, 0x19, 0x67,
                0xCF, 0xC3,
                0xAF, 0x40,
                0xBE,
                0x8F,
                0x1C,
                0xBA,
                0xEE,
                0x64,
                0x86,
                0xE8
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLW3CComputedStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC8, 0x06, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGTransformList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB0, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGCircleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x78, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGEllipseElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x79, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGLineElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7A, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGRectElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x77, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPolygonElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7B, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPolylineElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7C, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGGElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6F, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGSymbolElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x71, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGDefsElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x70, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPathElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB2, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGPreserveAspectRatio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD0, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGTextElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDF, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAnimatedPreserveAspectRatio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCE, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGImageElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCF, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGStopElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD5, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGGradientElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD6, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGLinearGradientElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD2, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGRadialGradientElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD3, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGMaskElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE7, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGMarkerElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDE, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGZoomEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD9, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGAElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDB, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGViewElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDC, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLMediaError
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0A, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLTimeRanges
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0B, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLMediaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0C, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLSourceElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0D, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLAudioElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0E, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLAudioElementFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEC, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLVideoElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0F, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGSwitchElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD8, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGDescElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x72, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGTitleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x73, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGMetadataElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD7, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGElementInstance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x75, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGElementInstanceList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x76, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2C, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_RangeException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2E, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x30, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_EventException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3B, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGScriptElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE1, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGStyleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD1, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGTextContentElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDD, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGTextPositioningElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMDocumentType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x39, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_NodeIterator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x45, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_TreeWalker
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x47, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMProcessingInstruction
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x43, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLPerformance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4F, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLPerformanceNavigation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x51, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLPerformanceTiming
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x53, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGTSpanElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE2, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CTemplatePrinter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB3, 0xF6, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CPrintManagerTemplatePrinter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x54, 0x9F, 0x61, 0x63,
                0x71, 0x9D,
                0x23, 0x4C,
                0xA0,
                0x8D,
                0x50,
                0xD7,
                0xF1,
                0x8D,
                0xB2,
                0xE9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SVGTextPathElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEB, 0x05, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_XMLSerializer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7E, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMParser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x82, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDOMXmlSerializerFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x80, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMParserFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x84, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLSemanticElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB0, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLProgressElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD5, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMMSTransitionEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB6, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMMSAnimationEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB8, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_WebGeolocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC6, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_WebGeocoordinates
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC8, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_WebGeopositionError
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCA, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_WebGeoposition
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCE, 0x07, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_CClientCaps
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4E, 0xC4, 0x8B, 0x7E,
                0xFF, 0xAE,
                0xD1, 0x11,
                0x89,
                0xC2,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0xBF,
                0xC4
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMMSManipulationEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0x08, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_DOMCloseEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0x08, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ApplicationCache
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x29, 0x08, 0x51, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HtmlDlgSafeHelper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x19, 0xF8, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_BlockFormats
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x31, 0xF8, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FontNames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3A, 0xF8, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLNamespace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBC, 0xF6, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLNamespaceCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB9, 0xF6, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ThreadDialogProcParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEB, 0xF5, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLDialog
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8A, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLPopup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x67, 0xF6, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLAppBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCB, 0xF5, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_OldHTMLDocument
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC9, 0x6E, 0x8A, 0xD4,
                0x4A, 0x6A,
                0xCF, 0x11,
                0x94,
                0xA7,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_OldHTMLFormElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x85, 0xD2, 0x04, 0x0D,
                0xEC, 0x6B,
                0xCF, 0x11,
                0x8B,
                0x97,
                0x00,
                0xAA,
                0x00,
                0x47,
                0x6D,
                0xA6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLInputButtonElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB4, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLInputTextElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAB, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLInputFileElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAE, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLOptionButtonElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBE, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_HTMLInputImage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC4, 0xF2, 0x50, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
