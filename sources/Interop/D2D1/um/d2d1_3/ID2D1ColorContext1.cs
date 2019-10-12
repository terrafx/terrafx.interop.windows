// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents a color context to be used with the Color Management Effect.</summary>
    [Guid("1AB42875-C57F-4BE9-BD85-9CD78D6F55EE")]
    public unsafe partial struct ID2D1ColorContext1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1ColorContext1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1ColorContext1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1ColorContext1* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1ColorContext1* This, ID2D1Factory** factory);

        /// <summary>Retrieves the color space of the color context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_COLOR_SPACE _GetColorSpace(ID2D1ColorContext1* This);

        /// <summary>Retrieves the size of the color profile, in bytes.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetProfileSize(ID2D1ColorContext1* This);

        /// <summary>Retrieves the color profile bytes.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetProfile(ID2D1ColorContext1* This, [NativeTypeName("BYTE[]")] byte* profile, [NativeTypeName("UINT32")] uint profileSize);

        /// <summary>Retrieves the color context type.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_COLOR_CONTEXT_TYPE _GetColorContextType(ID2D1ColorContext1* This);

        /// <summary>Retrieves the DXGI color space of this context. Returns DXGI_COLOR_SPACE_CUSTOM when color context type is ICC.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DXGI_COLOR_SPACE_TYPE _GetDXGIColorSpace(ID2D1ColorContext1* This);

        /// <summary>Retrieves a set simple color profile.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSimpleColorProfile(ID2D1ColorContext1* This, D2D1_SIMPLE_COLOR_PROFILE* simpleProfile);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public D2D1_COLOR_SPACE GetColorSpace()
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorSpace>(lpVtbl->GetColorSpace)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetProfileSize()
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetProfileSize>(lpVtbl->GetProfileSize)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProfile([NativeTypeName("BYTE[]")] byte* profile, [NativeTypeName("UINT32")] uint profileSize)
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetProfile>(lpVtbl->GetProfile)(This, profile, profileSize);
            }
        }

        public D2D1_COLOR_CONTEXT_TYPE GetColorContextType()
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorContextType>(lpVtbl->GetColorContextType)(This);
            }
        }

        public DXGI_COLOR_SPACE_TYPE GetDXGIColorSpace()
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDXGIColorSpace>(lpVtbl->GetDXGIColorSpace)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSimpleColorProfile(D2D1_SIMPLE_COLOR_PROFILE* simpleProfile)
        {
            fixed (ID2D1ColorContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSimpleColorProfile>(lpVtbl->GetSimpleColorProfile)(This, simpleProfile);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetColorSpace;

            public IntPtr GetProfileSize;

            public IntPtr GetProfile;

            public IntPtr GetColorContextType;

            public IntPtr GetDXGIColorSpace;

            public IntPtr GetSimpleColorProfile;
        }
    }
}
