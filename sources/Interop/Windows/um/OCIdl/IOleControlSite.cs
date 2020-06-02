// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B289-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IOleControlSite
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleControlSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnControlInfoChanged()
        {
            return lpVtbl->OnControlInfoChanged((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockInPlaceActive([NativeTypeName("BOOL")] int fLock)
        {
            return lpVtbl->LockInPlaceActive((IOleControlSite*)Unsafe.AsPointer(ref this), fLock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExtendedControl([NativeTypeName("IDispatch **")] IDispatch** ppDisp)
        {
            return lpVtbl->GetExtendedControl((IOleControlSite*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [return: NativeTypeName("HRESULT")]
        public int TransformCoords([NativeTypeName("POINTL *")] POINTL* pPtlHimetric, [NativeTypeName("POINTF *")] POINTF* pPtfContainer, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->TransformCoords((IOleControlSite*)Unsafe.AsPointer(ref this), pPtlHimetric, pPtfContainer, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorA([NativeTypeName("MSG *")] MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers)
        {
            return lpVtbl->TranslateAcceleratorA((IOleControlSite*)Unsafe.AsPointer(ref this), pMsg, grfModifiers);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnFocus([NativeTypeName("BOOL")] int fGotFocus)
        {
            return lpVtbl->OnFocus((IOleControlSite*)Unsafe.AsPointer(ref this), fGotFocus);
        }

        [return: NativeTypeName("HRESULT")]
        public int ShowPropertyFrame()
        {
            return lpVtbl->ShowPropertyFrame((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleControlSite*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleControlSite*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleControlSite*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleControlSite*, int> OnControlInfoChanged;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleControlSite*, int, int> LockInPlaceActive;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleControlSite*, IDispatch**, int> GetExtendedControl;

            [NativeTypeName("HRESULT (POINTL *, POINTF *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IOleControlSite*, POINTL*, POINTF*, uint, int> TransformCoords;

            [NativeTypeName("HRESULT (MSG *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IOleControlSite*, MSG*, uint, int> TranslateAcceleratorA;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleControlSite*, int, int> OnFocus;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleControlSite*, int> ShowPropertyFrame;
        }
    }
}
