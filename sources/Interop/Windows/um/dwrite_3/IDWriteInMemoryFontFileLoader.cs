// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteInMemoryFontFileLoader interface enables clients to reference in-memory fonts without having to implement a custom loader. The IDWriteFactory5::CreateInMemoryFontFileLoader method returns an instance of this interface, which the client is responsible for registering and unregistering using IDWriteFactory::RegisterFontFileLoader and IDWriteFactory::UnregisterFontFileLoader.</summary>
    [Guid("DC102F47-A12D-4B1C-822D-9E117E33043F")]
    public unsafe struct IDWriteInMemoryFontFileLoader
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteInMemoryFontFileLoader* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteInMemoryFontFileLoader* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteInMemoryFontFileLoader* This
        );

        /// <summary>Creates a font file stream object that encapsulates an open file resource. The resource is closed when the last reference to fontFileStream is released.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the font file resource within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="fontFileStream">Pointer to the newly created font file stream.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateStreamFromKey(
            [In] IDWriteInMemoryFontFileLoader* This,
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out] IDWriteFontFileStream** fontFileStream
        );

        /// <summary>The CreateInMemoryFontFileReference method creates a font file reference (IDWriteFontFile object) from an array of bytes. The font file reference is bound to the IDWRiteInMemoryFontFileLoader instance with which it was created and remains valid for as long as that loader is registered with the factory.</summary>
        /// <param name="factory">Factory object used to create the font file reference.</param>
        /// <param name="fontData">Pointer to a memory block containing the font data.</param>
        /// <param name="fontDataSize">Size of the font data.</param>
        /// <param name="ownerObject">Optional object that owns the memory specified by the fontData parameter. If this parameter is not NULL, the method stores a pointer to the font data and adds a reference to the owner object. The fontData pointer must remain valid until the owner object is released. If this parameter is NULL, the method makes a copy of the font data.</param>
        /// <param name="fontFile">Receives a pointer to the newly-created font file reference.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateInMemoryFontFileReference(
            [In] IDWriteInMemoryFontFileLoader* This,
            [In] IDWriteFactory* factory,
            [In] void* fontData,
            [In, NativeTypeName("UINT32")] uint fontDataSize,
            [In, Optional] IUnknown* ownerObject,
            [Out] IDWriteFontFile** fontFile
        );

        /// <summary>The GetFileCount method returns the number of font file references that have been created using this loader instance.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetFileCount(
            [In] IDWriteInMemoryFontFileLoader* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteInMemoryFontFileLoader* This = &this)
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
            fixed (IDWriteInMemoryFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteInMemoryFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromKey(
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out] IDWriteFontFileStream** fontFileStream
        )
        {
            fixed (IDWriteInMemoryFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStreamFromKey>(lpVtbl->CreateStreamFromKey)(
                    This,
                    fontFileReferenceKey,
                    fontFileReferenceKeySize,
                    fontFileStream
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInMemoryFontFileReference(
            [In] IDWriteFactory* factory,
            [In] void* fontData,
            [In, NativeTypeName("UINT32")] uint fontDataSize,
            [In, Optional] IUnknown* ownerObject,
            [Out] IDWriteFontFile** fontFile
        )
        {
            fixed (IDWriteInMemoryFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateInMemoryFontFileReference>(lpVtbl->CreateInMemoryFontFileReference)(
                    This,
                    factory,
                    fontData,
                    fontDataSize,
                    ownerObject,
                    fontFile
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFileCount()
        {
            fixed (IDWriteInMemoryFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFileCount>(lpVtbl->GetFileCount)(
                    This
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr CreateStreamFromKey;

            public IntPtr CreateInMemoryFontFileReference;

            public IntPtr GetFileCount;
        }
    }
}
