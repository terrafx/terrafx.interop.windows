// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>A locking mechanism from a Direct2D factory that Direct2D uses to control exclusive resource access in an app that is uses multiple threads.</summary>
    [Guid("31E6E7BC-E0FF-4D46-8C64-A0A8C41C15D3")]
    public unsafe partial struct ID2D1Multithread
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1Multithread* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1Multithread* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1Multithread* This);

        /// <summary>Returns whether the D2D factory was created with D2D1_FACTORY_TYPE_MULTI_THREADED.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetMultithreadProtected(ID2D1Multithread* This);

        /// <summary>Enters the D2D API critical section, if it exists.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Enter(ID2D1Multithread* This);

        /// <summary>Leaves the D2D API critical section, if it exists.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Leave(ID2D1Multithread* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1Multithread* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1Multithread* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Multithread* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetMultithreadProtected()
        {
            fixed (ID2D1Multithread* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMultithreadProtected>(lpVtbl->GetMultithreadProtected)(This);
            }
        }

        public void Enter()
        {
            fixed (ID2D1Multithread* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Enter>(lpVtbl->Enter)(This);
            }
        }

        public void Leave()
        {
            fixed (ID2D1Multithread* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Leave>(lpVtbl->Leave)(This);
            }
        }

        public partial struct Vtbl
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
