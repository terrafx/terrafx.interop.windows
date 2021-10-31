// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106FF-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ICanvasRenderingContext2D : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ICanvasRenderingContext2D
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, Guid*, void**, int>)(lpVtbl[0]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, uint>)(lpVtbl[1]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, uint>)(lpVtbl[2]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, uint*, int>)(lpVtbl[3]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_canvas(IHTMLCanvasElement** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, IHTMLCanvasElement**, int>)(lpVtbl[7]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT restore()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[8]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT save()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[9]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT rotate(float angle)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[10]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT scale(float x, float y)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, int>)(lpVtbl[11]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT setTransform(float m11, float m12, float m21, float m22, float dx, float dy)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, float, int>)(lpVtbl[12]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), m11, m12, m21, m22, dx, dy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT transform(float m11, float m12, float m21, float m22, float dx, float dy)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, float, int>)(lpVtbl[13]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), m11, m12, m21, m22, dx, dy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT translate(float x, float y)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, int>)(lpVtbl[14]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_globalAlpha(float v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[15]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_globalAlpha(float* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[16]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_globalCompositeOperation([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[17]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_globalCompositeOperation([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[18]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_fillStyle(VARIANT v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT, int>)(lpVtbl[19]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_fillStyle(VARIANT* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT*, int>)(lpVtbl[20]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_strokeStyle(VARIANT v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT, int>)(lpVtbl[21]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_strokeStyle(VARIANT* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT*, int>)(lpVtbl[22]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT createLinearGradient(float x0, float y0, float x1, float y1, ICanvasGradient** ppCanvasGradient)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, ICanvasGradient**, int>)(lpVtbl[23]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x0, y0, x1, y1, ppCanvasGradient);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT createRadialGradient(float x0, float y0, float r0, float x1, float y1, float r1, ICanvasGradient** ppCanvasGradient)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, float, ICanvasGradient**, int>)(lpVtbl[24]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x0, y0, r0, x1, y1, r1, ppCanvasGradient);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT createPattern(IDispatch* image, VARIANT repetition, ICanvasPattern** ppCanvasPattern)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, IDispatch*, VARIANT, ICanvasPattern**, int>)(lpVtbl[25]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), image, repetition, ppCanvasPattern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT put_lineCap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[26]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_lineCap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[27]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT put_lineJoin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[28]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT get_lineJoin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[29]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT put_lineWidth(float v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[30]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT get_lineWidth(float* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[31]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT put_miterLimit(float v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[32]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_miterLimit(float* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[33]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT put_shadowBlur(float v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[34]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_shadowBlur(float* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[35]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT put_shadowColor([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[36]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_shadowColor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[37]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT put_shadowOffsetX(float v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[38]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_shadowOffsetX(float* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[39]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT put_shadowOffsetY(float v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[40]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_shadowOffsetY(float* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[41]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT clearRect(float x, float y, float w, float h)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[42]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, w, h);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT fillRect(float x, float y, float w, float h)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[43]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, w, h);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT strokeRect(float x, float y, float w, float h)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[44]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, w, h);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT arc(float x, float y, float radius, float startAngle, float endAngle, BOOL anticlockwise)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, BOOL, int>)(lpVtbl[45]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, radius, startAngle, endAngle, anticlockwise);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT arcTo(float x1, float y1, float x2, float y2, float radius)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, int>)(lpVtbl[46]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x1, y1, x2, y2, radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT beginPath()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[47]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT bezierCurveTo(float cp1x, float cp1y, float cp2x, float cp2y, float x, float y)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, float, int>)(lpVtbl[48]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), cp1x, cp1y, cp2x, cp2y, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT clip()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[49]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT closePath()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[50]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT fill()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[51]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT lineTo(float x, float y)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, int>)(lpVtbl[52]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT moveTo(float x, float y)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, int>)(lpVtbl[53]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT quadraticCurveTo(float cpx, float cpy, float x, float y)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[54]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), cpx, cpy, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT rect(float x, float y, float w, float h)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[55]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, w, h);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT stroke()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[56]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT isPointInPath(float x, float y, [NativeTypeName("VARIANT_BOOL *")] short* pResult)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, short*, int>)(lpVtbl[57]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT put_font([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[58]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT get_font([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[59]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT put_textAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[60]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT get_textAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[61]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT put_textBaseline([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[62]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT get_textBaseline([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[63]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT fillText([NativeTypeName("BSTR")] ushort* text, float x, float y, VARIANT maxWidth)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, float, float, VARIANT, int>)(lpVtbl[64]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), text, x, y, maxWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT measureText([NativeTypeName("BSTR")] ushort* text, ICanvasTextMetrics** ppCanvasTextMetrics)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, ICanvasTextMetrics**, int>)(lpVtbl[65]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), text, ppCanvasTextMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT strokeText([NativeTypeName("BSTR")] ushort* text, float x, float y, VARIANT maxWidth)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, float, float, VARIANT, int>)(lpVtbl[66]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), text, x, y, maxWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT drawImage(IDispatch* pSrc, VARIANT a1, VARIANT a2, VARIANT a3, VARIANT a4, VARIANT a5, VARIANT a6, VARIANT a7, VARIANT a8)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, IDispatch*, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[67]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), pSrc, a1, a2, a3, a4, a5, a6, a7, a8);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT createImageData(VARIANT a1, VARIANT a2, ICanvasImageData** ppCanvasImageData)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT, VARIANT, ICanvasImageData**, int>)(lpVtbl[68]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), a1, a2, ppCanvasImageData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT getImageData(float sx, float sy, float sw, float sh, ICanvasImageData** ppCanvasImageData)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, ICanvasImageData**, int>)(lpVtbl[69]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), sx, sy, sw, sh, ppCanvasImageData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT putImageData(ICanvasImageData* imagedata, float dx, float dy, VARIANT dirtyX, VARIANT dirtyY, VARIANT dirtyWidth, VARIANT dirtyHeight)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ICanvasImageData*, float, float, VARIANT, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[70]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), imagedata, dx, dy, dirtyX, dirtyY, dirtyWidth, dirtyHeight);
        }
    }
}
