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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, uint*, int>)(lpVtbl[3]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_canvas(IHTMLCanvasElement** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, IHTMLCanvasElement**, int>)(lpVtbl[7]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int restore()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[8]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int save()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[9]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int rotate(float angle)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[10]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int scale(float x, float y)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, int>)(lpVtbl[11]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int setTransform(float m11, float m12, float m21, float m22, float dx, float dy)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, float, int>)(lpVtbl[12]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), m11, m12, m21, m22, dx, dy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int transform(float m11, float m12, float m21, float m22, float dx, float dy)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, float, int>)(lpVtbl[13]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), m11, m12, m21, m22, dx, dy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int translate(float x, float y)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, int>)(lpVtbl[14]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_globalAlpha(float v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[15]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_globalAlpha(float* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[16]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_globalCompositeOperation([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[17]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_globalCompositeOperation([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[18]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_fillStyle(VARIANT v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT, int>)(lpVtbl[19]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_fillStyle(VARIANT* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT*, int>)(lpVtbl[20]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_strokeStyle(VARIANT v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT, int>)(lpVtbl[21]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_strokeStyle(VARIANT* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT*, int>)(lpVtbl[22]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int createLinearGradient(float x0, float y0, float x1, float y1, ICanvasGradient** ppCanvasGradient)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, ICanvasGradient**, int>)(lpVtbl[23]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x0, y0, x1, y1, ppCanvasGradient);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int createRadialGradient(float x0, float y0, float r0, float x1, float y1, float r1, ICanvasGradient** ppCanvasGradient)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, float, ICanvasGradient**, int>)(lpVtbl[24]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x0, y0, r0, x1, y1, r1, ppCanvasGradient);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int createPattern(IDispatch* image, VARIANT repetition, ICanvasPattern** ppCanvasPattern)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, IDispatch*, VARIANT, ICanvasPattern**, int>)(lpVtbl[25]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), image, repetition, ppCanvasPattern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_lineCap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[26]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_lineCap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[27]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_lineJoin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[28]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_lineJoin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[29]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int put_lineWidth(float v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[30]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_lineWidth(float* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[31]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int put_miterLimit(float v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[32]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_miterLimit(float* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[33]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int put_shadowBlur(float v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[34]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_shadowBlur(float* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[35]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_shadowColor([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[36]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_shadowColor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[37]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_shadowOffsetX(float v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[38]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_shadowOffsetX(float* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[39]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int put_shadowOffsetY(float v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[40]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_shadowOffsetY(float* p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[41]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int clearRect(float x, float y, float w, float h)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[42]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, w, h);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int fillRect(float x, float y, float w, float h)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[43]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, w, h);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int strokeRect(float x, float y, float w, float h)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[44]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, w, h);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int arc(float x, float y, float radius, float startAngle, float endAngle, BOOL anticlockwise)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, BOOL, int>)(lpVtbl[45]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, radius, startAngle, endAngle, anticlockwise);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int arcTo(float x1, float y1, float x2, float y2, float radius)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, int>)(lpVtbl[46]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x1, y1, x2, y2, radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int beginPath()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[47]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int bezierCurveTo(float cp1x, float cp1y, float cp2x, float cp2y, float x, float y)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, float, int>)(lpVtbl[48]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), cp1x, cp1y, cp2x, cp2y, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int clip()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[49]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int closePath()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[50]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int fill()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[51]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int lineTo(float x, float y)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, int>)(lpVtbl[52]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int moveTo(float x, float y)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, int>)(lpVtbl[53]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int quadraticCurveTo(float cpx, float cpy, float x, float y)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[54]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), cpx, cpy, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int rect(float x, float y, float w, float h)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[55]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, w, h);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int stroke()
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[56]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int isPointInPath(float x, float y, [NativeTypeName("VARIANT_BOOL *")] short* pResult)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, short*, int>)(lpVtbl[57]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int put_font([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[58]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int get_font([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[59]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int put_textAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[60]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int get_textAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[61]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int put_textBaseline([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[62]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int get_textBaseline([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[63]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int fillText([NativeTypeName("BSTR")] ushort* text, float x, float y, VARIANT maxWidth)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, float, float, VARIANT, int>)(lpVtbl[64]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), text, x, y, maxWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int measureText([NativeTypeName("BSTR")] ushort* text, ICanvasTextMetrics** ppCanvasTextMetrics)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, ICanvasTextMetrics**, int>)(lpVtbl[65]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), text, ppCanvasTextMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int strokeText([NativeTypeName("BSTR")] ushort* text, float x, float y, VARIANT maxWidth)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, float, float, VARIANT, int>)(lpVtbl[66]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), text, x, y, maxWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int drawImage(IDispatch* pSrc, VARIANT a1, VARIANT a2, VARIANT a3, VARIANT a4, VARIANT a5, VARIANT a6, VARIANT a7, VARIANT a8)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, IDispatch*, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[67]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), pSrc, a1, a2, a3, a4, a5, a6, a7, a8);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int createImageData(VARIANT a1, VARIANT a2, ICanvasImageData** ppCanvasImageData)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT, VARIANT, ICanvasImageData**, int>)(lpVtbl[68]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), a1, a2, ppCanvasImageData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int getImageData(float sx, float sy, float sw, float sh, ICanvasImageData** ppCanvasImageData)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, ICanvasImageData**, int>)(lpVtbl[69]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), sx, sy, sw, sh, ppCanvasImageData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int putImageData(ICanvasImageData* imagedata, float dx, float dy, VARIANT dirtyX, VARIANT dirtyY, VARIANT dirtyWidth, VARIANT dirtyHeight)
        {
            return ((delegate* unmanaged<ICanvasRenderingContext2D*, ICanvasImageData*, float, float, VARIANT, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[70]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), imagedata, dx, dy, dirtyX, dirtyY, dirtyWidth, dirtyHeight);
        }
    }
}
