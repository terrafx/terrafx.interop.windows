// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC2BB46D-3F07-481E-8625-220C4AEDBB33")]
    public unsafe struct IWICEnumMetadataItem
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICEnumMetadataItem* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICEnumMetadataItem* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICEnumMetadataItem* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Next(IWICEnumMetadataItem* This, [NativeTypeName("ULONG")] uint celt, [Optional] PROPVARIANT* rgeltSchema, PROPVARIANT* rgeltId, PROPVARIANT* rgeltValue = null, [NativeTypeName("ULONG")] uint* pceltFetched = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Skip(IWICEnumMetadataItem* This, [NativeTypeName("ULONG")] uint celt);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reset(IWICEnumMetadataItem* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(IWICEnumMetadataItem* This, IWICEnumMetadataItem** ppIEnumMetadataItem = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICEnumMetadataItem* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICEnumMetadataItem* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICEnumMetadataItem* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [Optional] PROPVARIANT* rgeltSchema, PROPVARIANT* rgeltId, PROPVARIANT* rgeltValue = null, [NativeTypeName("ULONG")] uint* pceltFetched = null)
        {
            fixed (IWICEnumMetadataItem* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Next>(lpVtbl->Next)(This, celt, rgeltSchema, rgeltId, rgeltValue, pceltFetched);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            fixed (IWICEnumMetadataItem* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Skip>(lpVtbl->Skip)(This, celt);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            fixed (IWICEnumMetadataItem* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone(IWICEnumMetadataItem** ppIEnumMetadataItem = null)
        {
            fixed (IWICEnumMetadataItem* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)(This, ppIEnumMetadataItem);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Next;

            public IntPtr Skip;

            public IntPtr Reset;

            public IntPtr Clone;
        }
    }
}
