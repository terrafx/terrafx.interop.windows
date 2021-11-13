// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("C081FE77-2FD1-41AC-A5A3-34983C4BA61A")]
    [NativeTypeName("struct IDWriteFontFaceReference1 : IDWriteFontFaceReference")]
    [NativeInheritance("IDWriteFontFaceReference")]
    public unsafe partial struct IDWriteFontFaceReference1 : IDWriteFontFaceReference1.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, uint>)(lpVtbl[1]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, uint>)(lpVtbl[2]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateFontFace(IDWriteFontFace3** fontFace)
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, IDWriteFontFace3**, int>)(lpVtbl[3]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateFontFaceWithSimulations(DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace3** fontFace)
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, DWRITE_FONT_SIMULATIONS, IDWriteFontFace3**, int>)(lpVtbl[4]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFaceSimulationFlags, fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public BOOL Equals(IDWriteFontFaceReference* fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, IDWriteFontFaceReference*, int>)(lpVtbl[5]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFaceIndex()
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, uint>)(lpVtbl[6]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[7]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetFontFile(IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("UINT64")]
        public ulong GetLocalFileSize()
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, ulong>)(lpVtbl[9]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("UINT64")]
        public ulong GetFileSize()
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, ulong>)(lpVtbl[10]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetFileTime(FILETIME* lastWriteTime)
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, FILETIME*, int>)(lpVtbl[11]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), lastWriteTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public DWRITE_LOCALITY GetLocality()
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, DWRITE_LOCALITY>)(lpVtbl[12]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT EnqueueFontDownloadRequest()
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, int>)(lpVtbl[13]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT EnqueueCharacterDownloadRequest([NativeTypeName("const WCHAR *")] ushort* characters, [NativeTypeName("UINT32")] uint characterCount)
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, ushort*, uint, int>)(lpVtbl[14]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), characters, characterCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT EnqueueGlyphDownloadRequest([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount)
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, ushort*, uint, int>)(lpVtbl[15]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT EnqueueFileFragmentDownloadRequest([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize)
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, ulong, ulong, int>)(lpVtbl[16]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CreateFontFace(IDWriteFontFace5** fontFace)
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, IDWriteFontFace5**, int>)(lpVtbl[17]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontAxisValueCount()
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, uint>)(lpVtbl[18]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetFontAxisValues(DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return ((delegate* unmanaged<IDWriteFontFaceReference1*, DWRITE_FONT_AXIS_VALUE*, uint, int>)(lpVtbl[19]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }

        public interface Interface : IDWriteFontFaceReference.Interface
        {
            [VtblIndex(17)]
            HRESULT CreateFontFace(IDWriteFontFace5** fontFace);

            [VtblIndex(18)]
            [return: NativeTypeName("UINT32")]
            uint GetFontAxisValueCount();

            [VtblIndex(19)]
            HRESULT GetFontAxisValues(DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, uint> Release;

            [NativeTypeName("HRESULT (IDWriteFontFace3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, IDWriteFontFace3**, int> CreateFontFace;

            [NativeTypeName("HRESULT (DWRITE_FONT_SIMULATIONS, IDWriteFontFace3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, DWRITE_FONT_SIMULATIONS, IDWriteFontFace3**, int> CreateFontFaceWithSimulations;

            [NativeTypeName("BOOL (IDWriteFontFaceReference *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public new delegate* unmanaged<IDWriteFontFaceReference1*, IDWriteFontFaceReference*, int> Equals;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, uint> GetFontFaceIndex;

            [NativeTypeName("DWRITE_FONT_SIMULATIONS () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, DWRITE_FONT_SIMULATIONS> GetSimulations;

            [NativeTypeName("HRESULT (IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, IDWriteFontFile**, int> GetFontFile;

            [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, ulong> GetLocalFileSize;

            [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, ulong> GetFileSize;

            [NativeTypeName("HRESULT (FILETIME *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, FILETIME*, int> GetFileTime;

            [NativeTypeName("DWRITE_LOCALITY () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, DWRITE_LOCALITY> GetLocality;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, int> EnqueueFontDownloadRequest;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, ushort*, uint, int> EnqueueCharacterDownloadRequest;

            [NativeTypeName("HRESULT (const UINT16 *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, ushort*, uint, int> EnqueueGlyphDownloadRequest;

            [NativeTypeName("HRESULT (UINT64, UINT64) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, ulong, ulong, int> EnqueueFileFragmentDownloadRequest;

            [NativeTypeName("HRESULT (IDWriteFontFace5 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, IDWriteFontFace5**, int> CreateFontFace1;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, uint> GetFontAxisValueCount;

            [NativeTypeName("HRESULT (DWRITE_FONT_AXIS_VALUE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFaceReference1*, DWRITE_FONT_AXIS_VALUE*, uint, int> GetFontAxisValues;
        }
    }
}
