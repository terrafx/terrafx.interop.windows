// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868B4-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IVideoWindow : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IVideoWindow
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVideoWindow*, Guid*, void**, int>)(lpVtbl[0]))((IVideoWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVideoWindow*, uint>)(lpVtbl[1]))((IVideoWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVideoWindow*, uint>)(lpVtbl[2]))((IVideoWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IVideoWindow*, uint*, int>)(lpVtbl[3]))((IVideoWindow*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IVideoWindow*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IVideoWindow*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IVideoWindow*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IVideoWindow*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IVideoWindow*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_Caption([NativeTypeName("BSTR")] ushort* strCaption)
        {
            return ((delegate* unmanaged<IVideoWindow*, ushort*, int>)(lpVtbl[7]))((IVideoWindow*)Unsafe.AsPointer(ref this), strCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Caption([NativeTypeName("BSTR *")] ushort** strCaption)
        {
            return ((delegate* unmanaged<IVideoWindow*, ushort**, int>)(lpVtbl[8]))((IVideoWindow*)Unsafe.AsPointer(ref this), strCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_WindowStyle([NativeTypeName("long")] int WindowStyle)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[9]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_WindowStyle([NativeTypeName("long *")] int* WindowStyle)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[10]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_WindowStyleEx([NativeTypeName("long")] int WindowStyleEx)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[11]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowStyleEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_WindowStyleEx([NativeTypeName("long *")] int* WindowStyleEx)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[12]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowStyleEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_AutoShow([NativeTypeName("long")] int AutoShow)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[13]))((IVideoWindow*)Unsafe.AsPointer(ref this), AutoShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_AutoShow([NativeTypeName("long *")] int* AutoShow)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[14]))((IVideoWindow*)Unsafe.AsPointer(ref this), AutoShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_WindowState([NativeTypeName("long")] int WindowState)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[15]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_WindowState([NativeTypeName("long *")] int* WindowState)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[16]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_BackgroundPalette([NativeTypeName("long")] int BackgroundPalette)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[17]))((IVideoWindow*)Unsafe.AsPointer(ref this), BackgroundPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_BackgroundPalette([NativeTypeName("long *")] int* pBackgroundPalette)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[18]))((IVideoWindow*)Unsafe.AsPointer(ref this), pBackgroundPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_Visible([NativeTypeName("long")] int Visible)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[19]))((IVideoWindow*)Unsafe.AsPointer(ref this), Visible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_Visible([NativeTypeName("long *")] int* pVisible)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[20]))((IVideoWindow*)Unsafe.AsPointer(ref this), pVisible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_Left([NativeTypeName("long")] int Left)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[21]))((IVideoWindow*)Unsafe.AsPointer(ref this), Left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_Left([NativeTypeName("long *")] int* pLeft)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[22]))((IVideoWindow*)Unsafe.AsPointer(ref this), pLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_Width([NativeTypeName("long")] int Width)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[23]))((IVideoWindow*)Unsafe.AsPointer(ref this), Width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_Width([NativeTypeName("long *")] int* pWidth)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[24]))((IVideoWindow*)Unsafe.AsPointer(ref this), pWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_Top([NativeTypeName("long")] int Top)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[25]))((IVideoWindow*)Unsafe.AsPointer(ref this), Top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_Top([NativeTypeName("long *")] int* pTop)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[26]))((IVideoWindow*)Unsafe.AsPointer(ref this), pTop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_Height([NativeTypeName("long")] int Height)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[27]))((IVideoWindow*)Unsafe.AsPointer(ref this), Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_Height([NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[28]))((IVideoWindow*)Unsafe.AsPointer(ref this), pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_Owner(OAHWND Owner)
        {
            return ((delegate* unmanaged<IVideoWindow*, OAHWND, int>)(lpVtbl[29]))((IVideoWindow*)Unsafe.AsPointer(ref this), Owner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_Owner(OAHWND* Owner)
        {
            return ((delegate* unmanaged<IVideoWindow*, OAHWND*, int>)(lpVtbl[30]))((IVideoWindow*)Unsafe.AsPointer(ref this), Owner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_MessageDrain(OAHWND Drain)
        {
            return ((delegate* unmanaged<IVideoWindow*, OAHWND, int>)(lpVtbl[31]))((IVideoWindow*)Unsafe.AsPointer(ref this), Drain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_MessageDrain(OAHWND* Drain)
        {
            return ((delegate* unmanaged<IVideoWindow*, OAHWND*, int>)(lpVtbl[32]))((IVideoWindow*)Unsafe.AsPointer(ref this), Drain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_BorderColor([NativeTypeName("long *")] int* Color)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[33]))((IVideoWindow*)Unsafe.AsPointer(ref this), Color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT put_BorderColor([NativeTypeName("long")] int Color)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[34]))((IVideoWindow*)Unsafe.AsPointer(ref this), Color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_FullScreenMode([NativeTypeName("long *")] int* FullScreenMode)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[35]))((IVideoWindow*)Unsafe.AsPointer(ref this), FullScreenMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT put_FullScreenMode([NativeTypeName("long")] int FullScreenMode)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[36]))((IVideoWindow*)Unsafe.AsPointer(ref this), FullScreenMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT SetWindowForeground([NativeTypeName("long")] int Focus)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[37]))((IVideoWindow*)Unsafe.AsPointer(ref this), Focus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT NotifyOwnerMessage(OAHWND hwnd, [NativeTypeName("long")] int uMsg, [NativeTypeName("LONG_PTR")] nint wParam, [NativeTypeName("LONG_PTR")] nint lParam)
        {
            return ((delegate* unmanaged<IVideoWindow*, OAHWND, int, nint, nint, int>)(lpVtbl[38]))((IVideoWindow*)Unsafe.AsPointer(ref this), hwnd, uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT SetWindowPosition([NativeTypeName("long")] int Left, [NativeTypeName("long")] int Top, [NativeTypeName("long")] int Width, [NativeTypeName("long")] int Height)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int, int, int, int>)(lpVtbl[39]))((IVideoWindow*)Unsafe.AsPointer(ref this), Left, Top, Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT GetWindowPosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int*, int*, int*, int>)(lpVtbl[40]))((IVideoWindow*)Unsafe.AsPointer(ref this), pLeft, pTop, pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT GetMinIdealImageSize([NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int*, int>)(lpVtbl[41]))((IVideoWindow*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT GetMaxIdealImageSize([NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int*, int>)(lpVtbl[42]))((IVideoWindow*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT GetRestorePosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int*, int*, int*, int>)(lpVtbl[43]))((IVideoWindow*)Unsafe.AsPointer(ref this), pLeft, pTop, pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT HideCursor([NativeTypeName("long")] int HideCursor)
        {
            return ((delegate* unmanaged<IVideoWindow*, int, int>)(lpVtbl[44]))((IVideoWindow*)Unsafe.AsPointer(ref this), HideCursor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT IsCursorHidden([NativeTypeName("long *")] int* CursorHidden)
        {
            return ((delegate* unmanaged<IVideoWindow*, int*, int>)(lpVtbl[45]))((IVideoWindow*)Unsafe.AsPointer(ref this), CursorHidden);
        }
    }
}
