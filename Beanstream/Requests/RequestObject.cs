﻿// The MIT License (MIT)
//
// Copyright (c) 2014 Beanstream Internet Commerce Corp, Digital River, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
using System;

namespace Beanstream.Api.SDK.Requests
{
    public class RequestObject
    {
        private readonly HttpMethod _method;
        private readonly string _url;
        private readonly Credentials _credentials;
        private readonly string _subMerchantId;
        private readonly object _data;

        public RequestObject(HttpMethod method, string url, Credentials credentials, object data)
            : this(method, url, credentials, null, data)
        {
        }

        public RequestObject(HttpMethod method, string url, Credentials credentials, string subMerchantId, object data)
        {
            _method = method;
            _url = url;
            _credentials = credentials;
            _subMerchantId = subMerchantId;
            _data = data;
        }

        public object Data
        {
            get { return _data; }
        }

        public HttpMethod Method
        {
            get { return _method; }
        }

        public Uri Url
        {
            get { return new Uri(_url); }
        }

        public Credentials Credentials
        {
            get { return _credentials; }
        }

        public string SubMerchantId
        {
            get { return _subMerchantId; }
        }
    }
}