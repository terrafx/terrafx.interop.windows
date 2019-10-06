// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents an image source which shares resources with an original image source.</summary>
    [Guid("7F1F79E5-2796-416C-8F55-700F911445E5")]
    public unsafe partial struct ID2D1TransformedImageSource
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1TransformedImageSource* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1TransformedImageSource* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1TransformedImageSource* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1TransformedImageSource* This, ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetSource(ID2D1TransformedImageSource* This, ID2D1ImageSource** imageSource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetProperties(ID2D1TransformedImageSource* This, D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1TransformedImageSource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1TransformedImageSource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1TransformedImageSource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1TransformedImageSource* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public void GetSource(ID2D1ImageSource** imageSource)
        {
            fixed (ID2D1TransformedImageSource* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetSource>(lpVtbl->GetSource)(This, imageSource);
            }
        }

        public void GetProperties(D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties)
        {
            fixed (ID2D1TransformedImageSource* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetProperties>(lpVtbl->GetProperties)(This, properties);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetSource;

            public IntPtr GetProperties;
        }
    }
}
