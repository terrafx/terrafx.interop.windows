// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C081FE77-2FD1-41AC-A5A3-34983C4BA61A")]
    public unsafe partial struct IDWriteFontFaceReference1
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontFaceReference1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontFaceReference1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontFaceReference1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFace(IDWriteFontFaceReference1* pThis, [NativeTypeName("IDWriteFontFace3 **")] IDWriteFontFace3** fontFace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFaceWithSimulations(IDWriteFontFaceReference1* pThis, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, [NativeTypeName("IDWriteFontFace3 **")] IDWriteFontFace3** fontFace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _Equals(IDWriteFontFaceReference1* pThis, [NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontFaceIndex(IDWriteFontFaceReference1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_SIMULATIONS _GetSimulations(IDWriteFontFaceReference1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFile(IDWriteFontFaceReference1* pThis, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetLocalFileSize(IDWriteFontFaceReference1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetFileSize(IDWriteFontFaceReference1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFileTime(IDWriteFontFaceReference1* pThis, [NativeTypeName("FILETIME *")] FILETIME* lastWriteTime);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_LOCALITY _GetLocality(IDWriteFontFaceReference1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnqueueFontDownloadRequest(IDWriteFontFaceReference1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnqueueCharacterDownloadRequest(IDWriteFontFaceReference1* pThis, [NativeTypeName("const WCHAR *")] ushort* characters, [NativeTypeName("UINT32")] uint characterCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnqueueGlyphDownloadRequest(IDWriteFontFaceReference1* pThis, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnqueueFileFragmentDownloadRequest(IDWriteFontFaceReference1* pThis, [NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFace1(IDWriteFontFaceReference1* pThis, [NativeTypeName("IDWriteFontFace5 **")] IDWriteFontFace5** fontFace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontAxisValueCount(IDWriteFontFaceReference1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontAxisValues(IDWriteFontFaceReference1* pThis, [NativeTypeName("DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("IDWriteFontFace3 **")] IDWriteFontFace3** fontFace)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFace>(lpVtbl->CreateFontFace)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFace);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceWithSimulations(DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, [NativeTypeName("IDWriteFontFace3 **")] IDWriteFontFace3** fontFace)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFaceWithSimulations>(lpVtbl->CreateFontFaceWithSimulations)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFaceSimulationFlags, fontFace);
        }

        [return: NativeTypeName("BOOL")]
        public int Equals([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference)
        {
            return Marshal.GetDelegateForFunctionPointer<_Equals>(lpVtbl->Equals)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFaceIndex()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFaceIndex>(lpVtbl->GetFontFaceIndex)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSimulations>(lpVtbl->GetSimulations)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFile([NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFile>(lpVtbl->GetFontFile)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFile);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetLocalFileSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocalFileSize>(lpVtbl->GetLocalFileSize)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetFileSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFileSize>(lpVtbl->GetFileSize)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileTime([NativeTypeName("FILETIME *")] FILETIME* lastWriteTime)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFileTime>(lpVtbl->GetFileTime)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), lastWriteTime);
        }

        public DWRITE_LOCALITY GetLocality()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocality>(lpVtbl->GetLocality)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueFontDownloadRequest()
        {
            return Marshal.GetDelegateForFunctionPointer<_EnqueueFontDownloadRequest>(lpVtbl->EnqueueFontDownloadRequest)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueCharacterDownloadRequest([NativeTypeName("const WCHAR *")] ushort* characters, [NativeTypeName("UINT32")] uint characterCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnqueueCharacterDownloadRequest>(lpVtbl->EnqueueCharacterDownloadRequest)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), characters, characterCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueGlyphDownloadRequest([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnqueueGlyphDownloadRequest>(lpVtbl->EnqueueGlyphDownloadRequest)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueFileFragmentDownloadRequest([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnqueueFileFragmentDownloadRequest>(lpVtbl->EnqueueFileFragmentDownloadRequest)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("IDWriteFontFace5 **")] IDWriteFontFace5** fontFace)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFace1>(lpVtbl->CreateFontFace1)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFace);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontAxisValueCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontAxisValueCount>(lpVtbl->GetFontAxisValueCount)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisValues([NativeTypeName("DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontAxisValues>(lpVtbl->GetFontAxisValues)((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IDWriteFontFace3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFace;

            [NativeTypeName("HRESULT (DWRITE_FONT_SIMULATIONS, IDWriteFontFace3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFaceWithSimulations;

            [NativeTypeName("BOOL (IDWriteFontFaceReference *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public new IntPtr Equals;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFaceIndex;

            [NativeTypeName("DWRITE_FONT_SIMULATIONS () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSimulations;

            [NativeTypeName("HRESULT (IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFile;

            [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocalFileSize;

            [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFileSize;

            [NativeTypeName("HRESULT (FILETIME *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFileTime;

            [NativeTypeName("DWRITE_LOCALITY () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocality;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr EnqueueFontDownloadRequest;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr EnqueueCharacterDownloadRequest;

            [NativeTypeName("HRESULT (const UINT16 *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr EnqueueGlyphDownloadRequest;

            [NativeTypeName("HRESULT (UINT64, UINT64) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr EnqueueFileFragmentDownloadRequest;

            [NativeTypeName("HRESULT (IDWriteFontFace5 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFace1;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontAxisValueCount;

            [NativeTypeName("HRESULT (DWRITE_FONT_AXIS_VALUE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontAxisValues;
        }
    }
}
