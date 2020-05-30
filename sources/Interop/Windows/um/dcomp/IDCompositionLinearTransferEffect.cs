// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4305EE5B-C4A0-4C88-9385-67124E017683")]
    public unsafe partial struct IDCompositionLinearTransferEffect
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionLinearTransferEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionLinearTransferEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInput(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRedYIntercept(IDCompositionLinearTransferEffect* pThis, float redYIntercept);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRedYIntercept1(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRedSlope(IDCompositionLinearTransferEffect* pThis, float redSlope);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRedSlope1(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRedDisable(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("BOOL")] int redDisable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGreenYIntercept(IDCompositionLinearTransferEffect* pThis, float greenYIntercept);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGreenYIntercept1(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGreenSlope(IDCompositionLinearTransferEffect* pThis, float greenSlope);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGreenSlope1(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGreenDisable(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("BOOL")] int greenDisable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlueYIntercept(IDCompositionLinearTransferEffect* pThis, float blueYIntercept);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlueYIntercept1(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlueSlope(IDCompositionLinearTransferEffect* pThis, float blueSlope);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlueSlope1(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlueDisable(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("BOOL")] int blueDisable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlphaYIntercept(IDCompositionLinearTransferEffect* pThis, float alphaYIntercept);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlphaYIntercept1(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlphaSlope(IDCompositionLinearTransferEffect* pThis, float alphaSlope);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlphaSlope1(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlphaDisable(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("BOOL")] int alphaDisable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetClampOutput(IDCompositionLinearTransferEffect* pThis, [NativeTypeName("BOOL")] int clampOutput);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInput>(lpVtbl->SetInput)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedYIntercept(float redYIntercept)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRedYIntercept>(lpVtbl->SetRedYIntercept)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), redYIntercept);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedYIntercept([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRedYIntercept1>(lpVtbl->SetRedYIntercept1)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedSlope(float redSlope)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRedSlope>(lpVtbl->SetRedSlope)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), redSlope);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedSlope([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRedSlope1>(lpVtbl->SetRedSlope1)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedDisable([NativeTypeName("BOOL")] int redDisable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRedDisable>(lpVtbl->SetRedDisable)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), redDisable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenYIntercept(float greenYIntercept)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGreenYIntercept>(lpVtbl->SetGreenYIntercept)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), greenYIntercept);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenYIntercept([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGreenYIntercept1>(lpVtbl->SetGreenYIntercept1)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenSlope(float greenSlope)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGreenSlope>(lpVtbl->SetGreenSlope)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), greenSlope);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenSlope([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGreenSlope1>(lpVtbl->SetGreenSlope1)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenDisable([NativeTypeName("BOOL")] int greenDisable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGreenDisable>(lpVtbl->SetGreenDisable)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), greenDisable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueYIntercept(float blueYIntercept)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlueYIntercept>(lpVtbl->SetBlueYIntercept)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), blueYIntercept);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueYIntercept([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlueYIntercept1>(lpVtbl->SetBlueYIntercept1)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueSlope(float blueSlope)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlueSlope>(lpVtbl->SetBlueSlope)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), blueSlope);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueSlope([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlueSlope1>(lpVtbl->SetBlueSlope1)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueDisable([NativeTypeName("BOOL")] int blueDisable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlueDisable>(lpVtbl->SetBlueDisable)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), blueDisable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaYIntercept(float alphaYIntercept)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlphaYIntercept>(lpVtbl->SetAlphaYIntercept)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), alphaYIntercept);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaYIntercept([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlphaYIntercept1>(lpVtbl->SetAlphaYIntercept1)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaSlope(float alphaSlope)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlphaSlope>(lpVtbl->SetAlphaSlope)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), alphaSlope);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaSlope([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlphaSlope1>(lpVtbl->SetAlphaSlope1)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaDisable([NativeTypeName("BOOL")] int alphaDisable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlphaDisable>(lpVtbl->SetAlphaDisable)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), alphaDisable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClampOutput([NativeTypeName("BOOL")] int clampOutput)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetClampOutput>(lpVtbl->SetClampOutput)((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), clampOutput);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetInput;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRedYIntercept;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRedYIntercept1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRedSlope;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRedSlope1;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRedDisable;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetGreenYIntercept;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetGreenYIntercept1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetGreenSlope;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetGreenSlope1;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetGreenDisable;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlueYIntercept;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlueYIntercept1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlueSlope;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlueSlope1;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlueDisable;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAlphaYIntercept;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAlphaYIntercept1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAlphaSlope;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAlphaSlope1;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAlphaDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetClampOutput;
        }
    }
}
