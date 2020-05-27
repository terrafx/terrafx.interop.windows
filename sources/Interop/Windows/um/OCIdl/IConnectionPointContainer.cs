// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B284-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IConnectionPointContainer
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IConnectionPointContainer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IConnectionPointContainer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IConnectionPointContainer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumConnectionPoints(IConnectionPointContainer* pThis, [NativeTypeName("IEnumConnectionPoints **")] IEnumConnectionPoints** ppEnum);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindConnectionPoint(IConnectionPointContainer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IConnectionPoint **")] IConnectionPoint** ppCP);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IConnectionPointContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IConnectionPointContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IConnectionPointContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumConnectionPoints([NativeTypeName("IEnumConnectionPoints **")] IEnumConnectionPoints** ppEnum)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumConnectionPoints>(lpVtbl->EnumConnectionPoints)((IConnectionPointContainer*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindConnectionPoint([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IConnectionPoint **")] IConnectionPoint** ppCP)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindConnectionPoint>(lpVtbl->FindConnectionPoint)((IConnectionPointContainer*)Unsafe.AsPointer(ref this), riid, ppCP);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IEnumConnectionPoints **) __attribute__((stdcall))")]
            public IntPtr EnumConnectionPoints;

            [NativeTypeName("HRESULT (const IID &, IConnectionPoint **) __attribute__((stdcall))")]
            public IntPtr FindConnectionPoint;
        }
    }
}
