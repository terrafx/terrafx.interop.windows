// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\objidlbase.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000100-0000-0000-C000-000000000046")]
    public unsafe struct IEnumUnknown
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IEnumUnknown* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IEnumUnknown* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IEnumUnknown* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Next(
            [In] IEnumUnknown* This,
            [In, NativeTypeName("ULONG")] uint celt,
            [Out] IUnknown** rgelt,
            [Out, NativeTypeName("ULONG")] uint* pceltFetched = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Skip(
            [In] IEnumUnknown* This,
            [In, NativeTypeName("ULONG")] uint celt
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reset(
            [In] IEnumUnknown* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(
            [In] IEnumUnknown* This,
            [Out] IEnumUnknown** ppenum = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IEnumUnknown* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IEnumUnknown* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IEnumUnknown* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Next(
            [In, NativeTypeName("ULONG")] uint celt,
            [Out] IUnknown** rgelt,
            [Out, NativeTypeName("ULONG")] uint* pceltFetched = null
        )
        {
            fixed (IEnumUnknown* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Next>(lpVtbl->Next)(
                    This,
                    celt,
                    rgelt,
                    pceltFetched
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip(
            [In, NativeTypeName("ULONG")] uint celt
        )
        {
            fixed (IEnumUnknown* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Skip>(lpVtbl->Skip)(
                    This,
                    celt
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            fixed (IEnumUnknown* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone(
            [Out] IEnumUnknown** ppenum = null
        )
        {
            fixed (IEnumUnknown* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)(
                    This,
                    ppenum
                );
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
