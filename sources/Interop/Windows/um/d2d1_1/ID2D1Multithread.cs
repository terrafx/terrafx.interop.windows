// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>A locking mechanism from a Direct2D factory that Direct2D uses to control exclusive resource access in an app that is uses multiple threads.</summary>
    [Guid("31E6E7BC-E0FF-4D46-8C64-A0A8C41C15D3")]
    public unsafe struct ID2D1Multithread
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1Multithread* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1Multithread* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1Multithread* This
        );

        /// <summary>Returns whether the D2D factory was created with D2D1_FACTORY_TYPE_MULTI_THREADED.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _GetMultithreadProtected(
            [In] ID2D1Multithread* This
        );

        /// <summary>Enters the D2D API critical section, if it exists.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _Enter(
            [In] ID2D1Multithread* This
        );

        /// <summary>Leaves the D2D API critical section, if it exists.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _Leave(
            [In] ID2D1Multithread* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1Multithread* This = &this)
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
            fixed (ID2D1Multithread* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Multithread* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetMultithreadProtected()
        {
            fixed (ID2D1Multithread* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMultithreadProtected>(lpVtbl->GetMultithreadProtected)(
                    This
                );
            }
        }

        public void Enter()
        {
            fixed (ID2D1Multithread* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Enter>(lpVtbl->Enter)(
                    This
                );
            }
        }

        public void Leave()
        {
            fixed (ID2D1Multithread* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Leave>(lpVtbl->Leave)(
                    This
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetMultithreadProtected;

            public IntPtr Enter;

            public IntPtr Leave;
        }
    }
}
