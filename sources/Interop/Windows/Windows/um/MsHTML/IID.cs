// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IHTMLFiltersCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEE, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIE70DispatchEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6B, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIE80DispatchEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6C, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEventObj
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2D, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x27, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x25, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x29, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSiteOM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x89, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorRender
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAA, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSiteRender
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA7, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBA, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMConstructor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9B, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x57, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSStyleDeclaration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x40, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSStyleDeclaration2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD1, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSStyleDeclaration3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5C, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSStyleDeclaration4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3B, 0x0F, 0x10, 0xD6,
                0xC8, 0x27,
                0x32, 0x41,
                0xAF,
                0xEA,
                0xF0,
                0xE4,
                0xB1,
                0xE0,
                0x00,
                0x60
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC2, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCSSStyleDeclaration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9A, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCSSStyleDeclaration
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

    public static ref readonly Guid IID_IHTMLStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5E, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyle2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA2, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyle3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x56, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyle4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x16, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyle5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3A, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyle6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x80, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRuleStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCF, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRuleStyle2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAC, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRuleStyle3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x57, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRuleStyle4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRuleStyle5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x35, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRuleStyle6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x71, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5A, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyle
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

    public static ref readonly Guid IID_DispHTMLRuleStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5C, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLRuleStyle
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

    public static ref readonly Guid IID_IHTMLStyleSheetRulesCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE5, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE3, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE9, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSImportRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEA, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSMediaRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEB, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSMediaList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x31, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSNamespaceRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEE, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMSCSSKeyframeRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0C, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMSCSSKeyframesRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0D, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCSSRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7D, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCSSRule
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

    public static ref readonly Guid IID_DispHTMLCSSImportRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7E, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCSSImportRule
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

    public static ref readonly Guid IID_DispHTMLCSSMediaRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7F, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCSSMediaRule
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

    public static ref readonly Guid IID_DispHTMLCSSMediaList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x97, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCSSMediaList
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

    public static ref readonly Guid IID_DispHTMLCSSNamespaceRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x80, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCSSNamespaceRule
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

    public static ref readonly Guid IID_DispHTMLMSCSSKeyframeRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDE, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMSCSSKeyframeRule
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

    public static ref readonly Guid IID_DispHTMLMSCSSKeyframesRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDF, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMSCSSKeyframesRule
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

    public static ref readonly Guid IID_IHTMLRenderStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAE, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLRenderStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8B, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLRenderStyle
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

    public static ref readonly Guid IID_IHTMLCurrentStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDB, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCurrentStyle2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x58, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCurrentStyle3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x18, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCurrentStyle4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3B, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCurrentStyle5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x81, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCurrentStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x57, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCurrentStyle
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

    public static ref readonly Guid IID_IHTMLElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFF, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA3, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRect2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6C, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRectCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA4, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1F, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x34, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAttributeCollection3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x69, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMDocumentType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x38, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB8, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMNode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDA, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMNode2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0B, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMNode3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMAttribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB0, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMAttribute2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x10, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMAttribute3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x68, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMAttribute4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF9, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMTextNode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB1, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMTextNode2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x09, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMTextNode3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3E, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMImplementation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0D, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMImplementation2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3C, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDOMAttribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x64, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDOMAttribute
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

    public static ref readonly Guid IID_DispHTMLDOMTextNode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x65, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDOMTextNode
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

    public static ref readonly Guid IID_DispHTMLDOMImplementation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8F, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDOMImplementation
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

    public static ref readonly Guid IID_IHTMLAttributeCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC3, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAttributeCollection2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0A, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAttributeCollection4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFA, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMChildrenCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAB, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMChildrenCollection2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x91, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLAttributeCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6C, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAttributeCollection
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

    public static ref readonly Guid IID_DispStaticNodeList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9B, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_StaticNodeList
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

    public static ref readonly Guid IID_DispDOMChildrenCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x77, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMChildrenCollection
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

    public static ref readonly Guid IID_HTMLElementEvents4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5E, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLElementEvents3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9F, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLElementEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0F, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLElementEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3C, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRulesAppliedCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBE, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x73, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0F, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementSelector
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x63, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementRender
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x69, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLUniqueName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD0, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5D, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF8, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAA, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementAppliedStyles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBD, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementTraversal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x36, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDatabinding
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF2, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0xC5, 0x6F, 0x62,
                0x1E, 0xA4,
                0xCF, 0x11,
                0xA7,
                0x31,
                0x00,
                0xA0,
                0xC9,
                0x08,
                0x26,
                0x37
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementDefaults
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC9, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDefaults
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8C, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDefaults
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

    public static ref readonly Guid IID_IHTCDefaultDispatch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFD, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCPropertyBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDF, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCMethodBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x31, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCEventBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFF, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCAttachBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF4, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCAttachBehavior2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEB, 0xF7, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCDescBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDC, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTCDefaultDispatch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x73, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTCDefaultDispatch
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

    public static ref readonly Guid IID_DispHTCPropertyBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7F, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTCPropertyBehavior
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

    public static ref readonly Guid IID_DispHTCMethodBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x87, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTCMethodBehavior
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

    public static ref readonly Guid IID_DispHTCEventBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x74, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTCEventBehavior
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

    public static ref readonly Guid IID_DispHTCAttachBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x83, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTCAttachBehavior
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

    public static ref readonly Guid IID_DispHTCDescBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7E, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTCDescBehavior
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

    public static ref readonly Guid IID_IHTMLUrnCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE2, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLUrnCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x51, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLUrnCollection
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

    public static ref readonly Guid IID_IHTMLGenericElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB7, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLGenericElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x63, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLGenericElement
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

    public static ref readonly Guid IID_IHTMLStyleSheetRuleApplied
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC1, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetRule2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFD, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetRulesCollection2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE8, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleSheetRule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0E, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheetRule
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

    public static ref readonly Guid IID_DispHTMLStyleSheetRulesCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2F, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheetRulesCollection
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

    public static ref readonly Guid IID_IHTMLStyleSheetPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEE, 0xF7, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetPage2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xED, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetPagesCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF0, 0xF7, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleSheetPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x40, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheetPage
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

    public static ref readonly Guid IID_DispHTMLStyleSheetPagesCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x43, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheetPagesCollection
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

    public static ref readonly Guid IID_IHTMLStyleSheetsCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7E, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheet2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD1, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheet3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x96, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheet4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF4, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleSheet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8D, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheet
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

    public static ref readonly Guid IID_IHTMLStyleSheetsCollection2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE7, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleSheetsCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x47, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheetsCollection
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

    public static ref readonly Guid IID_HTMLLinkElementEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1D, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLinkElementEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCC, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLinkElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x05, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLinkElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE5, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLinkElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1E, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLinkElement4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3A, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLinkElement5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x26, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLLinkElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x24, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLinkElement
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

    public static ref readonly Guid IID_IHTMLTxtRange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTextRangeMetrics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0B, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTextRangeMetrics2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA6, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTxtRangeCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xED, 0xF7, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMRange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAE, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDOMRange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA3, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDOMRange
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

    public static ref readonly Guid IID_HTMLFormElementEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x14, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFormElementEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x64, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFormElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF7, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFormElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF6, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFormElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x36, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSubmitData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x45, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFormElement4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2C, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLFormElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x10, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFormElement
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

    public static ref readonly Guid IID_HTMLControlElementEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x12, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLControlElementEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEA, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLControlElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE9, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTextElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x18, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTextElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x37, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTextElement
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

    public static ref readonly Guid IID_HTMLTextContainerEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x24, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTextContainerEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x72, 0xAA, 0xF6, 0x1F,
                0x42, 0x58,
                0xCF, 0x11,
                0xA7,
                0x07,
                0x00,
                0xAA,
                0x00,
                0xC0,
                0x09,
                0x8D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTextContainer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x30, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLControlRange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9C, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLControlRange2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5E, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLImgEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x16, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLImgEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5B, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLImgElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x40, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLImgElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x26, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLImgElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x34, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLImgElement4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF6, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMSImgElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x93, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLImageElementFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8E, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLImg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1C, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLImg
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

    public static ref readonly Guid IID_HTMLImageElementFactory
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

    public static ref readonly Guid IID_IHTMLBodyElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD8, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBodyElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC5, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBodyElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x22, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBodyElement4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x95, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBodyElement5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x22, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLBody
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x07, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLBody
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

    public static ref readonly Guid IID_IHTMLFontElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD9, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLFontElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x12, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFontElement
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

    public static ref readonly Guid IID_HTMLAnchorEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x10, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAnchorEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9D, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAnchorElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDA, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAnchorElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x25, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAnchorElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1D, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLAnchorElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x02, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAnchorElement
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

    public static ref readonly Guid IID_HTMLLabelEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1C, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLabelEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x29, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLabelElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2A, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLabelElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x32, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLLabelElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x22, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLabelElement
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

    public static ref readonly Guid IID_IHTMLListElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0E, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLListElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x22, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLListElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x25, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLListElement
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

    public static ref readonly Guid IID_IHTMLUListElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDD, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLUListElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x38, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLUListElement
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

    public static ref readonly Guid IID_IHTMLOListElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDE, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLOListElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2A, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLOListElement
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

    public static ref readonly Guid IID_IHTMLLIElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLLIElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x23, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLIElement
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

    public static ref readonly Guid IID_IHTMLBlockElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x08, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBlockElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x23, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBlockElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x94, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLBlockElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x06, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLBlockElement
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

    public static ref readonly Guid IID_IHTMLDivElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDivElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0C, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDivElement
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

    public static ref readonly Guid IID_IHTMLDDElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF2, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDDElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0B, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDDElement
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

    public static ref readonly Guid IID_IHTMLDTElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF3, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDTElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0D, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDTElement
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

    public static ref readonly Guid IID_IHTMLBRElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF0, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLBRElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3A, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLBRElement
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

    public static ref readonly Guid IID_IHTMLDListElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF1, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDListElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3B, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDListElement
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

    public static ref readonly Guid IID_IHTMLHRElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF4, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLHRElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3D, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLHRElement
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

    public static ref readonly Guid IID_IHTMLParaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF5, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLParaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2C, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLParaElement
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

    public static ref readonly Guid IID_IHTMLElementCollection2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEE, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementCollection3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x35, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementCollection4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x25, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLElementCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6B, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLElementCollection
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

    public static ref readonly Guid IID_IHTMLHeaderElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF6, 0xF1, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLHeaderElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x15, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLHeaderElement
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

    public static ref readonly Guid IID_HTMLSelectElementEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x22, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSelectElementEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x02, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOptionElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x11, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectElementEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD1, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x44, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xED, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectElement4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x38, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectElement5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9D, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectElement6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x60, 0x07, 0x51, 0x30,
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

    public static ref readonly Guid IID_DispHTMLSelectElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x31, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSelectElement
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

    public static ref readonly Guid IID_DispHTMLWndSelectElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x97, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWndSelectElement
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

    public static ref readonly Guid IID_IHTMLSelectionObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5A, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectionObject2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEC, 0xF7, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB6, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOptionElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOptionElement4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB4, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOptionElementFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8C, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLOptionElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2B, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLOptionElement
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

    public static ref readonly Guid IID_HTMLOptionElementFactory
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

    public static ref readonly Guid IID_DispHTMLWndOptionElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x98, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWndOptionElement
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

    public static ref readonly Guid IID_HTMLButtonElementEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLButtonElementEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB3, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputTextElementEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x18, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLOptionButtonElementEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x19, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputFileElementEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1A, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputImageEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1B, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputTextElementEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA7, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLOptionButtonElementEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBD, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputFileElementEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAF, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputImageEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC3, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD2, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x21, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x35, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputButtonElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB2, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputHiddenElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA4, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputTextElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA6, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputTextElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD2, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputFileElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAD, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOptionButtonElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBC, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputImage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC2, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputRangeElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD4, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLInputElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7D, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputElement
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

    public static ref readonly Guid IID_IHTMLTextAreaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAA, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTextAreaElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD3, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTextAreaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x21, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTextAreaElement
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

    public static ref readonly Guid IID_DispHTMLRichtextElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLRichtextElement
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

    public static ref readonly Guid IID_IHTMLButtonElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBB, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLButtonElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF3, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLButtonElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1F, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLButtonElement
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

    public static ref readonly Guid IID_HTMLMarqueeElementEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1F, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMarqueeElementEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB8, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMarqueeElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB5, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLMarqueeElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x27, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMarqueeElement
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

    public static ref readonly Guid IID_IHTMLHtmlElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1C, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLHeadElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1D, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLHeadElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2F, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTitleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x22, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMetaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x03, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMetaElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1F, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMetaElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x95, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBaseElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x04, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBaseElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLHtmlElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x60, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLHtmlElement
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

    public static ref readonly Guid IID_DispHTMLHeadElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x61, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLHeadElement
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

    public static ref readonly Guid IID_DispHTMLTitleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x16, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTitleElement
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

    public static ref readonly Guid IID_DispHTMLMetaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMetaElement
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

    public static ref readonly Guid IID_DispHTMLBaseElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x18, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLBaseElement
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

    public static ref readonly Guid IID_IHTMLIsIndexElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x06, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLIsIndexElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2F, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLNextIdElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x07, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLIsIndexElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x19, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLIsIndexElement
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

    public static ref readonly Guid IID_DispHTMLNextIdElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1A, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLNextIdElement
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

    public static ref readonly Guid IID_IHTMLBaseFontElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x02, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLBaseFontElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x04, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLBaseFontElement
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

    public static ref readonly Guid IID_IHTMLUnknownElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x09, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLUnknownElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x39, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLUnknownElement
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

    public static ref readonly Guid IID_IWebGeolocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC5, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMimeTypesCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFC, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPluginsCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFD, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOmHistory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA2, 0xAA, 0xCE, 0xFE,
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

    public static ref readonly Guid IID_IHTMLOpsProfile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x01, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOmNavigator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA5, 0xAA, 0xCE, 0xFE,
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

    public static ref readonly Guid IID_INavigatorGeolocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCF, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_INavigatorDoNotTrack
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x04, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0xB1, 0x3B, 0x16,
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

    public static ref readonly Guid IID_DispHTMLHistory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x49, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLHistory
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

    public static ref readonly Guid IID_COpsProfile
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

    public static ref readonly Guid IID_DispHTMLNavigator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4C, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLNavigator
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

    public static ref readonly Guid IID_DispHTMLLocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4E, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLocation
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

    public static ref readonly Guid IID_CMimeTypes
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

    public static ref readonly Guid IID_DispCPlugins
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4A, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CPlugins
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

    public static ref readonly Guid IID_IHTMLBookmarkCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCE, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDataTransfer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB3, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEventObj2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8B, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEventObj3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x80, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEventObj4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x14, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEventObj5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x78, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEventObj6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x34, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispCEventObj
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x58, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CEventObj
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

    public static ref readonly Guid IID_IHTMLStyleMedia
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4B, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleMedia
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9E, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleMedia
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

    public static ref readonly Guid IID_IHTMLFramesCollection2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x26, 0x44, 0x2C, 0x33,
                0xCB, 0x26,
                0xD0, 0x11,
                0xB4,
                0x83,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x01,
                0x19
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_FramesCollection
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

    public static ref readonly Guid IID_HTMLWindowEvents3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA1, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWindowEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x25, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWindowEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0xA4, 0xA0, 0x96,
                0x62, 0xD0,
                0xCF, 0x11,
                0x94,
                0xB6,
                0x00,
                0xAA,
                0x00,
                0x60,
                0x27,
                0x5C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x25, 0x44, 0x2C, 0x33,
                0xCB, 0x26,
                0xD0, 0x11,
                0xB4,
                0x83,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x01,
                0x19
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x27, 0x44, 0x2C, 0x33,
                0xCB, 0x26,
                0xD0, 0x11,
                0xB4,
                0x83,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x01,
                0x19
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAE, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameBase
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x11, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStorage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x74, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPerformance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4E, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLApplicationCache
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x28, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScreen
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5C, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScreen2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4A, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScreen3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA1, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScreen4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6B, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCF, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0E, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x53, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB7, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAB, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLScreen
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x91, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLScreen
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

    public static ref readonly Guid IID_DispHTMLWindow2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5D, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWindow2
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

    public static ref readonly Guid IID_DispHTMLWindowProxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5E, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWindowProxy
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

    public static ref readonly Guid IID_IHTMLDocumentCompatibleInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1A, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocumentCompatibleInfoCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x18, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDocumentCompatibleInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3E, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocumentCompatibleInfo
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

    public static ref readonly Guid IID_DispHTMLDocumentCompatibleInfoCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3F, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocumentCompatibleInfoCollection
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

    public static ref readonly Guid IID_HTMLDocumentEvents4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x37, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocumentEvents3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA0, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocumentEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x13, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocumentEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x60, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGSVGElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE7, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMNodeIterator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x46, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMTreeWalker
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x48, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMProcessingInstruction
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x42, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x85, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9A, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0C, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD0, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDocumentEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBC, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDocumentRange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAF, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDocumentSelector
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x62, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDocumentTraversal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x44, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDocument
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5F, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocument
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

    public static ref readonly Guid IID_DWebBridgeEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFF, 0x97, 0xD8, 0xA6,
                0x95, 0x0A,
                0xD1, 0x11,
                0xB0,
                0xBA,
                0x00,
                0x60,
                0x08,
                0x16,
                0x6E,
                0x11
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebBridge
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAD, 0xFD, 0x24, 0xAE,
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

    public static ref readonly Guid IID_IWBScriptControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x70, 0x08, 0x17, 0xA5,
                0xF8, 0x0C,
                0xD1, 0x11,
                0x8B,
                0x91,
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

    public static ref readonly Guid IID_Scriptlet
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

    public static ref readonly Guid IID_IHTMLEmbedElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5F, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEmbedElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x93, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLEmbed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2E, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLEmbed
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

    public static ref readonly Guid IID_HTMLMapEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1E, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMapEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBA, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAreasCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x83, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAreasCollection2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEC, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAreasCollection3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x37, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAreasCollection4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x92, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMapElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x66, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLAreasCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6A, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAreasCollection
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

    public static ref readonly Guid IID_DispHTMLMapElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x26, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMapElement
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

    public static ref readonly Guid IID_HTMLAreaEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x11, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAreaEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x66, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAreaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x65, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAreaElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1F, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLAreaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x03, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAreaElement
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

    public static ref readonly Guid IID_IHTMLTableCaption
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEB, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTableCaption
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x08, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableCaption
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

    public static ref readonly Guid IID_IHTMLCommentElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0C, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCommentElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x13, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCommentElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3F, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCommentElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0A, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCommentElement
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

    public static ref readonly Guid IID_IHTMLPhraseElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0A, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPhraseElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x24, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPhraseElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3D, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSpanElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF3, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLPhraseElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2D, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLPhraseElement
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

    public static ref readonly Guid IID_DispHTMLSpanElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x48, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSpanElement
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

    public static ref readonly Guid IID_HTMLTableEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x23, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x07, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableSection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3B, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1E, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTable2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAD, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTable3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x29, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTable4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC2, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCol
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3A, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCol2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2A, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCol3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC4, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableSection2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC7, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableSection3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2B, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableSection4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC5, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableRow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3C, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableRow2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA1, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableRow3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2C, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableRow4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC6, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableRowMetrics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x13, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCell
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3D, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCell2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2D, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCell3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC7, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x32, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTable
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

    public static ref readonly Guid IID_DispHTMLTableCol
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x33, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableCol
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

    public static ref readonly Guid IID_DispHTMLTableSection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x34, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableSection
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

    public static ref readonly Guid IID_DispHTMLTableRow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x35, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableRow
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

    public static ref readonly Guid IID_DispHTMLTableCell
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x36, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableCell
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

    public static ref readonly Guid IID_HTMLScriptEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x21, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLScriptEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE2, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScriptElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8B, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScriptElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x28, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScriptElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x47, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScriptElement4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x01, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLScriptElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x30, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLScriptElement
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

    public static ref readonly Guid IID_IHTMLNoShowElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8A, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLNoShowElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x28, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLNoShowElement
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

    public static ref readonly Guid IID_HTMLObjectElementEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLObjectElementEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC4, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLObjectElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4F, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLObjectElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCD, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLObjectElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x27, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLObjectElement4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3E, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLObjectElement5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB5, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLParamElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3D, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLParamElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x44, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLObjectElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x29, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLObjectElement
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

    public static ref readonly Guid IID_DispHTMLParamElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x90, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLParamElement
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

    public static ref readonly Guid IID_HTMLFrameSiteEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFF, 0xF7, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFrameSiteEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameBase2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDB, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameBase3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2E, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLFrameBase
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x41, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFrameBase
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

    public static ref readonly Guid IID_IHTMLFrameElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x13, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF5, 0xF7, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2D, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLFrameElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x13, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFrameElement
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

    public static ref readonly Guid IID_IHTMLIFrameElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x15, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLIFrameElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE6, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLIFrameElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x33, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLIFrame
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1B, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLIFrame
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

    public static ref readonly Guid IID_IHTMLDivPosition
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x12, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFieldSetElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE7, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFieldSetElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x33, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLegendElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEA, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLegendElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x34, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDivPosition
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0F, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDivPosition
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

    public static ref readonly Guid IID_DispHTMLFieldSetElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x45, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFieldSetElement
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

    public static ref readonly Guid IID_DispHTMLLegendElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x46, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLegendElement
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

    public static ref readonly Guid IID_IHTMLSpanFlow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE5, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLSpanFlow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x44, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSpanFlow
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

    public static ref readonly Guid IID_IHTMLFrameSetElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x19, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameSetElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC6, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameSetElement3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x96, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLFrameSetSite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x14, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFrameSetSite
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

    public static ref readonly Guid IID_IHTMLBGsound
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x69, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLBGsound
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3C, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLBGsound
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

    public static ref readonly Guid IID_IHTMLFontNamesCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x76, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFontSizesCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x77, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOptionsHolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x78, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleElementEvents2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x15, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleElementEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCB, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x75, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2A, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x11, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleElement
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

    public static ref readonly Guid IID_IHTMLStyleFontFace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD5, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleFontFace2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEC, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleFontFace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x81, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleFontFace
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

    public static ref readonly Guid IID_IHTMLXDomainRequest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x54, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLXDomainRequestFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x56, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispXDomainRequest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x99, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_XDomainRequest
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

    public static ref readonly Guid IID_XDomainRequestFactory
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

    public static ref readonly Guid IID_IHTMLStorage2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x99, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStorage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9D, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStorage
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

    public static ref readonly Guid IID_IEventTarget
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB9, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA2, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMEvent
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

    public static ref readonly Guid IID_IDOMUIEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCA, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMUIEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x72, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMUIEvent
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

    public static ref readonly Guid IID_IDOMMouseEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCE, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMouseEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x73, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMouseEvent
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

    public static ref readonly Guid IID_IDOMDragEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x61, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMDragEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA7, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMDragEvent
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

    public static ref readonly Guid IID_IDOMMouseWheelEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD0, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMouseWheelEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x74, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMouseWheelEvent
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

    public static ref readonly Guid IID_IDOMWheelEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD2, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMWheelEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x75, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMWheelEvent
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

    public static ref readonly Guid IID_IDOMTextEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD4, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMTextEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x76, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMTextEvent
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

    public static ref readonly Guid IID_IDOMKeyboardEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD6, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMKeyboardEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x77, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMKeyboardEvent
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

    public static ref readonly Guid IID_IDOMCompositionEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD8, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMCompositionEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x78, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMCompositionEvent
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

    public static ref readonly Guid IID_IDOMMutationEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDA, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMutationEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x79, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMutationEvent
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

    public static ref readonly Guid IID_IDOMBeforeUnloadEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x63, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMBeforeUnloadEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA8, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMBeforeUnloadEvent
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

    public static ref readonly Guid IID_IDOMFocusEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCC, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMFocusEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x71, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMFocusEvent
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

    public static ref readonly Guid IID_IDOMCustomEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDE, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMCustomEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7C, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMCustomEvent
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

    public static ref readonly Guid IID_ICanvasGradient
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x14, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasPattern
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x16, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasTextMetrics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x18, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasImageData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1A, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasPixelArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1C, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCanvasElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE4, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasRenderingContext2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFF, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispCanvasGradient
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8C, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CanvasGradient
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

    public static ref readonly Guid IID_DispCanvasPattern
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8D, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CanvasPattern
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

    public static ref readonly Guid IID_DispCanvasTextMetrics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8E, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CanvasTextMetrics
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

    public static ref readonly Guid IID_DispCanvasImageData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8F, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CanvasImageData
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

    public static ref readonly Guid IID_DispCanvasRenderingContext2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x82, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CanvasRenderingContext2D
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

    public static ref readonly Guid IID_DispHTMLCanvasElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7B, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCanvasElement
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

    public static ref readonly Guid IID_IDOMProgressEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1E, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMProgressEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x91, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMProgressEvent
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

    public static ref readonly Guid IID_IDOMMessageEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMessageEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x92, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMessageEvent
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

    public static ref readonly Guid IID_IDOMSiteModeEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x65, 0x07, 0x51, 0x30,
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

    public static ref readonly Guid IID_DispDOMSiteModeEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA9, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMSiteModeEvent
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

    public static ref readonly Guid IID_IDOMStorageEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x22, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMStorageEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x93, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMStorageEvent
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

    public static ref readonly Guid IID_IXMLHttpRequestEventTarget
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x30, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispXMLHttpRequestEventTarget
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE7, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_XMLHttpRequestEventTarget
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

    public static ref readonly Guid IID_HTMLXMLHttpRequestEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x98, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLXMLHttpRequest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0A, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLXMLHttpRequest2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x82, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLXMLHttpRequestFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0C, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLXMLHttpRequest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x96, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLXMLHttpRequest
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

    public static ref readonly Guid IID_HTMLXMLHttpRequestFactory
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

    public static ref readonly Guid IID_ISVGAngle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD3, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAngle
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

    public static ref readonly Guid IID_ISVGElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC5, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGRect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD7, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGMatrix
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF6, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGStringList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC8, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedRect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD8, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedString
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC7, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedBoolean
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC6, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedTransformList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF9, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedPreserveAspectRatio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFB, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGStylable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDA, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGLocatable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDB, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTransformable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDC, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTests
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDD, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGLangSpace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDE, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGExternalResourcesRequired
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDF, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGFitToViewBox
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGZoomAndPan
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE1, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGURIReference
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE3, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedAngle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD4, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedAngle
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

    public static ref readonly Guid IID_ISVGTransformList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF8, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedTransformList
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

    public static ref readonly Guid IID_SVGAnimatedBoolean
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

    public static ref readonly Guid IID_ISVGAnimatedEnumeration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC9, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedEnumeration
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

    public static ref readonly Guid IID_ISVGAnimatedInteger
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCA, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedInteger
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

    public static ref readonly Guid IID_ISVGLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCF, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD0, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedLength
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

    public static ref readonly Guid IID_ISVGLengthList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD1, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedLengthList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD2, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedLengthList
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

    public static ref readonly Guid IID_ISVGNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCB, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCC, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedNumber
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

    public static ref readonly Guid IID_ISVGNumberList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCD, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedNumberList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCE, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedNumberList
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

    public static ref readonly Guid IID_SVGAnimatedRect
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

    public static ref readonly Guid IID_SVGAnimatedString
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

    public static ref readonly Guid IID_ISVGClipPathElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2D, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGClipPathElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3B, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGClipPathElement
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

    public static ref readonly Guid IID_ISVGDocument
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE6, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IGetSVGDocument
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAB, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGElement
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

    public static ref readonly Guid IID_IICCSVGColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD6, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGLength
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

    public static ref readonly Guid IID_SVGLengthList
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

    public static ref readonly Guid IID_SVGMatrix
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

    public static ref readonly Guid IID_SVGNumber
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

    public static ref readonly Guid IID_SVGNumberList
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

    public static ref readonly Guid IID_ISVGPaint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x24, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPatternElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2C, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPatternElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2C, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPatternElement
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

    public static ref readonly Guid IID_ISVGPathSeg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFC, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegArcAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x06, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegArcRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x07, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegClosePath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFD, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegMovetoAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFE, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegMovetoRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFF, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegLinetoAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegLinetoRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x01, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoCubicAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x02, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoCubicRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x03, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoCubicSmoothAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0C, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoCubicSmoothRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0D, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoQuadraticAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x04, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoQuadraticRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x05, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoQuadraticSmoothAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0E, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoQuadraticSmoothRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0F, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegLinetoHorizontalAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x08, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegLinetoHorizontalRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x09, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegLinetoVerticalAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0A, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegLinetoVerticalRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0B, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSeg
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

    public static ref readonly Guid IID_DispSVGPathSegArcAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x13, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegArcAbs
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

    public static ref readonly Guid IID_DispSVGPathSegArcRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x14, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegArcRel
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

    public static ref readonly Guid IID_DispSVGPathSegClosePath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x15, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegClosePath
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

    public static ref readonly Guid IID_DispSVGPathSegMovetoAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x24, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegMovetoAbs
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

    public static ref readonly Guid IID_DispSVGPathSegMovetoRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x25, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegMovetoRel
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

    public static ref readonly Guid IID_DispSVGPathSegLinetoAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1E, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegLinetoAbs
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

    public static ref readonly Guid IID_DispSVGPathSegLinetoRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x21, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegLinetoRel
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

    public static ref readonly Guid IID_DispSVGPathSegCurvetoCubicAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x16, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoCubicAbs
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

    public static ref readonly Guid IID_DispSVGPathSegCurvetoCubicRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoCubicRel
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

    public static ref readonly Guid IID_DispSVGPathSegCurvetoCubicSmoothAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x18, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoCubicSmoothAbs
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

    public static ref readonly Guid IID_DispSVGPathSegCurvetoCubicSmoothRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x19, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoCubicSmoothRel
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

    public static ref readonly Guid IID_DispSVGPathSegCurvetoQuadraticAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1A, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoQuadraticAbs
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

    public static ref readonly Guid IID_DispSVGPathSegCurvetoQuadraticRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1B, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoQuadraticRel
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

    public static ref readonly Guid IID_DispSVGPathSegCurvetoQuadraticSmoothAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1C, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoQuadraticSmoothAbs
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

    public static ref readonly Guid IID_DispSVGPathSegCurvetoQuadraticSmoothRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1D, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoQuadraticSmoothRel
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

    public static ref readonly Guid IID_DispSVGPathSegLinetoHorizontalAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1F, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegLinetoHorizontalAbs
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

    public static ref readonly Guid IID_DispSVGPathSegLinetoHorizontalRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegLinetoHorizontalRel
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

    public static ref readonly Guid IID_DispSVGPathSegLinetoVerticalAbs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x22, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegLinetoVerticalAbs
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

    public static ref readonly Guid IID_DispSVGPathSegLinetoVerticalRel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x23, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegLinetoVerticalRel
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

    public static ref readonly Guid IID_ISVGPathSegList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x10, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegList
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

    public static ref readonly Guid IID_ISVGPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF4, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPoint
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

    public static ref readonly Guid IID_ISVGPointList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF5, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPointList
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

    public static ref readonly Guid IID_SVGRect
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

    public static ref readonly Guid IID_SVGStringList
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

    public static ref readonly Guid IID_ISVGViewSpec
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE2, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTransform
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF7, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTransform
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

    public static ref readonly Guid IID_DispSVGSVGElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x01, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGSVGElement
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

    public static ref readonly Guid IID_ISVGElementInstance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEE, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGUseElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xED, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGUseElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x10, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGUseElement
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

    public static ref readonly Guid IID_IHTMLStyleSheetRulesAppliedCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC0, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRulesApplied
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBF, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleSheetRulesAppliedCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA6, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheetRulesAppliedCollection
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

    public static ref readonly Guid IID_DispRulesApplied
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA5, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_RulesApplied
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

    public static ref readonly Guid IID_DispRulesAppliedCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA4, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_RulesAppliedCollection
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

    public static ref readonly Guid IID_DispHTMLW3CComputedStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x70, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLW3CComputedStyle
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

    public static ref readonly Guid IID_SVGTransformList
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

    public static ref readonly Guid IID_ISVGAnimatedPoints
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGCircleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x14, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGEllipseElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x15, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGLineElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x16, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGRectElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x13, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPolygonElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x19, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPolylineElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x18, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGCircleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0A, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGCircleElement
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

    public static ref readonly Guid IID_DispSVGEllipseElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0B, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGEllipseElement
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

    public static ref readonly Guid IID_DispSVGLineElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0C, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGLineElement
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

    public static ref readonly Guid IID_DispSVGRectElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x09, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGRectElement
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

    public static ref readonly Guid IID_DispSVGPolygonElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0D, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPolygonElement
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

    public static ref readonly Guid IID_DispSVGPolylineElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0E, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPolylineElement
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

    public static ref readonly Guid IID_ISVGGElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE8, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGGElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x02, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGGElement
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

    public static ref readonly Guid IID_ISVGSymbolElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEC, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGSymbolElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x04, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGSymbolElement
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

    public static ref readonly Guid IID_ISVGDefsElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE9, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGDefsElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x03, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGDefsElement
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

    public static ref readonly Guid IID_ISVGAnimatedPathData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x11, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x12, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x11, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathElement
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

    public static ref readonly Guid IID_ISVGPreserveAspectRatio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFA, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPreserveAspectRatio
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

    public static ref readonly Guid IID_ISVGTextElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1C, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGTextElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x37, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTextElement
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

    public static ref readonly Guid IID_SVGAnimatedPreserveAspectRatio
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

    public static ref readonly Guid IID_ISVGImageElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF0, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGImageElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x27, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGImageElement
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

    public static ref readonly Guid IID_ISVGStopElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2B, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGStopElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2D, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGStopElement
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

    public static ref readonly Guid IID_ISVGGradientElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x28, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGGradientElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2E, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGGradientElement
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

    public static ref readonly Guid IID_ISVGLinearGradientElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x29, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGLinearGradientElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2A, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGLinearGradientElement
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

    public static ref readonly Guid IID_ISVGRadialGradientElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2A, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGRadialGradientElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2B, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGRadialGradientElement
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

    public static ref readonly Guid IID_ISVGMaskElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2E, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGMaskElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3C, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGMaskElement
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

    public static ref readonly Guid IID_ISVGMarkerElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x25, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGMarkerElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x36, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGMarkerElement
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

    public static ref readonly Guid IID_ISVGZoomEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4E, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGZoomEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x31, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGZoomEvent
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

    public static ref readonly Guid IID_ISVGAElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4B, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGAElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x33, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAElement
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

    public static ref readonly Guid IID_ISVGViewElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4C, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGViewElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x34, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGViewElement
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

    public static ref readonly Guid IID_IHTMLMediaError
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x04, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTimeRanges
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x05, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTimeRanges2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0B, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMediaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x06, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMediaElement2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x09, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMSMediaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x92, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSourceElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x07, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAudioElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x08, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLVideoElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x09, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAudioElementFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEB, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLMediaError
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x86, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMediaError
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

    public static ref readonly Guid IID_DispHTMLTimeRanges
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x87, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTimeRanges
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

    public static ref readonly Guid IID_DispHTMLMediaElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x88, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMediaElement
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

    public static ref readonly Guid IID_DispHTMLSourceElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x89, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSourceElement
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

    public static ref readonly Guid IID_DispHTMLAudioElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8A, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAudioElement
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

    public static ref readonly Guid IID_HTMLAudioElementFactory
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

    public static ref readonly Guid IID_DispHTMLVideoElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8B, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLVideoElement
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

    public static ref readonly Guid IID_ISVGSwitchElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF1, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGSwitchElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x30, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGSwitchElement
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

    public static ref readonly Guid IID_ISVGDescElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEA, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGDescElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x05, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGDescElement
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

    public static ref readonly Guid IID_ISVGTitleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEB, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGTitleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x06, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTitleElement
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

    public static ref readonly Guid IID_ISVGMetadataElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x60, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGMetadataElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2F, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGMetadataElement
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

    public static ref readonly Guid IID_ISVGElementInstanceList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEF, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGElementInstance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x07, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGElementInstance
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

    public static ref readonly Guid IID_DispSVGElementInstanceList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x08, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGElementInstanceList
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

    public static ref readonly Guid IID_IDOMException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2B, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x94, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMException
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

    public static ref readonly Guid IID_IRangeException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2D, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispRangeException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x95, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_RangeException
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

    public static ref readonly Guid IID_ISVGException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2F, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x96, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGException
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

    public static ref readonly Guid IID_IEventException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3A, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispEventException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x99, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_EventException
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

    public static ref readonly Guid IID_ISVGScriptElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGScriptElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x39, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGScriptElement
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

    public static ref readonly Guid IID_ISVGStyleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF3, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGStyleElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x29, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGStyleElement
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

    public static ref readonly Guid IID_ISVGTextContentElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1A, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGTextContentElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x35, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTextContentElement
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

    public static ref readonly Guid IID_ISVGTextPositioningElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1B, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGTextPositioningElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x38, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTextPositioningElement
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

    public static ref readonly Guid IID_DispDOMDocumentType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x98, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMDocumentType
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

    public static ref readonly Guid IID_DispNodeIterator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9C, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_NodeIterator
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

    public static ref readonly Guid IID_DispTreeWalker
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9D, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_TreeWalker
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

    public static ref readonly Guid IID_DispDOMProcessingInstruction
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9B, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMProcessingInstruction
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

    public static ref readonly Guid IID_IHTMLPerformanceNavigation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x50, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPerformanceTiming
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x52, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLPerformance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9F, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLPerformance
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

    public static ref readonly Guid IID_DispHTMLPerformanceNavigation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA0, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLPerformanceNavigation
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

    public static ref readonly Guid IID_DispHTMLPerformanceTiming
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA1, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLPerformanceTiming
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

    public static ref readonly Guid IID_ISVGTSpanElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1D, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGTSpanElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3A, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTSpanElement
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

    public static ref readonly Guid IID_ITemplatePrinter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB4, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITemplatePrinter2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3F, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITemplatePrinter3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA3, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintManagerTemplatePrinter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x14, 0xBE, 0x33, 0xF6,
                0xFF, 0x9E,
                0x4D, 0x4C,
                0x92,
                0x9E,
                0x05,
                0x71,
                0x7B,
                0x21,
                0xB3,
                0xE6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintManagerTemplatePrinter2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x97, 0x34, 0x40, 0xC6,
                0x93, 0x74,
                0x09, 0x4F,
                0x80,
                0x16,
                0x54,
                0xB0,
                0x3E,
                0x9B,
                0xDA,
                0x69
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CTemplatePrinter
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

    public static ref readonly Guid IID_DispCPrintManagerTemplatePrinter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE9, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CPrintManagerTemplatePrinter
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

    public static ref readonly Guid IID_ISVGTextPathElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1F, 0x05, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGTextPathElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3D, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTextPathElement
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

    public static ref readonly Guid IID_IDOMXmlSerializer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7D, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMParser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x81, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispXMLSerializer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAD, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_XMLSerializer
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

    public static ref readonly Guid IID_DispDOMParser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAE, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMParser
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

    public static ref readonly Guid IID_IDOMXmlSerializerFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7F, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMParserFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x83, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDOMXmlSerializerFactory
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

    public static ref readonly Guid IID_DOMParserFactory
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

    public static ref readonly Guid IID_DispHTMLSemanticElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBA, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSemanticElement
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

    public static ref readonly Guid IID_IHTMLProgressElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD6, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLProgressElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAF, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLProgressElement
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

    public static ref readonly Guid IID_IDOMMSTransitionEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB5, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMSTransitionEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBB, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMSTransitionEvent
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

    public static ref readonly Guid IID_IDOMMSAnimationEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB7, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMSAnimationEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBC, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMSAnimationEvent
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

    public static ref readonly Guid IID_IWebGeocoordinates
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC7, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebGeopositionError
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC9, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebGeoposition
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCD, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispWebGeolocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBD, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_WebGeolocation
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

    public static ref readonly Guid IID_DispWebGeocoordinates
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBE, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_WebGeocoordinates
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

    public static ref readonly Guid IID_DispWebGeopositionError
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBF, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_WebGeopositionError
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

    public static ref readonly Guid IID_DispWebGeoposition
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC1, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_WebGeoposition
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

    public static ref readonly Guid IID_IClientCaps
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0xC4, 0x8B, 0x7E,
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

    public static ref readonly Guid IID_CClientCaps
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

    public static ref readonly Guid IID_IDOMMSManipulationEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x16, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMSManipulationEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE1, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMSManipulationEvent
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

    public static ref readonly Guid IID_IDOMCloseEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFF, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMCloseEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDC, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMCloseEvent
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

    public static ref readonly Guid IID_DispApplicationCache
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE4, 0x00, 0x59, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ApplicationCache
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

    public static ref readonly Guid IID_ICSSFilterSite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xED, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupPointer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9F, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupContainer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF9, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupContainer2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x48, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLChangeLog
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x49, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLChangeSink
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4A, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISegmentList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x05, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISegmentListIterator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x92, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCaret
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x04, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISegment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x83, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementSegment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8F, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHighlightSegment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x90, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHighlightRenderingServices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x06, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ILineInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE2, 0xF7, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDisplayPointer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9E, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDisplayServices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9D, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHtmlDlgSafeHelper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1A, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBlockFormats
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x30, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFontNames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x39, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICSSFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEC, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISecureUrlHost
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC4, 0x84, 0x19, 0xC8,
                0xC8, 0x74,
                0xD2, 0x11,
                0xBA,
                0xA9,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0x04,
                0x0E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupServices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA0, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupServices2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x82, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLChangePlayback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupPointer2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x75, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupTextFrags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFA, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLGenericParse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x71, 0x30, 0xE2, 0xE4,
                0x07, 0x4D,
                0xD2, 0x11,
                0xAE,
                0x76,
                0x00,
                0x80,
                0xC7,
                0x3B,
                0xC1,
                0x99
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEditHost
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA0, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEditHost2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x48, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0D
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISequenceNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC1, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIMEServices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCA, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISelectionServicesListener
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x99, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISelectionServices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x84, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEditDesigner
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x62, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEditServices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x63, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEditServices2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x12, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLComputedStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC3, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HtmlDlgSafeHelper
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

    public static ref readonly Guid IID_BlockFormats
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

    public static ref readonly Guid IID_FontNames
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

    public static ref readonly Guid IID_IDeveloperConsoleMessageReceiver
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x08, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IScriptEventHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3A, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDebugCallbackNotificationHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x42, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IScriptEventHandlerSourceInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x41, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMEventRegistrationCallback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3B, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEventTarget2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x39, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLNamespaceEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBD, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLNamespace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBB, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLNamespaceCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB8, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLNamespace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4F, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLNamespace
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

    public static ref readonly Guid IID_DispHTMLNamespaceCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x50, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLNamespaceCollection
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

    public static ref readonly Guid IID_IHTMLPainter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA6, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPaintSite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA7, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPainterEventInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDF, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPainterOverlay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE3, 0xF7, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLIPrintCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB5, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumPrivacyRecords
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x44, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWPCBlockedUrls
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x13, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMConstructorCollection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9C, 0x04, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDialog
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x16, 0xF2, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDialog2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDialog3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x88, 0xF3, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLModelessInit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE4, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ThreadDialogProcParam
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

    public static ref readonly Guid IID_HTMLDialog
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

    public static ref readonly Guid IID_IHTMLPopup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x66, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLPopup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x89, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLPopup
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

    public static ref readonly Guid IID_IHTMLAppBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCA, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAppBehavior2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC9, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAppBehavior3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCD, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLAppBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x7C, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAppBehavior
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

    public static ref readonly Guid IID_OldHTMLDocument
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

    public static ref readonly Guid IID_OldHTMLFormElement
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

    public static ref readonly Guid IID_DispIHTMLInputButtonElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1E, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputButtonElement
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

    public static ref readonly Guid IID_DispIHTMLInputTextElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputTextElement
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

    public static ref readonly Guid IID_DispIHTMLInputFileElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x42, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputFileElement
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

    public static ref readonly Guid IID_DispIHTMLOptionButtonElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x09, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLOptionButtonElement
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

    public static ref readonly Guid IID_DispIHTMLInputImage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1D, 0xF5, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputImage
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

    public static ref readonly Guid IID_IElementNamespace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x71, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementNamespaceTable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x70, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementNamespaceFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x72, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementNamespaceFactory2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x05, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementNamespaceFactoryCallback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFD, 0xF7, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSiteOM2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x59, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xED, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSiteCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xEE, 0xF4, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSubmit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x46, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorFocus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB6, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorLayout
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBA, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorLayout2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x46, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSiteLayout
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB7, 0xF6, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSiteLayout2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x47, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHostBehaviorInit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x42, 0xF8, 0x50, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISurfacePresenter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE2, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IViewObjectPresentSite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE1, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasPixelArrayData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF9, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IViewObjectPrint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE3, 0x06, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IViewObjectPresentNotifySite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFA, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IViewObjectPresentNotify
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF8, 0x07, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITrackingProtection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x03, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBFCacheable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x61, 0x08, 0x51, 0x30,
                0xB5, 0x98,
                0xCF, 0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
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
