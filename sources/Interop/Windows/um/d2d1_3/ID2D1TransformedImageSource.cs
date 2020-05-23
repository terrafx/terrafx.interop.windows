// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7F1F79E5-2796-416C-8F55-700F911445E5")]
    public unsafe partial struct ID2D1TransformedImageSource
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1TransformedImageSource* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1TransformedImageSource* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1TransformedImageSource* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1TransformedImageSource* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetSource(ID2D1TransformedImageSource* pThis, [NativeTypeName("ID2D1ImageSource **")] ID2D1ImageSource** imageSource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetProperties(ID2D1TransformedImageSource* pThis, [NativeTypeName("D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *")] D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetSource([NativeTypeName("ID2D1ImageSource **")] ID2D1ImageSource** imageSource)
        {
            Marshal.GetDelegateForFunctionPointer<_GetSource>(lpVtbl->GetSource)((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), imageSource);
        }

        public void GetProperties([NativeTypeName("D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *")] D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties)
        {
            Marshal.GetDelegateForFunctionPointer<_GetProperties>(lpVtbl->GetProperties)((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), properties);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFactory;

            [NativeTypeName("void (ID2D1ImageSource **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSource;

            [NativeTypeName("void (D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetProperties;
        }
    }
}
