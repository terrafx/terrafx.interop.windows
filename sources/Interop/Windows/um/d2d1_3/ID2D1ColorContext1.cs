// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Represents a color context to be used with the Color Management Effect.</summary>
    [Guid("1AB42875-C57F-4BE9-BD85-9CD78D6F55EE")]
    public unsafe struct ID2D1ColorContext1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1ColorContext1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1ColorContext1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1ColorContext1* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1ColorContext1* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1ColorContext Delegates
        /// <summary>Retrieves the color space of the color context.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_COLOR_SPACE _GetColorSpace(
            [In] ID2D1ColorContext1* This
        );

        /// <summary>Retrieves the size of the color profile, in bytes.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetProfileSize(
            [In] ID2D1ColorContext1* This
        );

        /// <summary>Retrieves the color profile bytes.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetProfile(
            [In] ID2D1ColorContext1* This,
            [Out, NativeTypeName("BYTE[]")] byte* profile,
            [In, NativeTypeName("UINT32")] uint profileSize
        );
        #endregion

        #region Delegates
        /// <summary>Retrieves the color context type.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_COLOR_CONTEXT_TYPE _GetColorContextType(
            [In] ID2D1ColorContext1* This
        );

        /// <summary>Retrieves the DXGI color space of this context. Returns DXGI_COLOR_SPACE_CUSTOM when color context type is ICC.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DXGI_COLOR_SPACE_TYPE _GetDXGIColorSpace(
            [In] ID2D1ColorContext1* This
        );

        /// <summary>Retrieves a set simple color profile.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSimpleColorProfile(
            [In] ID2D1ColorContext1* This,
            [Out] D2D1_SIMPLE_COLOR_PROFILE* simpleProfile
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1ColorContext1* This = &this)
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
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1Resource Methods
        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1ColorContext Methods
        public D2D1_COLOR_SPACE GetColorSpace()
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorSpace>(lpVtbl->GetColorSpace)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetProfileSize()
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetProfileSize>(lpVtbl->GetProfileSize)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProfile(
            [Out, NativeTypeName("BYTE[]")] byte* profile,
            [In, NativeTypeName("UINT32")] uint profileSize
        )
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetProfile>(lpVtbl->GetProfile)(
                    This,
                    profile,
                    profileSize
                );
            }
        }
        #endregion

        #region Methods
        public D2D1_COLOR_CONTEXT_TYPE GetColorContextType()
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorContextType>(lpVtbl->GetColorContextType)(
                    This
                );
            }
        }

        public DXGI_COLOR_SPACE_TYPE GetDXGIColorSpace()
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDXGIColorSpace>(lpVtbl->GetDXGIColorSpace)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSimpleColorProfile(
            [Out] D2D1_SIMPLE_COLOR_PROFILE* simpleProfile
        )
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSimpleColorProfile>(lpVtbl->GetSimpleColorProfile)(
                    This,
                    simpleProfile
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

            #region ID2D1Resource Fields
            public IntPtr GetFactory;
            #endregion

            #region ID2D1ColorContext Fields
            public IntPtr GetColorSpace;

            public IntPtr GetProfileSize;

            public IntPtr GetProfile;
            #endregion

            #region Fields
            public IntPtr GetColorContextType;

            public IntPtr GetDXGIColorSpace;

            public IntPtr GetSimpleColorProfile;
            #endregion
        }
        #endregion
    }
}
