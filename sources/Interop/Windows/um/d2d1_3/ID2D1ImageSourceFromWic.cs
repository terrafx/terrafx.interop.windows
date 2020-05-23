// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("77395441-1C8F-4555-8683-F50DAB0FE792")]
    public unsafe partial struct ID2D1ImageSourceFromWic
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1ImageSourceFromWic* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1ImageSourceFromWic* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1ImageSourceFromWic* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetFactory(ID2D1ImageSourceFromWic* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OfferResources(ID2D1ImageSourceFromWic* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TryReclaimResources(ID2D1ImageSourceFromWic* pThis, [NativeTypeName("BOOL *")] int* resourcesDiscarded);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnsureCached(ID2D1ImageSourceFromWic* pThis, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToFill);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TrimCache(ID2D1ImageSourceFromWic* pThis, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToPreserve);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetSource(ID2D1ImageSourceFromWic* pThis, [NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** wicBitmapSource);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int OfferResources()
        {
            return Marshal.GetDelegateForFunctionPointer<_OfferResources>(lpVtbl->OfferResources)((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int TryReclaimResources([NativeTypeName("BOOL *")] int* resourcesDiscarded)
        {
            return Marshal.GetDelegateForFunctionPointer<_TryReclaimResources>(lpVtbl->TryReclaimResources)((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), resourcesDiscarded);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnsureCached([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToFill)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnsureCached>(lpVtbl->EnsureCached)((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), rectangleToFill);
        }

        [return: NativeTypeName("HRESULT")]
        public int TrimCache([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToPreserve)
        {
            return Marshal.GetDelegateForFunctionPointer<_TrimCache>(lpVtbl->TrimCache)((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), rectangleToPreserve);
        }

        public void GetSource([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** wicBitmapSource)
        {
            Marshal.GetDelegateForFunctionPointer<_GetSource>(lpVtbl->GetSource)((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), wicBitmapSource);
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

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr OfferResources;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr TryReclaimResources;

            [NativeTypeName("HRESULT (const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr EnsureCached;

            [NativeTypeName("HRESULT (const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr TrimCache;

            [NativeTypeName("void (IWICBitmapSource **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSource;
        }
    }
}
