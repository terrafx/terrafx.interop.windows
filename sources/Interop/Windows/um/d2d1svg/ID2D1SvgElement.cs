// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_SVG_ATTRIBUTE_POD_TYPE;

namespace TerraFX.Interop
{
    [Guid("AC7B67A6-183E-49C1-A823-0EBE40B0DB29")]
    [NativeTypeName("struct ID2D1SvgElement : ID2D1Resource")]
    public unsafe partial struct ID2D1SvgElement
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("FLOAT")] float value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT, &value, sizeof(float));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("FLOAT *")] float* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT, value, sizeof(float));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR, value, (uint)(sizeof(DXGI_RGBA)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR, value, (uint)(sizeof(DXGI_RGBA)));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_FILL_MODE value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE, &value, sizeof(D2D1_FILL_MODE));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_FILL_MODE *")] D2D1_FILL_MODE* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE, value, sizeof(D2D1_FILL_MODE));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_DISPLAY value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY, &value, sizeof(D2D1_SVG_DISPLAY));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_DISPLAY *")] D2D1_SVG_DISPLAY* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY, value, sizeof(D2D1_SVG_DISPLAY));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_OVERFLOW value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW, &value, sizeof(D2D1_SVG_OVERFLOW));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_OVERFLOW *")] D2D1_SVG_OVERFLOW* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW, value, sizeof(D2D1_SVG_OVERFLOW));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_LINE_JOIN value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN, &value, sizeof(D2D1_SVG_LINE_JOIN));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_LINE_JOIN *")] D2D1_SVG_LINE_JOIN* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN, value, sizeof(D2D1_SVG_LINE_JOIN));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_LINE_CAP value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP, &value, sizeof(D2D1_SVG_LINE_CAP));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_LINE_CAP *")] D2D1_SVG_LINE_CAP* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP, value, sizeof(D2D1_SVG_LINE_CAP));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_VISIBILITY value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY, &value, sizeof(D2D1_SVG_VISIBILITY));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_VISIBILITY *")] D2D1_SVG_VISIBILITY* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY, value, sizeof(D2D1_SVG_VISIBILITY));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX, value, (uint)(sizeof(D2D_MATRIX_3X2_F)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX, value, (uint)(sizeof(D2D_MATRIX_3X2_F)));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_UNIT_TYPE value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE, &value, sizeof(D2D1_SVG_UNIT_TYPE));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_UNIT_TYPE *")] D2D1_SVG_UNIT_TYPE* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE, value, sizeof(D2D1_SVG_UNIT_TYPE));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_EXTEND_MODE value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE, &value, sizeof(D2D1_EXTEND_MODE));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_EXTEND_MODE *")] D2D1_EXTEND_MODE* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE, value, sizeof(D2D1_EXTEND_MODE));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_SVG_PRESERVE_ASPECT_RATIO &")] D2D1_SVG_PRESERVE_ASPECT_RATIO* value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO, value, (uint)(sizeof(D2D1_SVG_PRESERVE_ASPECT_RATIO)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_PRESERVE_ASPECT_RATIO *")] D2D1_SVG_PRESERVE_ASPECT_RATIO* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO, value, (uint)(sizeof(D2D1_SVG_PRESERVE_ASPECT_RATIO)));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_SVG_LENGTH &")] D2D1_SVG_LENGTH* value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH, value, (uint)(sizeof(D2D1_SVG_LENGTH)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH, value, (uint)(sizeof(D2D1_SVG_LENGTH)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, uint>)(lpVtbl[1]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, uint>)(lpVtbl[2]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1SvgElement*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDocument([NativeTypeName("ID2D1SvgDocument **")] ID2D1SvgDocument** document)
        {
            ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgDocument**, void>)(lpVtbl[4]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), document);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTagName([NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, uint, int>)(lpVtbl[5]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetTagNameLength()
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, uint>)(lpVtbl[6]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsTextContent()
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, int>)(lpVtbl[7]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetParent([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** parent)
        {
            ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement**, void>)(lpVtbl[8]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int HasChildren()
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, int>)(lpVtbl[9]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFirstChild([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** child)
        {
            ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement**, void>)(lpVtbl[10]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), child);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetLastChild([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** child)
        {
            ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement**, void>)(lpVtbl[11]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), child);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreviousChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* referenceChild, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** previousChild)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)(lpVtbl[12]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), referenceChild, previousChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNextChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* referenceChild, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** nextChild)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)(lpVtbl[13]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), referenceChild, nextChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertChildBefore([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* newChild, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* referenceChild = null)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)(lpVtbl[14]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild, referenceChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* newChild)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement*, int>)(lpVtbl[15]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReplaceChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* newChild, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* oldChild)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)(lpVtbl[16]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* oldChild)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement*, int>)(lpVtbl[17]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateChild([NativeTypeName("PCWSTR")] ushort* tagName, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** newChild)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, ID2D1SvgElement**, int>)(lpVtbl[18]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), tagName, newChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsAttributeSpecified([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("BOOL *")] int* inherited = null)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, int*, int>)(lpVtbl[19]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, inherited);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetSpecifiedAttributeCount()
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, uint>)(lpVtbl[20]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecifiedAttributeName([NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount, [NativeTypeName("BOOL *")] int* inherited = null)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, uint, ushort*, uint, int*, int>)(lpVtbl[21]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), index, name, nameCount, inherited);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecifiedAttributeNameLength([NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32 *")] uint* nameLength, [NativeTypeName("BOOL *")] int* inherited = null)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, uint, uint*, int*, int>)(lpVtbl[22]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), index, nameLength, inherited);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAttribute([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, int>)(lpVtbl[23]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextValue([NativeTypeName("const WCHAR *")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, uint, int>)(lpVtbl[24]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextValue([NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, uint, int>)(lpVtbl[25]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetTextValueLength()
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, uint>)(lpVtbl[26]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PCWSTR")] ushort* value)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_STRING_TYPE, ushort*, int>)(lpVtbl[29]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PWSTR")] ushort* value, [NativeTypeName("UINT32")] uint valueCount)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_STRING_TYPE, ushort*, uint, int>)(lpVtbl[32]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValueLength([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("UINT32 *")] uint* valueLength)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_STRING_TYPE, uint*, int>)(lpVtbl[33]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, valueLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, [NativeTypeName("const void *")] void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_POD_TYPE, void*, uint, int>)(lpVtbl[28]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueSizeInBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, [NativeTypeName("void *")] void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_POD_TYPE, void*, uint, int>)(lpVtbl[31]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueSizeInBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgAttribute *")] ID2D1SvgAttribute* value)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, ID2D1SvgAttribute*, int>)(lpVtbl[27]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** value)
        {
            return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, Guid*, void**, int>)(lpVtbl[30]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, riid, value);
        }
    }
}
