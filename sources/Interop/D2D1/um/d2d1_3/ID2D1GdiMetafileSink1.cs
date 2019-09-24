// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>User-implementable interface for introspecting on a metafile.</summary>
    [Guid("FD0ECB6B-91E6-411E-8655-395E760F91B4")]
    public unsafe struct ID2D1GdiMetafileSink1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1GdiMetafileSink1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1GdiMetafileSink1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1GdiMetafileSink1* This);

        /// <summary>Callback for examining a metafile record.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ProcessRecord(ID2D1GdiMetafileSink1* This, [NativeTypeName("DWORD")] uint recordType, [Optional] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize);

        /// <summary>Callback for examining a metafile record.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ProcessRecord1(ID2D1GdiMetafileSink1* This, [NativeTypeName("DWORD")] uint recordType, [Optional] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize, [NativeTypeName("UINT32")] uint flags);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1GdiMetafileSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1GdiMetafileSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1GdiMetafileSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessRecord([NativeTypeName("DWORD")] uint recordType, [Optional] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize)
        {
            fixed (ID2D1GdiMetafileSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ProcessRecord>(lpVtbl->ProcessRecord)(This, recordType, recordData, recordDataSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessRecord1([NativeTypeName("DWORD")] uint recordType, [Optional] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize, [NativeTypeName("UINT32")] uint flags)
        {
            fixed (ID2D1GdiMetafileSink1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ProcessRecord1>(lpVtbl->ProcessRecord1)(This, recordType, recordData, recordDataSize, flags);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr ProcessRecord;

            public IntPtr ProcessRecord1;
        }
    }
}
