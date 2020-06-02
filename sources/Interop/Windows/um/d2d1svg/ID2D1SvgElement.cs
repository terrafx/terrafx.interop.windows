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
    public unsafe partial struct ID2D1SvgElement
    {
        public Vtbl* lpVtbl;

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
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR, value, (uint)sizeof(DXGI_RGBA));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR, value, (uint)sizeof(DXGI_RGBA));
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
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX, value, (uint)sizeof(D2D_MATRIX_3X2_F));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX, value, (uint)sizeof(D2D_MATRIX_3X2_F));
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
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO, value, (uint)sizeof(D2D1_SVG_PRESERVE_ASPECT_RATIO));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_PRESERVE_ASPECT_RATIO *")] D2D1_SVG_PRESERVE_ASPECT_RATIO* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO, value, (uint)sizeof(D2D1_SVG_PRESERVE_ASPECT_RATIO));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_SVG_LENGTH &")] D2D1_SVG_LENGTH* value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH, value, (uint)sizeof(D2D1_SVG_LENGTH));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH, value, (uint)sizeof(D2D1_SVG_LENGTH));
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1SvgElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1SvgElement*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetDocument([NativeTypeName("ID2D1SvgDocument **")] ID2D1SvgDocument** document)
        {
            lpVtbl->GetDocument((ID2D1SvgElement*)Unsafe.AsPointer(ref this), document);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTagName([NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            return lpVtbl->GetTagName((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetTagNameLength()
        {
            return lpVtbl->GetTagNameLength((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsTextContent()
        {
            return lpVtbl->IsTextContent((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        public void GetParent([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** parent)
        {
            lpVtbl->GetParent((ID2D1SvgElement*)Unsafe.AsPointer(ref this), parent);
        }

        [return: NativeTypeName("BOOL")]
        public int HasChildren()
        {
            return lpVtbl->HasChildren((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        public void GetFirstChild([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** child)
        {
            lpVtbl->GetFirstChild((ID2D1SvgElement*)Unsafe.AsPointer(ref this), child);
        }

        public void GetLastChild([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** child)
        {
            lpVtbl->GetLastChild((ID2D1SvgElement*)Unsafe.AsPointer(ref this), child);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPreviousChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* referenceChild, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** previousChild)
        {
            return lpVtbl->GetPreviousChild((ID2D1SvgElement*)Unsafe.AsPointer(ref this), referenceChild, previousChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNextChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* referenceChild, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** nextChild)
        {
            return lpVtbl->GetNextChild((ID2D1SvgElement*)Unsafe.AsPointer(ref this), referenceChild, nextChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int InsertChildBefore([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* newChild, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* referenceChild = null)
        {
            return lpVtbl->InsertChildBefore((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild, referenceChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int AppendChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* newChild)
        {
            return lpVtbl->AppendChild((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReplaceChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* newChild, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* oldChild)
        {
            return lpVtbl->ReplaceChild((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild, oldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* oldChild)
        {
            return lpVtbl->RemoveChild((ID2D1SvgElement*)Unsafe.AsPointer(ref this), oldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateChild([NativeTypeName("PCWSTR")] ushort* tagName, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** newChild)
        {
            return lpVtbl->CreateChild((ID2D1SvgElement*)Unsafe.AsPointer(ref this), tagName, newChild);
        }

        [return: NativeTypeName("BOOL")]
        public int IsAttributeSpecified([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("BOOL *")] int* inherited = null)
        {
            return lpVtbl->IsAttributeSpecified((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, inherited);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSpecifiedAttributeCount()
        {
            return lpVtbl->GetSpecifiedAttributeCount((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecifiedAttributeName([NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount, [NativeTypeName("BOOL *")] int* inherited = null)
        {
            return lpVtbl->GetSpecifiedAttributeName((ID2D1SvgElement*)Unsafe.AsPointer(ref this), index, name, nameCount, inherited);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecifiedAttributeNameLength([NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32 *")] uint* nameLength, [NativeTypeName("BOOL *")] int* inherited = null)
        {
            return lpVtbl->GetSpecifiedAttributeNameLength((ID2D1SvgElement*)Unsafe.AsPointer(ref this), index, nameLength, inherited);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAttribute([NativeTypeName("PCWSTR")] ushort* name)
        {
            return lpVtbl->RemoveAttribute((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextValue([NativeTypeName("const WCHAR *")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            return lpVtbl->SetTextValue((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextValue([NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            return lpVtbl->GetTextValue((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetTextValueLength()
        {
            return lpVtbl->GetTextValueLength((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PCWSTR")] ushort* value)
        {
            return lpVtbl->SetAttributeValue((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PWSTR")] ushort* value, [NativeTypeName("UINT32")] uint valueCount)
        {
            return lpVtbl->GetAttributeValue((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValueLength([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("UINT32 *")] uint* valueLength)
        {
            return lpVtbl->GetAttributeValueLength((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, valueLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, [NativeTypeName("const void *")] void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes)
        {
            return lpVtbl->SetAttributeValue1((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueSizeInBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, [NativeTypeName("void *")] void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes)
        {
            return lpVtbl->GetAttributeValue1((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueSizeInBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgAttribute *")] ID2D1SvgAttribute* value)
        {
            return lpVtbl->SetAttributeValue2((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** value)
        {
            return lpVtbl->GetAttributeValue2((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, riid, value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (ID2D1SvgDocument **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ID2D1SvgDocument**, void> GetDocument;

            [NativeTypeName("HRESULT (PWSTR, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, uint, int> GetTagName;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, uint> GetTagNameLength;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, int> IsTextContent;

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ID2D1SvgElement**, void> GetParent;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, int> HasChildren;

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ID2D1SvgElement**, void> GetFirstChild;

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ID2D1SvgElement**, void> GetLastChild;

            [NativeTypeName("HRESULT (ID2D1SvgElement *, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int> GetPreviousChild;

            [NativeTypeName("HRESULT (ID2D1SvgElement *, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int> GetNextChild;

            [NativeTypeName("HRESULT (ID2D1SvgElement *, ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int> InsertChildBefore;

            [NativeTypeName("HRESULT (ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ID2D1SvgElement*, int> AppendChild;

            [NativeTypeName("HRESULT (ID2D1SvgElement *, ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int> ReplaceChild;

            [NativeTypeName("HRESULT (ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ID2D1SvgElement*, int> RemoveChild;

            [NativeTypeName("HRESULT (PCWSTR, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, ID2D1SvgElement**, int> CreateChild;

            [NativeTypeName("BOOL (PCWSTR, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, int*, int> IsAttributeSpecified;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, uint> GetSpecifiedAttributeCount;

            [NativeTypeName("HRESULT (UINT32, PWSTR, UINT32, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, uint, ushort*, uint, int*, int> GetSpecifiedAttributeName;

            [NativeTypeName("HRESULT (UINT32, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, uint, uint*, int*, int> GetSpecifiedAttributeNameLength;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, int> RemoveAttribute;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, uint, int> SetTextValue;

            [NativeTypeName("HRESULT (PWSTR, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, uint, int> GetTextValue;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, uint> GetTextValueLength;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_STRING_TYPE, PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_STRING_TYPE, ushort*, int> SetAttributeValue;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_STRING_TYPE, PWSTR, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_STRING_TYPE, ushort*, uint, int> GetAttributeValue;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_STRING_TYPE, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_STRING_TYPE, uint*, int> GetAttributeValueLength;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_POD_TYPE, const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_POD_TYPE, void*, uint, int> SetAttributeValue1;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_POD_TYPE, void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_POD_TYPE, void*, uint, int> GetAttributeValue1;

            [NativeTypeName("HRESULT (PCWSTR, ID2D1SvgAttribute *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, ID2D1SvgAttribute*, int> SetAttributeValue2;

            [NativeTypeName("HRESULT (PCWSTR, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgElement*, ushort*, Guid*, void**, int> GetAttributeValue2;
        }
    }
}
