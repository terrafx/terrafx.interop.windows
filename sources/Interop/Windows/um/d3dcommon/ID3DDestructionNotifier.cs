// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
    public unsafe struct ID3DDestructionNotifier
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID3DDestructionNotifier* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID3DDestructionNotifier* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID3DDestructionNotifier* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RegisterDestructionCallback(
            [In] ID3DDestructionNotifier* This,
            [In, NativeTypeName("PFN_DESTRUCTION_CALLBACK")] IntPtr callbackFn,
            [In] void* pData,
            [Out, NativeTypeName("UINT")] uint* pCallbackID
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _UnregisterDestructionCallback(
            [In] ID3DDestructionNotifier* This,
            [In, NativeTypeName("UINT")] uint callbackID
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID3DDestructionNotifier* This = &this)
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
            fixed (ID3DDestructionNotifier* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3DDestructionNotifier* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterDestructionCallback(
            [In, NativeTypeName("PFN_DESTRUCTION_CALLBACK")] IntPtr callbackFn,
            [In] void* pData,
            [Out, NativeTypeName("UINT")] uint* pCallbackID
        )
        {
            fixed (ID3DDestructionNotifier* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterDestructionCallback>(lpVtbl->RegisterDestructionCallback)(
                    This,
                    callbackFn,
                    pData,
                    pCallbackID
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterDestructionCallback(
            [In, NativeTypeName("UINT")] uint callbackID
        )
        {
            fixed (ID3DDestructionNotifier* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UnregisterDestructionCallback>(lpVtbl->UnregisterDestructionCallback)(
                    This,
                    callbackID
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr RegisterDestructionCallback;

            public IntPtr UnregisterDestructionCallback;
        }
    }
}
