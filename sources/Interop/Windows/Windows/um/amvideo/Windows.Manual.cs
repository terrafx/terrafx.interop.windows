// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [return: NativeTypeName("DWORD *")]
    public static uint* BITMASKS(VIDEOINFO* pbmi)
        => (uint*)((byte*)&pbmi->bmiHeader + pbmi->bmiHeader.biSize);

    public static bool BIT_MASKS_MATCH(VIDEOINFO* pbmi1, VIDEOINFO* pbmi2)
        => (pbmi1->dwBitMasks[iRED] == pbmi2->dwBitMasks[iRED])
        && (pbmi1->dwBitMasks[iGREEN] == pbmi2->dwBitMasks[iGREEN])
        && (pbmi1->dwBitMasks[iBLUE] == pbmi2->dwBitMasks[iBLUE]);

    [return: NativeTypeName("RGBQUAD *")]
    public static RGBQUAD* COLORS(VIDEOINFO* pbmi)
        => (RGBQUAD*)((byte*)&pbmi->bmiHeader + pbmi->bmiHeader.biSize);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint WIDTHBYTES(uint bits)
        => unchecked(((bits + 31u) & ~31u) / 8u);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint DIBWIDTHBYTES(BITMAPINFOHEADER bi)
        => WIDTHBYTES(unchecked((uint)bi.biWidth * bi.biBitCount));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint _DIBSIZE(BITMAPINFOHEADER bi)
        => unchecked(DIBWIDTHBYTES(bi) * (uint)bi.biHeight);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint DIBSIZE(BITMAPINFOHEADER bi)
    {
        uint size = _DIBSIZE(bi);
        return (bi.biHeight < 0) ? unchecked(0u - size) : size;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BITMAPINFOHEADER *")]
    public static BITMAPINFOHEADER* HEADER([NativeTypeName("PVIDEOINFOHEADER")] VIDEOINFOHEADER* pVideoInfo)
        => &pVideoInfo->bmiHeader;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint WIDTHBYTES_RAW(uint bits)
        => unchecked((bits + 7u) / 8u);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint RAWWIDTHBYTES(BITMAPINFOHEADER bi)
        => WIDTHBYTES_RAW(unchecked((uint)bi.biWidth * bi.biBitCount));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint _RAWSIZE(BITMAPINFOHEADER bi)
        => unchecked(RAWWIDTHBYTES(bi) * (uint)bi.biHeight);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint RAWSIZE(BITMAPINFOHEADER bi)
    {
        uint size = _RAWSIZE(bi);
        return (bi.biHeight < 0) ? unchecked(0u - size) : size;
    }

    [NativeTypeName("#define SIZE_PREHEADER FIELD_OFFSET(VIDEOINFOHEADER, bmiHeader)")]
    public static uint SIZE_PREHEADER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out VIDEOINFOHEADER tmp);
            return unchecked((uint)(&tmp.bmiHeader) - (uint)(&tmp));
        }
    }

    [NativeTypeName("#define SIZE_VIDEOHEADER (sizeof(BITMAPINFOHEADER) + SIZE_PREHEADER)")]
    public static uint SIZE_VIDEOHEADER => (uint)sizeof(BITMAPINFOHEADER) + SIZE_PREHEADER;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint PALETTE_ENTRIES([NativeTypeName("PVIDEOINFOHEADER")] VIDEOINFOHEADER* pbmi)
        => 1u << pbmi->bmiHeader.biBitCount;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool PALETTISED([NativeTypeName("PVIDEOINFOHEADER")] VIDEOINFOHEADER* pbmi)
        => pbmi->bmiHeader.biBitCount <= iPALETTE;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void* RESET_HEADER([NativeTypeName("PVIDEOINFOHEADER")] VIDEOINFOHEADER* pbmi)
    {
        NativeMemory.Fill(pbmi, SIZE_VIDEOHEADER, 0);
        return pbmi;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void* RESET_MASKS(VIDEOINFO* pbmi)
    {
        // The SDK macro names a nonexistent dwBitFields member; VIDEOINFO exposes dwBitMasks.
        uint* bitMasks = BITMASKS(pbmi);
        NativeMemory.Fill(bitMasks, SIZE_MASKS, 0);
        return bitMasks;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void* RESET_PALETTE(VIDEOINFO* pbmi)
    {
        RGBQUAD* colors = COLORS(pbmi);
        NativeMemory.Fill(colors, SIZE_PALETTE, 0);
        return colors;
    }

    [return: NativeTypeName("TRUECOLORINFO *")]
    public static TRUECOLORINFO* TRUECOLOR(VIDEOINFO* pbmi)
        => (TRUECOLORINFO*)((byte*)&pbmi->bmiHeader + pbmi->bmiHeader.biSize);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint SIZE_MPEG1VIDEOINFO(MPEG1VIDEOINFO* pv)
    {
        Unsafe.SkipInit(out MPEG1VIDEOINFO tmp);
        uint offset = unchecked((uint)(&tmp.bSequenceHeader.e0) - (uint)(&tmp));
        return unchecked(offset + pv->cbSequenceHeader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const BYTE *")]
    public static byte* MPEG1_SEQUENCE_INFO(MPEG1VIDEOINFO* pv)
        => &pv->bSequenceHeader.e0;
}
