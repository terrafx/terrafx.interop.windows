// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000D-0000-0000-C000-000000000046")]
    public unsafe partial struct IEnumSTATSTG
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IEnumSTATSTG* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IEnumSTATSTG* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IEnumSTATSTG* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Next(IEnumSTATSTG* pThis, [NativeTypeName("ULONG")] uint celt, [NativeTypeName("STATSTG *")] STATSTG* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Skip(IEnumSTATSTG* pThis, [NativeTypeName("ULONG")] uint celt);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reset(IEnumSTATSTG* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(IEnumSTATSTG* pThis, [NativeTypeName("IEnumSTATSTG **")] IEnumSTATSTG** ppenum);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IEnumSTATSTG*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IEnumSTATSTG*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IEnumSTATSTG*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("STATSTG *")] STATSTG* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return Marshal.GetDelegateForFunctionPointer<_Next>(lpVtbl->Next)((IEnumSTATSTG*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return Marshal.GetDelegateForFunctionPointer<_Skip>(lpVtbl->Skip)((IEnumSTATSTG*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)((IEnumSTATSTG*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumSTATSTG **")] IEnumSTATSTG** ppenum)
        {
            return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)((IEnumSTATSTG*)Unsafe.AsPointer(ref this), ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (ULONG, STATSTG *, ULONG *) __attribute__((stdcall))")]
            public IntPtr Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public IntPtr Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Reset;

            [NativeTypeName("HRESULT (IEnumSTATSTG **) __attribute__((stdcall))")]
            public IntPtr Clone;
        }
    }
}
