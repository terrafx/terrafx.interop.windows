// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IWICProgressiveLevelControl
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICProgressiveLevelControl* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICProgressiveLevelControl* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICProgressiveLevelControl* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLevelCount(IWICProgressiveLevelControl* pThis, [NativeTypeName("UINT *")] uint* pcLevels);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentLevel(IWICProgressiveLevelControl* pThis, [NativeTypeName("UINT *")] uint* pnLevel);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCurrentLevel(IWICProgressiveLevelControl* pThis, [NativeTypeName("UINT")] uint nLevel);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLevelCount([NativeTypeName("UINT *")] uint* pcLevels)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLevelCount>(lpVtbl->GetLevelCount)((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), pcLevels);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLevel([NativeTypeName("UINT *")] uint* pnLevel)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurrentLevel>(lpVtbl->GetCurrentLevel)((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), pnLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentLevel([NativeTypeName("UINT")] uint nLevel)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCurrentLevel>(lpVtbl->SetCurrentLevel)((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), nLevel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetLevelCount;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetCurrentLevel;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr SetCurrentLevel;
        }
    }
}
