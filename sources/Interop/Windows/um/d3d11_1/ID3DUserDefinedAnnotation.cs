// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B2DAAD8B-03D4-4DBF-95EB-32AB4B63D0AB")]
    public unsafe partial struct ID3DUserDefinedAnnotation
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3DUserDefinedAnnotation* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3DUserDefinedAnnotation* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3DUserDefinedAnnotation* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("INT")]
        public delegate int _BeginEvent(ID3DUserDefinedAnnotation* pThis, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("INT")]
        public delegate int _EndEvent(ID3DUserDefinedAnnotation* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetMarker(ID3DUserDefinedAnnotation* pThis, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetStatus(ID3DUserDefinedAnnotation* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("INT")]
        public int BeginEvent([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_BeginEvent>(lpVtbl->BeginEvent)((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("INT")]
        public int EndEvent()
        {
            return Marshal.GetDelegateForFunctionPointer<_EndEvent>(lpVtbl->EndEvent)((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        public void SetMarker([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            Marshal.GetDelegateForFunctionPointer<_SetMarker>(lpVtbl->SetMarker)((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("BOOL")]
        public int GetStatus()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStatus>(lpVtbl->GetStatus)((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("INT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr BeginEvent;

            [NativeTypeName("INT () __attribute__((stdcall))")]
            public IntPtr EndEvent;

            [NativeTypeName("void (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetMarker;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public IntPtr GetStatus;
        }
    }
}
