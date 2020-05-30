// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E82E2-69C5-4EB4-A5F5-A7033F5132CD")]
    public unsafe partial struct IDCompositionTableTransferEffect
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionTableTransferEffect* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionTableTransferEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionTableTransferEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInput(IDCompositionTableTransferEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRedTable(IDCompositionTableTransferEffect* pThis, [NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGreenTable(IDCompositionTableTransferEffect* pThis, [NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlueTable(IDCompositionTableTransferEffect* pThis, [NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlphaTable(IDCompositionTableTransferEffect* pThis, [NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRedDisable(IDCompositionTableTransferEffect* pThis, [NativeTypeName("BOOL")] int redDisable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGreenDisable(IDCompositionTableTransferEffect* pThis, [NativeTypeName("BOOL")] int greenDisable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlueDisable(IDCompositionTableTransferEffect* pThis, [NativeTypeName("BOOL")] int blueDisable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlphaDisable(IDCompositionTableTransferEffect* pThis, [NativeTypeName("BOOL")] int alphaDisable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetClampOutput(IDCompositionTableTransferEffect* pThis, [NativeTypeName("BOOL")] int clampOutput);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRedTableValue(IDCompositionTableTransferEffect* pThis, [NativeTypeName("UINT")] uint index, float value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRedTableValue1(IDCompositionTableTransferEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGreenTableValue(IDCompositionTableTransferEffect* pThis, [NativeTypeName("UINT")] uint index, float value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGreenTableValue1(IDCompositionTableTransferEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlueTableValue(IDCompositionTableTransferEffect* pThis, [NativeTypeName("UINT")] uint index, float value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBlueTableValue1(IDCompositionTableTransferEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlphaTableValue(IDCompositionTableTransferEffect* pThis, [NativeTypeName("UINT")] uint index, float value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlphaTableValue1(IDCompositionTableTransferEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInput>(lpVtbl->SetInput)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedTable([NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRedTable>(lpVtbl->SetRedTable)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenTable([NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGreenTable>(lpVtbl->SetGreenTable)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueTable([NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlueTable>(lpVtbl->SetBlueTable)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaTable([NativeTypeName("const float *")] float* tableValues, [NativeTypeName("UINT")] uint count)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlphaTable>(lpVtbl->SetAlphaTable)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), tableValues, count);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedDisable([NativeTypeName("BOOL")] int redDisable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRedDisable>(lpVtbl->SetRedDisable)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), redDisable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenDisable([NativeTypeName("BOOL")] int greenDisable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGreenDisable>(lpVtbl->SetGreenDisable)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), greenDisable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueDisable([NativeTypeName("BOOL")] int blueDisable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlueDisable>(lpVtbl->SetBlueDisable)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), blueDisable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaDisable([NativeTypeName("BOOL")] int alphaDisable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlphaDisable>(lpVtbl->SetAlphaDisable)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), alphaDisable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClampOutput([NativeTypeName("BOOL")] int clampOutput)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetClampOutput>(lpVtbl->SetClampOutput)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), clampOutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedTableValue([NativeTypeName("UINT")] uint index, float value)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRedTableValue>(lpVtbl->SetRedTableValue)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRedTableValue([NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRedTableValue1>(lpVtbl->SetRedTableValue1)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenTableValue([NativeTypeName("UINT")] uint index, float value)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGreenTableValue>(lpVtbl->SetGreenTableValue)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreenTableValue([NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGreenTableValue1>(lpVtbl->SetGreenTableValue1)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueTableValue([NativeTypeName("UINT")] uint index, float value)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlueTableValue>(lpVtbl->SetBlueTableValue)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlueTableValue([NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBlueTableValue1>(lpVtbl->SetBlueTableValue1)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaTableValue([NativeTypeName("UINT")] uint index, float value)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlphaTableValue>(lpVtbl->SetAlphaTableValue)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaTableValue([NativeTypeName("UINT")] uint index, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlphaTableValue1>(lpVtbl->SetAlphaTableValue1)((IDCompositionTableTransferEffect*)Unsafe.AsPointer(ref this), index, animation);
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

            [NativeTypeName("HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRedTable;

            [NativeTypeName("HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetGreenTable;

            [NativeTypeName("HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlueTable;

            [NativeTypeName("HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAlphaTable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRedDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetGreenDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlueDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAlphaDisable;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetClampOutput;

            [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRedTableValue;

            [NativeTypeName("HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRedTableValue1;

            [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetGreenTableValue;

            [NativeTypeName("HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetGreenTableValue1;

            [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlueTableValue;

            [NativeTypeName("HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBlueTableValue1;

            [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAlphaTableValue;

            [NativeTypeName("HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAlphaTableValue1;
        }
    }
}
