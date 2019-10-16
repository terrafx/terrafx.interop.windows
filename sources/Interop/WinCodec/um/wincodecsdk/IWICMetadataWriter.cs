// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IWICMetadataWriter
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICMetadataWriter* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICMetadataWriter* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICMetadataWriter* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataFormat(IWICMetadataWriter* pThis, [NativeTypeName("GUID *")] Guid* pguidMetadataFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataHandlerInfo(IWICMetadataWriter* pThis, [NativeTypeName("IWICMetadataHandlerInfo **")] IWICMetadataHandlerInfo** ppIHandler);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCount(IWICMetadataWriter* pThis, [NativeTypeName("UINT *")] uint* pcCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetValueByIndex(IWICMetadataWriter* pThis, [NativeTypeName("UINT")] uint nIndex, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetValue(IWICMetadataWriter* pThis, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEnumerator(IWICMetadataWriter* pThis, [NativeTypeName("IWICEnumMetadataItem **")] IWICEnumMetadataItem** ppIEnumMetadata);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetValue(IWICMetadataWriter* pThis, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetValueByIndex(IWICMetadataWriter* pThis, [NativeTypeName("UINT")] uint nIndex, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveValue(IWICMetadataWriter* pThis, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveValueByIndex(IWICMetadataWriter* pThis, [NativeTypeName("UINT")] uint nIndex);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICMetadataWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID *")] Guid* pguidMetadataFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMetadataFormat>(lpVtbl->GetMetadataFormat)((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataHandlerInfo([NativeTypeName("IWICMetadataHandlerInfo **")] IWICMetadataHandlerInfo** ppIHandler)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMetadataHandlerInfo>(lpVtbl->GetMetadataHandlerInfo)((IWICMetadataWriter*)Unsafe.AsPointer(ref this), ppIHandler);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCount>(lpVtbl->GetCount)((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pcCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetValueByIndex>(lpVtbl->GetValueByIndex)((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetValue>(lpVtbl->GetValue)((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator([NativeTypeName("IWICEnumMetadataItem **")] IWICEnumMetadataItem** ppIEnumMetadata)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEnumerator>(lpVtbl->GetEnumerator)((IWICMetadataWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetValue>(lpVtbl->SetValue)((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValueByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetValueByIndex>(lpVtbl->SetValueByIndex)((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveValue>(lpVtbl->RemoveValue)((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveValueByIndex([NativeTypeName("UINT")] uint nIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveValueByIndex>(lpVtbl->RemoveValueByIndex)((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public IntPtr GetMetadataFormat;

            [NativeTypeName("HRESULT (IWICMetadataHandlerInfo **) __attribute__((stdcall))")]
            public IntPtr GetMetadataHandlerInfo;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetCount;

            [NativeTypeName("HRESULT (UINT, PROPVARIANT *, PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
            public IntPtr GetValueByIndex;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
            public IntPtr GetValue;

            [NativeTypeName("HRESULT (IWICEnumMetadataItem **) __attribute__((stdcall))")]
            public IntPtr GetEnumerator;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
            public IntPtr SetValue;

            [NativeTypeName("HRESULT (UINT, const PROPVARIANT *, const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
            public IntPtr SetValueByIndex;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
            public IntPtr RemoveValue;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr RemoveValueByIndex;
        }
    }
}
