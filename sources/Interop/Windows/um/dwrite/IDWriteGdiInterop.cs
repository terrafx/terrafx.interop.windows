// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>The GDI interop interface provides interoperability with GDI.</summary>
    [Guid("1EDD9491-9853-4299-898F-6432983B6F3A")]
    public unsafe struct IDWriteGdiInterop
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteGdiInterop* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteGdiInterop* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteGdiInterop* This
        );

        /// <summary>Creates a font object that matches the properties specified by the LOGFONT public structure in the system font collection (GetSystemFontCollection).</summary>
        /// <param name="logFont">Structure containing a GDI-compatible font description.</param>
        /// <param name="font">Receives a newly created font object if successful, or NULL in case of error.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateFontFromLOGFONT(
            [In] IDWriteGdiInterop* This,
            [In] LOGFONT* logFont,
            [Out] IDWriteFont** font
        );

        /// <summary>Initializes a LOGFONT public structure based on the GDI-compatible properties of the specified font.</summary>
        /// <param name="font">Specifies a font.</param>
        /// <param name="logFont">Structure that receives a GDI-compatible font description.</param>
        /// <param name="isSystemFont">Contains TRUE if the specified font object is part of the system font collection or FALSE otherwise.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ConvertFontToLOGFONT(
            [In] IDWriteGdiInterop* This,
            [In] IDWriteFont* font,
            [Out] LOGFONT* logFont,
            [Out, NativeTypeName("BOOL")] int* isSystemFont
        );

        /// <summary>Initializes a LOGFONT public structure based on the GDI-compatible properties of the specified font.</summary>
        /// <param name="font">Specifies a font face.</param>
        /// <param name="logFont">Structure that receives a GDI-compatible font description.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ConvertFontFaceToLOGFONT(
            [In] IDWriteGdiInterop* This,
            [In] IDWriteFontFace* font,
            [Out] LOGFONT* logFont
        );

        /// <summary>Creates a font face object that corresponds to the currently selected HFONT.</summary>
        /// <param name="hdc">Handle to a device context into which a font has been selected. It is assumed that the client has already performed font mapping and that the font selected into the DC is the actual font that would be used for rendering glyphs.</param>
        /// <param name="fontFace">Contains the newly created font face object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateFontFaceFromHdc(
            [In] IDWriteGdiInterop* This,
            [In, NativeTypeName("HDC")] IntPtr hdc,
            [Out] IDWriteFontFace** fontFace
        );

        /// <summary>Creates an object that encapsulates a bitmap and memory DC which can be used for rendering glyphs.</summary>
        /// <param name="hdc">Optional device context used to create a compatible memory DC.</param>
        /// <param name="width">Width of the bitmap.</param>
        /// <param name="height">Height of the bitmap.</param>
        /// <param name="renderTarget">Receives a pointer to the newly created render target.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateBitmapRenderTarget(
            [In] IDWriteGdiInterop* This,
            [In, Optional, NativeTypeName("HDC")] IntPtr hdc,
            [In, NativeTypeName("UINT32")] uint width,
            [In, NativeTypeName("UINT32")] uint height,
            [Out] IDWriteBitmapRenderTarget** renderTarget
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFromLOGFONT(
            [In] LOGFONT* logFont,
            [Out] IDWriteFont** font
        )
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFontFromLOGFONT>(lpVtbl->CreateFontFromLOGFONT)(
                    This,
                    logFont,
                    font
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertFontToLOGFONT(
            [In] IDWriteFont* font,
            [Out] LOGFONT* logFont,
            [Out, NativeTypeName("BOOL")] int* isSystemFont
        )
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ConvertFontToLOGFONT>(lpVtbl->ConvertFontToLOGFONT)(
                    This,
                    font,
                    logFont,
                    isSystemFont
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertFontFaceToLOGFONT(
            [In] IDWriteFontFace* font,
            [Out] LOGFONT* logFont
        )
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ConvertFontFaceToLOGFONT>(lpVtbl->ConvertFontFaceToLOGFONT)(
                    This,
                    font,
                    logFont
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceFromHdc(
            [In, NativeTypeName("HDC")] IntPtr hdc,
            [Out] IDWriteFontFace** fontFace
        )
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFontFaceFromHdc>(lpVtbl->CreateFontFaceFromHdc)(
                    This,
                    hdc,
                    fontFace
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapRenderTarget(
            [In, Optional, NativeTypeName("HDC")] IntPtr hdc,
            [In, NativeTypeName("UINT32")] uint width,
            [In, NativeTypeName("UINT32")] uint height,
            [Out] IDWriteBitmapRenderTarget** renderTarget
        )
        {
            fixed (IDWriteGdiInterop* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapRenderTarget>(lpVtbl->CreateBitmapRenderTarget)(
                    This,
                    hdc,
                    width,
                    height,
                    renderTarget
                );
            }
        }

        public struct Vtbl
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
