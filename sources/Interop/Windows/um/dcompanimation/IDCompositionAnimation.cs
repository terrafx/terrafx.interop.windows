// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcompanimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CBFD91D9-51B2-45e4-B3DE-D19CCFB863C5")]
    public unsafe partial struct IDCompositionAnimation
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionAnimation* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionAnimation* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionAnimation* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reset(IDCompositionAnimation* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAbsoluteBeginTime(IDCompositionAnimation* pThis, LARGE_INTEGER beginTime);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddCubic(IDCompositionAnimation* pThis, double beginOffset, float constantCoefficient, float linearCoefficient, float quadraticCoefficient, float cubicCoefficient);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddSinusoidal(IDCompositionAnimation* pThis, double beginOffset, float bias, float amplitude, float frequency, float phase);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddRepeat(IDCompositionAnimation* pThis, double beginOffset, double durationToRepeat);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _End(IDCompositionAnimation* pThis, double endOffset, float endValue);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionAnimation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionAnimation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionAnimation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)((IDCompositionAnimation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAbsoluteBeginTime(LARGE_INTEGER beginTime)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAbsoluteBeginTime>(lpVtbl->SetAbsoluteBeginTime)((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddCubic(double beginOffset, float constantCoefficient, float linearCoefficient, float quadraticCoefficient, float cubicCoefficient)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddCubic>(lpVtbl->AddCubic)((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginOffset, constantCoefficient, linearCoefficient, quadraticCoefficient, cubicCoefficient);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSinusoidal(double beginOffset, float bias, float amplitude, float frequency, float phase)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddSinusoidal>(lpVtbl->AddSinusoidal)((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginOffset, bias, amplitude, frequency, phase);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRepeat(double beginOffset, double durationToRepeat)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRepeat>(lpVtbl->AddRepeat)((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginOffset, durationToRepeat);
        }

        [return: NativeTypeName("HRESULT")]
        public int End(double endOffset, float endValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_End>(lpVtbl->End)((IDCompositionAnimation*)Unsafe.AsPointer(ref this), endOffset, endValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Reset;

            [NativeTypeName("HRESULT (LARGE_INTEGER) __attribute__((stdcall))")]
            public IntPtr SetAbsoluteBeginTime;

            [NativeTypeName("HRESULT (double, float, float, float, float) __attribute__((stdcall))")]
            public IntPtr AddCubic;

            [NativeTypeName("HRESULT (double, float, float, float, float) __attribute__((stdcall))")]
            public IntPtr AddSinusoidal;

            [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
            public IntPtr AddRepeat;

            [NativeTypeName("HRESULT (double, float) __attribute__((stdcall))")]
            public IntPtr End;
        }
    }
}
