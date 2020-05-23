// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000104-0000-0000-C000-000000000046")]
    public unsafe partial struct IEnumOLEVERB
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IEnumOLEVERB* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IEnumOLEVERB* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IEnumOLEVERB* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Next(IEnumOLEVERB* pThis, [NativeTypeName("ULONG")] uint celt, [NativeTypeName("LPOLEVERB")] OLEVERB* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Skip(IEnumOLEVERB* pThis, [NativeTypeName("ULONG")] uint celt);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reset(IEnumOLEVERB* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(IEnumOLEVERB* pThis, [NativeTypeName("IEnumOLEVERB **")] IEnumOLEVERB** ppenum);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IEnumOLEVERB*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IEnumOLEVERB*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IEnumOLEVERB*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("LPOLEVERB")] OLEVERB* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return Marshal.GetDelegateForFunctionPointer<_Next>(lpVtbl->Next)((IEnumOLEVERB*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return Marshal.GetDelegateForFunctionPointer<_Skip>(lpVtbl->Skip)((IEnumOLEVERB*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)((IEnumOLEVERB*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumOLEVERB **")] IEnumOLEVERB** ppenum)
        {
            return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)((IEnumOLEVERB*)Unsafe.AsPointer(ref this), ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (ULONG, LPOLEVERB, ULONG *) __attribute__((stdcall))")]
            public IntPtr Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public IntPtr Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Reset;

            [NativeTypeName("HRESULT (IEnumOLEVERB **) __attribute__((stdcall))")]
            public IntPtr Clone;
        }
    }
}
