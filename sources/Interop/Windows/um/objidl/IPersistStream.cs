// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\objidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("00000109-0000-0000-C000-000000000046")]
    public unsafe struct IPersistStream
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IPersistStream* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IPersistStream* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IPersistStream* This
        );
        #endregion

        #region IPersist Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetClassID(
            [In] IPersistStream* This,
            [Out, NativeTypeName("CLSID")] Guid* pClassID
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _IsDirty(
            [In] IPersistStream* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Load(
            [In] IPersistStream* This,
            [In] IStream* pStm = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Save(
            [In] IPersistStream* This,
            [In, Optional] IStream* pStm,
            [In, NativeTypeName("BOOL")] int fClearDirty
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSizeMax(
            [In] IPersistStream* This,
            [Out] ULARGE_INTEGER* pcbSize
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IPersistStream* This = &this)
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
            fixed (IPersistStream* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IPersistStream* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IPersist Methods
        [return: NativeTypeName("HRESULT")]
        public int GetClassID(
            [Out, NativeTypeName("CLSID")] Guid* pClassID
        )
        {
            fixed (IPersistStream* This = &this)
            {
                return MarshalFunction<_GetClassID>(lpVtbl->GetClassID)(
                    This,
                    pClassID
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            fixed (IPersistStream* This = &this)
            {
                return MarshalFunction<_IsDirty>(lpVtbl->IsDirty)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Load(
            [In] IStream* pStm = null
        )
        {
            fixed (IPersistStream* This = &this)
            {
                return MarshalFunction<_Load>(lpVtbl->Load)(
                    This,
                    pStm
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Save(
            [In, Optional] IStream* pStm,
            [In, NativeTypeName("BOOL")] int fClearDirty
        )
        {
            fixed (IPersistStream* This = &this)
            {
                return MarshalFunction<_Save>(lpVtbl->Save)(
                    This,
                    pStm,
                    fClearDirty
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax(
            [Out] ULARGE_INTEGER* pcbSize
        )
        {
            fixed (IPersistStream* This = &this)
            {
                return MarshalFunction<_GetSizeMax>(lpVtbl->GetSizeMax)(
                    This,
                    pcbSize
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

            #region IPersist Fields
            public IntPtr GetClassID;
            #endregion

            #region Fields
            public IntPtr IsDirty;

            public IntPtr Load;

            public IntPtr Save;

            public IntPtr GetSizeMax;
            #endregion
        }
        #endregion
    }
}
