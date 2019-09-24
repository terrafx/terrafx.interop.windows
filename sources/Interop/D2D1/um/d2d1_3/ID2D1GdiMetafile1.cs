// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Interface encapsulating a GDI/GDI+ metafile.</summary>
    [Guid("2E69F9E8-DD3F-4BF9-95BA-C04F49D788DF")]
    public unsafe struct ID2D1GdiMetafile1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1GdiMetafile1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1GdiMetafile1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1GdiMetafile1* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1GdiMetafile1* This, ID2D1Factory** factory);

        /// <summary>Play the metafile into a caller-supplied sink interface.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Stream(ID2D1GdiMetafile1* This, ID2D1GdiMetafileSink* sink);

        /// <summary>Gets the bounds of the metafile.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBounds(ID2D1GdiMetafile1* This, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds);

        /// <summary>Returns the DPI reported by the metafile.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDpi(ID2D1GdiMetafile1* This, [NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY);

        /// <summary>Gets the bounds (in DIPs) of the metafile (as specified by the frame rect declared in the metafile).</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSourceBounds(ID2D1GdiMetafile1* This, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1GdiMetafile1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1GdiMetafile1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1GdiMetafile1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1GdiMetafile1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Stream(ID2D1GdiMetafileSink* sink)
        {
            fixed (ID2D1GdiMetafile1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Stream>(lpVtbl->Stream)(This, sink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBounds([NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds)
        {
            fixed (ID2D1GdiMetafile1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBounds>(lpVtbl->GetBounds)(This, bounds);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDpi([NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY)
        {
            fixed (ID2D1GdiMetafile1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDpi>(lpVtbl->GetDpi)(This, dpiX, dpiY);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceBounds([NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds)
        {
            fixed (ID2D1GdiMetafile1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSourceBounds>(lpVtbl->GetSourceBounds)(This, bounds);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr Stream;

            public IntPtr GetBounds;

            public IntPtr GetDpi;

            public IntPtr GetSourceBounds;
        }
    }
}
