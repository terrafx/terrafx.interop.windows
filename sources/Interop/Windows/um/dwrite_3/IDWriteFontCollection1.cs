// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("53585141-D9F8-4095-8321-D73CF6BD116C")]
    public unsafe struct IDWriteFontCollection1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteFontCollection1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteFontCollection1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteFontCollection1* This
        );

        /// <summary>Gets the number of font families in the collection.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetFontFamilyCount(
            [In] IDWriteFontCollection1* This
        );

        /// <summary>Creates a font family object given a zero-based font family index.</summary>
        /// <param name="index">Zero-based index of the font family.</param>
        /// <param name="fontFamily">Receives a pointer the newly created font family object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFamily(
            [In] IDWriteFontCollection1* This,
            [In, NativeTypeName("UINT32")] uint index,
            [Out] IDWriteFontFamily** fontFamily
        );

        /// <summary>Finds the font family with the specified family name.</summary>
        /// <param name="familyName">Name of the font family. The name is not case-sensitive but must otherwise exactly match a family name in the collection.</param>
        /// <param name="index">Receives the zero-based index of the matching font family if the family name was found or UINT_MAX otherwise.</param>
        /// <param name="exists">Receives TRUE if the family name exists or FALSE otherwise.</param>
        /// <returns>Standard HRESULT error code. If the specified family name does not exist, the return value is S_OK, but *index is UINT_MAX and *exists is FALSE.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _FindFamilyName(
            [In] IDWriteFontCollection1* This,
            [In, NativeTypeName("WCHAR[]")] char* familyName,
            [Out, NativeTypeName("UINT32")] uint* index,
            [Out, NativeTypeName("BOOL")] int* exists
        );

        /// <summary>Gets the font object that corresponds to the same physical font as the specified font face object. The specified physical font must belong to the font collection.</summary>
        /// <param name="fontFace">Font face object that specifies the physical font.</param>
        /// <param name="font">Receives a pointer to the newly created font object if successful or NULL otherwise.</param>
        /// <returns>Standard HRESULT error code. If the specified physical font is not part of the font collection the return value is DWRITE_E_NOFONT.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFromFontFace(
            [In] IDWriteFontCollection1* This,
            [In] IDWriteFontFace* fontFace,
            [Out] IDWriteFont** font
        );

        /// <summary>Get the underlying font set used by this collection.</summary>
        /// <param name="fontSet">Contains font set used by the collection.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontSet(
            [In] IDWriteFontCollection1* This,
            [Out] IDWriteFontSet** fontSet
        );

        /// <summary>Creates a font family object given a zero-based font family index.</summary>
        /// <param name="index">Zero-based index of the font family.</param>
        /// <param name="fontFamily">Receives a pointer the newly created font family object.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFamily1(
            [In] IDWriteFontCollection1* This,
            [In, NativeTypeName("UINT32")] uint index,
            [Out] IDWriteFontFamily1** fontFamily
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFontCollection1* This = &this)
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
            fixed (IDWriteFontCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyCount()
        {
            fixed (IDWriteFontCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyCount>(lpVtbl->GetFontFamilyCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily(
            [In, NativeTypeName("UINT32")] uint index,
            [Out] IDWriteFontFamily** fontFamily
        )
        {
            fixed (IDWriteFontCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamily>(lpVtbl->GetFontFamily)(
                    This,
                    index,
                    fontFamily
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFamilyName(
            [In, NativeTypeName("WCHAR[]")] char* familyName,
            [Out, NativeTypeName("UINT32")] uint* index,
            [Out, NativeTypeName("BOOL")] int* exists
        )
        {
            fixed (IDWriteFontCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindFamilyName>(lpVtbl->FindFamilyName)(
                    This,
                    familyName,
                    index,
                    exists
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFromFontFace(
            [In] IDWriteFontFace* fontFace,
            [Out] IDWriteFont** font
        )
        {
            fixed (IDWriteFontCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFromFontFace>(lpVtbl->GetFontFromFontFace)(
                    This,
                    fontFace,
                    font
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSet(
            [Out] IDWriteFontSet** fontSet
        )
        {
            fixed (IDWriteFontCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontSet>(lpVtbl->GetFontSet)(
                    This,
                    fontSet
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily1(
            [In, NativeTypeName("UINT32")] uint index,
            [Out] IDWriteFontFamily1** fontFamily
        )
        {
            fixed (IDWriteFontCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamily1>(lpVtbl->GetFontFamily1)(
                    This,
                    index,
                    fontFamily
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFontFamilyCount;

            public IntPtr GetFontFamily;

            public IntPtr FindFamilyName;

            public IntPtr GetFontFromFontFace;

            public IntPtr GetFontSet;

            public IntPtr GetFontFamily1;
        }
    }
}
