// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B287-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IEnumConnections
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IEnumConnections* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IEnumConnections* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IEnumConnections* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Next(IEnumConnections* pThis, [NativeTypeName("ULONG")] uint cConnections, [NativeTypeName("LPCONNECTDATA")] CONNECTDATA* rgcd, [NativeTypeName("ULONG *")] uint* pcFetched);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Skip(IEnumConnections* pThis, [NativeTypeName("ULONG")] uint cConnections);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reset(IEnumConnections* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(IEnumConnections* pThis, [NativeTypeName("IEnumConnections **")] IEnumConnections** ppEnum);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IEnumConnections*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IEnumConnections*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IEnumConnections*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cConnections, [NativeTypeName("LPCONNECTDATA")] CONNECTDATA* rgcd, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return Marshal.GetDelegateForFunctionPointer<_Next>(lpVtbl->Next)((IEnumConnections*)Unsafe.AsPointer(ref this), cConnections, rgcd, pcFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cConnections)
        {
            return Marshal.GetDelegateForFunctionPointer<_Skip>(lpVtbl->Skip)((IEnumConnections*)Unsafe.AsPointer(ref this), cConnections);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)((IEnumConnections*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumConnections **")] IEnumConnections** ppEnum)
        {
            return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)((IEnumConnections*)Unsafe.AsPointer(ref this), ppEnum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (ULONG, LPCONNECTDATA, ULONG *) __attribute__((stdcall))")]
            public IntPtr Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public IntPtr Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Reset;

            [NativeTypeName("HRESULT (IEnumConnections **) __attribute__((stdcall))")]
            public IntPtr Clone;
        }
    }
}
