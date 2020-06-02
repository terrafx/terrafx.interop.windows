// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DAAC296F-7AA5-4DBF-8D15-225C5976F891")]
    public unsafe partial struct IWICProgressiveLevelControl
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLevelCount([NativeTypeName("UINT *")] uint* pcLevels)
        {
            return lpVtbl->GetLevelCount((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), pcLevels);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLevel([NativeTypeName("UINT *")] uint* pnLevel)
        {
            return lpVtbl->GetCurrentLevel((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), pnLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentLevel([NativeTypeName("UINT")] uint nLevel)
        {
            return lpVtbl->SetCurrentLevel((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), nLevel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICProgressiveLevelControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICProgressiveLevelControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICProgressiveLevelControl*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICProgressiveLevelControl*, uint*, int> GetLevelCount;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICProgressiveLevelControl*, uint*, int> GetCurrentLevel;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IWICProgressiveLevelControl*, uint, int> SetCurrentLevel;
        }
    }
}
