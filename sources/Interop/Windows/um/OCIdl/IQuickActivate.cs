// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CF51ED10-62FE-11CF-BF86-00A0C9034836")]
    public unsafe partial struct IQuickActivate
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IQuickActivate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IQuickActivate*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IQuickActivate*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int QuickActivate([NativeTypeName("QACONTAINER *")] QACONTAINER* pQaContainer, [NativeTypeName("QACONTROL *")] QACONTROL* pQaControl)
        {
            return lpVtbl->QuickActivate((IQuickActivate*)Unsafe.AsPointer(ref this), pQaContainer, pQaControl);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel)
        {
            return lpVtbl->SetContentExtent((IQuickActivate*)Unsafe.AsPointer(ref this), pSizel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel)
        {
            return lpVtbl->GetContentExtent((IQuickActivate*)Unsafe.AsPointer(ref this), pSizel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IQuickActivate*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IQuickActivate*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IQuickActivate*, uint> Release;

            [NativeTypeName("HRESULT (QACONTAINER *, QACONTROL *) __attribute__((stdcall))")]
            public delegate* stdcall<IQuickActivate*, QACONTAINER*, QACONTROL*, int> QuickActivate;

            [NativeTypeName("HRESULT (LPSIZEL) __attribute__((stdcall))")]
            public delegate* stdcall<IQuickActivate*, SIZE*, int> SetContentExtent;

            [NativeTypeName("HRESULT (LPSIZEL) __attribute__((stdcall))")]
            public delegate* stdcall<IQuickActivate*, SIZE*, int> GetContentExtent;
        }
    }
}
