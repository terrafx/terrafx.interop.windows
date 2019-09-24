// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dxgidebug.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("C5A05F0C-16F2-4ADF-9F4D-A8C4D58AC550")]
    public unsafe struct IDXGIDebug1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDXGIDebug1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDXGIDebug1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDXGIDebug1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ReportLiveObjects(
            [In] IDXGIDebug1* This,
            [In, NativeTypeName("GUID")] Guid apiid,
            [In] DXGI_DEBUG_RLO_FLAGS flags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _EnableLeakTrackingForThread(
            [In] IDXGIDebug1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DisableLeakTrackingForThread(
            [In] IDXGIDebug1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsLeakTrackingEnabledForThread(
            [In] IDXGIDebug1* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIDebug1* This = &this)
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
            fixed (IDXGIDebug1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIDebug1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportLiveObjects(
            [In, NativeTypeName("GUID")] Guid apiid,
            [In] DXGI_DEBUG_RLO_FLAGS flags
        )
        {
            fixed (IDXGIDebug1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReportLiveObjects>(lpVtbl->ReportLiveObjects)(
                    This,
                    apiid,
                    flags
                );
            }
        }

        public void EnableLeakTrackingForThread()
        {
            fixed (IDXGIDebug1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_EnableLeakTrackingForThread>(lpVtbl->EnableLeakTrackingForThread)(
                    This
                );
            }
        }

        public void DisableLeakTrackingForThread()
        {
            fixed (IDXGIDebug1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DisableLeakTrackingForThread>(lpVtbl->DisableLeakTrackingForThread)(
                    This
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsLeakTrackingEnabledForThread()
        {
            fixed (IDXGIDebug1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsLeakTrackingEnabledForThread>(lpVtbl->IsLeakTrackingEnabledForThread)(
                    This
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr ReportLiveObjects;

            public IntPtr EnableLeakTrackingForThread;

            public IntPtr DisableLeakTrackingForThread;

            public IntPtr IsLeakTrackingEnabledForThread;
        }
    }
}
