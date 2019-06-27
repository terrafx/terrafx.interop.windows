// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("00020403-0000-0000-C000-000000000046")]
    public unsafe struct ITypeComp
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ITypeComp* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ITypeComp* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ITypeComp* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Bind(
            [In] ITypeComp* This,
            [In, NativeTypeName("LPOLESTR")] char* szName,
            [In, NativeTypeName("ULONG")] uint lHashVal,
            [In, NativeTypeName("WORD")] ushort wFlags,
            [Out] ITypeInfo** ppTInfo,
            [Out] DESCKIND* pDescKind,
            [Out] BINDPTR* pBindPtr
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _BindType(
            [In] ITypeComp* This,
            [In, NativeTypeName("LPOLESTR")] char* szName,
            [In, NativeTypeName("ULONG")] uint lHashVal,
            [Out] ITypeInfo** ppTInfo,
            [Out] ITypeComp** ppTComp
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ITypeComp* This = &this)
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
            fixed (ITypeComp* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ITypeComp* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int Bind(
            [In, NativeTypeName("LPOLESTR")] char* szName,
            [In, NativeTypeName("ULONG")] uint lHashVal,
            [In, NativeTypeName("WORD")] ushort wFlags,
            [Out] ITypeInfo** ppTInfo,
            [Out] DESCKIND* pDescKind,
            [Out] BINDPTR* pBindPtr
        )
        {
            fixed (ITypeComp* This = &this)
            {
                return MarshalFunction<_Bind>(lpVtbl->Bind)(
                    This,
                    szName,
                    lHashVal,
                    wFlags,
                    ppTInfo,
                    pDescKind,
                    pBindPtr
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int BindType(
            [In, NativeTypeName("LPOLESTR")] char* szName,
            [In, NativeTypeName("ULONG")] uint lHashVal,
            [Out] ITypeInfo** ppTInfo,
            [Out] ITypeComp** ppTComp
        )
        {
            fixed (ITypeComp* This = &this)
            {
                return MarshalFunction<_BindType>(lpVtbl->BindType)(
                    This,
                    szName,
                    lHashVal,
                    ppTInfo,
                    ppTComp
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
            public IntPtr Bind;

            public IntPtr BindType;
            #endregion
        }
        #endregion
    }
}
