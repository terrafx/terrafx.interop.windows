// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868B4-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IVideoWindow : IDispatch")]
    public unsafe partial struct IVideoWindow
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVideoWindow*, Guid*, void**, int>)(lpVtbl[0]))((IVideoWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVideoWindow*, uint>)(lpVtbl[1]))((IVideoWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVideoWindow*, uint>)(lpVtbl[2]))((IVideoWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IVideoWindow*, uint*, int>)(lpVtbl[3]))((IVideoWindow*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IVideoWindow*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IVideoWindow*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IVideoWindow*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IVideoWindow*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IVideoWindow*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Caption([NativeTypeName("BSTR")] ushort* strCaption)
        {
            return ((delegate* unmanaged<IVideoWindow*, ushort*, int>)(lpVtbl[7]))((IVideoWindow*)Unsafe.AsPointer(ref this), strCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Caption([NativeTypeName("BSTR *")] ushort** strCaption)
        {
            return ((delegate* unmanaged<IVideoWindow*, ushort**, int>)(lpVtbl[8]))((IVideoWindow*)Unsafe.AsPointer(ref this), strCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_WindowStyle([NativeTypeName("long")] int WindowStyle)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[9]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_WindowStyle([NativeTypeName("long *")] int* WindowStyle)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[10]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_WindowStyleEx([NativeTypeName("long")] int WindowStyleEx)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[11]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowStyleEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_WindowStyleEx([NativeTypeName("long *")] int* WindowStyleEx)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[12]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowStyleEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_AutoShow([NativeTypeName("long")] int AutoShow)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[13]))((IVideoWindow*)Unsafe.AsPointer(ref this), AutoShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AutoShow([NativeTypeName("long *")] int* AutoShow)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[14]))((IVideoWindow*)Unsafe.AsPointer(ref this), AutoShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_WindowState([NativeTypeName("long")] int WindowState)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[15]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_WindowState([NativeTypeName("long *")] int* WindowState)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[16]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BackgroundPalette([NativeTypeName("long")] int BackgroundPalette)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[17]))((IVideoWindow*)Unsafe.AsPointer(ref this), BackgroundPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BackgroundPalette([NativeTypeName("long *")] int* pBackgroundPalette)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[18]))((IVideoWindow*)Unsafe.AsPointer(ref this), pBackgroundPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Visible([NativeTypeName("long")] int Visible)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[19]))((IVideoWindow*)Unsafe.AsPointer(ref this), Visible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Visible([NativeTypeName("long *")] int* pVisible)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[20]))((IVideoWindow*)Unsafe.AsPointer(ref this), pVisible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Left([NativeTypeName("long")] int Left)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[21]))((IVideoWindow*)Unsafe.AsPointer(ref this), Left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Left([NativeTypeName("long *")] int* pLeft)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[22]))((IVideoWindow*)Unsafe.AsPointer(ref this), pLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Width([NativeTypeName("long")] int Width)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[23]))((IVideoWindow*)Unsafe.AsPointer(ref this), Width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Width([NativeTypeName("long *")] int* pWidth)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[24]))((IVideoWindow*)Unsafe.AsPointer(ref this), pWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Top([NativeTypeName("long")] int Top)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[25]))((IVideoWindow*)Unsafe.AsPointer(ref this), Top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Top([NativeTypeName("long *")] int* pTop)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[26]))((IVideoWindow*)Unsafe.AsPointer(ref this), pTop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Height([NativeTypeName("long")] int Height)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[27]))((IVideoWindow*)Unsafe.AsPointer(ref this), Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Height([NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[28]))((IVideoWindow*)Unsafe.AsPointer(ref this), pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Owner([NativeTypeName("OAHWND")] nint Owner)
        {
            return ((delegate* unmanaged<IVideoWindow*, nint, int>)(lpVtbl[29]))((IVideoWindow*)Unsafe.AsPointer(ref this), Owner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Owner([NativeTypeName("OAHWND *")] nint* Owner)
        {
            return ((delegate* unmanaged<IVideoWindow*, nint*, int>)(lpVtbl[30]))((IVideoWindow*)Unsafe.AsPointer(ref this), Owner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_MessageDrain([NativeTypeName("OAHWND")] nint Drain)
        {
            return ((delegate* unmanaged<IVideoWindow*, nint, int>)(lpVtbl[31]))((IVideoWindow*)Unsafe.AsPointer(ref this), Drain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MessageDrain([NativeTypeName("OAHWND *")] nint* Drain)
        {
            return ((delegate* unmanaged<IVideoWindow*, nint*, int>)(lpVtbl[32]))((IVideoWindow*)Unsafe.AsPointer(ref this), Drain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BorderColor([NativeTypeName("long *")] int* Color)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[33]))((IVideoWindow*)Unsafe.AsPointer(ref this), Color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BorderColor([NativeTypeName("long")] int Color)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[34]))((IVideoWindow*)Unsafe.AsPointer(ref this), Color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FullScreenMode([NativeTypeName("long *")] int* FullScreenMode)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[35]))((IVideoWindow*)Unsafe.AsPointer(ref this), FullScreenMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_FullScreenMode([NativeTypeName("long")] int FullScreenMode)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[36]))((IVideoWindow*)Unsafe.AsPointer(ref this), FullScreenMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWindowForeground([NativeTypeName("long")] int Focus)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[37]))((IVideoWindow*)Unsafe.AsPointer(ref this), Focus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyOwnerMessage([NativeTypeName("OAHWND")] nint hwnd, [NativeTypeName("long")] int uMsg, [NativeTypeName("LONG_PTR")] nint wParam, [NativeTypeName("LONG_PTR")] nint lParam)
        {
            return ((delegate* unmanaged<IVideoWindow*, nint, int, nint, nint, int>)(lpVtbl[38]))((IVideoWindow*)Unsafe.AsPointer(ref this), hwnd, uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWindowPosition([NativeTypeName("long")] int Left, [NativeTypeName("long")] int Top, [NativeTypeName("long")] int Width, [NativeTypeName("long")] int Height)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int, int, int, int>)(lpVtbl[39]))((IVideoWindow*)Unsafe.AsPointer(ref this), Left, Top, Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindowPosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int*, int*, int*, int>)(lpVtbl[40]))((IVideoWindow*)Unsafe.AsPointer(ref this), pLeft, pTop, pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMinIdealImageSize([NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int*, int>)(lpVtbl[41]))((IVideoWindow*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxIdealImageSize([NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int*, int>)(lpVtbl[42]))((IVideoWindow*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRestorePosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int*, int*, int*, int>)(lpVtbl[43]))((IVideoWindow*)Unsafe.AsPointer(ref this), pLeft, pTop, pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HideCursor([NativeTypeName("long")] int HideCursor)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[44]))((IVideoWindow*)Unsafe.AsPointer(ref this), HideCursor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsCursorHidden([NativeTypeName("long *")] int* CursorHidden)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[45]))((IVideoWindow*)Unsafe.AsPointer(ref this), CursorHidden);
        }
    }
}
