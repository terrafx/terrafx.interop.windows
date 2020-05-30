// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E57AA735-DCDB-4c72-9C61-0591F58889EE")]
    public unsafe partial struct IDCompositionSkewTransform
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionSkewTransform* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionSkewTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionSkewTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAngleX(IDCompositionSkewTransform* pThis, float angleX);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAngleX1(IDCompositionSkewTransform* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAngleY(IDCompositionSkewTransform* pThis, float angleY);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAngleY1(IDCompositionSkewTransform* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCenterX(IDCompositionSkewTransform* pThis, float centerX);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCenterX1(IDCompositionSkewTransform* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCenterY(IDCompositionSkewTransform* pThis, float centerY);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCenterY1(IDCompositionSkewTransform* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngleX(float angleX)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAngleX>(lpVtbl->SetAngleX)((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), angleX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngleX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAngleX1>(lpVtbl->SetAngleX1)((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngleY(float angleY)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAngleY>(lpVtbl->SetAngleY)((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), angleY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngleY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAngleY1>(lpVtbl->SetAngleY1)((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX(float centerX)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCenterX>(lpVtbl->SetCenterX)((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), centerX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCenterX1>(lpVtbl->SetCenterX1)((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY(float centerY)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCenterY>(lpVtbl->SetCenterY)((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), centerY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCenterY1>(lpVtbl->SetCenterY1)((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAngleX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAngleX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAngleY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAngleY1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCenterX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCenterX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCenterY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCenterY1;
        }
    }
}
