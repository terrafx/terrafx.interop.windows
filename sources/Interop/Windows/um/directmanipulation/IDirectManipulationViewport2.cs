// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("923CCAAC-61E1-4385-B726-017AF189882A")]
    [NativeTypeName("struct IDirectManipulationViewport2 : IDirectManipulationViewport")]
    public unsafe partial struct IDirectManipulationViewport2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, uint>)(lpVtbl[1]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, uint>)(lpVtbl[2]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Enable()
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, int>)(lpVtbl[3]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Disable()
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, int>)(lpVtbl[4]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetContact([NativeTypeName("UINT32")] uint pointerId)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, uint, int>)(lpVtbl[5]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), pointerId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseContact([NativeTypeName("UINT32")] uint pointerId)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, uint, int>)(lpVtbl[6]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), pointerId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseAllContacts()
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, int>)(lpVtbl[7]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("DIRECTMANIPULATION_STATUS *")] DIRECTMANIPULATION_STATUS* status)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, DIRECTMANIPULATION_STATUS*, int>)(lpVtbl[8]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTag([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** @object, [NativeTypeName("UINT32 *")] uint* id)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, Guid*, void**, uint*, int>)(lpVtbl[9]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), riid, @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTag([NativeTypeName("IUnknown *")] IUnknown* @object, [NativeTypeName("UINT32")] uint id)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, IUnknown*, uint, int>)(lpVtbl[10]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewportRect([NativeTypeName("RECT *")] RECT* viewport)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, RECT*, int>)(lpVtbl[11]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), viewport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetViewportRect([NativeTypeName("const RECT *")] RECT* viewport)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, RECT*, int>)(lpVtbl[12]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), viewport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ZoomToRect([NativeTypeName("const float")] float left, [NativeTypeName("const float")] float top, [NativeTypeName("const float")] float right, [NativeTypeName("const float")] float bottom, [NativeTypeName("BOOL")] int animate)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, float, float, float, float, int, int>)(lpVtbl[13]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), left, top, right, bottom, animate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetViewportTransform([NativeTypeName("const float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, float*, uint, int>)(lpVtbl[14]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), matrix, pointCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SyncDisplayTransform([NativeTypeName("const float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, float*, uint, int>)(lpVtbl[15]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), matrix, pointCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrimaryContent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** @object)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, Guid*, void**, int>)(lpVtbl[16]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), riid, @object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddContent([NativeTypeName("IDirectManipulationContent *")] IDirectManipulationContent* content)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, IDirectManipulationContent*, int>)(lpVtbl[17]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), content);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveContent([NativeTypeName("IDirectManipulationContent *")] IDirectManipulationContent* content)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, IDirectManipulationContent*, int>)(lpVtbl[18]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), content);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetViewportOptions(DIRECTMANIPULATION_VIEWPORT_OPTIONS options)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, DIRECTMANIPULATION_VIEWPORT_OPTIONS, int>)(lpVtbl[19]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, DIRECTMANIPULATION_CONFIGURATION, int>)(lpVtbl[20]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), configuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, DIRECTMANIPULATION_CONFIGURATION, int>)(lpVtbl[21]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), configuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, DIRECTMANIPULATION_CONFIGURATION, int>)(lpVtbl[22]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), configuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetManualGesture(DIRECTMANIPULATION_GESTURE_CONFIGURATION configuration)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, DIRECTMANIPULATION_GESTURE_CONFIGURATION, int>)(lpVtbl[23]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), configuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetChaining(DIRECTMANIPULATION_MOTION_TYPES enabledTypes)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, DIRECTMANIPULATION_MOTION_TYPES, int>)(lpVtbl[24]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), enabledTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddEventHandler([NativeTypeName("HWND")] IntPtr window, [NativeTypeName("IDirectManipulationViewportEventHandler *")] IDirectManipulationViewportEventHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, IntPtr, IDirectManipulationViewportEventHandler*, uint*, int>)(lpVtbl[25]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), window, eventHandler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveEventHandler([NativeTypeName("DWORD")] uint cookie)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, uint, int>)(lpVtbl[26]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInputMode(DIRECTMANIPULATION_INPUT_MODE mode)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, DIRECTMANIPULATION_INPUT_MODE, int>)(lpVtbl[27]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUpdateMode(DIRECTMANIPULATION_INPUT_MODE mode)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, DIRECTMANIPULATION_INPUT_MODE, int>)(lpVtbl[28]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, int>)(lpVtbl[29]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Abandon()
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, int>)(lpVtbl[30]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddBehavior([NativeTypeName("IUnknown *")] IUnknown* behavior, [NativeTypeName("DWORD *")] uint* cookie)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, IUnknown*, uint*, int>)(lpVtbl[31]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), behavior, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveBehavior([NativeTypeName("DWORD")] uint cookie)
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, uint, int>)(lpVtbl[32]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllBehaviors()
        {
            return ((delegate* stdcall<IDirectManipulationViewport2*, int>)(lpVtbl[33]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
        }
    }
}
