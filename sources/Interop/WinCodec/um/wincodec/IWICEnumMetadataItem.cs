// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC2BB46D-3F07-481E-8625-220C4AEDBB33")]
    public unsafe partial struct IWICEnumMetadataItem
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICEnumMetadataItem* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICEnumMetadataItem* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICEnumMetadataItem* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Next(IWICEnumMetadataItem* pThis, [NativeTypeName("ULONG")] uint celt, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* rgeltSchema, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* rgeltId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* rgeltValue, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Skip(IWICEnumMetadataItem* pThis, [NativeTypeName("ULONG")] uint celt);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reset(IWICEnumMetadataItem* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(IWICEnumMetadataItem* pThis, [NativeTypeName("IWICEnumMetadataItem **")] IWICEnumMetadataItem** ppIEnumMetadataItem);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* rgeltSchema, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* rgeltId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* rgeltValue, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return Marshal.GetDelegateForFunctionPointer<_Next>(lpVtbl->Next)((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), celt, rgeltSchema, rgeltId, rgeltValue, pceltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return Marshal.GetDelegateForFunctionPointer<_Skip>(lpVtbl->Skip)((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IWICEnumMetadataItem **")] IWICEnumMetadataItem** ppIEnumMetadataItem)
        {
            return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), ppIEnumMetadataItem);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (ULONG, PROPVARIANT *, PROPVARIANT *, PROPVARIANT *, ULONG *) __attribute__((stdcall))")]
            public IntPtr Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public IntPtr Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Reset;

            [NativeTypeName("HRESULT (IWICEnumMetadataItem **) __attribute__((stdcall))")]
            public IntPtr Clone;
        }
    }
}
