// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C081FE77-2FD1-41AC-A5A3-34983C4BA61A")]
    [NativeTypeName("struct IDWriteFontFaceReference1 : IDWriteFontFaceReference")]
    public unsafe partial struct IDWriteFontFaceReference1
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, uint>)(lpVtbl[1]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, uint>)(lpVtbl[2]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("IDWriteFontFace3 **")] IDWriteFontFace3** fontFace)
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, IDWriteFontFace3**, int>)(lpVtbl[3]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFace);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceWithSimulations(DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, [NativeTypeName("IDWriteFontFace3 **")] IDWriteFontFace3** fontFace)
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, DWRITE_FONT_SIMULATIONS, IDWriteFontFace3**, int>)(lpVtbl[4]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFaceSimulationFlags, fontFace);
        }

        [return: NativeTypeName("BOOL")]
        public int Equals([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference)
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, IDWriteFontFaceReference*, int>)(lpVtbl[5]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFaceIndex()
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, uint>)(lpVtbl[6]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[7]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFile([NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFile);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetLocalFileSize()
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, ulong>)(lpVtbl[9]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetFileSize()
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, ulong>)(lpVtbl[10]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileTime([NativeTypeName("FILETIME *")] FILETIME* lastWriteTime)
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, FILETIME*, int>)(lpVtbl[11]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), lastWriteTime);
        }

        public DWRITE_LOCALITY GetLocality()
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, DWRITE_LOCALITY>)(lpVtbl[12]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueFontDownloadRequest()
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, int>)(lpVtbl[13]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueCharacterDownloadRequest([NativeTypeName("const WCHAR *")] ushort* characters, [NativeTypeName("UINT32")] uint characterCount)
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, ushort*, uint, int>)(lpVtbl[14]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), characters, characterCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueGlyphDownloadRequest([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount)
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, ushort*, uint, int>)(lpVtbl[15]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueFileFragmentDownloadRequest([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize)
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, ulong, ulong, int>)(lpVtbl[16]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("IDWriteFontFace5 **")] IDWriteFontFace5** fontFace)
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, IDWriteFontFace5**, int>)(lpVtbl[17]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFace);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontAxisValueCount()
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, uint>)(lpVtbl[18]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisValues([NativeTypeName("DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return ((delegate* stdcall<IDWriteFontFaceReference1*, DWRITE_FONT_AXIS_VALUE*, uint, int>)(lpVtbl[19]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }
    }
}
