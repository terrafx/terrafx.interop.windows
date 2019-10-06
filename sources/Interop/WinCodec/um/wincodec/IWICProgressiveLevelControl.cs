// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DAAC296F-7AA5-4DBF-8D15-225C5976F891")]
    public unsafe partial struct IWICProgressiveLevelControl
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICProgressiveLevelControl* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICProgressiveLevelControl* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICProgressiveLevelControl* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLevelCount(IWICProgressiveLevelControl* This, [NativeTypeName("UINT")] uint* pcLevels);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentLevel(IWICProgressiveLevelControl* This, [NativeTypeName("UINT")] uint* pnLevel);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCurrentLevel(IWICProgressiveLevelControl* This, [NativeTypeName("UINT")] uint nLevel);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLevelCount([NativeTypeName("UINT")] uint* pcLevels)
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLevelCount>(lpVtbl->GetLevelCount)(This, pcLevels);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLevel([NativeTypeName("UINT")] uint* pnLevel)
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCurrentLevel>(lpVtbl->GetCurrentLevel)(This, pnLevel);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentLevel([NativeTypeName("UINT")] uint nLevel)
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetCurrentLevel>(lpVtbl->SetCurrentLevel)(This, nLevel);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetLevelCount;

            public IntPtr GetCurrentLevel;

            public IntPtr SetCurrentLevel;
        }
    }
}
