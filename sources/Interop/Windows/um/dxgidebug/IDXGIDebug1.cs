// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dxgidebug.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("C5A05F0C-16F2-4ADF-9F4D-A8C4D58AC550")]
    public unsafe struct IDXGIDebug1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDXGIDebug1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDXGIDebug1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDXGIDebug1* This
        );
        #endregion

        #region IDXGIDebug Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ReportLiveObjects(
            [In] IDXGIDebug1* This,
            [In, NativeTypeName("GUID")] Guid apiid,
            [In] DXGI_DEBUG_RLO_FLAGS flags
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _EnableLeakTrackingForThread(
            [In] IDXGIDebug1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DisableLeakTrackingForThread(
            [In] IDXGIDebug1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsLeakTrackingEnabledForThread(
            [In] IDXGIDebug1* This
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIDebug1* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
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
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIDebug1* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDXGIDebug Methods
        [return: NativeTypeName("HRESULT")]
        public int ReportLiveObjects(
            [In, NativeTypeName("GUID")] Guid apiid,
            [In] DXGI_DEBUG_RLO_FLAGS flags
        )
        {
            fixed (IDXGIDebug1* This = &this)
            {
                return MarshalFunction<_ReportLiveObjects>(lpVtbl->ReportLiveObjects)(
                    This,
                    apiid,
                    flags
                );
            }
        }
        #endregion

        #region Methods
        public void EnableLeakTrackingForThread()
        {
            fixed (IDXGIDebug1* This = &this)
            {
                MarshalFunction<_EnableLeakTrackingForThread>(lpVtbl->EnableLeakTrackingForThread)(
                    This
                );
            }
        }

        public void DisableLeakTrackingForThread()
        {
            fixed (IDXGIDebug1* This = &this)
            {
                MarshalFunction<_DisableLeakTrackingForThread>(lpVtbl->DisableLeakTrackingForThread)(
                    This
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsLeakTrackingEnabledForThread()
        {
            fixed (IDXGIDebug1* This = &this)
            {
                return MarshalFunction<_IsLeakTrackingEnabledForThread>(lpVtbl->IsLeakTrackingEnabledForThread)(
                    This
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region IDXGIDebug Fields
            public IntPtr ReportLiveObjects;
            #endregion

            #region Fields
            public IntPtr EnableLeakTrackingForThread;

            public IntPtr DisableLeakTrackingForThread;

            public IntPtr IsLeakTrackingEnabledForThread;
            #endregion
        }
        #endregion
    }
}
