// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The GDI interop interface provides interoperability with GDI.</summary>
    [Guid("1EDD9491-9853-4299-898F-6432983B6F3A")]
    public unsafe partial struct IDWriteGdiInterop
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteGdiInterop* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteGdiInterop* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteGdiInterop* This);

        /// <summary>Creates a font object that matches the properties specified by the LOGFONT public partial structure in the system font collection (GetSystemFontCollection).</summary>
        /// <param name="logFont">Structure containing a GDI-compatible font description.</param>
        /// <param name="font">Receives a newly created font object if successful, or NULL in case of error.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFromLOGFONT(IDWriteGdiInterop* This, LOGFONT* logFont, IDWriteFont** font);

        /// <summary>Initializes a LOGFONT public partial structure based on the GDI-compatible properties of the specified font.</summary>
        /// <param name="font">Specifies a font.</param>
        /// <param name="logFont">Structure that receives a GDI-compatible font description.</param>
        /// <param name="isSystemFont">Contains TRUE if the specified font object is part of the system font collection or FALSE otherwise.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ConvertFontToLOGFONT(IDWriteGdiInterop* This, IDWriteFont* font, LOGFONT* logFont, [NativeTypeName("BOOL")] int* isSystemFont);

        /// <summary>Initializes a LOGFONT public partial structure based on the GDI-compatible properties of the specified font.</summary>
        /// <param name="font">Specifies a font face.</param>
        /// <param name="logFont">Structure that receives a GDI-compatible font description.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ConvertFontFaceToLOGFONT(IDWriteGdiInterop* This, IDWriteFontFace* font, LOGFONT* logFont);

        /// <summary>Creates a font face object that corresponds to the currently selected HFONT.</summary>
        /// <param name="hdc">Handle to a device context into which a font has been selected. It is assumed that the client has already performed font mapping and that the font selected into the DC is the actual font that would be used for rendering glyphs.</param>
        /// <param name="fontFace">Contains the newly created font face object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFaceFromHdc(IDWriteGdiInterop* This, [NativeTypeName("HDC")] IntPtr hdc, IDWriteFontFace** fontFace);

        /// <summary>Creates an object that encapsulates a bitmap and memory DC which can be used for rendering glyphs.</summary>
        /// <param name="hdc">Optional device context used to create a compatible memory DC.</param>
        /// <param name="width">Width of the bitmap.</param>
        /// <param name="height">Height of the bitmap.</param>
        /// <param name="renderTarget">Receives a pointer to the newly created render target.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapRenderTarget(IDWriteGdiInterop* This, [Optional, NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, IDWriteBitmapRenderTarget** renderTarget);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFromLOGFONT(LOGFONT* logFont, IDWriteFont** font)
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFontFromLOGFONT>(lpVtbl->CreateFontFromLOGFONT)(This, logFont, font);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertFontToLOGFONT(IDWriteFont* font, LOGFONT* logFont, [NativeTypeName("BOOL")] int* isSystemFont)
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ConvertFontToLOGFONT>(lpVtbl->ConvertFontToLOGFONT)(This, font, logFont, isSystemFont);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertFontFaceToLOGFONT(IDWriteFontFace* font, LOGFONT* logFont)
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ConvertFontFaceToLOGFONT>(lpVtbl->ConvertFontFaceToLOGFONT)(This, font, logFont);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceFromHdc([NativeTypeName("HDC")] IntPtr hdc, IDWriteFontFace** fontFace)
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFontFaceFromHdc>(lpVtbl->CreateFontFaceFromHdc)(This, hdc, fontFace);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapRenderTarget([Optional, NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, IDWriteBitmapRenderTarget** renderTarget)
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapRenderTarget>(lpVtbl->CreateBitmapRenderTarget)(This, hdc, width, height, renderTarget);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr CreateFontFromLOGFONT;

            public IntPtr ConvertFontToLOGFONT;

            public IntPtr ConvertFontFaceToLOGFONT;

            public IntPtr CreateFontFaceFromHdc;

            public IntPtr CreateBitmapRenderTarget;
        }
    }
}
