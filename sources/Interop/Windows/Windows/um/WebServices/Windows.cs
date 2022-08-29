// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public const int WS_MUST_UNDERSTAND_HEADER_ATTRIBUTE = 0x1;
    public const int WS_RELAY_HEADER_ATTRIBUTE = 0x2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsStartReaderCanonicalization"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsStartReaderCanonicalization(IntPtr reader, [NativeTypeName("WS_WRITE_CALLBACK")] delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> writeCallback, void* writeCallbackState, [NativeTypeName("const WS_XML_CANONICALIZATION_PROPERTY *")] WS_XML_CANONICALIZATION_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsEndReaderCanonicalization"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsEndReaderCanonicalization(IntPtr reader, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsStartWriterCanonicalization"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsStartWriterCanonicalization(IntPtr writer, [NativeTypeName("WS_WRITE_CALLBACK")] delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> writeCallback, void* writeCallbackState, [NativeTypeName("const WS_XML_CANONICALIZATION_PROPERTY *")] WS_XML_CANONICALIZATION_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsEndWriterCanonicalization"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsEndWriterCanonicalization(IntPtr writer, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateXmlBuffer"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateXmlBuffer(IntPtr heap, [NativeTypeName("const WS_XML_BUFFER_PROPERTY *")] WS_XML_BUFFER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_XML_BUFFER **")] IntPtr* buffer, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRemoveNode"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRemoveNode([NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* nodePosition, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateReader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateReader([NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_XML_READER **")] IntPtr* reader, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetInput"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetInput(IntPtr reader, [NativeTypeName("const WS_XML_READER_ENCODING *")] WS_XML_READER_ENCODING* encoding, [NativeTypeName("const WS_XML_READER_INPUT *")] WS_XML_READER_INPUT* input, [NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetInputToBuffer"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetInputToBuffer(IntPtr reader, IntPtr buffer, [NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeReader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeReader(IntPtr reader);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetReaderProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetReaderProperty(IntPtr reader, WS_XML_READER_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetReaderNode"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetReaderNode(IntPtr xmlReader, [NativeTypeName("const WS_XML_NODE **")] WS_XML_NODE** node, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFillReader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsFillReader(IntPtr reader, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadStartElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadStartElement(IntPtr reader, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadToStartElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadToStartElement(IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL* found, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadStartAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadStartAttribute(IntPtr reader, [NativeTypeName("ULONG")] uint attributeIndex, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadEndAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadEndAttribute(IntPtr reader, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadNode"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadNode(IntPtr reader, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSkipNode"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSkipNode(IntPtr reader, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadEndElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadEndElement(IntPtr reader, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFindAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsFindAttribute(IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL required, [NativeTypeName("ULONG *")] uint* attributeIndex, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadValue"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadValue(IntPtr reader, WS_VALUE_TYPE valueType, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadChars"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadChars(IntPtr reader, [NativeTypeName("WCHAR *")] ushort* chars, [NativeTypeName("ULONG")] uint maxCharCount, [NativeTypeName("ULONG *")] uint* actualCharCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadCharsUtf8"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadCharsUtf8(IntPtr reader, byte* bytes, [NativeTypeName("ULONG")] uint maxByteCount, [NativeTypeName("ULONG *")] uint* actualByteCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadBytes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadBytes(IntPtr reader, void* bytes, [NativeTypeName("ULONG")] uint maxByteCount, [NativeTypeName("ULONG *")] uint* actualByteCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadArray"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadArray(IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, WS_VALUE_TYPE valueType, void* array, [NativeTypeName("ULONG")] uint arraySize, [NativeTypeName("ULONG")] uint itemOffset, [NativeTypeName("ULONG")] uint itemCount, [NativeTypeName("ULONG *")] uint* actualItemCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetReaderPosition"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetReaderPosition(IntPtr reader, WS_XML_NODE_POSITION* nodePosition, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetReaderPosition"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetReaderPosition(IntPtr reader, [NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* nodePosition, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsMoveReader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsMoveReader(IntPtr reader, WS_MOVE_TO moveTo, BOOL* found, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateWriter"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateWriter([NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_XML_WRITER **")] IntPtr* writer, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeWriter"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeWriter(IntPtr writer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetOutput"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetOutput(IntPtr writer, [NativeTypeName("const WS_XML_WRITER_ENCODING *")] WS_XML_WRITER_ENCODING* encoding, [NativeTypeName("const WS_XML_WRITER_OUTPUT *")] WS_XML_WRITER_OUTPUT* output, [NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetOutputToBuffer"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetOutputToBuffer(IntPtr writer, IntPtr buffer, [NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetWriterProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetWriterProperty(IntPtr writer, WS_XML_WRITER_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFlushWriter"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsFlushWriter(IntPtr writer, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteStartElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteStartElement(IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteEndStartElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteEndStartElement(IntPtr writer, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteXmlnsAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteXmlnsAttribute(IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL singleQuote, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteStartAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteStartAttribute(IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL singleQuote, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteEndAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteEndAttribute(IntPtr writer, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteValue"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteValue(IntPtr writer, WS_VALUE_TYPE valueType, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteXmlBuffer"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteXmlBuffer(IntPtr writer, IntPtr xmlBuffer, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadXmlBuffer"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadXmlBuffer(IntPtr reader, IntPtr heap, [NativeTypeName("WS_XML_BUFFER **")] IntPtr* xmlBuffer, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteXmlBufferToBytes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteXmlBufferToBytes(IntPtr writer, IntPtr xmlBuffer, [NativeTypeName("const WS_XML_WRITER_ENCODING *")] WS_XML_WRITER_ENCODING* encoding, [NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr heap, void** bytes, [NativeTypeName("ULONG *")] uint* byteCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadXmlBufferFromBytes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadXmlBufferFromBytes(IntPtr reader, [NativeTypeName("const WS_XML_READER_ENCODING *")] WS_XML_READER_ENCODING* encoding, [NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const void *")] void* bytes, [NativeTypeName("ULONG")] uint byteCount, IntPtr heap, [NativeTypeName("WS_XML_BUFFER **")] IntPtr* xmlBuffer, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteArray"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteArray(IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, WS_VALUE_TYPE valueType, [NativeTypeName("const void *")] void* array, [NativeTypeName("ULONG")] uint arraySize, [NativeTypeName("ULONG")] uint itemOffset, [NativeTypeName("ULONG")] uint itemCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteQualifiedName"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteQualifiedName(IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteChars"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteChars(IntPtr writer, [NativeTypeName("const WCHAR *")] ushort* chars, [NativeTypeName("ULONG")] uint charCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteCharsUtf8"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteCharsUtf8(IntPtr writer, [NativeTypeName("const BYTE *")] byte* bytes, [NativeTypeName("ULONG")] uint byteCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteBytes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteBytes(IntPtr writer, [NativeTypeName("const void *")] void* bytes, [NativeTypeName("ULONG")] uint byteCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsPushBytes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsPushBytes(IntPtr writer, [NativeTypeName("WS_PUSH_BYTES_CALLBACK")] delegate* unmanaged<void*, delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT>, void*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> callback, void* callbackState, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsPullBytes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsPullBytes(IntPtr writer, [NativeTypeName("WS_PULL_BYTES_CALLBACK")] delegate* unmanaged<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> callback, void* callbackState, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteEndElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteEndElement(IntPtr writer, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteText"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteText(IntPtr writer, [NativeTypeName("const WS_XML_TEXT *")] WS_XML_TEXT* text, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteStartCData"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteStartCData(IntPtr writer, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteEndCData"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteEndCData(IntPtr writer, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteNode"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteNode(IntPtr writer, [NativeTypeName("const WS_XML_NODE *")] WS_XML_NODE* node, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetPrefixFromNamespace"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetPrefixFromNamespace(IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL required, [NativeTypeName("const WS_XML_STRING **")] WS_XML_STRING** prefix, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetWriterPosition"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetWriterPosition(IntPtr writer, WS_XML_NODE_POSITION* nodePosition, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetWriterPosition"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetWriterPosition(IntPtr writer, [NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* nodePosition, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsMoveWriter"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsMoveWriter(IntPtr writer, WS_MOVE_TO moveTo, BOOL* found, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsTrimXmlWhitespace"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsTrimXmlWhitespace([NativeTypeName("WCHAR *")] ushort* chars, [NativeTypeName("ULONG")] uint charCount, [NativeTypeName("WCHAR **")] ushort** trimmedChars, [NativeTypeName("ULONG *")] uint* trimmedCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsVerifyXmlNCName"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsVerifyXmlNCName([NativeTypeName("const WCHAR *")] ushort* ncNameChars, [NativeTypeName("ULONG")] uint ncNameCharCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsXmlStringEquals"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsXmlStringEquals([NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* string1, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* string2, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetNamespaceFromPrefix"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetNamespaceFromPrefix(IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, BOOL required, [NativeTypeName("const WS_XML_STRING **")] WS_XML_STRING** ns, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadQualifiedName"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadQualifiedName(IntPtr reader, IntPtr heap, WS_XML_STRING* prefix, WS_XML_STRING* localName, WS_XML_STRING* ns, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetXmlAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetXmlAttribute(IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, IntPtr heap, [NativeTypeName("WCHAR **")] ushort** valueChars, [NativeTypeName("ULONG *")] uint* valueCharCount, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCopyNode"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCopyNode(IntPtr writer, IntPtr reader, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAsyncExecute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAsyncExecute(WS_ASYNC_STATE* asyncState, [NativeTypeName("WS_ASYNC_FUNCTION")] delegate* unmanaged<HRESULT, WS_CALLBACK_MODEL, void*, WS_ASYNC_OPERATION*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> operation, WS_CALLBACK_MODEL callbackModel, void* callbackState, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateChannel(WS_CHANNEL_TYPE channelType, WS_CHANNEL_BINDING channelBinding, [NativeTypeName("const WS_CHANNEL_PROPERTY *")] WS_CHANNEL_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const WS_SECURITY_DESCRIPTION *")] WS_SECURITY_DESCRIPTION* securityDescription, [NativeTypeName("WS_CHANNEL **")] IntPtr* channel, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsOpenChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsOpenChannel(IntPtr channel, [NativeTypeName("const WS_ENDPOINT_ADDRESS *")] WS_ENDPOINT_ADDRESS* endpointAddress, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSendMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSendMessage(IntPtr channel, IntPtr message, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* messageDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* bodyValue, [NativeTypeName("ULONG")] uint bodyValueSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReceiveMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReceiveMessage(IntPtr channel, IntPtr message, [NativeTypeName("const WS_MESSAGE_DESCRIPTION **")] WS_MESSAGE_DESCRIPTION** messageDescriptions, [NativeTypeName("ULONG")] uint messageDescriptionCount, WS_RECEIVE_OPTION receiveOption, WS_READ_OPTION readBodyOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("ULONG *")] uint* index, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRequestReply"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRequestReply(IntPtr channel, IntPtr requestMessage, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* requestMessageDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* requestBodyValue, [NativeTypeName("ULONG")] uint requestBodyValueSize, IntPtr replyMessage, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* replyMessageDescription, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSendReplyMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSendReplyMessage(IntPtr channel, IntPtr replyMessage, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* replyMessageDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* replyBodyValue, [NativeTypeName("ULONG")] uint replyBodyValueSize, IntPtr requestMessage, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSendFaultMessageForError"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSendFaultMessageForError(IntPtr channel, IntPtr replyMessage, IntPtr faultError, HRESULT faultErrorCode, WS_FAULT_DISCLOSURE faultDisclosure, IntPtr requestMessage, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetChannelProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetChannelProperty(IntPtr channel, WS_CHANNEL_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetChannelProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetChannelProperty(IntPtr channel, WS_CHANNEL_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteMessageStart"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteMessageStart(IntPtr channel, IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteMessageEnd"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteMessageEnd(IntPtr channel, IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadMessageStart"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadMessageStart(IntPtr channel, IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadMessageEnd"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadMessageEnd(IntPtr channel, IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCloseChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCloseChannel(IntPtr channel, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAbortChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAbortChannel(IntPtr channel, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeChannel(IntPtr channel);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetChannel(IntPtr channel, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAbandonMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAbandonMessage(IntPtr channel, IntPtr message, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsShutdownSessionChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsShutdownSessionChannel(IntPtr channel, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetOperationContextProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetOperationContextProperty([NativeTypeName("const WS_OPERATION_CONTEXT *")] IntPtr context, [NativeTypeName("const WS_OPERATION_CONTEXT_PROPERTY_ID")] WS_OPERATION_CONTEXT_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetDictionary"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetDictionary(WS_ENCODING encoding, WS_XML_DICTIONARY** dictionary, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadEndpointAddressExtension"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadEndpointAddressExtension(IntPtr reader, WS_ENDPOINT_ADDRESS* endpointAddress, WS_ENDPOINT_ADDRESS_EXTENSION_TYPE extensionType, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateError"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateError([NativeTypeName("const WS_ERROR_PROPERTY *")] WS_ERROR_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR **")] IntPtr* error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAddErrorString"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAddErrorString(IntPtr error, [NativeTypeName("const WS_STRING *")] WS_STRING* @string);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetErrorString"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetErrorString(IntPtr error, [NativeTypeName("ULONG")] uint index, WS_STRING* @string);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCopyError"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCopyError(IntPtr source, IntPtr destination);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetErrorProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetErrorProperty(IntPtr error, WS_ERROR_PROPERTY_ID id, void* buffer, [NativeTypeName("ULONG")] uint bufferSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetErrorProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetErrorProperty(IntPtr error, WS_ERROR_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetError"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetError(IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeError"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeError(IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetFaultErrorProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetFaultErrorProperty(IntPtr error, WS_FAULT_ERROR_PROPERTY_ID id, void* buffer, [NativeTypeName("ULONG")] uint bufferSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetFaultErrorProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetFaultErrorProperty(IntPtr error, WS_FAULT_ERROR_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateFaultFromError"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateFaultFromError(IntPtr error, HRESULT faultErrorCode, WS_FAULT_DISCLOSURE faultDisclosure, IntPtr heap, WS_FAULT* fault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetFaultErrorDetail"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetFaultErrorDetail(IntPtr error, [NativeTypeName("const WS_FAULT_DETAIL_DESCRIPTION *")] WS_FAULT_DETAIL_DESCRIPTION* faultDetailDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetFaultErrorDetail"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetFaultErrorDetail(IntPtr error, [NativeTypeName("const WS_FAULT_DETAIL_DESCRIPTION *")] WS_FAULT_DETAIL_DESCRIPTION* faultDetailDescription, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateHeap"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateHeap([NativeTypeName("SIZE_T")] nuint maxSize, [NativeTypeName("SIZE_T")] nuint trimSize, [NativeTypeName("const WS_HEAP_PROPERTY *")] WS_HEAP_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_HEAP **")] IntPtr* heap, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAlloc"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAlloc(IntPtr heap, [NativeTypeName("SIZE_T")] nuint size, void** ptr, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetHeapProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetHeapProperty(IntPtr heap, WS_HEAP_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetHeap"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetHeap(IntPtr heap, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeHeap"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeHeap(IntPtr heap);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateListener(WS_CHANNEL_TYPE channelType, WS_CHANNEL_BINDING channelBinding, [NativeTypeName("const WS_LISTENER_PROPERTY *")] WS_LISTENER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const WS_SECURITY_DESCRIPTION *")] WS_SECURITY_DESCRIPTION* securityDescription, [NativeTypeName("WS_LISTENER **")] IntPtr* listener, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsOpenListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsOpenListener(IntPtr listener, [NativeTypeName("const WS_STRING *")] WS_STRING* url, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAcceptChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAcceptChannel(IntPtr listener, IntPtr channel, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCloseListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCloseListener(IntPtr listener, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAbortListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAbortListener(IntPtr listener, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetListener(IntPtr listener, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeListener(IntPtr listener);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetListenerProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetListenerProperty(IntPtr listener, WS_LISTENER_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetListenerProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetListenerProperty(IntPtr listener, WS_LISTENER_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateChannelForListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateChannelForListener(IntPtr listener, [NativeTypeName("const WS_CHANNEL_PROPERTY *")] WS_CHANNEL_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_CHANNEL **")] IntPtr* channel, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateMessage(WS_ENVELOPE_VERSION envelopeVersion, WS_ADDRESSING_VERSION addressingVersion, [NativeTypeName("const WS_MESSAGE_PROPERTY *")] WS_MESSAGE_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_MESSAGE **")] IntPtr* message, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateMessageForChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateMessageForChannel(IntPtr channel, [NativeTypeName("const WS_MESSAGE_PROPERTY *")] WS_MESSAGE_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_MESSAGE **")] IntPtr* message, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsInitializeMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsInitializeMessage(IntPtr message, WS_MESSAGE_INITIALIZATION initialization, IntPtr sourceMessage, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetMessage(IntPtr message, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeMessage(IntPtr message);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetHeaderAttributes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetHeaderAttributes(IntPtr message, IntPtr reader, [NativeTypeName("ULONG *")] uint* headerAttributes, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetHeader(IntPtr message, WS_HEADER_TYPE headerType, WS_TYPE valueType, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetCustomHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetCustomHeader(IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* customHeaderDescription, WS_REPEATING_HEADER_OPTION repeatingOption, [NativeTypeName("ULONG")] uint headerIndex, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("ULONG *")] uint* headerAttributes, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRemoveHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRemoveHeader(IntPtr message, WS_HEADER_TYPE headerType, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetHeader(IntPtr message, WS_HEADER_TYPE headerType, WS_TYPE valueType, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRemoveCustomHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRemoveCustomHeader(IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerNs, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAddCustomHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAddCustomHeader(IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* headerDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("ULONG")] uint headerAttributes, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAddMappedHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAddMappedHeader(IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, WS_TYPE valueType, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRemoveMappedHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRemoveMappedHeader(IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetMappedHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetMappedHeader(IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, WS_REPEATING_HEADER_OPTION repeatingOption, [NativeTypeName("ULONG")] uint headerIndex, WS_TYPE valueType, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteBody"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteBody(IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* bodyDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadBody"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadBody(IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* bodyDescription, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteEnvelopeStart"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteEnvelopeStart(IntPtr message, IntPtr writer, [NativeTypeName("WS_MESSAGE_DONE_CALLBACK")] delegate* unmanaged<void*, void> doneCallback, void* doneCallbackState, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteEnvelopeEnd"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteEnvelopeEnd(IntPtr message, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadEnvelopeStart"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadEnvelopeStart(IntPtr message, IntPtr reader, [NativeTypeName("WS_MESSAGE_DONE_CALLBACK")] delegate* unmanaged<void*, void> doneCallback, void* doneCallbackState, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadEnvelopeEnd"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadEnvelopeEnd(IntPtr message, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetMessageProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetMessageProperty(IntPtr message, WS_MESSAGE_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetMessageProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetMessageProperty(IntPtr message, WS_MESSAGE_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAddressMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAddressMessage(IntPtr message, [NativeTypeName("const WS_ENDPOINT_ADDRESS *")] WS_ENDPOINT_ADDRESS* address, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCheckMustUnderstandHeaders"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCheckMustUnderstandHeaders(IntPtr message, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsMarkHeaderAsUnderstood"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsMarkHeaderAsUnderstood(IntPtr message, [NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* headerPosition, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFillBody"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsFillBody(IntPtr message, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFlushBody"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsFlushBody(IntPtr message, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRequestSecurityToken"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRequestSecurityToken(IntPtr channel, [NativeTypeName("const WS_REQUEST_SECURITY_TOKEN_PROPERTY *")] WS_REQUEST_SECURITY_TOKEN_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_SECURITY_TOKEN **")] IntPtr* token, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetSecurityTokenProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetSecurityTokenProperty(IntPtr securityToken, WS_SECURITY_TOKEN_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr heap, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateXmlSecurityToken"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateXmlSecurityToken(IntPtr tokenXml, WS_SECURITY_KEY_HANDLE* tokenKey, [NativeTypeName("const WS_XML_SECURITY_TOKEN_PROPERTY *")] WS_XML_SECURITY_TOKEN_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_SECURITY_TOKEN **")] IntPtr* token, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeSecurityToken"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeSecurityToken(IntPtr token);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRevokeSecurityContext"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRevokeSecurityContext(IntPtr securityContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetSecurityContextProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetSecurityContextProperty(IntPtr securityContext, WS_SECURITY_CONTEXT_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadElement(IntPtr reader, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* elementDescription, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadAttribute(IntPtr reader, [NativeTypeName("const WS_ATTRIBUTE_DESCRIPTION *")] WS_ATTRIBUTE_DESCRIPTION* attributeDescription, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadType"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadType(IntPtr reader, WS_TYPE_MAPPING typeMapping, WS_TYPE type, [NativeTypeName("const void *")] void* typeDescription, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteElement(IntPtr writer, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* elementDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteAttribute(IntPtr writer, [NativeTypeName("const WS_ATTRIBUTE_DESCRIPTION *")] WS_ATTRIBUTE_DESCRIPTION* attributeDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteType"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteType(IntPtr writer, WS_TYPE_MAPPING typeMapping, WS_TYPE type, [NativeTypeName("const void *")] void* typeDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRegisterOperationForCancel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRegisterOperationForCancel([NativeTypeName("const WS_OPERATION_CONTEXT *")] IntPtr context, [NativeTypeName("WS_OPERATION_CANCEL_CALLBACK")] delegate* unmanaged<WS_SERVICE_CANCEL_REASON, void*, void> cancelCallback, [NativeTypeName("WS_OPERATION_FREE_STATE_CALLBACK")] delegate* unmanaged<void*, void> freestateCallback, void* userState, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetServiceHostProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetServiceHostProperty(IntPtr serviceHost, [NativeTypeName("const WS_SERVICE_PROPERTY_ID")] WS_SERVICE_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateServiceHost"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateServiceHost([NativeTypeName("const WS_SERVICE_ENDPOINT **")] WS_SERVICE_ENDPOINT** endpoints, [NativeTypeName("const USHORT")] ushort endpointCount, [NativeTypeName("const WS_SERVICE_PROPERTY *")] WS_SERVICE_PROPERTY* serviceProperties, [NativeTypeName("ULONG")] uint servicePropertyCount, [NativeTypeName("WS_SERVICE_HOST **")] IntPtr* serviceHost, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsOpenServiceHost"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsOpenServiceHost(IntPtr serviceHost, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCloseServiceHost"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCloseServiceHost(IntPtr serviceHost, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAbortServiceHost"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAbortServiceHost(IntPtr serviceHost, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeServiceHost"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeServiceHost(IntPtr serviceHost);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetServiceHost"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetServiceHost(IntPtr serviceHost, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetServiceProxyProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetServiceProxyProperty(IntPtr serviceProxy, [NativeTypeName("const WS_PROXY_PROPERTY_ID")] WS_PROXY_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateServiceProxy"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateServiceProxy([NativeTypeName("const WS_CHANNEL_TYPE")] WS_CHANNEL_TYPE channelType, [NativeTypeName("const WS_CHANNEL_BINDING")] WS_CHANNEL_BINDING channelBinding, [NativeTypeName("const WS_SECURITY_DESCRIPTION *")] WS_SECURITY_DESCRIPTION* securityDescription, [NativeTypeName("const WS_PROXY_PROPERTY *")] WS_PROXY_PROPERTY* properties, [NativeTypeName("const ULONG")] uint propertyCount, [NativeTypeName("const WS_CHANNEL_PROPERTY *")] WS_CHANNEL_PROPERTY* channelProperties, [NativeTypeName("const ULONG")] uint channelPropertyCount, [NativeTypeName("WS_SERVICE_PROXY **")] IntPtr* serviceProxy, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsOpenServiceProxy"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsOpenServiceProxy(IntPtr serviceProxy, [NativeTypeName("const WS_ENDPOINT_ADDRESS *")] WS_ENDPOINT_ADDRESS* address, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCloseServiceProxy"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCloseServiceProxy(IntPtr serviceProxy, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAbortServiceProxy"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAbortServiceProxy(IntPtr serviceProxy, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeServiceProxy"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeServiceProxy(IntPtr serviceProxy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetServiceProxy"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetServiceProxy(IntPtr serviceProxy, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAbandonCall"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAbandonCall(IntPtr serviceProxy, [NativeTypeName("ULONG")] uint callId, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCall"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCall(IntPtr serviceProxy, [NativeTypeName("const WS_OPERATION_DESCRIPTION *")] WS_OPERATION_DESCRIPTION* operation, [NativeTypeName("const void **")] void** arguments, IntPtr heap, [NativeTypeName("const WS_CALL_PROPERTY *")] WS_CALL_PROPERTY* callProperties, [NativeTypeName("const ULONG")] uint callPropertyCount, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsDecodeUrl"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsDecodeUrl([NativeTypeName("const WS_STRING *")] WS_STRING* url, [NativeTypeName("ULONG")] uint flags, IntPtr heap, WS_URL** outUrl, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsEncodeUrl"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsEncodeUrl([NativeTypeName("const WS_URL *")] WS_URL* url, [NativeTypeName("ULONG")] uint flags, IntPtr heap, WS_STRING* outUrl, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCombineUrl"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCombineUrl([NativeTypeName("const WS_STRING *")] WS_STRING* baseUrl, [NativeTypeName("const WS_STRING *")] WS_STRING* referenceUrl, [NativeTypeName("ULONG")] uint flags, IntPtr heap, WS_STRING* resultUrl, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsDateTimeToFileTime"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsDateTimeToFileTime([NativeTypeName("const WS_DATETIME *")] WS_DATETIME* dateTime, FILETIME* fileTime, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFileTimeToDateTime"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsFileTimeToDateTime([NativeTypeName("const FILETIME *")] FILETIME* fileTime, WS_DATETIME* dateTime, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateMetadata"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateMetadata([NativeTypeName("const WS_METADATA_PROPERTY *")] WS_METADATA_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_METADATA **")] IntPtr* metadata, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadMetadata"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadMetadata(IntPtr metadata, IntPtr reader, [NativeTypeName("const WS_STRING *")] WS_STRING* url, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeMetadata"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeMetadata(IntPtr metadata);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetMetadata"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetMetadata(IntPtr metadata, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetMetadataProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetMetadataProperty(IntPtr metadata, WS_METADATA_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetMissingMetadataDocumentAddress"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetMissingMetadataDocumentAddress(IntPtr metadata, WS_ENDPOINT_ADDRESS** address, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetMetadataEndpoints"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetMetadataEndpoints(IntPtr metadata, WS_METADATA_ENDPOINTS* endpoints, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsMatchPolicyAlternative"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsMatchPolicyAlternative(IntPtr policy, [NativeTypeName("ULONG")] uint alternativeIndex, WS_POLICY_CONSTRAINTS* policyConstraints, BOOL matchRequired, IntPtr heap, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetPolicyProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetPolicyProperty(IntPtr policy, WS_POLICY_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetPolicyAlternativeCount"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetPolicyAlternativeCount(IntPtr policy, [NativeTypeName("ULONG *")] uint* count, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateServiceProxyFromTemplate"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateServiceProxyFromTemplate(WS_CHANNEL_TYPE channelType, [NativeTypeName("const WS_PROXY_PROPERTY *")] WS_PROXY_PROPERTY* properties, [NativeTypeName("const ULONG")] uint propertyCount, WS_BINDING_TEMPLATE_TYPE templateType, void* templateValue, [NativeTypeName("ULONG")] uint templateSize, [NativeTypeName("const void *")] void* templateDescription, [NativeTypeName("ULONG")] uint templateDescriptionSize, [NativeTypeName("WS_SERVICE_PROXY **")] IntPtr* serviceProxy, IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateServiceEndpointFromTemplate"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateServiceEndpointFromTemplate(WS_CHANNEL_TYPE channelType, [NativeTypeName("const WS_SERVICE_ENDPOINT_PROPERTY *")] WS_SERVICE_ENDPOINT_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const WS_STRING *")] WS_STRING* addressUrl, [NativeTypeName("const WS_SERVICE_CONTRACT *")] WS_SERVICE_CONTRACT* contract, [NativeTypeName("WS_SERVICE_SECURITY_CALLBACK")] delegate* unmanaged<IntPtr, BOOL*, IntPtr, HRESULT> authorizationCallback, IntPtr heap, WS_BINDING_TEMPLATE_TYPE templateType, void* templateValue, [NativeTypeName("ULONG")] uint templateSize, [NativeTypeName("const void *")] void* templateDescription, [NativeTypeName("ULONG")] uint templateDescriptionSize, WS_SERVICE_ENDPOINT** serviceEndpoint, IntPtr error);
}
