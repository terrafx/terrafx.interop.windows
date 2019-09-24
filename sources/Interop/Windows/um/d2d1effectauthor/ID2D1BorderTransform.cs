// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>An effect uses this interface to configure border generation.</summary>
    [Guid("4998735C-3A19-473C-9781-656847E3A347")]
    public unsafe struct ID2D1BorderTransform
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1BorderTransform* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1BorderTransform* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1BorderTransform* This);

        /// <summary>Return the number of input this node has.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetInputCount(ID2D1BorderTransform* This);

        /// <summary>Controls the output precision and channel-depth for this transform.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOutputBuffer(ID2D1BorderTransform* This, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);

        /// <summary>Controls whether the output of this transform is cached.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetCached(ID2D1BorderTransform* This, [NativeTypeName("BOOL")] int isCached);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetExtendModeX(ID2D1BorderTransform* This, D2D1_EXTEND_MODE extendMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetExtendModeY(ID2D1BorderTransform* This, D2D1_EXTEND_MODE extendMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_EXTEND_MODE _GetExtendModeX(ID2D1BorderTransform* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_EXTEND_MODE _GetExtendModeY(ID2D1BorderTransform* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1BorderTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1BorderTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1BorderTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            fixed (ID2D1BorderTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInputCount>(lpVtbl->GetInputCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
        {
            fixed (ID2D1BorderTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetOutputBuffer>(lpVtbl->SetOutputBuffer)(This, bufferPrecision, channelDepth);
            }
        }

        public void SetCached([NativeTypeName("BOOL")] int isCached)
        {
            fixed (ID2D1BorderTransform* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetCached>(lpVtbl->SetCached)(This, isCached);
            }
        }

        public void SetExtendModeX(D2D1_EXTEND_MODE extendMode)
        {
            fixed (ID2D1BorderTransform* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetExtendModeX>(lpVtbl->SetExtendModeX)(This, extendMode);
            }
        }

        public void SetExtendModeY(D2D1_EXTEND_MODE extendMode)
        {
            fixed (ID2D1BorderTransform* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetExtendModeY>(lpVtbl->SetExtendModeY)(This, extendMode);
            }
        }

        public D2D1_EXTEND_MODE GetExtendModeX()
        {
            fixed (ID2D1BorderTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetExtendModeX>(lpVtbl->GetExtendModeX)(This);
            }
        }

        public D2D1_EXTEND_MODE GetExtendModeY()
        {
            fixed (ID2D1BorderTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetExtendModeY>(lpVtbl->GetExtendModeY)(This);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetInputCount;

            public IntPtr SetOutputBuffer;

            public IntPtr SetCached;

            public IntPtr SetExtendModeX;

            public IntPtr SetExtendModeY;

            public IntPtr GetExtendModeX;

            public IntPtr GetExtendModeY;
        }
    }
}
