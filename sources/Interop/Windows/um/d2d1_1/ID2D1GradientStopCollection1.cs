// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE1572F4-5DD0-4777-998B-9279472AE63B")]
    public unsafe partial struct ID2D1GradientStopCollection1
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1GradientStopCollection1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1GradientStopCollection1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1GradientStopCollection1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetFactory(ID2D1GradientStopCollection1* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetGradientStopCount(ID2D1GradientStopCollection1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetGradientStops(ID2D1GradientStopCollection1* pThis, [NativeTypeName("D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D2D1_GAMMA _GetColorInterpolationGamma(ID2D1GradientStopCollection1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D2D1_EXTEND_MODE _GetExtendMode(ID2D1GradientStopCollection1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetGradientStops1(ID2D1GradientStopCollection1* pThis, [NativeTypeName("D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D2D1_COLOR_SPACE _GetPreInterpolationSpace(ID2D1GradientStopCollection1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D2D1_COLOR_SPACE _GetPostInterpolationSpace(ID2D1GradientStopCollection1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D2D1_BUFFER_PRECISION _GetBufferPrecision(ID2D1GradientStopCollection1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D2D1_COLOR_INTERPOLATION_MODE _GetColorInterpolationMode(ID2D1GradientStopCollection1* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetGradientStopCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGradientStopCount>(lpVtbl->GetGradientStopCount)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public void GetGradientStops([NativeTypeName("D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount)
        {
            Marshal.GetDelegateForFunctionPointer<_GetGradientStops>(lpVtbl->GetGradientStops)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount);
        }

        public D2D1_GAMMA GetColorInterpolationGamma()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetColorInterpolationGamma>(lpVtbl->GetColorInterpolationGamma)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public D2D1_EXTEND_MODE GetExtendMode()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetExtendMode>(lpVtbl->GetExtendMode)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public void GetGradientStops1([NativeTypeName("D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount)
        {
            Marshal.GetDelegateForFunctionPointer<_GetGradientStops1>(lpVtbl->GetGradientStops1)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount);
        }

        public D2D1_COLOR_SPACE GetPreInterpolationSpace()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPreInterpolationSpace>(lpVtbl->GetPreInterpolationSpace)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public D2D1_COLOR_SPACE GetPostInterpolationSpace()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPostInterpolationSpace>(lpVtbl->GetPostInterpolationSpace)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public D2D1_BUFFER_PRECISION GetBufferPrecision()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBufferPrecision>(lpVtbl->GetBufferPrecision)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public D2D1_COLOR_INTERPOLATION_MODE GetColorInterpolationMode()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetColorInterpolationMode>(lpVtbl->GetColorInterpolationMode)((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
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

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGradientStopCount;

            [NativeTypeName("void (D2D1_GRADIENT_STOP *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGradientStops;

            [NativeTypeName("D2D1_GAMMA () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetColorInterpolationGamma;

            [NativeTypeName("D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetExtendMode;

            [NativeTypeName("void (D2D1_GRADIENT_STOP *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGradientStops1;

            [NativeTypeName("D2D1_COLOR_SPACE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPreInterpolationSpace;

            [NativeTypeName("D2D1_COLOR_SPACE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPostInterpolationSpace;

            [NativeTypeName("D2D1_BUFFER_PRECISION () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetBufferPrecision;

            [NativeTypeName("D2D1_COLOR_INTERPOLATION_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetColorInterpolationMode;
        }
    }
}
