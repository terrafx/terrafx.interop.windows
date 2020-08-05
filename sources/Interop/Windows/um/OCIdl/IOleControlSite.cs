// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B289-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IOleControlSite : IUnknown")]
    public unsafe partial struct IOleControlSite
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IOleControlSite*, Guid*, void**, int>)(lpVtbl[0]))((IOleControlSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IOleControlSite*, uint>)(lpVtbl[1]))((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IOleControlSite*, uint>)(lpVtbl[2]))((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnControlInfoChanged()
        {
            return ((delegate* stdcall<IOleControlSite*, int>)(lpVtbl[3]))((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockInPlaceActive([NativeTypeName("BOOL")] int fLock)
        {
            return ((delegate* stdcall<IOleControlSite*, int, int>)(lpVtbl[4]))((IOleControlSite*)Unsafe.AsPointer(ref this), fLock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExtendedControl([NativeTypeName("IDispatch **")] IDispatch** ppDisp)
        {
            return ((delegate* stdcall<IOleControlSite*, IDispatch**, int>)(lpVtbl[5]))((IOleControlSite*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [return: NativeTypeName("HRESULT")]
        public int TransformCoords([NativeTypeName("POINTL *")] POINTL* pPtlHimetric, [NativeTypeName("POINTF *")] POINTF* pPtfContainer, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IOleControlSite*, POINTL*, POINTF*, uint, int>)(lpVtbl[6]))((IOleControlSite*)Unsafe.AsPointer(ref this), pPtlHimetric, pPtfContainer, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateAccelerator([NativeTypeName("MSG *")] MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers)
        {
            return ((delegate* stdcall<IOleControlSite*, MSG*, uint, int>)(lpVtbl[7]))((IOleControlSite*)Unsafe.AsPointer(ref this), pMsg, grfModifiers);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnFocus([NativeTypeName("BOOL")] int fGotFocus)
        {
            return ((delegate* stdcall<IOleControlSite*, int, int>)(lpVtbl[8]))((IOleControlSite*)Unsafe.AsPointer(ref this), fGotFocus);
        }

        [return: NativeTypeName("HRESULT")]
        public int ShowPropertyFrame()
        {
            return ((delegate* stdcall<IOleControlSite*, int>)(lpVtbl[9]))((IOleControlSite*)Unsafe.AsPointer(ref this));
        }
    }
}
