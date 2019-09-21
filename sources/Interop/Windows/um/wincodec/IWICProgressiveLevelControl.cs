// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("DAAC296F-7AA5-4DBF-8D15-225C5976F891")]
    public unsafe struct IWICProgressiveLevelControl
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICProgressiveLevelControl* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICProgressiveLevelControl* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICProgressiveLevelControl* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLevelCount(
            [In] IWICProgressiveLevelControl* This,
            [Out, NativeTypeName("UINT")] uint* pcLevels
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetCurrentLevel(
            [In] IWICProgressiveLevelControl* This,
            [Out, NativeTypeName("UINT")] uint* pnLevel
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetCurrentLevel(
            [In] IWICProgressiveLevelControl* This,
            [In, NativeTypeName("UINT")] uint nLevel
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICProgressiveLevelControl* This = &this)
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
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int GetLevelCount(
            [Out, NativeTypeName("UINT")] uint* pcLevels
        )
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLevelCount>(lpVtbl->GetLevelCount)(
                    This,
                    pcLevels
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLevel(
            [Out, NativeTypeName("UINT")] uint* pnLevel
        )
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCurrentLevel>(lpVtbl->GetCurrentLevel)(
                    This,
                    pnLevel
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentLevel(
            [In, NativeTypeName("UINT")] uint nLevel
        )
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetCurrentLevel>(lpVtbl->SetCurrentLevel)(
                    This,
                    nLevel
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

            #region Fields
            public IntPtr GetLevelCount;

            public IntPtr GetCurrentLevel;

            public IntPtr SetCurrentLevel;
            #endregion
        }
        #endregion
    }
}
