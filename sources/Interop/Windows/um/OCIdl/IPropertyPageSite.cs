// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B28C-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IPropertyPageSite
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPropertyPageSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPropertyPageSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPropertyPageSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnStatusChange([NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->OnStatusChange((IPropertyPageSite*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleID([NativeTypeName("LCID *")] uint* pLocaleID)
        {
            return lpVtbl->GetLocaleID((IPropertyPageSite*)Unsafe.AsPointer(ref this), pLocaleID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPageContainer([NativeTypeName("IUnknown **")] IUnknown** ppUnk)
        {
            return lpVtbl->GetPageContainer((IPropertyPageSite*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorA([NativeTypeName("MSG *")] MSG* pMsg)
        {
            return lpVtbl->TranslateAcceleratorA((IPropertyPageSite*)Unsafe.AsPointer(ref this), pMsg);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPageSite*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPageSite*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPageSite*, uint> Release;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPageSite*, uint, int> OnStatusChange;

            [NativeTypeName("HRESULT (LCID *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPageSite*, uint*, int> GetLocaleID;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPageSite*, IUnknown**, int> GetPageContainer;

            [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPageSite*, MSG*, int> TranslateAcceleratorA;
        }
    }
}
