// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A721791A-0DEF-4D06-BD91-2118BF1DB10B")]
    public unsafe partial struct IWICMetadataQueryWriter
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICMetadataQueryWriter* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICMetadataQueryWriter* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICMetadataQueryWriter* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormat(IWICMetadataQueryWriter* This, [NativeTypeName("GUID")] Guid* pguidContainerFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocation(IWICMetadataQueryWriter* This, [NativeTypeName("UINT")] uint cchMaxLength, [Optional, NativeTypeName("WCHAR[]")] ushort* wzNamespace, [NativeTypeName("UINT")] uint* pcchActualLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataByName(IWICMetadataQueryWriter* This, [NativeTypeName("LPCWSTR")] ushort* wzName, PROPVARIANT* pvarValue = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEnumerator(IWICMetadataQueryWriter* This, IEnumString** ppIEnumString = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMetadataByName(IWICMetadataQueryWriter* This, [NativeTypeName("LPCWSTR")] ushort* wzName, PROPVARIANT* pvarValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveMetadataByName(IWICMetadataQueryWriter* This, [NativeTypeName("LPCWSTR")] ushort* wzName);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID")] Guid* pguidContainerFormat)
        {
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainerFormat>(lpVtbl->GetContainerFormat)(This, pguidContainerFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocation([NativeTypeName("UINT")] uint cchMaxLength, [Optional, NativeTypeName("WCHAR[]")] ushort* wzNamespace, [NativeTypeName("UINT")] uint* pcchActualLength)
        {
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocation>(lpVtbl->GetLocation)(This, cchMaxLength, wzNamespace, pcchActualLength);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName, PROPVARIANT* pvarValue = null)
        {
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataByName>(lpVtbl->GetMetadataByName)(This, wzName, pvarValue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(IEnumString** ppIEnumString = null)
        {
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEnumerator>(lpVtbl->GetEnumerator)(This, ppIEnumString);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName, PROPVARIANT* pvarValue)
        {
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMetadataByName>(lpVtbl->SetMetadataByName)(This, wzName, pvarValue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName)
        {
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveMetadataByName>(lpVtbl->RemoveMetadataByName)(This, wzName);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetContainerFormat;

            public IntPtr GetLocation;

            public IntPtr GetMetadataByName;

            public IntPtr GetEnumerator;

            public IntPtr SetMetadataByName;

            public IntPtr RemoveMetadataByName;
        }
    }
}
